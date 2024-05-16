namespace Alarm_Oclock
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Name = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.BorderStyle = BorderStyle.Fixed3D;
            Name.Font = new Font("SimSun", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name.ForeColor = SystemColors.ButtonHighlight;
            Name.Location = new Point(225, 30);
            Name.Margin = new Padding(10, 0, 10, 0);
            Name.Name = "Name";
            Name.Size = new Size(228, 39);
            Name.TabIndex = 0;
            Name.Text = "Alarm Clock";
            Name.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(190, 90);
            label1.Name = "label1";
            label1.Size = new Size(298, 23);
            label1.TabIndex = 1;
            label1.Text = "The signal will sound at";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 150);
            textBox1.Margin = new Padding(10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 61);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 61);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(451, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(92, 61);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox3.Leave += textBox3_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(212, 181);
            label2.Name = "label2";
            label2.Size = new Size(28, 30);
            label2.TabIndex = 5;
            label2.Text = "h";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(390, 181);
            label3.Name = "label3";
            label3.Size = new Size(28, 30);
            label3.TabIndex = 6;
            label3.Text = "m";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(559, 181);
            label4.Name = "label4";
            label4.Size = new Size(28, 30);
            label4.TabIndex = 7;
            label4.Text = "s";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("SimSun", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(237, 255);
            button1.Name = "button1";
            button1.Size = new Size(197, 43);
            button1.TabIndex = 8;
            button1.Text = "Select a melody .mp3";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(273, 327);
            button2.Name = "button2";
            button2.Size = new Size(125, 37);
            button2.TabIndex = 9;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(24F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(682, 453);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Name);
            Font = new Font("SimSun", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(10, 6, 10, 6);
            Text = "Alarm clock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}
