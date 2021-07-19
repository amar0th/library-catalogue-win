
namespace LibraryCatalogue
{
    partial class LibraryCatalogue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.category = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автор";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(68, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(68, 45);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заглавие";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(73, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(298, 20);
            this.title.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.category);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(205, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Категория";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(27, 19);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(100, 20);
            this.category.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.genre);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(364, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 106);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Жанр";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(27, 19);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 20);
            this.genre.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.publisher);
            this.groupBox4.Location = new System.Drawing.Point(523, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 106);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Издателство";
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(6, 19);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(237, 20);
            this.publisher.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Година";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(437, 21);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(80, 20);
            this.year.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(616, 173);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 14;
            this.submit.Text = "Запази";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(697, 173);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 15;
            this.clear.Text = "Изчисти";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(616, 202);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(156, 55);
            this.showAll.TabIndex = 16;
            this.showAll.Text = "Покажи всички книги";
            this.showAll.UseVisualStyleBackColor = true;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning.Location = new System.Drawing.Point(154, 202);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(75, 20);
            this.warning.TabIndex = 12;
            this.warning.Text = "Warning";
            this.warning.Visible = false;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(155, 202);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(77, 20);
            this.success.TabIndex = 13;
            this.success.Text = "Success";
            this.success.Visible = false;
            // 
            // LibraryCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 272);
            this.Controls.Add(this.success);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibraryCatalogue";
            this.Text = "Library Catalogue";
            this.Load += new System.EventHandler(this.LibraryCatalogue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label success;
    }
}

