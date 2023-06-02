namespace Torres_de_hanoi
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
            palosDeTorre = new PictureBox();
            cubo4 = new Button();
            label1 = new Label();
            btnPrueba = new Button();
            cubo3 = new Button();
            cubo2 = new Button();
            cubo1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)palosDeTorre).BeginInit();
            SuspendLayout();
            // 
            // palosDeTorre
            // 
            palosDeTorre.Image = (Image)resources.GetObject("palosDeTorre.Image");
            palosDeTorre.InitialImage = (Image)resources.GetObject("palosDeTorre.InitialImage");
            palosDeTorre.Location = new Point(25, 29);
            palosDeTorre.Name = "palosDeTorre";
            palosDeTorre.Size = new Size(802, 451);
            palosDeTorre.SizeMode = PictureBoxSizeMode.StretchImage;
            palosDeTorre.TabIndex = 0;
            palosDeTorre.TabStop = false;
            // 
            // cubo4
            // 
            cubo4.BackColor = SystemColors.ActiveCaptionText;
            cubo4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cubo4.ForeColor = SystemColors.ButtonHighlight;
            cubo4.Location = new Point(37, 374);
            cubo4.Name = "cubo4";
            cubo4.Size = new Size(179, 60);
            cubo4.TabIndex = 1;
            cubo4.Text = "4";
            cubo4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(340, -6);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 5;
            label1.Text = "Torre de hanoi";
            // 
            // btnPrueba
            // 
            btnPrueba.BackColor = SystemColors.MenuHighlight;
            btnPrueba.Location = new Point(525, 47);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(89, 60);
            btnPrueba.TabIndex = 6;
            btnPrueba.UseVisualStyleBackColor = false;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // cubo3
            // 
            cubo3.BackColor = SystemColors.ActiveCaptionText;
            cubo3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cubo3.ForeColor = SystemColors.ButtonHighlight;
            cubo3.Location = new Point(37, 317);
            cubo3.Name = "cubo3";
            cubo3.Size = new Size(179, 60);
            cubo3.TabIndex = 7;
            cubo3.Text = "3";
            cubo3.UseVisualStyleBackColor = false;
            // 
            // cubo2
            // 
            cubo2.BackColor = SystemColors.ActiveCaptionText;
            cubo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cubo2.ForeColor = SystemColors.ButtonHighlight;
            cubo2.Location = new Point(37, 260);
            cubo2.Name = "cubo2";
            cubo2.Size = new Size(179, 60);
            cubo2.TabIndex = 8;
            cubo2.Text = "2";
            cubo2.UseVisualStyleBackColor = false;
            // 
            // cubo1
            // 
            cubo1.BackColor = SystemColors.ActiveCaptionText;
            cubo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cubo1.ForeColor = SystemColors.ButtonHighlight;
            cubo1.Location = new Point(37, 203);
            cubo1.Name = "cubo1";
            cubo1.Size = new Size(179, 60);
            cubo1.TabIndex = 9;
            cubo1.Text = "1";
            cubo1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(336, 203);
            button1.Name = "button1";
            button1.Size = new Size(179, 60);
            button1.TabIndex = 13;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(336, 260);
            button2.Name = "button2";
            button2.Size = new Size(179, 60);
            button2.TabIndex = 12;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(336, 317);
            button3.Name = "button3";
            button3.Size = new Size(179, 60);
            button3.TabIndex = 11;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(336, 374);
            button4.Name = "button4";
            button4.Size = new Size(179, 60);
            button4.TabIndex = 10;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(637, 203);
            button5.Name = "button5";
            button5.Size = new Size(179, 60);
            button5.TabIndex = 17;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(637, 260);
            button6.Name = "button6";
            button6.Size = new Size(179, 60);
            button6.TabIndex = 16;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(637, 317);
            button7.Name = "button7";
            button7.Size = new Size(179, 60);
            button7.TabIndex = 15;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(637, 374);
            button8.Name = "button8";
            button8.Size = new Size(179, 60);
            button8.TabIndex = 14;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 482);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(cubo1);
            Controls.Add(cubo2);
            Controls.Add(cubo3);
            Controls.Add(btnPrueba);
            Controls.Add(label1);
            Controls.Add(cubo4);
            Controls.Add(palosDeTorre);
            Name = "Form1";
            Text = "Torres de hanoi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)palosDeTorre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox palosDeTorre;
        private Button cubo4;
        private Label label1;
        private Button btnPrueba;
        private Button cubo3;
        private Button cubo2;
        private Button cubo1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}