namespace Autosimulator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.EngineStartBar = new System.Windows.Forms.ProgressBar();
            this.SpeedBar = new System.Windows.Forms.ProgressBar();
            this.Startlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(273, 12);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(232, 21);
            this.comboBoxAutos.TabIndex = 0;
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged);
            // 
            // EngineStartBar
            // 
            this.EngineStartBar.Location = new System.Drawing.Point(530, 12);
            this.EngineStartBar.Name = "EngineStartBar";
            this.EngineStartBar.Size = new System.Drawing.Size(246, 21);
            this.EngineStartBar.TabIndex = 3;
            this.EngineStartBar.Value = 100;
            this.EngineStartBar.Click += new System.EventHandler(this.EngineStartBar_Click);
            // 
            // SpeedBar
            // 
            this.SpeedBar.Enabled = false;
            this.SpeedBar.Location = new System.Drawing.Point(12, 12);
            this.SpeedBar.MarqueeAnimationSpeed = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(255, 21);
            this.SpeedBar.TabIndex = 3;
            this.SpeedBar.Tag = "";
            // 
            // Startlabel
            // 
            this.Startlabel.AutoSize = true;
            this.Startlabel.BackColor = System.Drawing.Color.Transparent;
            this.Startlabel.Location = new System.Drawing.Point(599, 36);
            this.Startlabel.Name = "Startlabel";
            this.Startlabel.Size = new System.Drawing.Size(77, 13);
            this.Startlabel.TabIndex = 4;
            this.Startlabel.Text = "START/STOP";
            this.Startlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 112);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_leave);
            this.button1.MouseHover += new System.EventHandler(this.button1_hover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Startlabel);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.EngineStartBar);
            this.Controls.Add(this.comboBoxAutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.ProgressBar EngineStartBar;
        private System.Windows.Forms.ProgressBar SpeedBar;
        private System.Windows.Forms.Label Startlabel;
        private System.Windows.Forms.Button button1;
    }
}

