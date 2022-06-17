namespace bookstore
{
    partial class FormPatronHistory
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
            this.buttonHistoryOK = new System.Windows.Forms.Button();
            this.richTextBoxPatronHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonHistoryOK
            // 
            this.buttonHistoryOK.Location = new System.Drawing.Point(129, 327);
            this.buttonHistoryOK.Name = "buttonHistoryOK";
            this.buttonHistoryOK.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoryOK.TabIndex = 0;
            this.buttonHistoryOK.Text = "OK";
            this.buttonHistoryOK.UseVisualStyleBackColor = true;
            this.buttonHistoryOK.Click += new System.EventHandler(this.buttonHistoryOK_Click);
            // 
            // richTextBoxPatronHistory
            // 
            this.richTextBoxPatronHistory.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxPatronHistory.Name = "richTextBoxPatronHistory";
            this.richTextBoxPatronHistory.ReadOnly = true;
            this.richTextBoxPatronHistory.Size = new System.Drawing.Size(310, 309);
            this.richTextBoxPatronHistory.TabIndex = 1;
            this.richTextBoxPatronHistory.Text = "";
            // 
            // FormPatronHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.richTextBoxPatronHistory);
            this.Controls.Add(this.buttonHistoryOK);
            this.Name = "FormPatronHistory";
            this.ShowIcon = false;
            this.Text = "Patron History";
            this.Load += new System.EventHandler(this.FormPatronHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHistoryOK;
        private System.Windows.Forms.RichTextBox richTextBoxPatronHistory;
    }
}