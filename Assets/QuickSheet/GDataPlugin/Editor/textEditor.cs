using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(text))]
public class textEditor : BaseGoogleEditor<text>
{	    
    public override bool Load()
    {        
        text targetData = target as text;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<textData>(targetData.WorksheetName) ?? db.CreateTable<textData>(targetData.WorksheetName);
        
        List<textData> myDataList = new List<textData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            textData data = new textData();
            
            data = Cloner.DeepCopy<textData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
