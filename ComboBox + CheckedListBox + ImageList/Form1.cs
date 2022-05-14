using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox___CheckedListBox___ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DisplayChoice_comboBox.Items.AddRange(new string[] { "Название", "Флаг"});
            Countries_checkedListBox.Items.AddRange(new string[] { "Австралия", "Великобритания", 
                "Греция", "Исландия", "Норвегия", "Россия", "США" });

            Countries_checkedListBox.CheckOnClick = true;
            Countries_checkedListBox.SelectionMode = SelectionMode.One;
            Countries_checkedListBox.MultiColumn = true;
            DisplayChoice_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DisplayChoice_comboBox.SelectedItem = "Название";
        }

        private void Output_button_Click(object sender, EventArgs e)
        {
            string SelectedCountry = Convert.ToString(Countries_checkedListBox.SelectedItem);

            if (DisplayChoice_comboBox.Text == "Флаг")
            {
                Output_label.ImageList = Countries_imageList;
                Output_label.Text = "     ";

                if (SelectedCountry == "Австралия") { Output_label.ImageIndex = 0; }
                else if (SelectedCountry == "Великобритания") { Output_label.ImageIndex = 5; }
                else if (SelectedCountry == "Греция") { Output_label.ImageIndex = 1; }
                else if (SelectedCountry == "Исландия") { Output_label.ImageIndex = 2; }
                else if (SelectedCountry == "Норвегия") { Output_label.ImageIndex = 3; }
                else if (SelectedCountry == "Россия") { Output_label.ImageIndex = 4; }
                else if (SelectedCountry == "США") { Output_label.ImageIndex = 6; }
            }
            else if (DisplayChoice_comboBox.Text == "Название")
            {
                Output_label.ImageList = null;
                Output_label.Text = SelectedCountry;
            }
        }
    }
}