using System.Collections.Immutable;

namespace Mocca.Memorizer.Data;

public record DataFile(ImmutableList<DataFileItem> Items)
{
    public static DataFile Switch(DataFile dataFile)
    {
        return new(
            [.. dataFile.Items.Select(x => new DataFileItem(x.Answer, x.Question))]
        );
    }
}

public static class EnumerableExtensions
{
    public static T GetRandom<T>(this ImmutableList<T> data)
    {
        var index = Random.Shared.Next(0, data.Count);
        return data[index];
    }

    public static ImmutableList<T> GetRandom<T>(this ImmutableList<T> data, int count)
    {
        var current = count;
        var result = new List<T>();
        while (current > 0)
        {
            var item = GetRandom(data);
            data = data.Remove(item);
            result.Add(item);

            current--;
        }

        return [.. result];
    }
}