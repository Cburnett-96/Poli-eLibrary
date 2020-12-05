namespace Poli_eLibary
{
    partial class BorrowBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.close = new System.Windows.Forms.Button();
            this.studentid_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.Button();
            this.listborrow = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.currentdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(12, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 21);
            this.close.TabIndex = 35;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // studentid_textbox
            // 
            this.studentid_textbox.Enabled = false;
            this.studentid_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid_textbox.Location = new System.Drawing.Point(256, 126);
            this.studentid_textbox.Name = "studentid_textbox";
            this.studentid_textbox.Size = new System.Drawing.Size(130, 22);
            this.studentid_textbox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 84);
            this.label1.TabIndex = 42;
            this.label1.Text = "\r\nBook ID Number:\r\n\r\nCurrent Date:";
            // 
            // bookid
            // 
            this.bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(256, 167);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(130, 22);
            this.bookid.TabIndex = 43;
            this.bookid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(94, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 47);
            this.label3.TabIndex = 46;
            this.label3.Text = "Poli - eLibrary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(35, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 37);
            this.label4.TabIndex = 45;
            this.label4.Text = "Borrowing Book Information.";
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.Transparent;
            this.borrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrow.BackgroundImage")));
            this.borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrow.FlatAppearance.BorderSize = 0;
            this.borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow.Location = new System.Drawing.Point(90, 282);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(138, 50);
            this.borrow.TabIndex = 47;
            this.borrow.Text = "Borrow Book";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // listborrow
            // 
            this.listborrow.BackColor = System.Drawing.Color.Transparent;
            this.listborrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listborrow.BackgroundImage")));
            this.listborrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listborrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listborrow.FlatAppearance.BorderSize = 0;
            this.listborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listborrow.Location = new System.Drawing.Point(256, 282);
            this.listborrow.Name = "listborrow";
            this.listborrow.Size = new System.Drawing.Size(142, 50);
            this.listborrow.TabIndex = 48;
            this.listborrow.Text = "List of Borrow Books";
            this.toolTip1.SetToolTip(this.listborrow, "Only Authorized Personnel Can Access.");
            this.listborrow.UseVisualStyleBackColor = false;
            this.listborrow.Click += new System.EventHandler(this.listborrow_Click);
            // 
            // currentdate
            // 
            this.currentdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.currentdate.Location = new System.Drawing.Point(256, 209);
            this.currentdate.Name = "currentdate";
            this.currentdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentdate.Size = new System.Drawing.Size(130, 20);
            this.currentdate.TabIndex = 61;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 374);
            this.Controls.Add(this.currentdate);
            this.Controls.Add(this.listborrow);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentid_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBook";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox studentid_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button listborrow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker currentdate;
    }
}