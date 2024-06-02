using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "GemData", menuName = "Scriptable/GemData")]
public class GemData : ScriptableObject, IData
{
    public string Name;
    public Sprite sprite;
}
