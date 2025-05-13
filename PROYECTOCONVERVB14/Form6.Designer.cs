namespace PROYECTOCONVERVB14
{
    partial class Form6
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            delisleACelsiusToolStripMenuItem = new ToolStripMenuItem();
            celsiusADelisleToolStripMenuItem = new ToolStripMenuItem();
            rømerACelsiusToolStripMenuItem = new ToolStripMenuItem();
            celsiusARømerToolStripMenuItem = new ToolStripMenuItem();
            réaumurAFahrenheitToolStripMenuItem = new ToolStripMenuItem();
            fahrenheitARéaumurToolStripMenuItem = new ToolStripMenuItem();
            newtonACelsiusToolStripMenuItem = new ToolStripMenuItem();
            celsiusANewtonToolStripMenuItem = new ToolStripMenuItem();
            rankineAKelvinToolStripMenuItem = new ToolStripMenuItem();
            kelvinARankineToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 26.25F);
            textBox2.Location = new Point(764, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 54);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F);
            textBox1.Location = new Point(764, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 54);
            textBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F);
            button1.Location = new Point(810, 351);
            button1.Name = "button1";
            button1.Size = new Size(204, 77);
            button1.TabIndex = 23;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F);
            label3.Location = new Point(529, 130);
            label3.Name = "label3";
            label3.Size = new Size(158, 47);
            label3.TabIndex = 22;
            label3.Text = "Réaumur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F);
            label2.Location = new Point(529, 230);
            label2.Name = "label2";
            label2.Size = new Size(182, 47);
            label2.TabIndex = 21;
            label2.Text = "Fahrenheit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 95);
            label1.Name = "label1";
            label1.Size = new Size(375, 258);
            label1.TabIndex = 20;
            label1.Text = "Réaumur\r\n a \r\nFahrenheit";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { delisleACelsiusToolStripMenuItem, celsiusADelisleToolStripMenuItem, rømerACelsiusToolStripMenuItem, celsiusARømerToolStripMenuItem, réaumurAFahrenheitToolStripMenuItem, fahrenheitARéaumurToolStripMenuItem, newtonACelsiusToolStripMenuItem, celsiusANewtonToolStripMenuItem, rankineAKelvinToolStripMenuItem, kelvinARankineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1167, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // delisleACelsiusToolStripMenuItem
            // 
            delisleACelsiusToolStripMenuItem.Name = "delisleACelsiusToolStripMenuItem";
            delisleACelsiusToolStripMenuItem.Size = new Size(102, 20);
            delisleACelsiusToolStripMenuItem.Text = "\tDelisle a Celsius";
            delisleACelsiusToolStripMenuItem.Click += delisleACelsiusToolStripMenuItem_Click;
            // 
            // celsiusADelisleToolStripMenuItem
            // 
            celsiusADelisleToolStripMenuItem.Name = "celsiusADelisleToolStripMenuItem";
            celsiusADelisleToolStripMenuItem.Size = new Size(102, 20);
            celsiusADelisleToolStripMenuItem.Text = "\tCelsius a Delisle";
            celsiusADelisleToolStripMenuItem.Click += celsiusADelisleToolStripMenuItem_Click;
            // 
            // rømerACelsiusToolStripMenuItem
            // 
            rømerACelsiusToolStripMenuItem.Name = "rømerACelsiusToolStripMenuItem";
            rømerACelsiusToolStripMenuItem.Size = new Size(103, 20);
            rømerACelsiusToolStripMenuItem.Text = "\tRømer a Celsius";
            rømerACelsiusToolStripMenuItem.Click += rømerACelsiusToolStripMenuItem_Click;
            // 
            // celsiusARømerToolStripMenuItem
            // 
            celsiusARømerToolStripMenuItem.Name = "celsiusARømerToolStripMenuItem";
            celsiusARømerToolStripMenuItem.Size = new Size(103, 20);
            celsiusARømerToolStripMenuItem.Text = "Celsius a Rømer";
            celsiusARømerToolStripMenuItem.Click += celsiusARømerToolStripMenuItem_Click;
            // 
            // réaumurAFahrenheitToolStripMenuItem
            // 
            réaumurAFahrenheitToolStripMenuItem.Name = "réaumurAFahrenheitToolStripMenuItem";
            réaumurAFahrenheitToolStripMenuItem.Size = new Size(135, 20);
            réaumurAFahrenheitToolStripMenuItem.Text = "Réaumur a Fahrenheit";
            réaumurAFahrenheitToolStripMenuItem.Click += réaumurAFahrenheitToolStripMenuItem_Click;
            // 
            // fahrenheitARéaumurToolStripMenuItem
            // 
            fahrenheitARéaumurToolStripMenuItem.Name = "fahrenheitARéaumurToolStripMenuItem";
            fahrenheitARéaumurToolStripMenuItem.Size = new Size(135, 20);
            fahrenheitARéaumurToolStripMenuItem.Text = "Fahrenheit a Réaumur";
            fahrenheitARéaumurToolStripMenuItem.Click += fahrenheitARéaumurToolStripMenuItem_Click;
            // 
            // newtonACelsiusToolStripMenuItem
            // 
            newtonACelsiusToolStripMenuItem.Name = "newtonACelsiusToolStripMenuItem";
            newtonACelsiusToolStripMenuItem.Size = new Size(110, 20);
            newtonACelsiusToolStripMenuItem.Text = "Newton a Celsius";
            newtonACelsiusToolStripMenuItem.Click += newtonACelsiusToolStripMenuItem_Click;
            // 
            // celsiusANewtonToolStripMenuItem
            // 
            celsiusANewtonToolStripMenuItem.Name = "celsiusANewtonToolStripMenuItem";
            celsiusANewtonToolStripMenuItem.Size = new Size(110, 20);
            celsiusANewtonToolStripMenuItem.Text = "Celsius a Newton";
            celsiusANewtonToolStripMenuItem.Click += celsiusANewtonToolStripMenuItem_Click;
            // 
            // rankineAKelvinToolStripMenuItem
            // 
            rankineAKelvinToolStripMenuItem.Name = "rankineAKelvinToolStripMenuItem";
            rankineAKelvinToolStripMenuItem.Size = new Size(105, 20);
            rankineAKelvinToolStripMenuItem.Text = "Rankine a Kelvin";
            rankineAKelvinToolStripMenuItem.Click += rankineAKelvinToolStripMenuItem_Click;
            // 
            // kelvinARankineToolStripMenuItem
            // 
            kelvinARankineToolStripMenuItem.Name = "kelvinARankineToolStripMenuItem";
            kelvinARankineToolStripMenuItem.Size = new Size(105, 20);
            kelvinARankineToolStripMenuItem.Text = "\tKelvin a Rankine";
            kelvinARankineToolStripMenuItem.Click += kelvinARankineToolStripMenuItem_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 450);
            Controls.Add(menuStrip1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem delisleACelsiusToolStripMenuItem;
        private ToolStripMenuItem celsiusADelisleToolStripMenuItem;
        private ToolStripMenuItem rømerACelsiusToolStripMenuItem;
        private ToolStripMenuItem celsiusARømerToolStripMenuItem;
        private ToolStripMenuItem réaumurAFahrenheitToolStripMenuItem;
        private ToolStripMenuItem fahrenheitARéaumurToolStripMenuItem;
        private ToolStripMenuItem newtonACelsiusToolStripMenuItem;
        private ToolStripMenuItem celsiusANewtonToolStripMenuItem;
        private ToolStripMenuItem rankineAKelvinToolStripMenuItem;
        private ToolStripMenuItem kelvinARankineToolStripMenuItem;
    }
}