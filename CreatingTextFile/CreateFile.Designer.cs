namespace CreatingTextFile
{
    partial class CreateFile
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
            this.contentTxt = new System.Windows.Forms.RichTextBox();
            this.filenameTxt = new System.Windows.Forms.TextBox();
            this.haha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTxt
            // 
            this.contentTxt.BackColor = System.Drawing.Color.White;
            this.contentTxt.Location = new System.Drawing.Point(12, 164);
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(390, 409);
            this.contentTxt.TabIndex = 0;
            this.contentTxt.Text = "";
            // 
            // filenameTxt
            // 
            this.filenameTxt.BackColor = System.Drawing.Color.White;
            this.filenameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filenameTxt.Location = new System.Drawing.Point(12, 100);
            this.filenameTxt.Name = "filenameTxt";
            this.filenameTxt.Size = new System.Drawing.Size(213, 23);
            this.filenameTxt.TabIndex = 1;
            // 
            // haha
            // 
            this.haha.AutoSize = true;
            this.haha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haha.Location = new System.Drawing.Point(8, 77);
            this.haha.Name = "haha";
            this.haha.Size = new System.Drawing.Size(123, 20);
            this.haha.TabIndex = 2;
            this.haha.Text = "Enter File Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(84, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create New Text File";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 61);
            this.panel1.TabIndex = 5;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(307, 582);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(97, 38);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(208, 582);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(97, 38);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(283, 138);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(121, 23);
            this.OpenFileBtn.TabIndex = 8;
            this.OpenFileBtn.Text = "Open File";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // CreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(414, 629);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haha);
            this.Controls.Add(this.filenameTxt);
            this.Controls.Add(this.contentTxt);
            this.Name = "CreateFile";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentTxt;
        private System.Windows.Forms.TextBox filenameTxt;
        private System.Windows.Forms.Label haha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button OpenFileBtn;
    }
}

