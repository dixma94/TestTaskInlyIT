public interface IDataView<T> where T : IData
{
    public void Init(T data);
    public void Select();
    public void UnSelect();

}

