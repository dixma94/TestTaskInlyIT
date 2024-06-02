using System.Collections.Generic;

public interface IDataProvider<T> where T : IData
{
    IAsyncEnumerable<T> GetData();
}

