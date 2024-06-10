using System.Collections.Immutable;

namespace Mocca.Memorizer.Data;

public class DatFileMemoryExecutioner
{
    private readonly DataFile _dataFile;

    private ImmutableList<DataFileItem> _currentRun;

    public DatFileMemoryExecutioner(DataFile dataFile)
    {
        _dataFile = dataFile;
        _currentRun = [.. dataFile.Items];
    }

    public QuestionWithAnswers GenerateNextQuestion()
    {
        if (_currentRun.Count == 0)
        {
            _currentRun = [.. _dataFile.Items];
        }

        var dataFileItem = _currentRun.GetRandom();
        var faultyAnswers = _dataFile.Items.Remove(dataFileItem).GetRandom(3);

        _currentRun = _currentRun.Remove(dataFileItem);

        return new QuestionWithAnswers(dataFileItem, [.. faultyAnswers.Select(x => x.Answer)]);
    }

    public bool HandleAnswer(QuestionWithAnswers question, string answer)
    {
        return question.Item.Answer == answer;
    }
}