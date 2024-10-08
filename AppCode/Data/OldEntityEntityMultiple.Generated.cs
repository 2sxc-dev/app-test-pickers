// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "OldEntityEntityMultiple.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class OldEntityEntityMultiple
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

namespace AppCode.Data
{
  // This is a generated class for OldEntityEntityMultiple 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// OldEntityEntityMultiple data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.EntityEntityMultiple`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class OldEntityEntityMultiple: AutoGenerated.ZAutoGenOldEntityEntityMultiple
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.OldEntityEntityMultiple in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenOldEntityEntityMultiple: Custom.Data.CustomItem
  {
    /// <summary>
    /// EntityEntityMultiple as list of Car.
    /// </summary>
    /// <remarks>
    /// Generated to return child-list child because field settings had Multi-Value=true. The type Car was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// An IEnumerable of specified type, but can be empty.
    /// </returns>
    public IEnumerable<Car> EntityEntityMultiple => _entityEntityMultiple ??= _item.Children<Car>("EntityEntityMultiple");
    private IEnumerable<Car> _entityEntityMultiple;
  }
}