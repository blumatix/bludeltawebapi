using CommandLine;
using CommandLine.Text;

namespace BludeltaWebApiTestClient
{
  public class Options
  {
    [Option('i', "invoice", Required = false, DefaultValue = "", HelpText = "Path to a single invoice")]
    public string Invoice { get; set; }

    [HelpOption]
    public string GetUsage()
    {
      return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
    }
  }
}
