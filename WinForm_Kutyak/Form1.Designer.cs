
namespace WinForm_Kutyak
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Fajta = new System.Windows.Forms.TextBox();
            this.label_Nev = new System.Windows.Forms.Label();
            this.label_Fajta = new System.Windows.Forms.Label();
            this.label_Suly = new System.Windows.Forms.Label();
            this.label_Datum = new System.Windows.Forms.Label();
            this.dateTimePicker_Datum = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Suly = new System.Windows.Forms.NumericUpDown();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Torol = new System.Windows.Forms.Button();
            this.button_Mosodit = new System.Windows.Forms.Button();
            this.listBox_kutyak = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Suly)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Mosodit);
            this.groupBox1.Controls.Add(this.button_Torol);
            this.groupBox1.Controls.Add(this.button_Mentes);
            this.groupBox1.Controls.Add(this.numericUpDown_Suly);
            this.groupBox1.Controls.Add(this.dateTimePicker_Datum);
            this.groupBox1.Controls.Add(this.label_Datum);
            this.groupBox1.Controls.Add(this.label_Suly);
            this.groupBox1.Controls.Add(this.label_Fajta);
            this.groupBox1.Controls.Add(this.label_Nev);
            this.groupBox1.Controls.Add(this.textBox_Fajta);
            this.groupBox1.Controls.Add(this.textBox_Nev);
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(491, 545);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kutyák adatai";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(220, 79);
            this.textBox_Nev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(213, 30);
            this.textBox_Nev.TabIndex = 0;
            // 
            // textBox_Fajta
            // 
            this.textBox_Fajta.Location = new System.Drawing.Point(220, 149);
            this.textBox_Fajta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Fajta.Name = "textBox_Fajta";
            this.textBox_Fajta.Size = new System.Drawing.Size(213, 30);
            this.textBox_Fajta.TabIndex = 3;
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Location = new System.Drawing.Point(46, 82);
            this.label_Nev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(47, 25);
            this.label_Nev.TabIndex = 4;
            this.label_Nev.Text = "Név";
            // 
            // label_Fajta
            // 
            this.label_Fajta.AutoSize = true;
            this.label_Fajta.Location = new System.Drawing.Point(46, 152);
            this.label_Fajta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Fajta.Name = "label_Fajta";
            this.label_Fajta.Size = new System.Drawing.Size(55, 25);
            this.label_Fajta.TabIndex = 5;
            this.label_Fajta.Text = "Fajta";
            // 
            // label_Suly
            // 
            this.label_Suly.AutoSize = true;
            this.label_Suly.Location = new System.Drawing.Point(46, 212);
            this.label_Suly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Suly.Name = "label_Suly";
            this.label_Suly.Size = new System.Drawing.Size(51, 25);
            this.label_Suly.TabIndex = 6;
            this.label_Suly.Text = "Súly";
            // 
            // label_Datum
            // 
            this.label_Datum.AutoSize = true;
            this.label_Datum.Location = new System.Drawing.Point(46, 282);
            this.label_Datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Datum.Name = "label_Datum";
            this.label_Datum.Size = new System.Drawing.Size(151, 25);
            this.label_Datum.TabIndex = 7;
            this.label_Datum.Text = "Születési dátum";
            // 
            // dateTimePicker_Datum
            // 
            this.dateTimePicker_Datum.Location = new System.Drawing.Point(220, 277);
            this.dateTimePicker_Datum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_Datum.Name = "dateTimePicker_Datum";
            this.dateTimePicker_Datum.Size = new System.Drawing.Size(213, 30);
            this.dateTimePicker_Datum.TabIndex = 8;
            // 
            // numericUpDown_Suly
            // 
            this.numericUpDown_Suly.DecimalPlaces = 2;
            this.numericUpDown_Suly.Location = new System.Drawing.Point(220, 207);
            this.numericUpDown_Suly.Name = "numericUpDown_Suly";
            this.numericUpDown_Suly.Size = new System.Drawing.Size(213, 30);
            this.numericUpDown_Suly.TabIndex = 9;
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(174, 359);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(110, 42);
            this.button_Mentes.TabIndex = 10;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button_Torol
            // 
            this.button_Torol.Location = new System.Drawing.Point(174, 422);
            this.button_Torol.Name = "button_Torol";
            this.button_Torol.Size = new System.Drawing.Size(110, 42);
            this.button_Torol.TabIndex = 11;
            this.button_Torol.Text = "Törlés";
            this.button_Torol.UseVisualStyleBackColor = true;
            this.button_Torol.Click += new System.EventHandler(this.button_Torol_Click);
            // 
            // button_Mosodit
            // 
            this.button_Mosodit.Location = new System.Drawing.Point(174, 486);
            this.button_Mosodit.Name = "button_Mosodit";
            this.button_Mosodit.Size = new System.Drawing.Size(110, 42);
            this.button_Mosodit.TabIndex = 12;
            this.button_Mosodit.Text = "Módosítás";
            this.button_Mosodit.UseVisualStyleBackColor = true;
            this.button_Mosodit.Click += new System.EventHandler(this.button_Mosodit_Click);
            // 
            // listBox_kutyak
            // 
            this.listBox_kutyak.FormattingEnabled = true;
            this.listBox_kutyak.ItemHeight = 25;
            this.listBox_kutyak.Location = new System.Drawing.Point(574, 45);
            this.listBox_kutyak.Name = "listBox_kutyak";
            this.listBox_kutyak.Size = new System.Drawing.Size(365, 529);
            this.listBox_kutyak.TabIndex = 1;
            this.listBox_kutyak.SelectedIndexChanged += new System.EventHandler(this.listBox_kutyak_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 602);
            this.Controls.Add(this.listBox_kutyak);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kutyák";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Suly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Mosodit;
        private System.Windows.Forms.Button button_Torol;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.NumericUpDown numericUpDown_Suly;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Datum;
        private System.Windows.Forms.Label label_Datum;
        private System.Windows.Forms.Label label_Suly;
        private System.Windows.Forms.Label label_Fajta;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.TextBox textBox_Fajta;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.ListBox listBox_kutyak;
    }
}

