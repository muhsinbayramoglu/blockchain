namespace Project_Hash
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHashInput = new System.Windows.Forms.TextBox();
            this.cmdHash = new System.Windows.Forms.Button();
            this.txtHashedValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlockNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNounce = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrev = new System.Windows.Forms.TextBox();
            this.btnKeys = new System.Windows.Forms.Button();
            this.richTxtKeys = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction";
            // 
            // txtHashInput
            // 
            this.txtHashInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtHashInput.Location = new System.Drawing.Point(86, 78);
            this.txtHashInput.Name = "txtHashInput";
            this.txtHashInput.Size = new System.Drawing.Size(251, 20);
            this.txtHashInput.TabIndex = 1;
            // 
            // cmdHash
            // 
            this.cmdHash.Location = new System.Drawing.Point(20, 138);
            this.cmdHash.Name = "cmdHash";
            this.cmdHash.Size = new System.Drawing.Size(75, 23);
            this.cmdHash.TabIndex = 2;
            this.cmdHash.Text = "hash it";
            this.cmdHash.UseVisualStyleBackColor = true;
            this.cmdHash.Click += new System.EventHandler(this.cmdHash_Click);
            // 
            // txtHashedValue
            // 
            this.txtHashedValue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHashedValue.Location = new System.Drawing.Point(116, 140);
            this.txtHashedValue.Name = "txtHashedValue";
            this.txtHashedValue.ReadOnly = true;
            this.txtHashedValue.Size = new System.Drawing.Size(638, 20);
            this.txtHashedValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Block#";
            // 
            // txtBlockNr
            // 
            this.txtBlockNr.BackColor = System.Drawing.SystemColors.Window;
            this.txtBlockNr.Location = new System.Drawing.Point(86, 24);
            this.txtBlockNr.Name = "txtBlockNr";
            this.txtBlockNr.Size = new System.Drawing.Size(65, 20);
            this.txtBlockNr.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nounce";
            // 
            // txtNounce
            // 
            this.txtNounce.BackColor = System.Drawing.SystemColors.Window;
            this.txtNounce.Location = new System.Drawing.Point(86, 52);
            this.txtNounce.Name = "txtNounce";
            this.txtNounce.Size = new System.Drawing.Size(65, 20);
            this.txtNounce.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Previous";
            // 
            // txtPrev
            // 
            this.txtPrev.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrev.Location = new System.Drawing.Point(86, 102);
            this.txtPrev.Name = "txtPrev";
            this.txtPrev.Size = new System.Drawing.Size(586, 20);
            this.txtPrev.TabIndex = 10;
            // 
            // btnKeys
            // 
            this.btnKeys.Location = new System.Drawing.Point(20, 287);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(75, 23);
            this.btnKeys.TabIndex = 11;
            this.btnKeys.Text = "Keys";
            this.btnKeys.UseVisualStyleBackColor = true;
            this.btnKeys.Click += new System.EventHandler(this.btnKeys_Click);
            // 
            // richTxtKeys
            // 
            this.richTxtKeys.Location = new System.Drawing.Point(116, 197);
            this.richTxtKeys.Name = "richTxtKeys";
            this.richTxtKeys.Size = new System.Drawing.Size(638, 164);
            this.richTxtKeys.TabIndex = 12;
            this.richTxtKeys.Text = "";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 421);
            this.Controls.Add(this.richTxtKeys);
            this.Controls.Add(this.btnKeys);
            this.Controls.Add(this.txtPrev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNounce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBlockNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHashedValue);
            this.Controls.Add(this.cmdHash);
            this.Controls.Add(this.txtHashInput);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "First Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHashInput;
        private System.Windows.Forms.Button cmdHash;
        private System.Windows.Forms.TextBox txtHashedValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBlockNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNounce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrev;
        private System.Windows.Forms.Button btnKeys;
        private System.Windows.Forms.RichTextBox richTxtKeys;
    }
}

