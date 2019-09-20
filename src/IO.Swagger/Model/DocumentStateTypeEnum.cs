using System.ComponentModel;

namespace IO.Swagger.Model
{
    public enum DocumentStateTypeEnum
    {
        [Description("New")]
        New = 1,
        [Description("Autoprocessed")]
        Autoprocessed = 2,
        [Description("NeedForAction")]
        NeedForAction = 3,
        [Description("Validated")]
        Validated = 4,
        [Description("Released")]
        Released = 5,
        [Description("Imported")]
        Imported = 6
    }
}
