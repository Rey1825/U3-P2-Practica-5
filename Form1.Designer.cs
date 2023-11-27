namespace U3_P2_Practica_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 35);
            label1.Name = "label1";
            label1.Size = new Size(485, 31);
            label1.TabIndex = 0;
            label1.Text = "Verifica si un numero es par o impar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 128);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 1;
            label2.Text = "Escribe un número:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(427, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 304);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(234, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 37);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(150, 185);
            button1.Name = "button1";
            button1.Size = new Size(142, 49);
            button1.TabIndex = 4;
            button1.Text = "Verifica\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(693, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Impar y Par";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
    }
}