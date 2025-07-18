using System.ComponentModel;
using System.Globalization;

namespace time_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbo_input.SelectedIndex = 3;
            cbo_output.SelectedIndex = 0;
        }

        private string InputFormat { get; set; }
        private string OutputFormat { get; set; }
        private string InputString { get; set; }
        private string OutputString { get; set; }
        private DateTime InputDateTime { get; set; }
        private DateTime OutputDateTime { get; set; }
        private TimeSpan ComputableTime { get; set; }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParseAllInputs();
            IdentifyOperation();
            WriteOutput();
            txt_output.Text = OutputString;
        }

        private void ParseAllInputs()
        {
            InputString = txt_input.Text;
            InputFormat = (string)cbo_input.SelectedItem;
            OutputFormat = (string)cbo_output.SelectedItem;
        }

        private void IdentifyOperation()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            switch (InputFormat)
            {
                case "seconds":
                    ComputableTime = TimeSpan.FromSeconds(Double.Parse(InputString));
                    break;
                case "minutes":
                    ComputableTime = TimeSpan.FromMinutes(Double.Parse(InputString));
                    break;
                case "hours":
                    ComputableTime = TimeSpan.FromHours(Double.Parse(InputString));
                    break;
                case "HH:MM:SS or MM:SS":
                    int colonCount = GetColonCount();
                    if(colonCount == 2)
                    {
                        var formats = new[] { "h':'mm':'ss", "'0'h':'mm':'ss" };
                        ComputableTime = TimeSpan.ParseExact(InputString, formats, provider);
                    }
                    else if (colonCount == 1)
                    {
                        var formats = new[] { "m':'ss", "'0'm':'ss" };
                        ComputableTime = TimeSpan.ParseExact(InputString, formats, provider);
                    }
                    break;
                case "HH:MM":
                    ComputableTime = TimeSpan.ParseExact(InputString, @"hh\:mm", provider);
                    break;
                case "MM:SS":
                    ComputableTime = TimeSpan.ParseExact(InputString, @"mm\:ss", provider);
                    break;
            }
            
        }

        private int GetColonCount()
        {
            int colonCount = 0;
            foreach (char character in InputString)
            {
                if(character == ':')
                {
                    colonCount++;
                }
            }
            return colonCount;
        }

        private void WriteOutput()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            switch (OutputFormat)
            {
                case "seconds":
                    OutputString = string.Format("{0}", (double)ComputableTime.TotalSeconds);
                    break;
                case "minutes":
                    OutputString = string.Format("{0}", (double)ComputableTime.TotalMinutes);
                    break;
                case "hours":
                    OutputString = string.Format("{0}", (double)ComputableTime.TotalHours);
                    break;
                case "HH:MM:SS":
                    OutputString = ComputableTime.ToString(@"hh\:mm\:ss");
                    break;
                case "HH:MM":
                    OutputString = string.Format("{0}:{1}", (int)ComputableTime.TotalHours, ComputableTime.Minutes.ToString("00"));
                    break;
                case "MM:SS":
                    OutputString = string.Format("{0}:{1}",(int)ComputableTime.TotalMinutes, ComputableTime.Seconds.ToString("00"));
                    break;
            }
        }

        private void cbo_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
