namespace Lector_Laser
{
    partial class mForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mPDisponibles = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.mSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.s_prueba = new System.Windows.Forms.Button();
            this.detener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.msAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimmer = new System.Windows.Forms.ToolStripMenuItem();
            this.msSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimmer0 = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimmer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimmer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mMotor = new System.Windows.Forms.ToolStripMenuItem();
            this.mmManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.mConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mcGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mcAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mcDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.maInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.maAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(98, 140);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(174, 20);
            this.texto.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArchivo,
            this.mSensor,
            this.mMotor,
            this.mConfig,
            this.mAyuda});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(390, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mArchivo
            // 
            this.mArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPDisponibles,
            this.mGuardar,
            this.mSeparador,
            this.mSalir});
            this.mArchivo.Name = "mArchivo";
            this.mArchivo.Size = new System.Drawing.Size(60, 20);
            this.mArchivo.Text = "Archivo";
            // 
            // mPDisponibles
            // 
            this.mPDisponibles.Name = "mPDisponibles";
            this.mPDisponibles.Size = new System.Drawing.Size(178, 22);
            this.mPDisponibles.Text = "Puertos Disponibles";
            // 
            // mSeparador
            // 
            this.mSeparador.Name = "mSeparador";
            this.mSeparador.Size = new System.Drawing.Size(175, 6);
            // 
            // mSalir
            // 
            this.mSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mSalir.Name = "mSalir";
            this.mSalir.Size = new System.Drawing.Size(178, 22);
            this.mSalir.Text = "Salir";
            // 
            // s_prueba
            // 
            this.s_prueba.Location = new System.Drawing.Point(65, 58);
            this.s_prueba.Name = "s_prueba";
            this.s_prueba.Size = new System.Drawing.Size(75, 45);
            this.s_prueba.TabIndex = 2;
            this.s_prueba.Text = "Iniciar Lecturas";
            this.s_prueba.UseVisualStyleBackColor = true;
            // 
            // detener
            // 
            this.detener.Location = new System.Drawing.Point(250, 58);
            this.detener.Name = "detener";
            this.detener.Size = new System.Drawing.Size(75, 45);
            this.detener.TabIndex = 3;
            this.detener.Text = "Detener";
            this.detener.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lectura Actual:";
            // 
            // mGuardar
            // 
            this.mGuardar.Name = "mGuardar";
            this.mGuardar.Size = new System.Drawing.Size(178, 22);
            this.mGuardar.Text = "Guardar";
            // 
            // mSensor
            // 
            this.mSensor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAuto,
            this.msTimmer,
            this.msSingle});
            this.mSensor.Name = "mSensor";
            this.mSensor.Size = new System.Drawing.Size(54, 20);
            this.mSensor.Text = "Sensor";
            // 
            // msAuto
            // 
            this.msAuto.Name = "msAuto";
            this.msAuto.Size = new System.Drawing.Size(152, 22);
            this.msAuto.Text = "Automático";
            // 
            // msTimmer
            // 
            this.msTimmer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTimmer0,
            this.msTimmer1,
            this.msTimmer2});
            this.msTimmer.Name = "msTimmer";
            this.msTimmer.Size = new System.Drawing.Size(152, 22);
            this.msTimmer.Text = "Por Tiempo";
            // 
            // msSingle
            // 
            this.msSingle.Name = "msSingle";
            this.msSingle.Size = new System.Drawing.Size(152, 22);
            this.msSingle.Text = "Manual";
            // 
            // msTimmer0
            // 
            this.msTimmer0.Name = "msTimmer0";
            this.msTimmer0.Size = new System.Drawing.Size(152, 22);
            this.msTimmer0.Text = "0.5s";
            // 
            // msTimmer1
            // 
            this.msTimmer1.Name = "msTimmer1";
            this.msTimmer1.Size = new System.Drawing.Size(152, 22);
            this.msTimmer1.Text = "1.0 s";
            // 
            // msTimmer2
            // 
            this.msTimmer2.Name = "msTimmer2";
            this.msTimmer2.Size = new System.Drawing.Size(152, 22);
            this.msTimmer2.Text = "3.0 s";
            // 
            // mMotor
            // 
            this.mMotor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmManual,
            this.mmAuto});
            this.mMotor.Name = "mMotor";
            this.mMotor.Size = new System.Drawing.Size(52, 20);
            this.mMotor.Text = "Motor";
            // 
            // mmManual
            // 
            this.mmManual.Name = "mmManual";
            this.mmManual.Size = new System.Drawing.Size(152, 22);
            this.mmManual.Text = "Manual";
            // 
            // mmAuto
            // 
            this.mmAuto.Name = "mmAuto";
            this.mmAuto.Size = new System.Drawing.Size(152, 22);
            this.mmAuto.Text = "Programa";
            // 
            // mConfig
            // 
            this.mConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcAbrir,
            this.mcGuardar,
            this.mcDefault});
            this.mConfig.Name = "mConfig";
            this.mConfig.Size = new System.Drawing.Size(95, 20);
            this.mConfig.Text = "Configuración";
            // 
            // mcGuardar
            // 
            this.mcGuardar.Name = "mcGuardar";
            this.mcGuardar.Size = new System.Drawing.Size(214, 22);
            this.mcGuardar.Text = "Guardar Config.";
            // 
            // mcAbrir
            // 
            this.mcAbrir.Name = "mcAbrir";
            this.mcAbrir.Size = new System.Drawing.Size(214, 22);
            this.mcAbrir.Text = "Abrir";
            // 
            // mcDefault
            // 
            this.mcDefault.Name = "mcDefault";
            this.mcDefault.Size = new System.Drawing.Size(214, 22);
            this.mcDefault.Text = "Establecer Predeterminada";
            // 
            // mAyuda
            // 
            this.mAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maInfo,
            this.maAyuda});
            this.mAyuda.Name = "mAyuda";
            this.mAyuda.Size = new System.Drawing.Size(53, 20);
            this.mAyuda.Text = "Ayuda";
            // 
            // maInfo
            // 
            this.maInfo.Name = "maInfo";
            this.maInfo.Size = new System.Drawing.Size(152, 22);
            this.maInfo.Text = "Info";
            // 
            // maAyuda
            // 
            this.maAyuda.Name = "maAyuda";
            this.maAyuda.Size = new System.Drawing.Size(152, 22);
            this.maAyuda.Text = "Ayuda";
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detener);
            this.Controls.Add(this.s_prueba);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "mForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epsilon optoNCDT 1302 + Eva Robotics";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void m(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control && e.Alt && (e.KeyCode == System.Windows.Forms.Keys.G))
            {
                System.Windows.Forms.MessageBox.Show(
                    System.Text.Encoding.UTF8.GetString(
                    System.Convert.FromBase64String(
                    "RXN0ZSBwcm9ncmFtYSBlcyBwcm9waWVkYWQgaW50ZWxlY3R1YWwgZGUgSi5CLkIuTQ=="
                    )), "Importante", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        #endregion

        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mArchivo;
        private System.Windows.Forms.ToolStripMenuItem mSalir;
        private System.Windows.Forms.ToolStripSeparator mSeparador;
        private System.Windows.Forms.ToolStripMenuItem mPDisponibles;
        private System.Windows.Forms.Button s_prueba;
        private System.Windows.Forms.Button detener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mGuardar;
        private System.Windows.Forms.ToolStripMenuItem mSensor;
        private System.Windows.Forms.ToolStripMenuItem msAuto;
        private System.Windows.Forms.ToolStripMenuItem msTimmer;
        private System.Windows.Forms.ToolStripMenuItem msTimmer0;
        private System.Windows.Forms.ToolStripMenuItem msTimmer1;
        private System.Windows.Forms.ToolStripMenuItem msTimmer2;
        private System.Windows.Forms.ToolStripMenuItem msSingle;
        private System.Windows.Forms.ToolStripMenuItem mMotor;
        private System.Windows.Forms.ToolStripMenuItem mmManual;
        private System.Windows.Forms.ToolStripMenuItem mmAuto;
        private System.Windows.Forms.ToolStripMenuItem mConfig;
        private System.Windows.Forms.ToolStripMenuItem mcAbrir;
        private System.Windows.Forms.ToolStripMenuItem mcGuardar;
        private System.Windows.Forms.ToolStripMenuItem mcDefault;
        private System.Windows.Forms.ToolStripMenuItem mAyuda;
        private System.Windows.Forms.ToolStripMenuItem maInfo;
        private System.Windows.Forms.ToolStripMenuItem maAyuda;
    }
}

