using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/text")]
    public static void CreatetextAssetFile()
    {
        text asset = CustomAssetUtility.CreateAsset<text>();
        asset.SheetName = "Tower";
        asset.WorksheetName = "text";
        EditorUtility.SetDirty(asset);        
    }
    
}