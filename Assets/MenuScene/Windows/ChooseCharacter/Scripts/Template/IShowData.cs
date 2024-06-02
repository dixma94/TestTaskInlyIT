using System.Threading.Tasks;

public interface IShowData<T> where T : IData
{
    void Show(IDataProvider<T> dataProvider);
    ICreateDataView<T> GetFactory();
}

