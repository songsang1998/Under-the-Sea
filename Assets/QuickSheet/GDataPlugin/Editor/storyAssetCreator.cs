using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/story")]
    public static void CreatestoryAssetFile()
    {
        story asset = CustomAssetUtility.CreateAsset<story>();
        asset.SheetName = "Tower";
        asset.WorksheetName = "story";
        EditorUtility.SetDirty(asset);        
    }
    
}