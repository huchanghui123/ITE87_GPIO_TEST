using System;
using System.Windows.Forms;

namespace GPIO_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            uint nResult = IT8786GPIO.InitInpOutDriver();
            if (nResult == 0)
            {
                label4.Text = "Unable to open InpOut driver.";
                label4.ForeColor = System.Drawing.Color.Red;
                btn_mode.Enabled = false;
                btn_gpio.Enabled = false;
            }
            else
            {
                label4.Text = "Load InpOut driver successfully.";
                IT8786GPIO.InitGPIO();
                ReadGPIOAttr();
            }
        }

        private void btn_gpio_Click(object sender, EventArgs e)
        {
            try
            {    
                short iData = Convert.ToInt16(gp_data.Text.Trim(), 16);
                Console.WriteLine("gpio value:"+ iData);
                IT8786GPIO.SetGpioVal(iData);
                ReadGPIOAttr();
                gp_data.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        private void btn_mode_Click(object sender, EventArgs e)
        {
            try
            {
                short iData = Convert.ToInt16(gp_mode.Text.Trim(), 16);
                Console.WriteLine("gpio mode:" + iData);
                IT8786GPIO.SetGpioMode(iData);
                ReadGPIOAttr();
                gp_mode.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        private void ReadGPIOAttr()
        {
            short c = IT8786GPIO.ReadGpioMode();
            lab_mode.Text = "GPIO MODE:" + Convert.ToInt32(c).ToString("X2");
            short c1 = IT8786GPIO.ReadGpioVal();
            lab_val.Text = "GPIO VALUE:" + Convert.ToInt32(c1).ToString("X2");
            Console.WriteLine(lab_mode.Text + "----" + lab_val.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IT8786GPIO.FreeGPIO();
        }

    }
}
