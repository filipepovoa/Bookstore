namespace bookstore
{
    partial class FormBookHistory
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
            this.buttonHistoryOK2 = new System.Windows.Forms.Button();
            this.richTextBoxBookHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonHistoryOK2
            // 
            this.buttonHistoryOK2.Location = new System.Drawing.Point(130, 327);
            this.buttonHistoryOK2.Name = "buttonHistoryOK2";
            this.buttonHistoryOK2.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoryOK2.TabIndex = 0;
            this.buttonHistoryOK2.Text = "OK";
            this.buttonHistoryOK2.UseVisualStyleBackColor = true;
            this.buttonHistoryOK2.Click += new System.EventHandler(this.buttonHistoryOK2_Click);
            // 
            // richTextBoxBookHistory
            // 
            this.richTextBoxBookHistory.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxBookHistory.Name = "richTextBoxBookHistory";
            this.richTextBoxBookHistory.ReadOnly = true;
            this.richTextBoxBookHistory.Size = new System.Drawing.Size(310, 309);
            this.richTextBoxBookHistory.TabIndex = 1;
            this.richTextBoxBookHistory.Text = "";
            // 
            // FormBookHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.richTextBoxBookHistory);
            this.Controls.Add(this.buttonHistoryOK2);
            this.Name = "FormBookHistory";
            this.ShowIcon = false;
            this.Text = "Book History";
            this.Load += new System.EventHandler(this.FormBookHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHistoryOK2;
        private System.Windows.Forms.RichTextBox richTextBoxBookHistory;
    }
}