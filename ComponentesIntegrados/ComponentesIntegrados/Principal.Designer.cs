namespace ComponentesIntegrados
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.gbSerialNumber = new System.Windows.Forms.GroupBox();
            this.gbDiskNumber = new System.Windows.Forms.GroupBox();
            this.rtxtNumeroDiscos = new System.Windows.Forms.RichTextBox();
            this.gbbalance = new System.Windows.Forms.GroupBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblprocesadores = new System.Windows.Forms.Label();
            this.rtxtNit = new System.Windows.Forms.RichTextBox();
            this.gbMacAddress = new System.Windows.Forms.GroupBox();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.lblnit = new System.Windows.Forms.Label();
            this.rtxtPatches = new System.Windows.Forms.RichTextBox();
            this.lblpatches = new System.Windows.Forms.Label();
            this.btnRegedit = new System.Windows.Forms.Button();
            this.btnTaskManager = new System.Windows.Forms.Button();
            this.gbSerialNumber.SuspendLayout();
            this.gbDiskNumber.SuspendLayout();
            this.gbbalance.SuspendLayout();
            this.gbMacAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.Teal;
            this.btnAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(518, 429);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 35);
            this.btnAnalizar.TabIndex = 0;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(6, 26);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSerialNumber.TabIndex = 1;
            this.lblSerialNumber.Text = "Numero de serie";
            // 
            // gbSerialNumber
            // 
            this.gbSerialNumber.Controls.Add(this.lblSerialNumber);
            this.gbSerialNumber.Location = new System.Drawing.Point(12, 12);
            this.gbSerialNumber.Name = "gbSerialNumber";
            this.gbSerialNumber.Size = new System.Drawing.Size(216, 52);
            this.gbSerialNumber.TabIndex = 4;
            this.gbSerialNumber.TabStop = false;
            this.gbSerialNumber.Text = "Numero de Serie";
            // 
            // gbDiskNumber
            // 
            this.gbDiskNumber.Controls.Add(this.rtxtNumeroDiscos);
            this.gbDiskNumber.Location = new System.Drawing.Point(12, 84);
            this.gbDiskNumber.Name = "gbDiskNumber";
            this.gbDiskNumber.Size = new System.Drawing.Size(216, 100);
            this.gbDiskNumber.TabIndex = 5;
            this.gbDiskNumber.TabStop = false;
            this.gbDiskNumber.Text = "Numero de Discos";
            // 
            // rtxtNumeroDiscos
            // 
            this.rtxtNumeroDiscos.Location = new System.Drawing.Point(9, 19);
            this.rtxtNumeroDiscos.Name = "rtxtNumeroDiscos";
            this.rtxtNumeroDiscos.Size = new System.Drawing.Size(201, 75);
            this.rtxtNumeroDiscos.TabIndex = 0;
            this.rtxtNumeroDiscos.Text = "Numero de discos";
            // 
            // gbbalance
            // 
            this.gbbalance.Controls.Add(this.lblRam);
            this.gbbalance.Controls.Add(this.lblprocesadores);
            this.gbbalance.Location = new System.Drawing.Point(10, 205);
            this.gbbalance.Name = "gbbalance";
            this.gbbalance.Size = new System.Drawing.Size(218, 100);
            this.gbbalance.TabIndex = 6;
            this.gbbalance.TabStop = false;
            this.gbbalance.Text = "Balance General";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(8, 55);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(29, 13);
            this.lblRam.TabIndex = 1;
            this.lblRam.Text = "Ram";
            // 
            // lblprocesadores
            // 
            this.lblprocesadores.AutoSize = true;
            this.lblprocesadores.Location = new System.Drawing.Point(8, 31);
            this.lblprocesadores.Name = "lblprocesadores";
            this.lblprocesadores.Size = new System.Drawing.Size(72, 13);
            this.lblprocesadores.TabIndex = 0;
            this.lblprocesadores.Text = "Procesadores";
            // 
            // rtxtNit
            // 
            this.rtxtNit.Location = new System.Drawing.Point(241, 35);
            this.rtxtNit.Name = "rtxtNit";
            this.rtxtNit.Size = new System.Drawing.Size(306, 354);
            this.rtxtNit.TabIndex = 7;
            this.rtxtNit.Text = "";
            // 
            // gbMacAddress
            // 
            this.gbMacAddress.Controls.Add(this.lblMacAddress);
            this.gbMacAddress.Location = new System.Drawing.Point(10, 324);
            this.gbMacAddress.Name = "gbMacAddress";
            this.gbMacAddress.Size = new System.Drawing.Size(218, 87);
            this.gbMacAddress.TabIndex = 9;
            this.gbMacAddress.TabStop = false;
            this.gbMacAddress.Text = "MacAddress";
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(8, 26);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(66, 13);
            this.lblMacAddress.TabIndex = 0;
            this.lblMacAddress.Text = "MacAddress";
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Location = new System.Drawing.Point(376, 16);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(25, 13);
            this.lblnit.TabIndex = 10;
            this.lblnit.Text = "NIT";
            // 
            // rtxtPatches
            // 
            this.rtxtPatches.Location = new System.Drawing.Point(574, 35);
            this.rtxtPatches.Name = "rtxtPatches";
            this.rtxtPatches.Size = new System.Drawing.Size(259, 354);
            this.rtxtPatches.TabIndex = 11;
            this.rtxtPatches.Text = "";
            // 
            // lblpatches
            // 
            this.lblpatches.AutoSize = true;
            this.lblpatches.Location = new System.Drawing.Point(669, 13);
            this.lblpatches.Name = "lblpatches";
            this.lblpatches.Size = new System.Drawing.Size(46, 13);
            this.lblpatches.TabIndex = 12;
            this.lblpatches.Text = "Patches";
            // 
            // btnRegedit
            // 
            this.btnRegedit.Location = new System.Drawing.Point(9, 429);
            this.btnRegedit.Name = "btnRegedit";
            this.btnRegedit.Size = new System.Drawing.Size(101, 35);
            this.btnRegedit.TabIndex = 13;
            this.btnRegedit.Text = "Regedit";
            this.btnRegedit.UseVisualStyleBackColor = true;
            this.btnRegedit.Click += new System.EventHandler(this.btnRegedit_Click);
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Location = new System.Drawing.Point(135, 429);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(93, 35);
            this.btnTaskManager.TabIndex = 14;
            this.btnTaskManager.Text = "Task Manager";
            this.btnTaskManager.UseVisualStyleBackColor = true;
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 485);
            this.Controls.Add(this.btnTaskManager);
            this.Controls.Add(this.btnRegedit);
            this.Controls.Add(this.lblpatches);
            this.Controls.Add(this.rtxtPatches);
            this.Controls.Add(this.lblnit);
            this.Controls.Add(this.gbMacAddress);
            this.Controls.Add(this.rtxtNit);
            this.Controls.Add(this.gbbalance);
            this.Controls.Add(this.gbDiskNumber);
            this.Controls.Add(this.gbSerialNumber);
            this.Controls.Add(this.btnAnalizar);
            this.Name = "Principal";
            this.Text = "Form1";
            this.gbSerialNumber.ResumeLayout(false);
            this.gbSerialNumber.PerformLayout();
            this.gbDiskNumber.ResumeLayout(false);
            this.gbbalance.ResumeLayout(false);
            this.gbbalance.PerformLayout();
            this.gbMacAddress.ResumeLayout(false);
            this.gbMacAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.GroupBox gbSerialNumber;
        private System.Windows.Forms.GroupBox gbDiskNumber;
        private System.Windows.Forms.GroupBox gbbalance;
        private System.Windows.Forms.Label lblprocesadores;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.RichTextBox rtxtNit;
        private System.Windows.Forms.GroupBox gbMacAddress;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.RichTextBox rtxtNumeroDiscos;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.RichTextBox rtxtPatches;
        private System.Windows.Forms.Label lblpatches;
        private System.Windows.Forms.Button btnRegedit;
        private System.Windows.Forms.Button btnTaskManager;
    }
}

