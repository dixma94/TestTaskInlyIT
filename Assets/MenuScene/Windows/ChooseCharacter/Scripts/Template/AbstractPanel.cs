using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractPanel<T> : MonoBehaviour, IShowData<T>
    where T : IData
{
    [SerializeField] protected AbstractFactory<T> factory;
    [SerializeField] protected Transform parent;

    protected List<AbstractDataView<T>> dataViewList = new List<AbstractDataView<T>>();

    public ICreateDataView<T> GetFactory()
    {
        return factory;
    }

    public async virtual void Show(IDataProvider<T> dataProvider)
    {
        await foreach (T item in dataProvider.GetData())
        {
            AbstractDataView<T> dataView = GetFactory().Create(item) as AbstractDataView<T>;
            dataViewList.Add(dataView);
            dataView.Init(item);
            dataView.transform.parent = parent;
            dataView.transform.localScale = new Vector3(1, 1, 1);
            dataView.Selected += OnDataViewSelected;
        }
    }

    public virtual void OnDataViewSelected(IDataView<T> dataView)
    {
        dataView.Select();
    }


}

