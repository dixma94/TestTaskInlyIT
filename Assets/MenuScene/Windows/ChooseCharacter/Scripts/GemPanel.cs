using UnityEngine;

public class GemPanel : AbstractPanel<GemData>
{
    [SerializeField] GemsDataProvider gemsDataProvider;

    private void Start()
    {
        Show(gemsDataProvider);
    }

    public override void OnDataViewSelected(IDataView<GemData> dataView)
    {
        foreach (var item in dataViewList)
        {
            item.UnSelect();
        }
        dataView.Select();

    }




}
