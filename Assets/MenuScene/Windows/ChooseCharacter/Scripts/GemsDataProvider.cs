using System.Collections.Generic;
using UnityEngine;

public class GemsDataProvider : MonoBehaviour, IDataProvider<GemData>
{

    public List<GemData> data = new List<GemData>();

    private void Awake()
    {
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
        data.Add(new GemData { Name = "Ryby", spriteName = "Ryby" });
        data.Add(new GemData { Name = "Star", spriteName = "Star" });
        data.Add(new GemData { Name = "Heart", spriteName = "Heart" });
    }
    public List<GemData> GetData()
    {
       return data;
    }

}
