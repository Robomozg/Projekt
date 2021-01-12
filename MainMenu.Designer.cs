
namespace Projekt_Alfa
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kontynuuj = new System.Windows.Forms.Button();
            this.NowaGra = new System.Windows.Forms.Button();
            this.Wyjdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Projekt_Alfa.Properties.Resources._600x300;
            this.panel1.Location = new System.Drawing.Point(660, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 300);
            this.panel1.TabIndex = 0;
            // 
            // Kontynuuj
            // 
            this.Kontynuuj.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kontynuuj.Location = new System.Drawing.Point(810, 506);
            this.Kontynuuj.Name = "Kontynuuj";
            this.Kontynuuj.Size = new System.Drawing.Size(300, 50);
            this.Kontynuuj.TabIndex = 1;
            this.Kontynuuj.Text = "Kontynuuj";
            this.Kontynuuj.UseVisualStyleBackColor = true;
            this.Kontynuuj.Click += new System.EventHandler(this.Kontynuuj_Click);
            // 
            // NowaGra
            // 
            this.NowaGra.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NowaGra.Location = new System.Drawing.Point(810, 562);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(300, 50);
            this.NowaGra.TabIndex = 2;
            this.NowaGra.Text = "NowaGra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // Wyjdz
            // 
            this.Wyjdz.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyjdz.Location = new System.Drawing.Point(810, 618);
            this.Wyjdz.Name = "Wyjdz";
            this.Wyjdz.Size = new System.Drawing.Size(300, 50);
            this.Wyjdz.TabIndex = 3;
            this.Wyjdz.Text = "Wyjdź";
            this.Wyjdz.UseVisualStyleBackColor = true;
            this.Wyjdz.Click += new System.EventHandler(this.Wyjdz_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.Wyjdz);
            this.Controls.Add(this.NowaGra);
            this.Controls.Add(this.Kontynuuj);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ptasznik: the Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Kontynuuj;
        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.Button Wyjdz;
    }
}

