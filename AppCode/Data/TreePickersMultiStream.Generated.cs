// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "TreePickersMultiStream.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class TreePickersMultiStream
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
  // This is a generated class for TreePickersMultiStream 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// TreePickersMultiStream data. <br/>
  /// Generated 2024-09-24 13:04:01Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.FileFolderCPTreePicker`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class TreePickersMultiStream: AutoGenerated.ZAutoGenTreePickersMultiStream
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.TreePickersMultiStream in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZAutoGenTreePickersMultiStream: Custom.Data.CustomItem
  {
    /// <summary>
    /// FileFolderCPTreePicker as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem FileFolderCPTreePicker => _fileFolderCPTreePicker ??= _item.Child("FileFolderCPTreePicker");
    private ITypedItem _fileFolderCPTreePicker;

    /// <summary>
    /// FileFolderPCTreePicker as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem FileFolderPCTreePicker => _fileFolderPCTreePicker ??= _item.Child("FileFolderPCTreePicker");
    private ITypedItem _fileFolderPCTreePicker;
  }
}