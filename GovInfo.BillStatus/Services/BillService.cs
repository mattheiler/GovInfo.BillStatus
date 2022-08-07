using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Flurl.Http;
using Flurl.Http.Configuration;

namespace GovInfo.BillStatus.Services
{
    public class BillService
    {
        private readonly IFlurlClient _http;

        public BillService(IFlurlClientFactory httpClientFactory)
        {
            _http = httpClientFactory.Get("https://www.govinfo.gov/bulkdata/BILLSTATUS");
        }

        public string WorkingDirectory { get; set; }

        // TODO BillFileLoader
        public Task<FileInfo> GetBillsFile(int number, string type)
        {
            return GetBillsFile(number, type, new Progress<double>(value => { }));
        }

        // TODO BillFileLoader
        public async Task<FileInfo> GetBillsFile(int number, string type, IProgress<double> progress)
        {
            var directory = Directory.CreateDirectory(WorkingDirectory ?? Path.GetTempPath());
            var file = new FileInfo(Path.Combine(directory.FullName, $"bills-{number}-{type}-{DateTime.Now:yy-MM-dd}.zip".Replace(':', '-')));

            if (File.Exists(file.FullName))
                return file;

            using var response = await _http.Request($"{number}/{type}/BILLSTATUS-{number}-{type}.zip")
                .SendAsync(HttpMethod.Get, default, default, HttpCompletionOption.ResponseHeadersRead);

            await using var input = await response.GetStreamAsync();
            await using var output = file.Create();

            var count = 0;
            var total = response.ResponseMessage.Content.Headers.ContentLength;

            int length;
            var buffer = new byte[1024];

            while ((length = await input.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await output.WriteAsync(buffer, 0, length);

                if (total > 0)
                    progress.Report(Math.Round((count += length) / (double) total, 2) * 100);
            }

            return file;
        }

        // TODO BillFileReader
        public async Task<IReadOnlyList<BillStatus>> GetBills(string fileName)
        {
            var serializer = new XmlSerializer(typeof(BillStatus));
            var bills = new List<BillStatus>();

            using var archive = ZipFile.OpenRead(fileName);

            foreach (var entry in archive.Entries)
            {
                await Task.Yield();

                using var file = new StreamReader(entry.Open());

                bills.Add((BillStatus) serializer.Deserialize(file));
            }

            return bills.AsReadOnly();
        }
    }
}