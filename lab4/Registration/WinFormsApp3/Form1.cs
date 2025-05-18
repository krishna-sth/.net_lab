using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string name = textBox2.Text.Trim();
            int age = (int)numericUpDown1.Value;
            string province = comboBox1.Text.Trim();
            string district = comboBox2.Text.Trim();
            //bool hasSkill = Java_SelectedIndexChanged.CheckedItems.Count > 0;

            if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(province) || string.IsNullOrEmpty(district) )
            {
                MessageBox.Show("Please fill all the fields properly and select at least one skill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Sign Up Successful!\n\nName: {name}\nAge: {age}\nProvince: {province}\nDistrict: {district}\n");
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Java_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}