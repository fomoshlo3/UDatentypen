namespace UDatentypen
{
    partial class MainForm
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
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.BtnAnzeigen = new System.Windows.Forms.Button();
            this.BtnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(12, 12);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(34, 15);
            this.LblAusgabe.TabIndex = 0;
            this.LblAusgabe.Text = "(leer)";
            // 
            // button1
            // 
            this.BtnAnzeigen.Location = new System.Drawing.Point(341, 12);
            this.BtnAnzeigen.Name = "BtnAnzeigen";
            this.BtnAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.BtnAnzeigen.TabIndex = 1;
            this.BtnAnzeigen.Text = "Anzeigen";
            this.BtnAnzeigen.UseVisualStyleBackColor = true;
            this.BtnAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // button2
            // 
            this.BtnBeenden.Location = new System.Drawing.Point(341, 41);
            this.BtnBeenden.Name = "BtnBeenden";
            this.BtnBeenden.Size = new System.Drawing.Size(75, 23);
            this.BtnBeenden.TabIndex = 2;
            this.BtnBeenden.Text = "Beenden";
            this.BtnBeenden.UseVisualStyleBackColor = true;
            this.BtnBeenden.Click += new System.EventHandler(this.CmdBeenden_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 320);
            this.Controls.Add(this.BtnBeenden);
            this.Controls.Add(this.BtnAnzeigen);
            this.Controls.Add(this.LblAusgabe);
            this.Name = "MainForm";
            this.Text = "UDatentypen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblAusgabe;
        private Button BtnAnzeigen;
        private Button BtnBeenden;
    }
}