namespace Practica_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(71, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingresar valor";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(71, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 132);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opcion de conversion";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(156, 76);
            button3.Name = "button3";
            button3.Size = new Size(86, 35);
            button3.TabIndex = 2;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(214, 35);
            button2.Name = "button2";
            button2.Size = new Size(119, 35);
            button2.TabIndex = 1;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(81, 35);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 0;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(71, 296);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(478, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado en grados ";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(156, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 19);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 0;
            label2.Text = "Equivalente en Grados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Conversiones ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
    }
}