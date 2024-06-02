using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class GemsDataProvider : MonoBehaviour, IDataProvider<GemData>
{

    public List<AssetReference> data = new List<AssetReference>();

    public async IAsyncEnumerable<GemData> GetData()
    {
        foreach (var asset in data)
        {
            GemData gemData = await asset.LoadAssetAsync<GemData>().Task;
            yield return gemData;
        }
    }

}
