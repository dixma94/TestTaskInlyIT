public interface ICreateDataView<T> where T : IData
{
    public IDataView<T> Create(T data);
}
