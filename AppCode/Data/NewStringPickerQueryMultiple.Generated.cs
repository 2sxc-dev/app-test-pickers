// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "NewStringPickerQueryMultiple.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class NewStringPickerQueryMultiple
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v18.01.00
// App/Edition: app-test-pickers/
// User:        2sichost
// When:        2024-09-24 13:04:01Z
namespace AppCode.Data
{
  // This is a generated class for NewStringPickerQueryMultiple 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// NewStringPickerQueryMultiple data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.StringQuery`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class NewStringPickerQueryMultiple: AutoGenerated.ZAutoGenNewStringPickerQueryMultiple
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.NewStringPickerQueryMultiple in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenNewStringPickerQueryMultiple: Custom.Data.CustomItem
  {
    /// <summary>
    /// StringQuery as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("StringQuery", scrubHtml: true) etc.
    /// </summary>
    public string StringQuery => _item.String("StringQuery", fallback: "");
  }
}