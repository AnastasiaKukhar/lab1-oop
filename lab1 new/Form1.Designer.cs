using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace lab1_new
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_side_3_result = new System.Windows.Forms.Label();
            this.label_side_2_result = new System.Windows.Forms.Label();
            this.label_side_1_result = new System.Windows.Forms.Label();
            this.label_sides_result = new System.Windows.Forms.Label();
            this.button_ok_2 = new System.Windows.Forms.Button();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_rad = new System.Windows.Forms.TextBox();
            this.angle_3_res = new System.Windows.Forms.Label();
            this.label_angle_3 = new System.Windows.Forms.Label();
            this.label_angle_2 = new System.Windows.Forms.Label();
            this.label_angle_1 = new System.Windows.Forms.Label();
            this.label_radius = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_rectangle = new System.Windows.Forms.TextBox();
            this.label_rectangle = new System.Windows.Forms.Label();
            this.button_cord = new System.Windows.Forms.Button();
            this.textBox_y_cord = new System.Windows.Forms.TextBox();
            this.textBox_x_cord = new System.Windows.Forms.TextBox();
            this.true_false = new System.Windows.Forms.Label();
            this.label_true_false = new System.Windows.Forms.Label();
            this.label_y_cord = new System.Windows.Forms.Label();
            this.label_x_cord = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox_x_scl = new System.Windows.Forms.TextBox();
            this.button_x_scl = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Label();
            this.Ln = new System.Windows.Forms.Label();
            this.label_cos = new System.Windows.Forms.Label();
            this.label_sin = new System.Windows.Forms.Label();
            this.label_ln = new System.Windows.Forms.Label();
            this.label_x_scl = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.kn_result = new System.Windows.Forms.Label();
            this.button_kn = new System.Windows.Forms.Button();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_k = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label_day_A = new System.Windows.Forms.Label();
            this.textBox_day_A = new System.Windows.Forms.TextBox();
            this.label_day_B = new System.Windows.Forms.Label();
            this.day_B = new System.Windows.Forms.Label();
            this.label_sun = new System.Windows.Forms.Label();
            this.sun_days = new System.Windows.Forms.Label();
            this.label_cloud = new System.Windows.Forms.Label();
            this.cloud_days = new System.Windows.Forms.Label();
            this.button_suncloud = new System.Windows.Forms.Button();
            this.label_num = new System.Windows.Forms.Label();
            this.label_numbers = new System.Windows.Forms.Label();
            this.numbers_in_row = new System.Windows.Forms.Label();
            this.textBox_alpha_numb = new System.Windows.Forms.TextBox();
            this.button_numbers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button_ok);
            this.tabPage1.Controls.Add(this.result);
            this.tabPage1.Controls.Add(this.textBox_Y);
            this.tabPage1.Controls.Add(this.textBox_X);
            this.tabPage1.Controls.Add(this.label_result);
            this.tabPage1.Controls.Add(this.label_y);
            this.tabPage1.Controls.Add(this.label_x);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 91);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(24, 108);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(181, 33);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "Обчислити";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(110, 171);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(24, 16);
            this.result.TabIndex = 5;
            this.result.Text = "(   )";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(74, 56);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(132, 22);
            this.textBox_Y.TabIndex = 4;
            this.textBox_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Y_KeyPress);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(74, 17);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(132, 22);
            this.textBox_X.TabIndex = 3;
            this.textBox_X.TextChanged += new System.EventHandler(this.textBox_X_TextChanged);
            this.textBox_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_X_KeyPress);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(24, 171);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(80, 16);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "Результат:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(24, 56);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(19, 16);
            this.label_y.TabIndex = 1;
            this.label_y.Text = "Y:";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(24, 20);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(18, 16);
            this.label_x.TabIndex = 0;
            this.label_x.Text = "X:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_side_3_result);
            this.tabPage2.Controls.Add(this.label_side_2_result);
            this.tabPage2.Controls.Add(this.label_side_1_result);
            this.tabPage2.Controls.Add(this.label_sides_result);
            this.tabPage2.Controls.Add(this.button_ok_2);
            this.tabPage2.Controls.Add(this.textBox_2);
            this.tabPage2.Controls.Add(this.textBox_1);
            this.tabPage2.Controls.Add(this.textBox_rad);
            this.tabPage2.Controls.Add(this.angle_3_res);
            this.tabPage2.Controls.Add(this.label_angle_3);
            this.tabPage2.Controls.Add(this.label_angle_2);
            this.tabPage2.Controls.Add(this.label_angle_1);
            this.tabPage2.Controls.Add(this.label_radius);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label_side_3_result
            // 
            this.label_side_3_result.AutoSize = true;
            this.label_side_3_result.Location = new System.Drawing.Point(17, 350);
            this.label_side_3_result.Name = "label_side_3_result";
            this.label_side_3_result.Size = new System.Drawing.Size(18, 16);
            this.label_side_3_result.TabIndex = 13;
            this.label_side_3_result.Text = "( )";
            // 
            // label_side_2_result
            // 
            this.label_side_2_result.AutoSize = true;
            this.label_side_2_result.Location = new System.Drawing.Point(17, 308);
            this.label_side_2_result.Name = "label_side_2_result";
            this.label_side_2_result.Size = new System.Drawing.Size(18, 16);
            this.label_side_2_result.TabIndex = 12;
            this.label_side_2_result.Text = "( )";
            // 
            // label_side_1_result
            // 
            this.label_side_1_result.AutoSize = true;
            this.label_side_1_result.Location = new System.Drawing.Point(17, 270);
            this.label_side_1_result.Name = "label_side_1_result";
            this.label_side_1_result.Size = new System.Drawing.Size(18, 16);
            this.label_side_1_result.TabIndex = 11;
            this.label_side_1_result.Text = "( )";
            // 
            // label_sides_result
            // 
            this.label_sides_result.AutoSize = true;
            this.label_sides_result.Location = new System.Drawing.Point(17, 231);
            this.label_sides_result.Name = "label_sides_result";
            this.label_sides_result.Size = new System.Drawing.Size(145, 16);
            this.label_sides_result.TabIndex = 10;
            this.label_sides_result.Text = "Сторони трикутників";
            this.label_sides_result.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_ok_2
            // 
            this.button_ok_2.Location = new System.Drawing.Point(20, 166);
            this.button_ok_2.Name = "button_ok_2";
            this.button_ok_2.Size = new System.Drawing.Size(287, 40);
            this.button_ok_2.TabIndex = 9;
            this.button_ok_2.Text = "Обчислити";
            this.button_ok_2.UseVisualStyleBackColor = true;
            this.button_ok_2.Click += new System.EventHandler(this.button_ok_2_Click);
            // 
            // textBox_2
            // 
            this.textBox_2.Location = new System.Drawing.Point(195, 87);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(100, 22);
            this.textBox_2.TabIndex = 8;
            this.textBox_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_2_KeyPress);
            // 
            // textBox_1
            // 
            this.textBox_1.Location = new System.Drawing.Point(195, 50);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(100, 22);
            this.textBox_1.TabIndex = 7;
            this.textBox_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_1_KeyPress);
            // 
            // textBox_rad
            // 
            this.textBox_rad.Location = new System.Drawing.Point(195, 16);
            this.textBox_rad.Name = "textBox_rad";
            this.textBox_rad.Size = new System.Drawing.Size(100, 22);
            this.textBox_rad.TabIndex = 6;
            this.textBox_rad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_rad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_rad_KeyPress);
            // 
            // angle_3_res
            // 
            this.angle_3_res.AutoSize = true;
            this.angle_3_res.Location = new System.Drawing.Point(192, 127);
            this.angle_3_res.Name = "angle_3_res";
            this.angle_3_res.Size = new System.Drawing.Size(27, 16);
            this.angle_3_res.TabIndex = 5;
            this.angle_3_res.Text = "(    )";
            // 
            // label_angle_3
            // 
            this.label_angle_3.AutoSize = true;
            this.label_angle_3.Location = new System.Drawing.Point(17, 127);
            this.label_angle_3.Name = "label_angle_3";
            this.label_angle_3.Size = new System.Drawing.Size(75, 16);
            this.label_angle_3.TabIndex = 4;
            this.label_angle_3.Text = "Третій кут";
            // 
            // label_angle_2
            // 
            this.label_angle_2.AutoSize = true;
            this.label_angle_2.Location = new System.Drawing.Point(17, 90);
            this.label_angle_2.Name = "label_angle_2";
            this.label_angle_2.Size = new System.Drawing.Size(79, 16);
            this.label_angle_2.TabIndex = 3;
            this.label_angle_2.Text = "Другий кут";
            // 
            // label_angle_1
            // 
            this.label_angle_1.AutoSize = true;
            this.label_angle_1.Location = new System.Drawing.Point(17, 53);
            this.label_angle_1.Name = "label_angle_1";
            this.label_angle_1.Size = new System.Drawing.Size(83, 16);
            this.label_angle_1.TabIndex = 2;
            this.label_angle_1.Text = "Перший кут";
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Location = new System.Drawing.Point(17, 19);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(156, 16);
            this.label_radius.TabIndex = 0;
            this.label_radius.Text = "Радіус описаного кола";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_rectangle);
            this.tabPage3.Controls.Add(this.label_rectangle);
            this.tabPage3.Controls.Add(this.button_cord);
            this.tabPage3.Controls.Add(this.textBox_y_cord);
            this.tabPage3.Controls.Add(this.textBox_x_cord);
            this.tabPage3.Controls.Add(this.true_false);
            this.tabPage3.Controls.Add(this.label_true_false);
            this.tabPage3.Controls.Add(this.label_y_cord);
            this.tabPage3.Controls.Add(this.label_x_cord);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "завдання 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_rectangle
            // 
            this.textBox_rectangle.Location = new System.Drawing.Point(127, 104);
            this.textBox_rectangle.Name = "textBox_rectangle";
            this.textBox_rectangle.Size = new System.Drawing.Size(110, 22);
            this.textBox_rectangle.TabIndex = 9;
            this.textBox_rectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_rectangle_KeyPress);
            // 
            // label_rectangle
            // 
            this.label_rectangle.AutoSize = true;
            this.label_rectangle.Location = new System.Drawing.Point(18, 107);
            this.label_rectangle.Name = "label_rectangle";
            this.label_rectangle.Size = new System.Drawing.Size(103, 16);
            this.label_rectangle.TabIndex = 8;
            this.label_rectangle.Text = "Номер прямок.";
            // 
            // button_cord
            // 
            this.button_cord.Location = new System.Drawing.Point(15, 153);
            this.button_cord.Name = "button_cord";
            this.button_cord.Size = new System.Drawing.Size(182, 29);
            this.button_cord.TabIndex = 7;
            this.button_cord.Text = "Перевірити";
            this.button_cord.UseVisualStyleBackColor = true;
            this.button_cord.Click += new System.EventHandler(this.button_cord_Click);
            // 
            // textBox_y_cord
            // 
            this.textBox_y_cord.Location = new System.Drawing.Point(60, 55);
            this.textBox_y_cord.Name = "textBox_y_cord";
            this.textBox_y_cord.Size = new System.Drawing.Size(110, 22);
            this.textBox_y_cord.TabIndex = 6;
            this.textBox_y_cord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_y_cord_KeyPress);
            // 
            // textBox_x_cord
            // 
            this.textBox_x_cord.Location = new System.Drawing.Point(60, 11);
            this.textBox_x_cord.Name = "textBox_x_cord";
            this.textBox_x_cord.Size = new System.Drawing.Size(110, 22);
            this.textBox_x_cord.TabIndex = 5;
            this.textBox_x_cord.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox_x_cord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_x_cord_KeyPress);
            // 
            // true_false
            // 
            this.true_false.AutoSize = true;
            this.true_false.Location = new System.Drawing.Point(12, 220);
            this.true_false.Name = "true_false";
            this.true_false.Size = new System.Drawing.Size(18, 16);
            this.true_false.TabIndex = 4;
            this.true_false.Text = "( )";
            // 
            // label_true_false
            // 
            this.label_true_false.AutoSize = true;
            this.label_true_false.Location = new System.Drawing.Point(8, 194);
            this.label_true_false.Name = "label_true_false";
            this.label_true_false.Size = new System.Drawing.Size(306, 16);
            this.label_true_false.TabIndex = 3;
            this.label_true_false.Text = "Чи належить точка А(x,y) цьому прямокутнику\r\n";
            // 
            // label_y_cord
            // 
            this.label_y_cord.AutoSize = true;
            this.label_y_cord.Location = new System.Drawing.Point(12, 58);
            this.label_y_cord.Name = "label_y_cord";
            this.label_y_cord.Size = new System.Drawing.Size(31, 16);
            this.label_y_cord.TabIndex = 2;
            this.label_y_cord.Text = "A(y)";
            // 
            // label_x_cord
            // 
            this.label_x_cord.AutoSize = true;
            this.label_x_cord.Location = new System.Drawing.Point(12, 14);
            this.label_x_cord.Name = "label_x_cord";
            this.label_x_cord.Size = new System.Drawing.Size(30, 16);
            this.label_x_cord.TabIndex = 1;
            this.label_x_cord.Text = "А(х)";
            this.label_x_cord.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(321, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(474, 421);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox_x_scl);
            this.tabPage4.Controls.Add(this.button_x_scl);
            this.tabPage4.Controls.Add(this.cos);
            this.tabPage4.Controls.Add(this.sin);
            this.tabPage4.Controls.Add(this.Ln);
            this.tabPage4.Controls.Add(this.label_cos);
            this.tabPage4.Controls.Add(this.label_sin);
            this.tabPage4.Controls.Add(this.label_ln);
            this.tabPage4.Controls.Add(this.label_x_scl);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "завдання 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox_x_scl
            // 
            this.textBox_x_scl.Location = new System.Drawing.Point(91, 22);
            this.textBox_x_scl.Name = "textBox_x_scl";
            this.textBox_x_scl.Size = new System.Drawing.Size(100, 22);
            this.textBox_x_scl.TabIndex = 8;
            this.textBox_x_scl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_x_scl_KeyPress);
            // 
            // button_x_scl
            // 
            this.button_x_scl.Location = new System.Drawing.Point(33, 62);
            this.button_x_scl.Name = "button_x_scl";
            this.button_x_scl.Size = new System.Drawing.Size(158, 35);
            this.button_x_scl.TabIndex = 7;
            this.button_x_scl.Text = "Обрахувати";
            this.button_x_scl.UseVisualStyleBackColor = true;
            this.button_x_scl.Click += new System.EventHandler(this.button_x_scl_Click);
            // 
            // cos
            // 
            this.cos.AutoSize = true;
            this.cos.Location = new System.Drawing.Point(105, 152);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(18, 16);
            this.cos.TabIndex = 6;
            this.cos.Text = "( )";
            // 
            // sin
            // 
            this.sin.AutoSize = true;
            this.sin.Location = new System.Drawing.Point(105, 110);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(18, 16);
            this.sin.TabIndex = 5;
            this.sin.Text = "( )";
            // 
            // Ln
            // 
            this.Ln.AutoSize = true;
            this.Ln.Location = new System.Drawing.Point(105, 192);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(18, 16);
            this.Ln.TabIndex = 4;
            this.Ln.Text = "( )";
            // 
            // label_cos
            // 
            this.label_cos.AutoSize = true;
            this.label_cos.Location = new System.Drawing.Point(30, 152);
            this.label_cos.Name = "label_cos";
            this.label_cos.Size = new System.Drawing.Size(45, 16);
            this.label_cos.TabIndex = 3;
            this.label_cos.Text = "Cos(x)";
            // 
            // label_sin
            // 
            this.label_sin.AutoSize = true;
            this.label_sin.Location = new System.Drawing.Point(30, 110);
            this.label_sin.Name = "label_sin";
            this.label_sin.Size = new System.Drawing.Size(40, 16);
            this.label_sin.TabIndex = 2;
            this.label_sin.Text = "Sin(x)";
            // 
            // label_ln
            // 
            this.label_ln.AutoSize = true;
            this.label_ln.Location = new System.Drawing.Point(30, 192);
            this.label_ln.Name = "label_ln";
            this.label_ln.Size = new System.Drawing.Size(31, 16);
            this.label_ln.TabIndex = 1;
            this.label_ln.Text = "In(x)";
            // 
            // label_x_scl
            // 
            this.label_x_scl.AutoSize = true;
            this.label_x_scl.Location = new System.Drawing.Point(30, 25);
            this.label_x_scl.Name = "label_x_scl";
            this.label_x_scl.Size = new System.Drawing.Size(16, 16);
            this.label_x_scl.TabIndex = 0;
            this.label_x_scl.Text = "x:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.kn_result);
            this.tabPage5.Controls.Add(this.button_kn);
            this.tabPage5.Controls.Add(this.textBox_k);
            this.tabPage5.Controls.Add(this.textBox_n);
            this.tabPage5.Controls.Add(this.label_k);
            this.tabPage5.Controls.Add(this.label_n);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(795, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "завдання 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // kn_result
            // 
            this.kn_result.AutoSize = true;
            this.kn_result.Location = new System.Drawing.Point(8, 134);
            this.kn_result.Name = "kn_result";
            this.kn_result.Size = new System.Drawing.Size(18, 16);
            this.kn_result.TabIndex = 5;
            this.kn_result.Text = "( )";
            // 
            // button_kn
            // 
            this.button_kn.Location = new System.Drawing.Point(11, 88);
            this.button_kn.Name = "button_kn";
            this.button_kn.Size = new System.Drawing.Size(130, 23);
            this.button_kn.TabIndex = 4;
            this.button_kn.Text = "Перевірити";
            this.button_kn.UseVisualStyleBackColor = true;
            this.button_kn.Click += new System.EventHandler(this.button_kn_Click);
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(81, 48);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(100, 22);
            this.textBox_k.TabIndex = 3;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(81, 14);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 22);
            this.textBox_n.TabIndex = 2;
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Location = new System.Drawing.Point(8, 48);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(67, 16);
            this.label_k.TabIndex = 1;
            this.label_k.Text = "Введіть k";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(8, 17);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(67, 16);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "Введіть n";
            this.label_n.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button_suncloud);
            this.tabPage6.Controls.Add(this.cloud_days);
            this.tabPage6.Controls.Add(this.label_cloud);
            this.tabPage6.Controls.Add(this.sun_days);
            this.tabPage6.Controls.Add(this.label_sun);
            this.tabPage6.Controls.Add(this.day_B);
            this.tabPage6.Controls.Add(this.label_day_B);
            this.tabPage6.Controls.Add(this.textBox_day_A);
            this.tabPage6.Controls.Add(this.label_day_A);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(795, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "завдання 6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button_numbers);
            this.tabPage7.Controls.Add(this.textBox_alpha_numb);
            this.tabPage7.Controls.Add(this.numbers_in_row);
            this.tabPage7.Controls.Add(this.label_numbers);
            this.tabPage7.Controls.Add(this.label_num);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(795, 424);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "завдання 7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label_day_A
            // 
            this.label_day_A.AutoSize = true;
            this.label_day_A.Location = new System.Drawing.Point(6, 12);
            this.label_day_A.Name = "label_day_A";
            this.label_day_A.Size = new System.Drawing.Size(369, 16);
            this.label_day_A.TabIndex = 0;
            this.label_day_A.Text = "Введіть висоту перебування равлика в перший день А :";
            // 
            // textBox_day_A
            // 
            this.textBox_day_A.Location = new System.Drawing.Point(380, 9);
            this.textBox_day_A.Name = "textBox_day_A";
            this.textBox_day_A.Size = new System.Drawing.Size(130, 22);
            this.textBox_day_A.TabIndex = 1;
            this.textBox_day_A.TextChanged += new System.EventHandler(this.textBox_day_A_TextChanged);
            this.textBox_day_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_day_A_KeyPress);
            // 
            // label_day_B
            // 
            this.label_day_B.AutoSize = true;
            this.label_day_B.Location = new System.Drawing.Point(8, 78);
            this.label_day_B.Name = "label_day_B";
            this.label_day_B.Size = new System.Drawing.Size(172, 16);
            this.label_day_B.TabIndex = 2;
            this.label_day_B.Text = "Висота равлика в день В:";
            // 
            // day_B
            // 
            this.day_B.AutoSize = true;
            this.day_B.Location = new System.Drawing.Point(205, 78);
            this.day_B.Name = "day_B";
            this.day_B.Size = new System.Drawing.Size(18, 16);
            this.day_B.TabIndex = 3;
            this.day_B.Text = "( )";
            // 
            // label_sun
            // 
            this.label_sun.AutoSize = true;
            this.label_sun.Location = new System.Drawing.Point(8, 110);
            this.label_sun.Name = "label_sun";
            this.label_sun.Size = new System.Drawing.Size(160, 16);
            this.label_sun.TabIndex = 4;
            this.label_sun.Text = "Кількість сонячних днів:";
            // 
            // sun_days
            // 
            this.sun_days.AutoSize = true;
            this.sun_days.Location = new System.Drawing.Point(205, 110);
            this.sun_days.Name = "sun_days";
            this.sun_days.Size = new System.Drawing.Size(18, 16);
            this.sun_days.TabIndex = 5;
            this.sun_days.Text = "( )";
            // 
            // label_cloud
            // 
            this.label_cloud.AutoSize = true;
            this.label_cloud.Location = new System.Drawing.Point(8, 143);
            this.label_cloud.Name = "label_cloud";
            this.label_cloud.Size = new System.Drawing.Size(191, 16);
            this.label_cloud.TabIndex = 6;
            this.label_cloud.Text = "Кількість похмурих днів днів:";
            // 
            // cloud_days
            // 
            this.cloud_days.AutoSize = true;
            this.cloud_days.Location = new System.Drawing.Point(205, 143);
            this.cloud_days.Name = "cloud_days";
            this.cloud_days.Size = new System.Drawing.Size(18, 16);
            this.cloud_days.TabIndex = 7;
            this.cloud_days.Text = "( )";
            // 
            // button_suncloud
            // 
            this.button_suncloud.Location = new System.Drawing.Point(15, 39);
            this.button_suncloud.Name = "button_suncloud";
            this.button_suncloud.Size = new System.Drawing.Size(207, 23);
            this.button_suncloud.TabIndex = 8;
            this.button_suncloud.Text = "Обрахувати";
            this.button_suncloud.UseVisualStyleBackColor = true;
            this.button_suncloud.Click += new System.EventHandler(this.button_suncloud_Click);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(18, 15);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(116, 16);
            this.label_num.TabIndex = 0;
            this.label_num.Text = "Введіть символи";
            // 
            // label_numbers
            // 
            this.label_numbers.AutoSize = true;
            this.label_numbers.Location = new System.Drawing.Point(18, 97);
            this.label_numbers.Name = "label_numbers";
            this.label_numbers.Size = new System.Drawing.Size(208, 16);
            this.label_numbers.TabIndex = 1;
            this.label_numbers.Text = "Найдовша послідовність цифр:";
            // 
            // numbers_in_row
            // 
            this.numbers_in_row.AutoSize = true;
            this.numbers_in_row.Location = new System.Drawing.Point(232, 97);
            this.numbers_in_row.Name = "numbers_in_row";
            this.numbers_in_row.Size = new System.Drawing.Size(18, 16);
            this.numbers_in_row.TabIndex = 2;
            this.numbers_in_row.Text = "( )";
            // 
            // textBox_alpha_numb
            // 
            this.textBox_alpha_numb.Location = new System.Drawing.Point(140, 12);
            this.textBox_alpha_numb.Name = "textBox_alpha_numb";
            this.textBox_alpha_numb.Size = new System.Drawing.Size(631, 22);
            this.textBox_alpha_numb.TabIndex = 3;
            this.textBox_alpha_numb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_alpha_numb_KeyPress);
            // 
            // button_numbers
            // 
            this.button_numbers.Location = new System.Drawing.Point(21, 49);
            this.button_numbers.Name = "button_numbers";
            this.button_numbers.Size = new System.Drawing.Size(168, 35);
            this.button_numbers.TabIndex = 4;
            this.button_numbers.Text = "Обрахувати";
            this.button_numbers.UseVisualStyleBackColor = true;
            this.button_numbers.Click += new System.EventHandler(this.button_numbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label angle_3_res;
        private System.Windows.Forms.Label label_angle_3;
        private System.Windows.Forms.Label label_angle_2;
        private System.Windows.Forms.Label label_angle_1;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label_side_3_result;
        private System.Windows.Forms.Label label_side_2_result;
        private System.Windows.Forms.Label label_side_1_result;
        private System.Windows.Forms.Label label_sides_result;
        private System.Windows.Forms.Button button_ok_2;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox_rad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_x_cord;
        private System.Windows.Forms.Label true_false;
        private System.Windows.Forms.Label label_true_false;
        private System.Windows.Forms.Label label_y_cord;
        private System.Windows.Forms.TextBox textBox_x_cord;
        private System.Windows.Forms.Button button_cord;
        private System.Windows.Forms.TextBox textBox_y_cord;
        private System.Windows.Forms.TextBox textBox_rectangle;
        private System.Windows.Forms.Label label_rectangle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox_x_scl;
        private System.Windows.Forms.Button button_x_scl;
        private System.Windows.Forms.Label cos;
        private System.Windows.Forms.Label sin;
        private System.Windows.Forms.Label Ln;
        private System.Windows.Forms.Label label_cos;
        private System.Windows.Forms.Label label_sin;
        private System.Windows.Forms.Label label_ln;
        private System.Windows.Forms.Label label_x_scl;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label kn_result;
        private System.Windows.Forms.Button button_kn;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_day_A;
        private System.Windows.Forms.Label label_day_A;
        private System.Windows.Forms.Label label_sun;
        private System.Windows.Forms.Label day_B;
        private System.Windows.Forms.Label label_day_B;
        private System.Windows.Forms.Button button_suncloud;
        private System.Windows.Forms.Label cloud_days;
        private System.Windows.Forms.Label label_cloud;
        private System.Windows.Forms.Label sun_days;
        private System.Windows.Forms.Button button_numbers;
        private System.Windows.Forms.TextBox textBox_alpha_numb;
        private System.Windows.Forms.Label numbers_in_row;
        private System.Windows.Forms.Label label_numbers;
        private System.Windows.Forms.Label label_num;
    }
}


#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public partial class Form1 : Form
{
    private Container components;

    public Form1()
    {
        InitializeComponent(); //
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

// Add the missing #endregion directive at the end of the file
#endregion
