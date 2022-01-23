namespace Ukol2_retezec_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cifry = new System.Windows.Forms.ListBox();
            this.vystup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vstup = new System.Windows.Forms.TextBox();
            this.zjistit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cifry
            // 
            this.cifry.FormattingEnabled = true;
            this.cifry.Location = new System.Drawing.Point(12, 64);
            this.cifry.Name = "cifry";
            this.cifry.Size = new System.Drawing.Size(120, 95);
            this.cifry.TabIndex = 11;
            // 
            // vystup
            // 
            this.vystup.Location = new System.Drawing.Point(148, 38);
            this.vystup.Name = "vystup";
            this.vystup.ReadOnly = true;
            this.vystup.Size = new System.Drawing.Size(100, 20);
            this.vystup.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bez nadbytečných mezer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zadej řetězec znaků:";
            // 
            // vstup
            // 
            this.vstup.Location = new System.Drawing.Point(148, 12);
            this.vstup.Name = "vstup";
            this.vstup.Size = new System.Drawing.Size(100, 20);
            this.vstup.TabIndex = 7;
            // 
            // zjistit
            // 
            this.zjistit.Location = new System.Drawing.Point(159, 94);
            this.zjistit.Name = "zjistit";
            this.zjistit.Size = new System.Drawing.Size(75, 36);
            this.zjistit.TabIndex = 6;
            this.zjistit.Text = "Zjistit";
            this.zjistit.UseVisualStyleBackColor = true;
            this.zjistit.Click += new System.EventHandler(this.zjistit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 174);
            this.Controls.Add(this.cifry);
            this.Controls.Add(this.vystup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vstup);
            this.Controls.Add(this.zjistit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Úkol 2 řetězce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cifry;
        private System.Windows.Forms.TextBox vystup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vstup;
        private System.Windows.Forms.Button zjistit;
    }
}

