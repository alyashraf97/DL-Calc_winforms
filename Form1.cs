
using System;

namespace DL_Calc
{
    public partial class Form1 : Form
    {
        public double fileSize; // Filesize variable
        public double speed;

        // /*

        public double fileSizeMultiplier =1;
        public string sizeUnitChoice;
        public Dictionary<string, double> sizeChoices = new Dictionary<string, double>
        {
            {"GB",  Math.Pow(2, 30) },
            {"MB",  Math.Pow(2, 20) },
            {"KB",  Math.Pow(2, 10) },
            {"B", 1 },
        };

        // Convert.ToDouble( //

        // Download Speed
        public double speedMultiplier =1;
        public string speedUnitChoice;

        public Dictionary<string, double> speedChoices= new Dictionary<string, double>
        {
            {"Gbps", Math.Pow(10, 9)},
            {"Mbps", Math.Pow(10, 6)},
            {"Kbps", Math.Pow(10, 3)},
            {"bps", 1 },
        };
        // */

        public double time; // Download time
        public double hr;
        public double min;
        public double sec;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("GB");
            comboBox1.Items.Add("MB");
            comboBox1.Items.Add("KB");


            comboBox2.Items.Add("Gbps");
            comboBox2.Items.Add("Mbps");
            comboBox2.Items.Add("Kbps");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           

            fileSize = Convert.ToDouble(textBox1.Text);  // get the filesize
            speed = Convert.ToDouble(textBox2.Text);     // get the download speed

            /*

            if (comboBox1.Text == "GB" & comboBox2.Text=="Gbps" 
                | comboBox1.Text == "MB" & comboBox2.Text == "Mbps" 
                | comboBox1.Text == "KB" & comboBox2.Text == "Kbps")
            { 
                time = (fileSize * 8) / speed;
            }

            else if (comboBox1.Text == "GB" & comboBox2.Text == "Mbps" 
                | comboBox1.Text == "MB" & comboBox2.Text == "Kbps")
            {
                time = (fileSize * 8 * 1024) / speed;
            }

            else if (comboBox1.Text == "MB" & comboBox2.Text == "Gbps"
                | comboBox1.Text == "KB" & comboBox2.Text == "Mbps")
            {
                time = (fileSize * 8 ) / (speed * 1024);
            }
            else if (comboBox1.Text == "GB" & comboBox2.Text == "Kbps")
            {
                time = (fileSize * 8 * Math.Pow(2, 20) )/ speed;
            }
            else if (comboBox1.Text == "KB" & comboBox2.Text == "Gbps")
            {
                time = (fileSize * 8) / (speed * 1024 * 1024);
            }
            */

            // /*
            sizeUnitChoice = comboBox1.Text;
            speedUnitChoice = comboBox2.Text;

            fileSizeMultiplier = sizeChoices[sizeUnitChoice];
            Console.WriteLine(fileSizeMultiplier);
            speedMultiplier = speedChoices[speedUnitChoice];
            Console.WriteLine(speedMultiplier);

            // */

            time = (fileSize * 8 * fileSizeMultiplier) / (speed * speedMultiplier);


            Console.WriteLine(time);
            hr = Math.Floor(time / 3600);
            min = Math.Floor((time - hr * 3600) / 60);
            sec = Math.Floor((time - hr * 3600 - min * 60));

            label4.Text = $"{hr} Hours, {min} Minutes, {sec} Seconds.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*public void calculate()
        {
            


        }
        */
    }
}