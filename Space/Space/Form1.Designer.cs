namespace Space
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sunLbl = new System.Windows.Forms.Label();
            this.mercLbl = new System.Windows.Forms.Label();
            this.venLbl = new System.Windows.Forms.Label();
            this.earthLbl = new System.Windows.Forms.Label();
            this.marsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sunLbl
            // 
            this.sunLbl.AutoSize = true;
            this.sunLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sunLbl.Font = new System.Drawing.Font("Bell MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.sunLbl.Location = new System.Drawing.Point(635, 158);
            this.sunLbl.Name = "sunLbl";
            this.sunLbl.Size = new System.Drawing.Size(93, 25);
            this.sunLbl.TabIndex = 0;
            this.sunLbl.Text = "Солнце";
            this.sunLbl.Click += new System.EventHandler(this.sunLbl_Click);
            // 
            // mercLbl
            // 
            this.mercLbl.AutoSize = true;
            this.mercLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mercLbl.Font = new System.Drawing.Font("Bell MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mercLbl.Location = new System.Drawing.Point(623, 188);
            this.mercLbl.Name = "mercLbl";
            this.mercLbl.Size = new System.Drawing.Size(120, 25);
            this.mercLbl.TabIndex = 1;
            this.mercLbl.Text = "Меркурий";
            this.mercLbl.Click += new System.EventHandler(this.mercLbl_Click);
            // 
            // venLbl
            // 
            this.venLbl.AutoSize = true;
            this.venLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.venLbl.Font = new System.Drawing.Font("Bell MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.venLbl.Location = new System.Drawing.Point(636, 218);
            this.venLbl.Name = "venLbl";
            this.venLbl.Size = new System.Drawing.Size(92, 25);
            this.venLbl.TabIndex = 2;
            this.venLbl.Text = "Венера";
            this.venLbl.Click += new System.EventHandler(this.venLbl_Click);
            // 
            // earthLbl
            // 
            this.earthLbl.AutoSize = true;
            this.earthLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.earthLbl.Font = new System.Drawing.Font("Bell MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earthLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.earthLbl.Location = new System.Drawing.Point(640, 248);
            this.earthLbl.Name = "earthLbl";
            this.earthLbl.Size = new System.Drawing.Size(80, 25);
            this.earthLbl.TabIndex = 3;
            this.earthLbl.Text = "Земля";
            this.earthLbl.Click += new System.EventHandler(this.earthLbl_Click);
            // 
            // marsLbl
            // 
            this.marsLbl.AutoSize = true;
            this.marsLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.marsLbl.Font = new System.Drawing.Font("Bell MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.marsLbl.Location = new System.Drawing.Point(647, 279);
            this.marsLbl.Name = "marsLbl";
            this.marsLbl.Size = new System.Drawing.Size(69, 25);
            this.marsLbl.TabIndex = 4;
            this.marsLbl.Text = "Марс";
            this.marsLbl.Click += new System.EventHandler(this.marsLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.marsLbl);
            this.Controls.Add(this.earthLbl);
            this.Controls.Add(this.venLbl);
            this.Controls.Add(this.mercLbl);
            this.Controls.Add(this.sunLbl);
            this.Name = "Form1";
            this.Text = "Space";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sunLbl;
        private System.Windows.Forms.Label mercLbl;
        private System.Windows.Forms.Label venLbl;
        private System.Windows.Forms.Label earthLbl;
        private System.Windows.Forms.Label marsLbl;
    }
}

