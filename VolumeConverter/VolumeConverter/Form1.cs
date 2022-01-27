using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Activate the Convert Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Creating Objects for All Unit Classes
            Temperature temp = new Temperature();
            Volume vol = new Volume();
            Length len = new Length();
            Weight weight = new Weight();
            Area area = new Area();
            //Hide the Error Mark
            label4.Hide();
            //Catch all the exceptions that may encounter 
            try
            {
                //Boolean type to identify if the input is a numerical value
                var isValid = double.TryParse(TextBox1.Text, out double value);
                if (isValid) //If is it a Value do this...
                {
                    //Determine the string value of label1.Text..
                    switch (label1.Text)
                    {
                        //If string value of label1.Text is Centiliter, do this..
                        case "Centiliter":
                            vol.CL = (float)value; //Implicitly convert the double value to float
                            TextBox2.Text = Convert.ToString(vol.ConvertToLitre()); //Convert float to String
                            label5.Text = "(cl)"; //Change label5.Text to (cl)
                            label6.Text = "(l)"; //Change label5.Text to (l)
                            break;
                        case "Liter":
                            vol.Litre = (float)value; 
                            TextBox2.Text = Convert.ToString(vol.ConvertToCL());
                            label5.Text = "(l)";
                            label6.Text = "(cl)";
                            break;
                        case "Celsius":
                            temp.Celcius = (float)value;
                            TextBox2.Text = Convert.ToString(temp.ConvertToFahrenheit());
                            label5.Text = "(°c)";
                            label6.Text = "(°f)";
                            break;
                        case "Fahrenheit":
                            temp.Fahrenheit = (float)value;
                            TextBox2.Text = Convert.ToString(temp.ConvertToCelcius());
                            label5.Text = "(°f)";
                            label6.Text = "(°c)";
                            break;
                        case "Kilometer":
                            len.Kilometer = value;
                            TextBox2.Text = Convert.ToString(len.ConvertToMile());
                            label5.Text = "(km)";
                            label6.Text = "(mi)";
                            break;
                        case "Mile":
                            len.Miles = value;
                            TextBox2.Text = Convert.ToString(len.ConvertToKM());
                            label5.Text = "(mi)";
                            label6.Text = "(km)";
                            break;
                        case "Kilogram":
                            weight.Kilogram = value;
                            TextBox2.Text = Convert.ToString(weight.ConvertToOunce());
                            label5.Text = "(lg)";
                            label6.Text = "(oz)";
                            break;
                        case "Ounce":
                            weight.Ounce = value;
                            TextBox2.Text = Convert.ToString(weight.ConvertToKilogram());
                            label5.Text = "(oz)";
                            label6.Text = "(kg)";
                            break;
                        case "Square meter":
                            area.MeterSquare = value;
                            TextBox2.Text = Convert.ToString(area.ConvertToHectare());
                            label5.Text = "(m²)";
                            label6.Text = "(ha)";
                            break;
                        default:
                            area.Hectare = value;
                            TextBox2.Text = Convert.ToString(area.ConvertToMeterSquare());
                            label5.Text = "(ha)";
                            label6.Text = "(m²)";
                            break;
                    }
                }
                else
                {
                    //If the boolean "IsValid" is equal to false throw this..
                    throw new ArgumentException("Invalid Value! Please Enter a valid value.");
                }
            }
            catch (Exception ex) //Catch all the exceptions and display the messagebox and label4 -> "!"
            {
                label4.Show();
                MessageBox.Show(ex.Message);
            }
        }

        //Clear all value in textbox when click
        private void button2_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            label4.Hide();
        }

        //Method for switching
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case "Centiliter":
                    label1.Text = "Liter";
                    label2.Text = "Centiliter";
                    label5.Text = "(l)";
                    label6.Text = "(cl)";
                    TextBox2.Clear();
                    break;
                case "Liter":
                    label1.Text = "Centiliter";
                    label2.Text = "Liter";
                    label5.Text = "(cl)";
                    label6.Text = "(l)";
                    TextBox2.Clear();
                    break;
                case "Celsius":
                    label1.Text = "Fahrenheit";
                    label2.Text = "Celsius";
                    label6.Text = "(°f)";
                    label5.Text = "(°c)";
                    TextBox2.Clear();
                    break;
                case "F":
                    label1.Text = "Celsius";
                    label2.Text = "Fahrenheit";
                    label5.Text = "(°c)";
                    label6.Text = "(°f)";
                    TextBox2.Clear();
                    break;
                case "Kilometer":
                    label1.Text = "Mile";
                    label2.Text = "Kilometer";
                    label5.Text = "(mi)";
                    label6.Text = "(km)";
                    TextBox2.Clear();
                    break;
                case "Mile":
                    label1.Text = "Kilometer";
                    label2.Text = "Mile";
                    label5.Text = "(km)";
                    label6.Text = "(mi)";
                    TextBox2.Clear();
                    break;
                case "Kilogram":
                    label1.Text = "Ounce";
                    label2.Text = "Kilogram";
                    label5.Text = "(oz)";
                    label6.Text = "(kg)";
                    TextBox2.Clear();
                    break;
                case "Ounce":
                    label1.Text = "Kilogram";
                    label2.Text = "Ounce";
                    label5.Text = "(kg)";
                    label6.Text = "(oz)";
                    TextBox2.Clear();
                    break;
                case "Square meter":
                    label1.Text = "Hectare";
                    label2.Text = "Square meter";
                    label5.Text = "(ha)";
                    label6.Text = "(m²)";
                    TextBox2.Clear();
                    break;
                default:
                    label1.Text = "Square meter";
                    label2.Text = "Hectare";
                    label5.Text = "(m²)";
                    label6.Text = "(ha)";
                    TextBox2.Clear();
                    break;
            }
        }

        //Temperature Unit Tab -> Switch to Temp text values and format when click
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Celsius";
            label2.Text = "Fahrenheit";
            TextBox1.Clear();
            TextBox2.Clear();
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            temp_button.Image = global::VolumeConverter.Properties.Resources.bg_orange;
            vol_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            len_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            weight_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            area_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
        }

        //Volume Unit Tab -> Switch to Vol text values and format when click
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Centiliter";
            label2.Text = "Liter";
            TextBox1.Clear();
            TextBox2.Clear();
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            temp_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            vol_button.Image = global::VolumeConverter.Properties.Resources.bg_orange;
            len_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            weight_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            area_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
        }
        //Length Unit Tab -> Switch to length text values and format when click
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Kilometer";
            label2.Text = "Mile";
            TextBox1.Clear();
            TextBox2.Clear();
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            temp_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            vol_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            len_button.Image = global::VolumeConverter.Properties.Resources.bg_orange;
            weight_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            area_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
        }

        //Weight Unit Tab -> Switch to weight text values and format when click
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Kilogram";
            label2.Text = "Ounce";
            TextBox1.Clear();
            TextBox2.Clear();
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            temp_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            vol_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            len_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            weight_button.Image = global::VolumeConverter.Properties.Resources.bg_orange;
            area_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
        }

        //Area Unit Tab -> Switch to area text values and format when click
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Square meter";
            label2.Text = "Hectare";
            TextBox1.Clear();
            TextBox2.Clear();
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            temp_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            vol_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            len_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            weight_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            area_button.Image = global::VolumeConverter.Properties.Resources.bg_orange;
        }
    }
}
