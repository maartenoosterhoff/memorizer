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