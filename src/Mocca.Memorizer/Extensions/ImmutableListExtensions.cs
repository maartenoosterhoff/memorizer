using System.Collections.Immutable;

namespace Mocca.Memorizer.Extensions;

public static class ImmutableListExtensions
{
    public static T GetRandom<T>(this ImmutableList<T> data)
    {
        var index = Random.Shared.Next(0, data.Count);
        return data[index];
    }

    public static ImmutableList<T> GetRandom<T>(this ImmutableList<T> data, int count)
    {
        if (count >= data.Count)
        {
            var dataArray = data.ToArray();
            Random.Shared.Shuffle(dataArray);
            return [.. dataArray];
        }

        var current = count;
        var result = new List<T>();
        while (current > 0)
        {
            var item = data.GetRandom();
            data = data.Remove(item);
            result.Add(item);

            current--;
        }

        return [.. result];
    }
}