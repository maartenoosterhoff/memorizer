using System.Collections.Immutable;
using Mocca.Memorizer.Extensions;

namespace Mocca.Memorizer.Data;

public class DatFileMemoryExecutioner(DataFile dataFile)
{
    private ImmutableList<DataFileItem> _currentRun = [.. dataFile.Items];

    public QuestionWithAnswers GenerateNextQuestion()
    {
        if (_currentRun.Count == 0)
        {
            _currentRun = [.. dataFile.Items];
        }

        var dataFileItem = _currentRun.GetRandom();
        var faultyAnswers = dataFile.Items.Remove(dataFileItem).GetRandom(3);

        _currentRun = _currentRun.Remove(dataFileItem);

        return new QuestionWithAnswers(dataFileItem, [.. faultyAnswers.Select(x => x.Answer)]);
    }

    public bool HandleAnswer(QuestionWithAnswers question, string answer)
    {
        return question.Item.Answer == answer;
    }
}