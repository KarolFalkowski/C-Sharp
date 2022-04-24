
namespace Projekt_Falkowski
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ZmienKolor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioCzerwony = new System.Windows.Forms.RadioButton();
            this.radioZielony = new System.Windows.Forms.RadioButton();
            this.radioNiebieski = new System.Windows.Forms.RadioButton();
            this.wlLegende = new System.Windows.Forms.Button();
            this.wylegende = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PokazDane = new System.Windows.Forms.Button();
            this.ListaDoUkrycia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // Wykres
            // 
            chartArea4.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Wykres.Legends.Add(legend4);
            this.Wykres.Location = new System.Drawing.Point(7, 7);
            this.Wykres.Name = "Wykres";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Oceny";
            this.Wykres.Series.Add(series4);
            this.Wykres.Size = new System.Drawing.Size(500, 424);
            this.Wykres.TabIndex = 0;
            this.Wykres.Text = "chart1";
            // 
            // ZmienKolor
            // 
            this.ZmienKolor.Location = new System.Drawing.Point(513, 48);
            this.ZmienKolor.Name = "ZmienKolor";
            this.ZmienKolor.Size = new System.Drawing.Size(275, 67);
            this.ZmienKolor.TabIndex = 1;
            this.ZmienKolor.Text = "Zmień kolor";
            this.ZmienKolor.UseVisualStyleBackColor = true;
            this.ZmienKolor.Click += new System.EventHandler(this.ZmienKolor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modyfikacje wykresu";
            // 
            // radioCzerwony
            // 
            this.radioCzerwony.AutoSize = true;
            this.radioCzerwony.Location = new System.Drawing.Point(513, 121);
            this.radioCzerwony.Name = "radioCzerwony";
            this.radioCzerwony.Size = new System.Drawing.Size(71, 17);
            this.radioCzerwony.TabIndex = 3;
            this.radioCzerwony.TabStop = true;
            this.radioCzerwony.Text = "Czerwony";
            this.radioCzerwony.UseVisualStyleBackColor = true;
            // 
            // radioZielony
            // 
            this.radioZielony.AutoSize = true;
            this.radioZielony.Location = new System.Drawing.Point(604, 121);
            this.radioZielony.Name = "radioZielony";
            this.radioZielony.Size = new System.Drawing.Size(59, 17);
            this.radioZielony.TabIndex = 4;
            this.radioZielony.TabStop = true;
            this.radioZielony.Text = "Zielony";
            this.radioZielony.UseVisualStyleBackColor = true;
            // 
            // radioNiebieski
            // 
            this.radioNiebieski.AutoSize = true;
            this.radioNiebieski.Location = new System.Drawing.Point(695, 121);
            this.radioNiebieski.Name = "radioNiebieski";
            this.radioNiebieski.Size = new System.Drawing.Size(68, 17);
            this.radioNiebieski.TabIndex = 5;
            this.radioNiebieski.TabStop = true;
            this.radioNiebieski.Text = "Niebieski";
            this.radioNiebieski.UseVisualStyleBackColor = true;
            // 
            // wlLegende
            // 
            this.wlLegende.Location = new System.Drawing.Point(513, 160);
            this.wlLegende.Name = "wlLegende";
            this.wlLegende.Size = new System.Drawing.Size(120, 67);
            this.wlLegende.TabIndex = 6;
            this.wlLegende.Text = "Włącz legendę";
            this.wlLegende.UseVisualStyleBackColor = true;
            this.wlLegende.Click += new System.EventHandler(this.wlLegende_Click);
            // 
            // wylegende
            // 
            this.wylegende.Location = new System.Drawing.Point(669, 160);
            this.wylegende.Name = "wylegende";
            this.wylegende.Size = new System.Drawing.Size(119, 67);
            this.wylegende.TabIndex = 7;
            this.wylegende.Text = "Wyłącz Legendę";
            this.wylegende.UseVisualStyleBackColor = true;
            this.wylegende.Click += new System.EventHandler(this.wylegende_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(519, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ukryj dane";
            // 
            // PokazDane
            // 
            this.PokazDane.Location = new System.Drawing.Point(669, 286);
            this.PokazDane.Name = "PokazDane";
            this.PokazDane.Size = new System.Drawing.Size(119, 94);
            this.PokazDane.TabIndex = 10;
            this.PokazDane.Text = "Pokaż dane";
            this.PokazDane.UseVisualStyleBackColor = true;
            this.PokazDane.Click += new System.EventHandler(this.PokazDane_Click);
            // 
            // ListaDoUkrycia
            // 
            this.ListaDoUkrycia.FormattingEnabled = true;
            this.ListaDoUkrycia.Location = new System.Drawing.Point(529, 292);
            this.ListaDoUkrycia.Name = "ListaDoUkrycia";
            this.ListaDoUkrycia.Size = new System.Drawing.Size(116, 21);
            this.ListaDoUkrycia.TabIndex = 11;
            this.ListaDoUkrycia.SelectedIndexChanged += new System.EventHandler(this.ListaDoUkrycia_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaDoUkrycia);
            this.Controls.Add(this.PokazDane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wylegende);
            this.Controls.Add(this.wlLegende);
            this.Controls.Add(this.radioNiebieski);
            this.Controls.Add(this.radioZielony);
            this.Controls.Add(this.radioCzerwony);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZmienKolor);
            this.Controls.Add(this.Wykres);
            this.Name = "Form2";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.Button ZmienKolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCzerwony;
        private System.Windows.Forms.RadioButton radioZielony;
        private System.Windows.Forms.RadioButton radioNiebieski;
        private System.Windows.Forms.Button wlLegende;
        private System.Windows.Forms.Button wylegende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PokazDane;
        private System.Windows.Forms.ComboBox ListaDoUkrycia;
    }
}