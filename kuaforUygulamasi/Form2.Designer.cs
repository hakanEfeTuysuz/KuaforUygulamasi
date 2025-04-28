namespace NesneyeDayalıProgramlamaProje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            adTextBox = new TextBox();
            soyadTextBox = new TextBox();
            telefonNoTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adTextBox
            // 
            adTextBox.Location = new Point(129, 77);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(267, 27);
            adTextBox.TabIndex = 1;
            // 
            // soyadTextBox
            // 
            soyadTextBox.Location = new Point(129, 134);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(267, 27);
            soyadTextBox.TabIndex = 2;
            // 
            // telefonNoTextBox
            // 
            telefonNoTextBox.Location = new Point(129, 185);
            telefonNoTextBox.Name = "telefonNoTextBox";
            telefonNoTextBox.Size = new Size(267, 27);
            telefonNoTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 84);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 141);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 192);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Telefon No :";
            // 
            // button2
            // 
            button2.Location = new Point(153, 289);
            button2.Name = "button2";
            button2.Size = new Size(181, 54);
            button2.TabIndex = 7;
            button2.Text = "Randevu Oluştur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(telefonNoTextBox);
            Controls.Add(soyadTextBox);
            Controls.Add(adTextBox);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hakan Kuaför - Randevu Oluşturma Merkezi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox adTextBox;
        private TextBox soyadTextBox;
        private TextBox telefonNoTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}