using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel.Oh
{
    public partial class helloForm : Form
    {
        public helloForm()
        {
            InitializeComponent();
        }

        private void radioButton1_Seattle_CheckedChanged(object sender, EventArgs e)
        {
            label_Hello2.Text = "Hello, Seattle!";
            picture_City.Image = (Image)Daniel.Oh.Properties.Resources.ResourceManager.GetObject("Seattle");
            label2_Area.Text = "142.5";
            label2_population.Text = "730400";
    

            label_Hello2.Visible = true;
            picture_City.Visible = true;
            checkBox1_Area_CheckedChanged(sender, null);
        }

        private void radioButton2_Atlanta_CheckedChanged(object sender, EventArgs e)
        {
            label_Hello2.Text = "Hello, Atlanta!";
            picture_City.Image = (Image)Daniel.Oh.Properties.Resources.ResourceManager.GetObject("Atlanta");
            label2_Area.Text = "134.0";
            label2_population.Text = "486290";
   


            label_Hello2.Visible = true;
            picture_City.Visible = true;
            checkBox1_Area_CheckedChanged(sender, null);
        }

        private void radioButton3_NYC_CheckedChanged(object sender, EventArgs e)
        {
            label_Hello2.Text = "Hello, New York!";
            picture_City.Image = (Image)Daniel.Oh.Properties.Resources.ResourceManager.GetObject("NewYork");
            label2_Area.Text = "468.484";
            label2_population.Text = "8623000";

            label_Hello2.Visible = true;
            picture_City.Visible = true;
            checkBox1_Area_CheckedChanged(sender, null);
        }
        private void radioButton4_LA_CheckedChanged(object sender, EventArgs e)
        {
            label_Hello2.Text = "Hello, Los Angeles!";
            picture_City.Image = (Image)Daniel.Oh.Properties.Resources.ResourceManager.GetObject("Los_Angeles");
            label2_Area.Text = "502.76";
            label2_population.Text = "3999759";

            label_Hello2.Visible = true;
            picture_City.Visible = true;
            checkBox1_Area_CheckedChanged(sender, null);
        }

        private void radioButton5_Chicago_CheckedChanged(object sender, EventArgs e)
        {
            label_Hello2.Text = "Hello, Chicago!";
            picture_City.Image = (Image)Daniel.Oh.Properties.Resources.ResourceManager.GetObject("Chicago");
            label2_Area.Text = "234.14";
            label2_population.Text = "2716450";

            label_Hello2.Visible = true;
            picture_City.Visible = true;
            checkBox1_Area_CheckedChanged(sender, null);
        }

        private void radioButton6_SF_CheckedChanged_1(object sender, EventArgs e)
        {
            label_Hello2.Text = "Hello, San Francisco!";
            picture_City.Image = (Image)Daniel.Oh.Properties.Resources.ResourceManager.GetObject("San_Francisco");
            label2_Area.Text = "231.89";
            label2_population.Text = "884363";

            label_Hello2.Visible = true;
            picture_City.Visible = true;
            checkBox1_Area_CheckedChanged(sender, null);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helloForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TeamName_TextChanged(object sender, EventArgs e)
        {
            label2_GoTeam.Text = "Go " + textBox_TeamName.Text + "!";
            label2_GoTeam.Visible = (textBox_TeamName.Text.Length > 0
               && textBox_TeamName.Text.Length < 11);
        }

        private void checkBox1_Area_CheckedChanged(object sender, EventArgs e) => label2_Area.Visible = checkBox1_Area.Checked && (radioButton1_Seattle.Checked || radioButton2_Atlanta.Checked || radioButton3_NYC.Checked || radioButton4_LA.Checked || radioButton5_Chicago.Checked || radioButton6_SF.Checked);

        private void checkBox2_Population_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
