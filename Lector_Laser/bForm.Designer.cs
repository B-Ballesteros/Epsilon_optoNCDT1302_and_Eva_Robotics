namespace Lector_Laser
{
    partial class bForm
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
            this.ilButton = new System.Windows.Forms.Button();
            this.ipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ilButton
            // 
            this.ilButton.Location = new System.Drawing.Point(59, 98);
            this.ilButton.Name = "ilButton";
            this.ilButton.Size = new System.Drawing.Size(75, 35);
            this.ilButton.TabIndex = 0;
            this.ilButton.Text = "Iniciar Lecturas";
            this.ilButton.UseVisualStyleBackColor = true;
            // 
            // ipButton
            // 
            this.ipButton.Location = new System.Drawing.Point(206, 98);
            this.ipButton.Name = "ipButton";
            this.ipButton.Size = new System.Drawing.Size(90, 35);
            this.ipButton.TabIndex = 1;
            this.ipButton.Text = "Información del  programa";
            this.ipButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Epsilon optoNCDT 1302 + Eva Robotics";
            // 
            // bForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipButton);
            this.Controls.Add(this.ilButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "bForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epsilon optoNCDT 1302 + Eva Robotics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ilButton;
        private System.Windows.Forms.Button ipButton;
        private System.Windows.Forms.Label label1;
    }
}