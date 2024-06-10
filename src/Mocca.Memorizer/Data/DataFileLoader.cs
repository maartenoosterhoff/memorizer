using System.Collections.Immutable;

namespace Mocca.Memorizer.Data;

public class DataFileLoader
{
    private readonly ImmutableList<char> _separators = ['|'];

    public DataFile Load(string dataFilePath)
    {
        var items = new List<DataFileItem>();
        foreach (var line in File.ReadLines(dataFilePath))
        {
            if (string.IsNullOrEmpty(line) ||
                line.StartsWith("'"))
            {
                continue;
            }

            var lineItems = line.Split(_separators.ToArray());
            if (lineItems.Length != 2)
            {
                continue;
            }

            items.Add(new(lineItems[0].Trim(), lineItems[1].Trim()));
        }

        return new([.. items]);
    }
}