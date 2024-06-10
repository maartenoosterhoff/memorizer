using System.Collections.Immutable;

namespace Mocca.Memorizer.Data;

public class QuestionWithAnswers
{
    public QuestionWithAnswers(DataFileItem item, ImmutableList<string> faultyAnswers)
    {
        Item = item;
        Question = item.Question;
        string[] answers = [item.Answer, .. faultyAnswers];
        Random.Shared.Shuffle(answers);
        Answers = [.. answers];
    }

    public DataFileItem Item { get; }

    public string Question { get; }

    public ImmutableList<string> Answers { get; }
}