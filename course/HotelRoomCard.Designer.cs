namespace course
{
    partial class HotelRoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.label_amo = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_view = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.button_book = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(424, 31);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "label1";
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.Location = new System.Drawing.Point(24, 31);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(375, 222);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoom.TabIndex = 2;
            this.pictureBoxRoom.TabStop = false;
            // 
            // label_amo
            // 
            this.label_amo.AutoSize = true;
            this.label_amo.Location = new System.Drawing.Point(424, 65);
            this.label_amo.Name = "label_amo";
            this.label_amo.Size = new System.Drawing.Size(44, 16);
            this.label_amo.TabIndex = 3;
            this.label_amo.Text = "label1";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(730, 48);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(44, 16);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "label1";
            // 
            // label_view
            // 
            this.label_view.AutoSize = true;
            this.label_view.Location = new System.Drawing.Point(424, 100);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(44, 16);
            this.label_view.TabIndex = 5;
            this.label_view.Text = "label2";
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(427, 137);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.Size = new System.Drawing.Size(347, 116);
            this.textBox_info.TabIndex = 6;
            // 
            // button_book
            // 
            this.button_book.Location = new System.Drawing.Point(589, 306);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(202, 44);
            this.button_book.TabIndex = 7;
            this.button_book.Text = "Забронювати";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(319, 306);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(202, 44);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Редагувати";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(46, 306);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(202, 44);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // HotelRoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label_view);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_amo);
            this.Controls.Add(this.pictureBoxRoom);
            this.Controls.Add(this.label_name);
            this.Name = "HotelRoomCard";
            this.Size = new System.Drawing.Size(851, 386);
            this.Load += new System.EventHandler(this.HotelRoomCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.Label label_amo;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_Delete;
    }
}
