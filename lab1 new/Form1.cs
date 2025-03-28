using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace lab1_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_X_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox_X.Text);
                double y = Convert.ToDouble(textBox_Y.Text);
                double res = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);
                result.Text = res.ToString();

            }
            catch
            {

            }
        }

        private void textBox_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }            if (e.KeyChar == ',')
            {
                if (textBox_X.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_ok.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_Y.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_ok.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ok_2_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(textBox_rad.Text);
            double angle_1 = Convert.ToDouble(textBox_1.Text);
            double angle_2 = Convert.ToDouble(textBox_2.Text);
            double angle_3 = 180 - (angle_1 + angle_2);
            double side_1 = 2 * rad * Math.Sin(angle_1 * Math.PI / 180);
            double side_2 = 2 * rad * Math.Sin(angle_2 * Math.PI / 180);
            double side_3 = 2 * rad * Math.Sin(angle_3 * Math.PI / 180);
            angle_3_res.Text = angle_3.ToString();
            label_side_1_result.Text = Math.Round(side_1, 2).ToString();
            label_side_2_result.Text = Math.Round(side_2, 2).ToString();
            label_side_3_result.Text = Math.Round(side_3, 2).ToString();



        }

        private void textBox_rad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_rad.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_ok_2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_ok_2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_2.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_ok_2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_cord_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox_x_cord.Text);
                double y = Convert.ToDouble(textBox_y_cord.Text);
                int rect_number = Convert.ToInt32(textBox_rectangle.Text);

                bool result = (rect_number == 1 && x >= -10 && x <= 0 && y >= 0 && y <= 10) ||
                              (rect_number == 2 && x >= 0 && x <= 10 && y >= 0 && y <= 10) ||
                              (rect_number == 3 && x >= -10 && x <= 0 && y >= -10 && y <= 0) ||
                              (rect_number == 4 && x >= 0 && x <= 10 && y >= -10 && y <= 0);

                true_false.Text = result ? "True" : "False";
            }
            catch
            {

            }
        }

        private void textBox_x_cord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            // Додамо перевірку діапазону після введення
            string newText = textBox_x_cord.Text.Insert(textBox_x_cord.SelectionStart, e.KeyChar.ToString());

            if (double.TryParse(newText, out double value))
            {
                if (value < -10 || value > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_y_cord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            // Додамо перевірку діапазону після введення
            string newText = textBox_y_cord.Text.Insert(textBox_y_cord.SelectionStart, e.KeyChar.ToString());

            if (double.TryParse(newText, out double value))
            {
                if (value < -10 || value > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_rectangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!"1234".Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void button_x_scl_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox_x_scl.Text);
                double sinx = Math.Sin(x);
                double cosx = Math.Cos(x);
                double lnx = Math.Log(x);

                sin.Text = sinx.ToString();
                cos.Text = cosx.ToString();
                Ln.Text = lnx.ToString();

            }
            catch
            {

            }
        }

        private void textBox_x_scl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_x_scl.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_x_scl.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button_kn_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox_n.Text);
                int k = Convert.ToInt32(textBox_k.Text);


                if (n <= 0 || k <= 0)
                {
                    kn_result.Text = "Помилка: введіть натуральні числа";
                    return;
                }

                int sum = 0;
                int temp = n;


                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += (int)Math.Pow(digit, k);
                    temp /= 10;
                }


                kn_result.Text = (sum == n) ? "Так, дорівнює" : "Ні, не дорівнює";
            }
            catch
            {
                kn_result.Text = "Помилка: введіть коректні значення";
            }
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_k_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_day_A_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_suncloud_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox_day_A.Text);
            double b = a;
            string[] days = { "cloud", "cloud", "sun", "sun", "cloud", "sun",
         "cloud", "cloud", "sun", "sun", "sun", "sun",
         "cloud", "sun", "cloud", "cloud", "sun", "sun",
         "cloud", "cloud", "sun", "sun", "cloud", "sun",
         "sun", "cloud", "sun", "sun", "cloud", "sun" };

            int sunCount = 0;
            int cloudCount = 0;

            foreach (string day in days)
            {
                if (day == "sun")
                {
                    b += 2;
                    sunCount++;
                }
                else if (day == "cloud")
                {
                    b -= 1;
                    cloudCount++;
                }
            }

            day_B.Text = b.ToString();
            sun_days.Text = sunCount.ToString();
            cloud_days.Text = cloudCount.ToString();
        }

        private void textBox_day_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_X.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button_ok.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void button_numbers_Click(object sender, EventArgs e)
        {
            string numb_alpha = textBox_alpha_numb.Text;
            int maxLength = 0;
            int currentLength = 0;

            foreach (char c in numb_alpha)
            {
                if (char.IsDigit(c))
                {
                    currentLength++;
                    if (currentLength > maxLength)
                        maxLength = currentLength;
                }
                else
                {
                    currentLength = 0;
                }
            }

            numbers_in_row.Text = maxLength.ToString();

        }

        private void textBox_alpha_numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {

                return;
            }

            if (char.IsControl(e.KeyChar))
            {

                return;
            }

            e.Handled = true;
        }
    }

}








