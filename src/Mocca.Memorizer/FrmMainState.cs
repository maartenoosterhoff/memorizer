using Mocca.Memorizer.Data;

namespace Mocca.Memorizer;

public class FrmMainState
{
    public FrmMainState()
    {
        SetButtonStates();
    }

    public DataFile? CurrentDataFile { get; private set; }

    public DatFileMemoryExecutioner? CurrentMemoryExecution { get; private set; }

    public QuestionWithAnswers? CurrentQuestion { get; private set; }

    public bool UserIsMemorizing { get; private set; }

    public bool LoadDataFileEnabled { get; private set; }

    public bool StartStopEnabled { get; private set; }

    public string StartStopText { get; private set; } = "Start";

    public bool QuestionAndAnswersEnabled { get; private set; }

    public int TotalAnswersAmount { get; private set; }

    public int CorrectAnswersAmount { get; private set; }

    public int IncorrectAnswersAmount { get; private set; }

    public string ResultText { get; private set; } = string.Empty;

    public Color ResultColor { get; private set; }


    public void OnDataFileLoaded(DataFile dataFile)
    {
        CurrentDataFile = dataFile;
        UserIsMemorizing = false;
        SetButtonStates();
    }

    public void OnDataFileLoadCancelled()
    {
        CurrentDataFile = null;
        UserIsMemorizing = false;
        SetButtonStates();
    }

    public void OnStartStop()
    {
        UserIsMemorizing = !UserIsMemorizing;

        if (UserIsMemorizing)
        {
            CurrentMemoryExecution = new DatFileMemoryExecutioner(CurrentDataFile!);
            CurrentQuestion = CurrentMemoryExecution.GenerateNextQuestion();
        }
        else
        {
            CurrentMemoryExecution = null;
            CurrentQuestion = null;
        }

        TotalAnswersAmount = 0;
        CorrectAnswersAmount = 0;
        IncorrectAnswersAmount = 0;

        ResultText = string.Empty;

        SetButtonStates();
    }

    public void OnAnswered(string answer)
    {
        if (CurrentMemoryExecution is null ||
            CurrentQuestion is null)
        {
            return;
        }

        var answeredCorrect = CurrentMemoryExecution.HandleAnswer(CurrentQuestion, answer);

        TotalAnswersAmount++;
        if (answeredCorrect)
        {
            CorrectAnswersAmount++;

            ResultText = $"Correct! {CurrentQuestion.Question} => {CurrentQuestion.Item.Answer}";
            ResultColor = Color.DarkGreen;
        }
        else
        {
            IncorrectAnswersAmount++;

            ResultText = $"Incorrect! {CurrentQuestion.Question} => {CurrentQuestion.Item.Answer}";
            ResultColor = Color.Red;
        }

        CurrentQuestion = CurrentMemoryExecution.GenerateNextQuestion();

        SetButtonStates();
    }

    private void SetButtonStates()
    {
        LoadDataFileEnabled = !UserIsMemorizing;
        StartStopEnabled = CurrentDataFile != null;
        StartStopText = UserIsMemorizing ? "Stop" : "Start";

        QuestionAndAnswersEnabled = CurrentMemoryExecution != null;
    }
}