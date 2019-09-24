using System;
using System.Collections.Generic;
using System.IO;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace BludeltaWebApiTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = string.Empty;

            var options = new Options();
            var parser = new CommandLine.Parser(s =>
            {
                s.CaseSensitive = true;
                s.HelpWriter = Console.Out;
            });

            if (parser.ParseArguments(args, options))
            {
                invoice = options.Invoice;
            }

            var config = new Configuration(new ApiClient("http://bludelta-alpha-staging.azurewebsites.net/"));
            config.DefaultHeader.Add("X-ApiKey","testtoken");

            // CreateAccessToken
            var accessToken = CreateAccessToken(config);

            config.DefaultHeader.Add("X-AccessToken", accessToken);

            // Get number of validatable invoices
            var validatbleInvoiceCount = GetValidatableInvoiceCount(config);

            // Get number of importable invoices
            var importableInvoiceCount = GetImportableInvoiceCount(config);

            // Get next invoice for import
            var invoiceTuple = ImportNextInvoice(config);

            // Confirm an invoice
            var isConfirmed = ConfirmInvoice("667EA5E7-960C-4999-8348-650B350C1982", config);

            // Upload File
            if (File.Exists(invoice))
            {
                UploadInvoiceContainer(invoice);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static bool UploadInvoiceContainer(string invoice, Configuration config = null)
        {
            var uploadApi = config == null ? new UploadInvoiceApi() : new UploadInvoiceApi(config);
            var invoiceBytes = File.ReadAllBytes(invoice);

            // optional description field
            var description = "My invoice BlaBlaBla";

            // invoice must be provided as base64 encoded string
            var invoiceB64 = Convert.ToBase64String(invoiceBytes);
            var request = new UploadInvoiceContainerRequest
            {
                Name = "MyInvoice",
                Description = description,
                File = invoiceB64
            };

            var result = uploadApi.UploadInvoiceContainer(request);

            Console.WriteLine($"Upload response: {result}");

            return result.State == 0;
        }

        private static string CreateAccessToken(Configuration config = null)
        {
            var api = new CreateAccessTokenApi(config);
            var result = api.AccessTokenRequest(new AccessTokenRequest
            {
                Name = "John Doe",
                Description = "John Doe User",
                TimeoutSeconds = 1500,
                ApiIdentifier = new List<string>()
            });

            Console.WriteLine($"Create AccessToken: {result}");

            return result.AccessToken;
        }

        private static int? GetValidatableInvoiceCount(Configuration config = null)
        {
            return CountInvoices(config, $"{DocumentStateTypeEnum.Autoprocessed.ToString()},{DocumentStateTypeEnum.NeedForAction}");
        }

        private static int? GetImportableInvoiceCount(Configuration config = null)
        {
            return CountInvoices(config, $"{DocumentStateTypeEnum.Released}");
        }

        private static int? CountInvoices(Configuration config, string state)
        {
            var api = config != null ? new CountInvoiceApi(config) : new CountInvoiceApi();
            var result = api.CountInvoicesRequestinvoicesStateGet(new CountInvoicesRequest(state));

            Console.WriteLine($"Get CountInvoices: {result}");

            return result.Count;
        }

        private static Tuple<string, byte[], DetectInvoiceResponse> ImportNextInvoice(Configuration config = null)
        {
            var api = config != null ? new ImportInvoiceApi(config) : new ImportInvoiceApi();
            var result = api.GetImportInvoiceRequest();

            Console.WriteLine($"Get ImportInvoice {result}");

            return result.Available.HasValue && result.Available.Value
                ? Tuple.Create(result.FileName, Convert.FromBase64String(result.File), result.DetectInvoiceResponse)
                : null;
        }

        private static bool ConfirmInvoice(string invoiceId, Configuration config = null)
        {
            var api = config != null ? new ConfirmInvoiceApi(config) : new ConfirmInvoiceApi();

            var result = api.PostConfirmInvoiceRequest(new ConfirmInvoiceRequest(0, invoiceId));

            Console.WriteLine($"Post ConfirmInvoiceRequest: {result}");

            return result.State == 0;
        }


    }
}
