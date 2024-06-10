namespace Mocca.Memorizer.Data;

public interface IDataFileLoader
{
    DataFile Load(string dataFilePath);
}