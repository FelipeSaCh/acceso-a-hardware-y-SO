namespace ComponentesIntegrados
{
    partial class taskmanager_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taskmanager_));
            this.lbitems = new System.Windows.Forms.ListBox();
            this.btnfinalizarTarea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbitems
            // 
            this.lbitems.FormattingEnabled = true;
            this.lbitems.Location = new System.Drawing.Point(12, 12);
            this.lbitems.Name = "lbitems";
            this.lbitems.Size = new System.Drawing.Size(284, 316);
            this.lbitems.TabIndex = 0;
            // 
            // btnfinalizarTarea
            // 
            this.btnfinalizarTarea.Location = new System.Drawing.Point(84, 342);
            this.btnfinalizarTarea.Name = "btnfinalizarTarea";
            this.btnfinalizarTarea.Size = new System.Drawing.Size(138, 23);
            this.btnfinalizarTarea.TabIndex = 1;
            this.btnfinalizarTarea.Text = "Finalizar tarea";
            this.btnfinalizarTarea.UseVisualStyleBackColor = true;
            this.btnfinalizarTarea.Click += new System.EventHandler(this.btnfinalizarTarea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // taskmanager_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnfinalizarTarea);
            this.Controls.Add(this.lbitems);
            this.Name = "taskmanager_";
            this.Text = "taskmanager_";
            this.Load += new System.EventHandler(this.taskmanager__Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbitems;
        private System.Windows.Forms.Button btnfinalizarTarea;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}