
namespace Classes
{
    partial class Form1
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.dgrwStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 20;
            this.lbxStudents.Location = new System.Drawing.Point(24, 77);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(120, 164);
            this.lbxStudents.TabIndex = 0;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dgrwStudents
            // 
            this.dgrwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwStudents.Location = new System.Drawing.Point(208, 77);
            this.dgrwStudents.Name = "dgrwStudents";
            this.dgrwStudents.Size = new System.Drawing.Size(441, 164);
            this.dgrwStudents.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrwStudents);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.DataGridView dgrwStudents;
    }
}

