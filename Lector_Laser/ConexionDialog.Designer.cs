namespace Lector_Laser
{
    partial class ConexionDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.optoCB = new System.Windows.Forms.ComboBox();
            this.evaCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opto NCDT 1302";
            // 
            // optoCB
            // 
            this.optoCB.FormattingEnabled = true;
            this.optoCB.Location = new System.Drawing.Point(108, 23);
            this.optoCB.Name = "optoCB";
            this.optoCB.Size = new System.Drawing.Size(121, 21);
            this.optoCB.TabIndex = 1;
            // 
            // evaCB
            // 
            this.evaCB.FormattingEnabled = true;
            this.evaCB.Location = new System.Drawing.Point(108, 59);
            this.evaCB.Name = "evaCB";
            this.evaCB.Size = new System.Drawing.Size(121, 21);
            this.evaCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eva Robotics";
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(68, 104);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(75, 23);
            this.aButton.TabIndex = 4;
            this.aButton.Text = "Aceptar";
            this.aButton.UseVisualStyleBackColor = true;
            // 
            // cButton
            // 
            this.cButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cButton.Location = new System.Drawing.Point(149, 104);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(75, 23);
            this.cButton.TabIndex = 5;
            this.cButton.Text = "Cancelar";
            this.cButton.UseVisualStyleBackColor = true;
            // 
            // ConsexionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 139);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.evaCB);
            this.Controls.Add(this.optoCB);
            this.Controls.Add(this.label1);
            this.Name = "ConsexionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección Hardware";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox optoCB;
        private System.Windows.Forms.ComboBox evaCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button cButton;
    }
}