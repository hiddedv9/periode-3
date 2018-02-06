namespace GevorderProgrammerenPracticumWeek1
{
    partial class formPracticumWeek1
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
            this.listBoxPersonen = new System.Windows.Forms.ListBox();
            this.listBoxHuisdieren = new System.Windows.Forms.ListBox();
            this.groupBoxPersoon = new System.Windows.Forms.GroupBox();
            this.textBoxVoornaam = new System.Windows.Forms.TextBox();
            this.buttonAddPersoon = new System.Windows.Forms.Button();
            this.labelLeeftijd = new System.Windows.Forms.Label();
            this.labelAchternaam = new System.Windows.Forms.Label();
            this.labelVoornaam = new System.Windows.Forms.Label();
            this.groupBoxHuisdieren = new System.Windows.Forms.GroupBox();
            this.textBoxAchternaam = new System.Windows.Forms.TextBox();
            this.textBoxLeeftijd = new System.Windows.Forms.TextBox();
            this.buttonAddHuisdier = new System.Windows.Forms.Button();
            this.labelHuisdierNaam = new System.Windows.Forms.Label();
            this.labelHuisdierSoort = new System.Windows.Forms.Label();
            this.textBoxHuisdierNaam = new System.Windows.Forms.TextBox();
            this.textBoxHuisdierSoort = new System.Windows.Forms.TextBox();
            this.groupBoxPersoon.SuspendLayout();
            this.groupBoxHuisdieren.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPersonen
            // 
            this.listBoxPersonen.FormattingEnabled = true;
            this.listBoxPersonen.Location = new System.Drawing.Point(315, 64);
            this.listBoxPersonen.Name = "listBoxPersonen";
            this.listBoxPersonen.Size = new System.Drawing.Size(213, 381);
            this.listBoxPersonen.TabIndex = 0;
            this.listBoxPersonen.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonen_SelectedIndexChanged);
            // 
            // listBoxHuisdieren
            // 
            this.listBoxHuisdieren.FormattingEnabled = true;
            this.listBoxHuisdieren.Location = new System.Drawing.Point(557, 64);
            this.listBoxHuisdieren.Name = "listBoxHuisdieren";
            this.listBoxHuisdieren.Size = new System.Drawing.Size(213, 381);
            this.listBoxHuisdieren.TabIndex = 1;
            this.listBoxHuisdieren.SelectedIndexChanged += new System.EventHandler(this.listBoxHuisdieren_SelectedIndexChanged);
            // 
            // groupBoxPersoon
            // 
            this.groupBoxPersoon.Controls.Add(this.textBoxLeeftijd);
            this.groupBoxPersoon.Controls.Add(this.textBoxAchternaam);
            this.groupBoxPersoon.Controls.Add(this.textBoxVoornaam);
            this.groupBoxPersoon.Controls.Add(this.buttonAddPersoon);
            this.groupBoxPersoon.Controls.Add(this.labelLeeftijd);
            this.groupBoxPersoon.Controls.Add(this.labelAchternaam);
            this.groupBoxPersoon.Controls.Add(this.labelVoornaam);
            this.groupBoxPersoon.Location = new System.Drawing.Point(12, 24);
            this.groupBoxPersoon.Name = "groupBoxPersoon";
            this.groupBoxPersoon.Size = new System.Drawing.Size(273, 445);
            this.groupBoxPersoon.TabIndex = 2;
            this.groupBoxPersoon.TabStop = false;
            this.groupBoxPersoon.Text = "Persoon";
            // 
            // textBoxVoornaam
            // 
            this.textBoxVoornaam.Location = new System.Drawing.Point(90, 37);
            this.textBoxVoornaam.Name = "textBoxVoornaam";
            this.textBoxVoornaam.Size = new System.Drawing.Size(159, 20);
            this.textBoxVoornaam.TabIndex = 4;
            // 
            // buttonAddPersoon
            // 
            this.buttonAddPersoon.Location = new System.Drawing.Point(21, 393);
            this.buttonAddPersoon.Name = "buttonAddPersoon";
            this.buttonAddPersoon.Size = new System.Drawing.Size(229, 37);
            this.buttonAddPersoon.TabIndex = 3;
            this.buttonAddPersoon.Text = "Voeg persoon toe";
            this.buttonAddPersoon.UseVisualStyleBackColor = true;
            this.buttonAddPersoon.Click += new System.EventHandler(this.buttonAddPersoon_Click);
            // 
            // labelLeeftijd
            // 
            this.labelLeeftijd.AutoSize = true;
            this.labelLeeftijd.Location = new System.Drawing.Point(16, 107);
            this.labelLeeftijd.Name = "labelLeeftijd";
            this.labelLeeftijd.Size = new System.Drawing.Size(41, 13);
            this.labelLeeftijd.TabIndex = 2;
            this.labelLeeftijd.Text = "Leeftijd";
            // 
            // labelAchternaam
            // 
            this.labelAchternaam.AutoSize = true;
            this.labelAchternaam.Location = new System.Drawing.Point(15, 73);
            this.labelAchternaam.Name = "labelAchternaam";
            this.labelAchternaam.Size = new System.Drawing.Size(64, 13);
            this.labelAchternaam.TabIndex = 1;
            this.labelAchternaam.Text = "Achternaam";
            // 
            // labelVoornaam
            // 
            this.labelVoornaam.AutoSize = true;
            this.labelVoornaam.Location = new System.Drawing.Point(15, 40);
            this.labelVoornaam.Name = "labelVoornaam";
            this.labelVoornaam.Size = new System.Drawing.Size(55, 13);
            this.labelVoornaam.TabIndex = 0;
            this.labelVoornaam.Text = "Voornaam";
            // 
            // groupBoxHuisdieren
            // 
            this.groupBoxHuisdieren.Controls.Add(this.textBoxHuisdierSoort);
            this.groupBoxHuisdieren.Controls.Add(this.textBoxHuisdierNaam);
            this.groupBoxHuisdieren.Controls.Add(this.labelHuisdierSoort);
            this.groupBoxHuisdieren.Controls.Add(this.labelHuisdierNaam);
            this.groupBoxHuisdieren.Controls.Add(this.buttonAddHuisdier);
            this.groupBoxHuisdieren.Location = new System.Drawing.Point(797, 24);
            this.groupBoxHuisdieren.Name = "groupBoxHuisdieren";
            this.groupBoxHuisdieren.Size = new System.Drawing.Size(273, 445);
            this.groupBoxHuisdieren.TabIndex = 3;
            this.groupBoxHuisdieren.TabStop = false;
            this.groupBoxHuisdieren.Text = "Huisdier";
            // 
            // textBoxAchternaam
            // 
            this.textBoxAchternaam.Location = new System.Drawing.Point(90, 70);
            this.textBoxAchternaam.Name = "textBoxAchternaam";
            this.textBoxAchternaam.Size = new System.Drawing.Size(159, 20);
            this.textBoxAchternaam.TabIndex = 5;
            // 
            // textBoxLeeftijd
            // 
            this.textBoxLeeftijd.Location = new System.Drawing.Point(90, 104);
            this.textBoxLeeftijd.Name = "textBoxLeeftijd";
            this.textBoxLeeftijd.Size = new System.Drawing.Size(159, 20);
            this.textBoxLeeftijd.TabIndex = 6;
            // 
            // buttonAddHuisdier
            // 
            this.buttonAddHuisdier.Enabled = false;
            this.buttonAddHuisdier.Location = new System.Drawing.Point(25, 393);
            this.buttonAddHuisdier.Name = "buttonAddHuisdier";
            this.buttonAddHuisdier.Size = new System.Drawing.Size(229, 37);
            this.buttonAddHuisdier.TabIndex = 7;
            this.buttonAddHuisdier.Text = "Voeg huisdier toe";
            this.buttonAddHuisdier.UseVisualStyleBackColor = true;
            this.buttonAddHuisdier.Click += new System.EventHandler(this.buttonAddHuisdier_Click);
            // 
            // labelHuisdierNaam
            // 
            this.labelHuisdierNaam.AutoSize = true;
            this.labelHuisdierNaam.Location = new System.Drawing.Point(22, 40);
            this.labelHuisdierNaam.Name = "labelHuisdierNaam";
            this.labelHuisdierNaam.Size = new System.Drawing.Size(35, 13);
            this.labelHuisdierNaam.TabIndex = 8;
            this.labelHuisdierNaam.Text = "Naam";
            // 
            // labelHuisdierSoort
            // 
            this.labelHuisdierSoort.AutoSize = true;
            this.labelHuisdierSoort.Location = new System.Drawing.Point(22, 73);
            this.labelHuisdierSoort.Name = "labelHuisdierSoort";
            this.labelHuisdierSoort.Size = new System.Drawing.Size(32, 13);
            this.labelHuisdierSoort.TabIndex = 9;
            this.labelHuisdierSoort.Text = "Soort";
            // 
            // textBoxHuisdierNaam
            // 
            this.textBoxHuisdierNaam.Location = new System.Drawing.Point(95, 37);
            this.textBoxHuisdierNaam.Name = "textBoxHuisdierNaam";
            this.textBoxHuisdierNaam.Size = new System.Drawing.Size(159, 20);
            this.textBoxHuisdierNaam.TabIndex = 7;
            // 
            // textBoxHuisdierSoort
            // 
            this.textBoxHuisdierSoort.Location = new System.Drawing.Point(95, 70);
            this.textBoxHuisdierSoort.Name = "textBoxHuisdierSoort";
            this.textBoxHuisdierSoort.Size = new System.Drawing.Size(159, 20);
            this.textBoxHuisdierSoort.TabIndex = 10;
            // 
            // formPracticumWeek1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 492);
            this.Controls.Add(this.groupBoxHuisdieren);
            this.Controls.Add(this.listBoxPersonen);
            this.Controls.Add(this.groupBoxPersoon);
            this.Controls.Add(this.listBoxHuisdieren);
            this.Name = "formPracticumWeek1";
            this.Text = "Gevorderd Programmeren - Practicum week 1";
            this.groupBoxPersoon.ResumeLayout(false);
            this.groupBoxPersoon.PerformLayout();
            this.groupBoxHuisdieren.ResumeLayout(false);
            this.groupBoxHuisdieren.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPersonen;
        private System.Windows.Forms.ListBox listBoxHuisdieren;
        private System.Windows.Forms.GroupBox groupBoxPersoon;
        private System.Windows.Forms.GroupBox groupBoxHuisdieren;
        private System.Windows.Forms.Label labelLeeftijd;
        private System.Windows.Forms.Label labelAchternaam;
        private System.Windows.Forms.Label labelVoornaam;
        private System.Windows.Forms.TextBox textBoxVoornaam;
        private System.Windows.Forms.Button buttonAddPersoon;
        private System.Windows.Forms.TextBox textBoxLeeftijd;
        private System.Windows.Forms.TextBox textBoxAchternaam;
        private System.Windows.Forms.Button buttonAddHuisdier;
        private System.Windows.Forms.Label labelHuisdierSoort;
        private System.Windows.Forms.Label labelHuisdierNaam;
        private System.Windows.Forms.TextBox textBoxHuisdierSoort;
        private System.Windows.Forms.TextBox textBoxHuisdierNaam;
    }
}

