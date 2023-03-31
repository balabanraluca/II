namespace L1_Tema
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
            CUPPA = new ListBox();
            MORE = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // CUPPA
            // 
            CUPPA.FormattingEnabled = true;
            CUPPA.ItemHeight = 20;
            CUPPA.Location = new Point(128, 12);
            CUPPA.Name = "CUPPA";
            CUPPA.Size = new Size(595, 284);
            CUPPA.TabIndex = 0;
            CUPPA.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MORE
            // 
            MORE.Location = new Point(169, 162);
            MORE.Name = "MORE";
            MORE.Size = new Size(94, 29);
            MORE.TabIndex = 1;
            MORE.Text = "MORE";
            MORE.UseVisualStyleBackColor = true;
            MORE.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(340, 162);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "LESS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.ImageKey = "(none)";
            button2.Location = new Point(556, 162);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "SINGLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(225, 48);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 4;
            label1.Text = "Coffee";
            // 
            // button4
            // 
            button4.Location = new Point(608, 248);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "NEXT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(169, 82);
            label2.Name = "label2";
            label2.Size = new Size(487, 40);
            label2.TabIndex = 7;
            label2.Text = "Pătrundeți în lumea fascinantă a aromelor bogate și lăsați-vă inspirat \r\nde noutățile din universul L'OR - lansări de produse, oferte sau campanii.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(139, 22);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "CUPPA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MORE);
            Controls.Add(CUPPA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CUPPA;
        private Button MORE;
        private Button LESS;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button4;
        private Label label2;
        private Label label3;
    }
}