using System.Reflection;
using Mocca.Memorizer.Data;

namespace Mocca.Memorizer;

public partial class FrmMain : Form
{
    private readonly FrmMainState _state = new();

    public FrmMain()
    {
        InitializeComponent();

        SetButtons();
    }

    private void btnLoadDataFile_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();

        openFileDialog.InitialDirectory = Path.Combine(Assembly.GetExecutingAssembly().Location, ".");
        openFileDialog.Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var filePath = openFileDialog.FileName;
            var dataFile = new DataFileLoader().Load(filePath);

            if (MessageBox.Show(@"Do you want to switch the data?", @"Switch data?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                dataFile = DataFile.Switch(dataFile);
            }

            _state.OnDataFileLoaded(dataFile);
        }
        else
        {
            _state.OnDataFileLoadCancelled();
        }

        SetButtons();
    }

    private void btnStartStop_Click(object sender, EventArgs e)
    {
        _state.OnStartStop();

        SetButtons();
    }

    private void SetButtons()
    {
        btnLoadDataFile.Enabled = _state.LoadDataFileEnabled;
        btnStartStop.Enabled = _state.StartStopEnabled;
        btnStartStop.Text = _state.StartStopText;
        btnQuestion.Enabled = _state.QuestionAndAnswersEnabled;
        btnAnswer1.Enabled = _state.QuestionAndAnswersEnabled;
        btnAnswer2.Enabled = _state.QuestionAndAnswersEnabled;
        btnAnswer3.Enabled = _state.QuestionAndAnswersEnabled;
        btnAnswer4.Enabled = _state.QuestionAndAnswersEnabled;

        if (_state.CurrentQuestion != null)
        {
            btnQuestion.Text = _state.CurrentQuestion.Question;
            btnAnswer1.Text = _state.CurrentQuestion.Answers[0];
            btnAnswer2.Text = _state.CurrentQuestion.Answers[1];
            btnAnswer3.Text = _state.CurrentQuestion.Answers[2];
            btnAnswer4.Text = _state.CurrentQuestion.Answers[3];
        }
        else
        {
            btnQuestion.Text = null;
            btnAnswer1.Text = null;
            btnAnswer2.Text = null;
            btnAnswer3.Text = null;
            btnAnswer4.Text = null;
        }

        txtTotalAnswers.Text = _state.TotalAnswersAmount.ToString();
        txtCorrectAnswers.Text = _state.CorrectAnswersAmount.ToString();
        txtIncorrectAnswers.Text = _state.IncorrectAnswersAmount.ToString();

        lblResultaat.Text = _state.ResultText;
        lblResultaat.ForeColor = _state.ResultColor;

    }

    private void btnAnswer1_Click(object sender, EventArgs e)
    {
        _state.OnAnswered(btnAnswer1.Text);
        SetButtons();
    }

    private void btnAnswer2_Click(object sender, EventArgs e)
    {
        _state.OnAnswered(btnAnswer2.Text);
        SetButtons();
    }

    private void btnAnswer3_Click(object sender, EventArgs e)
    {
        _state.OnAnswered(btnAnswer3.Text);
        SetButtons();
    }

    private void btnAnswer4_Click(object sender, EventArgs e)
    {
        _state.OnAnswered(btnAnswer4.Text);
        SetButtons();
    }
}