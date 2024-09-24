// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "NewStringPickerDropdownSingle.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class NewStringPickerDropdownSingle
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
  // This is a generated class for NewStringPickerDropdownSingle 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// NewStringPickerDropdownSingle data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.StringDropdown`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class NewStringPickerDropdownSingle: AutoGenerated.ZAutoGenNewStringPickerDropdownSingle
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.NewStringPickerDropdownSingle in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenNewStringPickerDropdownSingle: Custom.Data.CustomItem
  {
    /// <summary>
    /// StringDropdown as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("StringDropdown", scrubHtml: true) etc.
    /// </summary>
    public string StringDropdown => _item.String("StringDropdown", fallback: "");
  }
}