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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 482);
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
    }
}