namespace ParserApp
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
            this.primariPageTxtBox = new System.Windows.Forms.TextBox();
            this.EndPageTxtBox = new System.Windows.Forms.TextBox();
            this.UrlTxtBox = new System.Windows.Forms.TextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primariPageTxtBox
            // 
            this.primariPageTxtBox.Location = new System.Drawing.Point(38, 48);
            this.primariPageTxtBox.Name = "primariPageTxtBox";
            this.primariPageTxtBox.Size = new System.Drawing.Size(100, 20);
            this.primariPageTxtBox.TabIndex = 0;
            this.primariPageTxtBox.Text = "1";
            // 
            // EndPageTxtBox
            // 
            this.EndPageTxtBox.Location = new System.Drawing.Point(38, 101);
            this.EndPageTxtBox.Name = "EndPageTxtBox";
            this.EndPageTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EndPageTxtBox.TabIndex = 1;
            this.EndPageTxtBox.Text = "1";
            // 
            // UrlTxtBox
            // 
            this.UrlTxtBox.Location = new System.Drawing.Point(164, 12);
            this.UrlTxtBox.Name = "UrlTxtBox";
            this.UrlTxtBox.Size = new System.Drawing.Size(363, 20);
            this.UrlTxtBox.TabIndex = 2;
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(164, 48);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(363, 343);
            this.rtb_output.TabIndex = 3;
            this.rtb_output.Text = "";
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(38, 128);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(100, 37);
            this.btn_go.TabIndex = 4;
            this.btn_go.Text = "Gooo!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 403);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.UrlTxtBox);
            this.Controls.Add(this.EndPageTxtBox);
            this.Controls.Add(this.primariPageTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox primariPageTxtBox;
        private System.Windows.Forms.TextBox EndPageTxtBox;
        private System.Windows.Forms.TextBox UrlTxtBox;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Button btn_go;
    }
}

