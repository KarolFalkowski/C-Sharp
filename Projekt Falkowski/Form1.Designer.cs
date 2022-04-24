
namespace Projekt_Falkowski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Wczytaj = new System.Windows.Forms.Button();
            this.pokazWykres = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wczytaj
            // 
            this.Wczytaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Wczytaj.Location = new System.Drawing.Point(12, 36);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(211, 116);
            this.Wczytaj.TabIndex = 0;
            this.Wczytaj.Text = "Wczytaj dane";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // pokazWykres
            // 
            this.pokazWykres.Location = new System.Drawing.Point(534, 36);
            this.pokazWykres.Name = "pokazWykres";
            this.pokazWykres.Size = new System.Drawing.Size(206, 116);
            this.pokazWykres.TabIndex = 1;
            this.pokazWykres.Text = "Pokaż wykres";
            this.pokazWykres.UseVisualStyleBackColor = true;
            this.pokazWykres.Visible = false;
            this.pokazWykres.Click += new System.EventHandler(this.pokazWykres_Click);
            // 
            // zapisz
            // 
            this.zapisz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zapisz.Location = new System.Drawing.Point(12, 318);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(211, 120);
            this.zapisz.TabIndex = 2;
            this.zapisz.Text = "Zapisz dane";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Visible = false;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Otworzenie nowego okna z wykresem";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybranie pliku z danymi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybranie pliku do zapisu";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.pokazWykres);
            this.Controls.Add(this.Wczytaj);
            this.Name = "Form1";
            this.Text = "Projekt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.Button pokazWykres;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

