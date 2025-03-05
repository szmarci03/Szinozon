namespace Színözön
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
            this.tippelek = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.jrszöveg = new System.Windows.Forms.TextBox();
            this.jjszöveg = new System.Windows.Forms.TextBox();
            this.jrszám = new System.Windows.Forms.TextBox();
            this.jjszám = new System.Windows.Forms.TextBox();
            this.tippek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tippelek
            // 
            this.tippelek.Location = new System.Drawing.Point(1033, 283);
            this.tippelek.Name = "tippelek";
            this.tippelek.Size = new System.Drawing.Size(75, 23);
            this.tippelek.TabIndex = 0;
            this.tippelek.Text = "tippelek";
            this.tippelek.UseVisualStyleBackColor = true;
            this.tippelek.Click += new System.EventHandler(this.tippelek_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Purple"});
            this.comboBox1.Location = new System.Drawing.Point(67, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Purple"});
            this.comboBox2.Location = new System.Drawing.Point(67, 204);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Purple"});
            this.comboBox3.Location = new System.Drawing.Point(67, 307);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Purple"});
            this.comboBox4.Location = new System.Drawing.Point(67, 402);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Purple"});
            this.comboBox5.Location = new System.Drawing.Point(67, 498);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 23);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // jrszöveg
            // 
            this.jrszöveg.Location = new System.Drawing.Point(1011, 42);
            this.jrszöveg.Name = "jrszöveg";
            this.jrszöveg.Size = new System.Drawing.Size(138, 23);
            this.jrszöveg.TabIndex = 6;
            // 
            // jjszöveg
            // 
            this.jjszöveg.Location = new System.Drawing.Point(857, 42);
            this.jjszöveg.Name = "jjszöveg";
            this.jjszöveg.Size = new System.Drawing.Size(138, 23);
            this.jjszöveg.TabIndex = 7;
            // 
            // jrszám
            // 
            this.jrszám.Location = new System.Drawing.Point(1063, 71);
            this.jrszám.Name = "jrszám";
            this.jrszám.Size = new System.Drawing.Size(45, 23);
            this.jrszám.TabIndex = 8;
            // 
            // jjszám
            // 
            this.jjszám.Location = new System.Drawing.Point(902, 71);
            this.jjszám.Name = "jjszám";
            this.jjszám.Size = new System.Drawing.Size(45, 23);
            this.jjszám.TabIndex = 9;
            // 
            // tippek
            // 
            this.tippek.Location = new System.Drawing.Point(1063, 498);
            this.tippek.Name = "tippek";
            this.tippek.Size = new System.Drawing.Size(45, 23);
            this.tippek.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 592);
            this.Controls.Add(this.tippek);
            this.Controls.Add(this.jjszám);
            this.Controls.Add(this.jrszám);
            this.Controls.Add(this.jjszöveg);
            this.Controls.Add(this.jrszöveg);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tippelek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tippelek;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private TextBox jrszöveg;
        private TextBox jjszöveg;
        private TextBox jrszám;
        private TextBox jjszám;
        private TextBox tippek;
    }
}