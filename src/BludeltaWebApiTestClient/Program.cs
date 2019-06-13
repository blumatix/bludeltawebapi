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

      var config = new Configuration(new ApiClient("http://localhost:8060"));

      // CreateAccessToken
      var accessToken = CreateAccessToken(config);

      // Get number of validatable invoices
      var validatbleInvoiceCount = GetValidatableInvoiceCount(config);

      // Upload File
      if (File.Exists(invoice))
      {
        UploadInvoiceContainer(invoice);
      }

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }

    private static void UploadInvoiceContainer(string invoice, Configuration config=null)
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
    }

    private static string CreateAccessToken(Configuration config = null)
    {
      var api = new CreateAccessTokenApi(config);
      var result = api.AccessTokenRequest(new AccessTokenRequest
      {
        Name = "John Doe",
        Description = "John Doe User",
        TimeoutSeconds = 1500,
        //ApiIdentifier = new List<string> { "Customer1", "Costumer2"}
      });

      Console.WriteLine(result);

      return result.AccessToken;
    }

    private static int GetValidatableInvoiceCount(Configuration config = null)
    {
      var api = config != null ? new ValidatableInvoiceApi(config) : new ValidatableInvoiceApi();
      var result = api.GetValidatableInvoiceRequest();

      Console.WriteLine(result);

      return result.Count;
    }
  }
}
