namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.btnSearchByAuthor = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lbLibrary = new System.Windows.Forms.ListBox();
            this.lbSearchByTitle = new System.Windows.Forms.Label();
            this.txtSearchByTitle = new System.Windows.Forms.TextBox();
            this.lbSearchByAuthor = new System.Windows.Forms.Label();
            this.txtSearchByAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(66, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(97, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(66, 60);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(97, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(66, 86);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(97, 20);
            this.txtYear.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Назва";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(21, 114);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(142, 23);
            this.AddBook.TabIndex = 9;
            this.AddBook.Text = "Додати книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.Location = new System.Drawing.Point(21, 229);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(142, 23);
            this.btnSearchByTitle.TabIndex = 10;
            this.btnSearchByTitle.Text = "Пошук за назвою";
            this.btnSearchByTitle.UseVisualStyleBackColor = true;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);
            // 
            // btnSearchByAuthor
            // 
            this.btnSearchByAuthor.Location = new System.Drawing.Point(21, 284);
            this.btnSearchByAuthor.Name = "btnSearchByAuthor";
            this.btnSearchByAuthor.Size = new System.Drawing.Size(142, 23);
            this.btnSearchByAuthor.TabIndex = 11;
            this.btnSearchByAuthor.Text = "Пошук за автором";
            this.btnSearchByAuthor.UseVisualStyleBackColor = true;
            this.btnSearchByAuthor.Click += new System.EventHandler(this.btnSearchByAuthor_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.Location = new System.Drawing.Point(21, 322);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(142, 23);
            this.btnShowAllBooks.TabIndex = 12;
            this.btnShowAllBooks.Text = "Показати всі книги";
            this.btnShowAllBooks.UseVisualStyleBackColor = true;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(21, 143);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveBook.TabIndex = 13;
            this.btnRemoveBook.Text = "Видалити книгу";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Зберегти ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Рік";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(66, 8);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(97, 20);
            this.txtISBN.TabIndex = 18;
            // 
            // lbLibrary
            // 
            this.lbLibrary.FormattingEnabled = true;
            this.lbLibrary.Location = new System.Drawing.Point(175, 8);
            this.lbLibrary.Name = "lbLibrary";
            this.lbLibrary.Size = new System.Drawing.Size(240, 433);
            this.lbLibrary.TabIndex = 20;
            this.lbLibrary.SelectedIndexChanged += new System.EventHandler(this.library_SelectedIndexChanged);
            // 
            // lbSearchByTitle
            // 
            this.lbSearchByTitle.AutoSize = true;
            this.lbSearchByTitle.Location = new System.Drawing.Point(20, 206);
            this.lbSearchByTitle.Name = "lbSearchByTitle";
            this.lbSearchByTitle.Size = new System.Drawing.Size(39, 13);
            this.lbSearchByTitle.TabIndex = 22;
            this.lbSearchByTitle.Text = "Назва";
            // 
            // txtSearchByTitle
            // 
            this.txtSearchByTitle.Location = new System.Drawing.Point(66, 203);
            this.txtSearchByTitle.Name = "txtSearchByTitle";
            this.txtSearchByTitle.Size = new System.Drawing.Size(97, 20);
            this.txtSearchByTitle.TabIndex = 21;
            // 
            // lbSearchByAuthor
            // 
            this.lbSearchByAuthor.AutoSize = true;
            this.lbSearchByAuthor.Location = new System.Drawing.Point(20, 261);
            this.lbSearchByAuthor.Name = "lbSearchByAuthor";
            this.lbSearchByAuthor.Size = new System.Drawing.Size(37, 13);
            this.lbSearchByAuthor.TabIndex = 24;
            this.lbSearchByAuthor.Text = "Автор";
            // 
            // txtSearchByAuthor
            // 
            this.txtSearchByAuthor.Location = new System.Drawing.Point(66, 258);
            this.txtSearchByAuthor.Name = "txtSearchByAuthor";
            this.txtSearchByAuthor.Size = new System.Drawing.Size(97, 20);
            this.txtSearchByAuthor.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.lbSearchByAuthor);
            this.Controls.Add(this.txtSearchByAuthor);
            this.Controls.Add(this.lbSearchByTitle);
            this.Controls.Add(this.txtSearchByTitle);
            this.Controls.Add(this.lbLibrary);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnSearchByAuthor);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.Button btnSearchByAuthor;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ListBox lbLibrary;
        private System.Windows.Forms.Label lbSearchByTitle;
        private System.Windows.Forms.TextBox txtSearchByTitle;
        private System.Windows.Forms.Label lbSearchByAuthor;
        private System.Windows.Forms.TextBox txtSearchByAuthor;
    }
}

