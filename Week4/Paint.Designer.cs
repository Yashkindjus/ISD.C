namespace ISDWeek3
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.ColorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FillButton = new System.Windows.Forms.Button();
            this.colorFillDialog = new System.Windows.Forms.ColorDialog();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.PutImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ColorButton.Location = new System.Drawing.Point(574, 31);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(158, 78);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Select Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ClearButton.Location = new System.Drawing.Point(574, 115);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(157, 71);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BackColor = System.Drawing.SystemColors.Window;
            this.CanvasPanel.Location = new System.Drawing.Point(21, 31);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(536, 343);
            this.CanvasPanel.TabIndex = 2;
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            this.CanvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseMove);
            this.CanvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseUp);
            // 
            // FillButton
            // 
            this.FillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillButton.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FillButton.Location = new System.Drawing.Point(574, 191);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(157, 65);
            this.FillButton.TabIndex = 3;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openImageDialog";
            // 
            // PutImage
            // 
            this.PutImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PutImage.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PutImage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.PutImage.Location = new System.Drawing.Point(574, 262);
            this.PutImage.Name = "PutImage";
            this.PutImage.Size = new System.Drawing.Size(156, 73);
            this.PutImage.TabIndex = 4;
            this.PutImage.Text = "Put Image";
            this.PutImage.UseVisualStyleBackColor = true;
            this.PutImage.Click += new System.EventHandler(this.PutImage_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(743, 401);
            this.Controls.Add(this.PutImage);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ColorButton);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paint";
            this.Text = "Paint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.ColorDialog colorFillDialog;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Button PutImage;
    }
}

