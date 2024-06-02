using UnityEngine;

public abstract class AbstractFactory<T> : MonoBehaviour, ICreateDataView<T>
    where T : IData
{
    [SerializeField] protected AbstractDataView<T> Prefab;

    public IDataView<T> Create(T data)
    {
        return Instantiate(Prefab);
    }
}
