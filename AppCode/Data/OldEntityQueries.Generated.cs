// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "OldEntityQueries.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class OldEntityQueries
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
  // This is a generated class for OldEntityQueries 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// OldEntityQueries data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.AddEditDelete`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class OldEntityQueries: AutoGenerated.ZAutoGenOldEntityQueries
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.OldEntityQueries in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenOldEntityQueries: Custom.Data.CustomItem
  {
    /// <summary>
    /// AddEditDelete as single item of Car.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type Car was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public Car AddEditDelete => _addEditDelete ??= _item.Child<Car>("AddEditDelete");
    private Car _addEditDelete;

    /// <summary>
    /// HasParams as single item of Car.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type Car was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public Car HasParams => _hasParams ??= _item.Child<Car>("HasParams");
    private Car _hasParams;

    /// <summary>
    /// NoData as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem NoData => _noData ??= _item.Child("NoData");
    private ITypedItem _noData;

    /// <summary>
    /// NoQueryConfigured as single item of Car.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type Car was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public Car NoQueryConfigured => _noQueryConfigured ??= _item.Child<Car>("NoQueryConfigured");
    private Car _noQueryConfigured;

    /// <summary>
    /// NoStreamConfigured as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem NoStreamConfigured => _noStreamConfigured ??= _item.Child("NoStreamConfigured");
    private ITypedItem _noStreamConfigured;

    /// <summary>
    /// NothingAllowed as single item of Car.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type Car was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public Car NothingAllowed => _nothingAllowed ??= _item.Child<Car>("NothingAllowed");
    private Car _nothingAllowed;

    /// <summary>
    /// NothingAllowedExceptExisingValues as single item of Car.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type Car was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public Car NothingAllowedExceptExisingValues => _nothingAllowedExceptExisingValues ??= _item.Child<Car>("NothingAllowedExceptExisingValues");
    private Car _nothingAllowedExceptExisingValues;
  }
}