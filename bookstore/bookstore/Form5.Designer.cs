namespace bookstore
{
    partial class FormPatronAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatronAdd));
            this.buttonPatronAdd = new System.Windows.Forms.Button();
            this.buttonPatronCancelEdit = new System.Windows.Forms.Button();
            this.textBoxPatronZipAdd = new System.Windows.Forms.TextBox();
            this.textBoxPatronStateAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatronTownAdd = new System.Windows.Forms.TextBox();
            this.textBoxPatronAddressAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatronFNameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatronEmailAdd = new System.Windows.Forms.TextBox();
            this.textBoxPatronPhoneAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPatronLNameAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPatronAdd
            // 
            this.buttonPatronAdd.Location = new System.Drawing.Point(42, 374);
            this.buttonPatronAdd.Name = "buttonPatronAdd";
            this.buttonPatronAdd.Size = new System.Drawing.Size(108, 36);
            this.buttonPatronAdd.TabIndex = 8;
            this.buttonPatronAdd.Text = "Add";
            this.buttonPatronAdd.UseVisualStyleBackColor = true;
            this.buttonPatronAdd.Click += new System.EventHandler(this.buttonPatronAdd_Click);
            // 
            // buttonPatronCancelEdit
            // 
            this.buttonPatronCancelEdit.Location = new System.Drawing.Point(215, 374);
            this.buttonPatronCancelEdit.Name = "buttonPatronCancelEdit";
            this.buttonPatronCancelEdit.Size = new System.Drawing.Size(108, 36);
            this.buttonPatronCancelEdit.TabIndex = 9;
            this.buttonPatronCancelEdit.Text = "Close";
            this.buttonPatronCancelEdit.UseVisualStyleBackColor = true;
            this.buttonPatronCancelEdit.Click += new System.EventHandler(this.buttonPatronCancelEdit_Click);
            // 
            // textBoxPatronZipAdd
            // 
            this.textBoxPatronZipAdd.Location = new System.Drawing.Point(156, 220);
            this.textBoxPatronZipAdd.Name = "textBoxPatronZipAdd";
            this.textBoxPatronZipAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronZipAdd.TabIndex = 5;
            // 
            // textBoxPatronStateAdd
            // 
            this.textBoxPatronStateAdd.Location = new System.Drawing.Point(156, 186);
            this.textBoxPatronStateAdd.Name = "textBoxPatronStateAdd";
            this.textBoxPatronStateAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronStateAdd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Zip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Town:";
            // 
            // textBoxPatronTownAdd
            // 
            this.textBoxPatronTownAdd.Location = new System.Drawing.Point(156, 145);
            this.textBoxPatronTownAdd.Name = "textBoxPatronTownAdd";
            this.textBoxPatronTownAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronTownAdd.TabIndex = 3;
            // 
            // textBoxPatronAddressAdd
            // 
            this.textBoxPatronAddressAdd.Location = new System.Drawing.Point(156, 104);
            this.textBoxPatronAddressAdd.Name = "textBoxPatronAddressAdd";
            this.textBoxPatronAddressAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronAddressAdd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name:";
            // 
            // textBoxPatronFNameAdd
            // 
            this.textBoxPatronFNameAdd.Location = new System.Drawing.Point(156, 29);
            this.textBoxPatronFNameAdd.Name = "textBoxPatronFNameAdd";
            this.textBoxPatronFNameAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronFNameAdd.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "State:";
            // 
            // textBoxPatronEmailAdd
            // 
            this.textBoxPatronEmailAdd.Location = new System.Drawing.Point(156, 297);
            this.textBoxPatronEmailAdd.Name = "textBoxPatronEmailAdd";
            this.textBoxPatronEmailAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronEmailAdd.TabIndex = 7;
            // 
            // textBoxPatronPhoneAdd
            // 
            this.textBoxPatronPhoneAdd.Location = new System.Drawing.Point(156, 260);
            this.textBoxPatronPhoneAdd.Name = "textBoxPatronPhoneAdd";
            this.textBoxPatronPhoneAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronPhoneAdd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email::";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Last Name:";
            // 
            // textBoxPatronLNameAdd
            // 
            this.textBoxPatronLNameAdd.Location = new System.Drawing.Point(156, 65);
            this.textBoxPatronLNameAdd.Name = "textBoxPatronLNameAdd";
            this.textBoxPatronLNameAdd.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatronLNameAdd.TabIndex = 1;
            // 
            // FormPatronAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 422);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPatronLNameAdd);
            this.Controls.Add(this.textBoxPatronEmailAdd);
            this.Controls.Add(this.textBoxPatronPhoneAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonPatronAdd);
            this.Controls.Add(this.buttonPatronCancelEdit);
            this.Controls.Add(this.textBoxPatronZipAdd);
            this.Controls.Add(this.textBoxPatronStateAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPatronTownAdd);
            this.Controls.Add(this.textBoxPatronAddressAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatronFNameAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatronAdd";
            this.ShowIcon = false;
            this.Text = "Add Patron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPatronAdd;
        private System.Windows.Forms.Button buttonPatronCancelEdit;
        private System.Windows.Forms.TextBox textBoxPatronZipAdd;
        private System.Windows.Forms.TextBox textBoxPatronStateAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPatronTownAdd;
        private System.Windows.Forms.TextBox textBoxPatronAddressAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatronFNameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPatronEmailAdd;
        private System.Windows.Forms.TextBox textBoxPatronPhoneAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPatronLNameAdd;
    }
}