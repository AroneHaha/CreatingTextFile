namespace CreatingTextFile
{
    partial class OpenTextFile
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
            this.FindBtn = new System.Windows.Forms.Button();
            this.FindFileList = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find your file";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.FindBtn.ForeColor = System.Drawing.Color.White;
            this.FindBtn.Location = new System.Drawing.Point(212, 276);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(101, 28);
            this.FindBtn.TabIndex = 26;
            this.FindBtn.Text = "Open";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // FindFileList
            // 
            this.FindFileList.GridLines = true;
            this.FindFileList.HideSelection = false;
            this.FindFileList.Location = new System.Drawing.Point(23, 53);
            this.FindFileList.Name = "FindFileList";
            this.FindFileList.Size = new System.Drawing.Size(468, 214);
            this.FindFileList.TabIndex = 27;
            this.FindFileList.UseCompatibleStateImageBehavior = false;
            this.FindFileList.SelectedIndexChanged += new System.EventHandler(this.FindFileList_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RecordBtn
            // 
            this.RecordBtn.Location = new System.Drawing.Point(370, 23);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(121, 23);
            this.RecordBtn.TabIndex = 28;
            this.RecordBtn.Text = "Records";
            this.RecordBtn.UseVisualStyleBackColor = true;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // OpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 316);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.FindFileList);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.label1);
            this.Name = "OpenTextFile";
            this.Text = "OpenTextFile";
            this.Load += new System.EventHandler(this.OpenTextFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button RecordBtn;
        public System.Windows.Forms.ListView FindFileList;
    }
}