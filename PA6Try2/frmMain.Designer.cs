namespace PA6Try2
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtCopiesData = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtLengthData = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtISBNData = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(258, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(262, 36);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(169, 29);
            this.txtTitleData.TabIndex = 1;
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(262, 94);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(169, 29);
            this.txtAuthorData.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(258, 67);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(262, 152);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(169, 29);
            this.txtGenreData.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(258, 125);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(63, 24);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // txtCopiesData
            // 
            this.txtCopiesData.Location = new System.Drawing.Point(262, 213);
            this.txtCopiesData.Name = "txtCopiesData";
            this.txtCopiesData.Size = new System.Drawing.Size(169, 29);
            this.txtCopiesData.TabIndex = 7;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(258, 186);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(150, 24);
            this.lblCopies.TabIndex = 6;
            this.lblCopies.Text = "Copies Avaliable";
            // 
            // txtLengthData
            // 
            this.txtLengthData.Location = new System.Drawing.Point(262, 335);
            this.txtLengthData.Name = "txtLengthData";
            this.txtLengthData.Size = new System.Drawing.Size(169, 29);
            this.txtLengthData.TabIndex = 9;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(258, 308);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 24);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length";
            // 
            // txtISBNData
            // 
            this.txtISBNData.Location = new System.Drawing.Point(262, 274);
            this.txtISBNData.Name = "txtISBNData";
            this.txtISBNData.Size = new System.Drawing.Size(169, 29);
            this.txtISBNData.TabIndex = 11;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(258, 247);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 24);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "ISBN";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 24;
            this.lstBooks.Location = new System.Drawing.Point(3, 22);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(253, 340);
            this.lstBooks.TabIndex = 12;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(437, 34);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(202, 249);
            this.pbCover.TabIndex = 13;
            this.pbCover.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(457, 299);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(83, 46);
            this.btnRent.TabIndex = 14;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(546, 299);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(83, 46);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(262, 378);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 33);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(355, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 33);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(448, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(542, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 33);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 439);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtISBNData);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtLengthData);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtCopiesData);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtCopiesData;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtLengthData;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtISBNData;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}