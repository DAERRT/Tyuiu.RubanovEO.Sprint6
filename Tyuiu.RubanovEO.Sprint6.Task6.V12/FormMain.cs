using Tyuiu.RubanovEO.Sprint6.Task6.V12.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath1;
        DataService ds = new DataService();

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath1 = openFileDialog1.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath1);
            groupBoxRes.Text = groupBoxRes.Text + " " + openFilePath1;
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath1);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
