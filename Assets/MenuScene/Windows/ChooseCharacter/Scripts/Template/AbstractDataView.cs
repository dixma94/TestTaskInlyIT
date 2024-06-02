using System;
using UnityEngine;

public abstract class AbstractDataView<T> : MonoBehaviour, IDataView<T>
    where T : IData
{
    protected T data;

    public event Action<IDataView<T>> Selected;

    public abstract void Init(T data);

    public abstract void Select();

    public abstract void UnSelect();

    public virtual void OnSelected()
    {
        Selected?.Invoke(this);
    }

}
