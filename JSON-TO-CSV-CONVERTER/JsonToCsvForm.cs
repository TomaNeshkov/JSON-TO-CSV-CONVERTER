using System.Diagnostics;

namespace ProjectJsonToCsvConverter
{
    public partial class JsonToCsvForm : Form
    {
        public JsonToCsvForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var userInput = $"{textBoxUserInput.Text}/";

            try
            {
                JsonToCsv.CheckUserInput(userInput);
                txtBoxJson.Text = JsonToCsv.GetJson(userInput);
            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message, "Error");
                return;
            }


        }

        private void DisplayInvalidInputMessage(string message, string v)
        {
            MessageBox.Show(message, v);
        }

        private void textBoxJson_TextChanged(object sender, EventArgs e)
        {
            btnConvert.Visible = true;
            btnConvert.Focus();
            txtBoxCsv.Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtBoxCsv.Text = JsonToCsv.GetCsv();
        }

        private void textBoxCsv_TextChanged(object sender, EventArgs e)
        {
            textBoxUserInput.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
