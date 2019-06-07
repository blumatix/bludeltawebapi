using System;
using System.IO;
using IO.Swagger.Api;
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

      if (File.Exists(invoice))
      {
        UploadInvoiceContainer(invoice);
      }

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }

    private static void UploadInvoiceContainer(string invoice)
    {
      var uploadApi = new UploadInvoiceApi();
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
  }
}
