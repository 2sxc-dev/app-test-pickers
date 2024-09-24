// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "NewPickerErrIncompleteEntity.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class NewPickerErrIncompleteEntity
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v18.01.00
// App/Edition: app-test-pickers/
// User:        2sichost
// When:        2024-09-24 13:04:01Z
using System.Collections.Generic;
using ToSic.Sxc.Data;

namespace AppCode.Data
{
  // This is a generated class for NewPickerErrIncompleteEntity 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// NewPickerErrIncompleteEntity data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.QueryPickerIncomplete`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class NewPickerErrIncompleteEntity: AutoGenerated.ZAutoGenNewPickerErrIncompleteEntity
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.NewPickerErrIncompleteEntity in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenNewPickerErrIncompleteEntity: Custom.Data.CustomItem
  {
    /// <summary>
    /// QueryPickerIncomplete as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem QueryPickerIncomplete => _queryPickerIncomplete ??= _item.Child("QueryPickerIncomplete");
    private ITypedItem _queryPickerIncomplete;
  }
}