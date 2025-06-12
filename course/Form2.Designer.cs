namespace course
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_view = new System.Windows.Forms.Button();
            this.label_SearchG = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_NewRoom = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogOut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogOut.Image")));
            this.pictureBoxLogOut.Location = new System.Drawing.Point(1105, 22);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(87, 31);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogOut.TabIndex = 0;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1118, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Log out";
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(27, 22);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(298, 20);
            this.label_Search.TabIndex = 2;
            this.label_Search.Text = "Пошук номера (за назвою номеру)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_view
            // 
            this.button_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_view.Location = new System.Drawing.Point(910, 22);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(189, 68);
            this.button_view.TabIndex = 4;
            this.button_view.Text = "Переглянути бронювання та зайняті номери";
            this.button_view.UseCompatibleTextRendering = true;
            this.button_view.UseMnemonic = false;
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // label_SearchG
            // 
            this.label_SearchG.AutoSize = true;
            this.label_SearchG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SearchG.Location = new System.Drawing.Point(340, 22);
            this.label_SearchG.Name = "label_SearchG";
            this.label_SearchG.Size = new System.Drawing.Size(292, 20);
            this.label_SearchG.TabIndex = 5;
            this.label_SearchG.Text = "Пошук гостя (за ім\'ям/прізвищем)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_NewRoom
            // 
            this.button_NewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NewRoom.Location = new System.Drawing.Point(1042, 182);
            this.button_NewRoom.Name = "button_NewRoom";
            this.button_NewRoom.Size = new System.Drawing.Size(161, 67);
            this.button_NewRoom.TabIndex = 7;
            this.button_NewRoom.Text = "Створити номер";
            this.button_NewRoom.UseVisualStyleBackColor = true;
            this.button_NewRoom.Click += new System.EventHandler(this.button_NewRoom_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel.Location = new System.Drawing.Point(31, 170);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(966, 457);
            this.flowLayoutPanel.TabIndex = 8;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(28, 452);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(638, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пошук заброньованих номерів";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(642, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 639);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.button_NewRoom);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_SearchG);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxLogOut);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Адміністратор готелю";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Label label_SearchG;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_NewRoom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}