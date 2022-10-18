namespace CRUD_App
{
    partial class StudentDetails
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.classtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(186, 111);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlabel.Location = new System.Drawing.Point(186, 157);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(77, 25);
            this.Genderlabel.TabIndex = 2;
            this.Genderlabel.Text = "Gender";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(186, 207);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(48, 25);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Age";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(186, 256);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(62, 25);
            this.ClassLabel.TabIndex = 4;
            this.ClassLabel.Text = "Class";
            this.ClassLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(322, 111);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(171, 30);
            this.nametxt.TabIndex = 5;
            // 
            // classtxt
            // 
            this.classtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classtxt.Location = new System.Drawing.Point(322, 251);
            this.classtxt.Name = "classtxt";
            this.classtxt.Size = new System.Drawing.Size(171, 30);
            this.classtxt.TabIndex = 6;
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.Location = new System.Drawing.Point(322, 204);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(171, 30);
            this.agetxt.TabIndex = 7;
            // 
            // gendertxt
            // 
            this.gendertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertxt.Location = new System.Drawing.Point(322, 157);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(171, 30);
            this.gendertxt.TabIndex = 8;
            // 
            // insertbtn
            // 
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(122, 304);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(88, 37);
            this.insertbtn.TabIndex = 9;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(288, 304);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(109, 37);
            this.Updatebtn.TabIndex = 10;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(436, 304);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(88, 37);
            this.Deletebtn.TabIndex = 11;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Location = new System.Drawing.Point(588, 304);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(88, 37);
            this.Clearbtn.TabIndex = 12;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 285);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 678);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.gendertxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.classtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.Genderlabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Name = "StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox classtxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

