// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Car.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Car
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
  // This is a generated class for Car 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Car data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Colour`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Car: AutoGenerated.ZAutoGenCar
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.Car in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenCar: Custom.Data.CustomItem
  {
    /// <summary>
    /// Colour as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Colour", scrubHtml: true) etc.
    /// </summary>
    public string Colour => _item.String("Colour", fallback: "");

    /// <summary>
    /// CountryOfOrigin as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("CountryOfOrigin", scrubHtml: true) etc.
    /// </summary>
    public string CountryOfOrigin => _item.String("CountryOfOrigin", fallback: "");

    /// <summary>
    /// Generation as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Generation", scrubHtml: true) etc.
    /// </summary>
    public string Generation => _item.String("Generation", fallback: "");

    /// <summary>
    /// Manufacturer as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Manufacturer", scrubHtml: true) etc.
    /// </summary>
    public string Manufacturer => _item.String("Manufacturer", fallback: "");

    /// <summary>
    /// Model as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Model", scrubHtml: true) etc.
    /// </summary>
    public string Model => _item.String("Model", fallback: "");

    /// <summary>
    /// YearOfFIrstRegistration as int. <br/>
    /// To get other types use methods such as .Decimal("YearOfFIrstRegistration")
    /// </summary>
    public int YearOfFIrstRegistration => _item.Int("YearOfFIrstRegistration");
  }
}