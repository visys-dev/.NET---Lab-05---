using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private Button button1;
        private TextBox textBox1;

        public Form1()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                textBox1.Text = "Кнопку натиснули";
            };
        }

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.Text = "Натисни мене";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Task3: WinForms Events";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}