namespace course
{
    partial class CreateRoom
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
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.pictureBox_Room = new System.Windows.Forms.PictureBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_square = new System.Windows.Forms.TextBox();
            this.textBox_view = new System.Windows.Forms.TextBox();
            this.button_AddPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(425, 143);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(347, 116);
            this.textBox_info.TabIndex = 12;
            // 
            // pictureBox_Room
            // 
            this.pictureBox_Room.Location = new System.Drawing.Point(24, 37);
            this.pictureBox_Room.Name = "pictureBox_Room";
            this.pictureBox_Room.Size = new System.Drawing.Size(375, 222);
            this.pictureBox_Room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Room.TabIndex = 8;
            this.pictureBox_Room.TabStop = false;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(658, 293);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(143, 56);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = " Зберегти";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(701, 52);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 22);
            this.textBox_price.TabIndex = 14;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(425, 26);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 15;
            // 
            // textBox_square
            // 
            this.textBox_square.Location = new System.Drawing.Point(425, 68);
            this.textBox_square.Name = "textBox_square";
            this.textBox_square.Size = new System.Drawing.Size(100, 22);
            this.textBox_square.TabIndex = 16;
            // 
            // textBox_view
            // 
            this.textBox_view.Location = new System.Drawing.Point(425, 106);
            this.textBox_view.Name = "textBox_view";
            this.textBox_view.Size = new System.Drawing.Size(100, 22);
            this.textBox_view.TabIndex = 17;
            // 
            // button_AddPhoto
            // 
            this.button_AddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddPhoto.Location = new System.Drawing.Point(274, 265);
            this.button_AddPhoto.Name = "button_AddPhoto";
            this.button_AddPhoto.Size = new System.Drawing.Size(125, 32);
            this.button_AddPhoto.TabIndex = 18;
            this.button_AddPhoto.Text = "Додати фото";
            this.button_AddPhoto.UseVisualStyleBackColor = true;
            this.button_AddPhoto.Click += new System.EventHandler(this.button_AddPhoto_Click);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(844, 386);
            this.Controls.Add(this.button_AddPhoto);
            this.Controls.Add(this.textBox_view);
            this.Controls.Add(this.textBox_square);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.pictureBox_Room);
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.Load += new System.EventHandler(this.CreateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.PictureBox pictureBox_Room;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_square;
        private System.Windows.Forms.TextBox textBox_view;
        private System.Windows.Forms.Button button_AddPhoto;
        private System.Windows.Forms.TextBox textBox_name;
    }
}