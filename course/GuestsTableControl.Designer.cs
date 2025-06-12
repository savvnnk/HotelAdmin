namespace course
{
    partial class GuestsTableControl
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

        // Fixing the error CS0102 by renaming the duplicate field "GuestName" to "GuestNameColumn".  

        private void InitializeComponent()
        {
            this.dataGridView_Guests = new System.Windows.Forms.DataGridView();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteTxtButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Guests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Guests
            // 
            this.dataGridView_Guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Guests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameRoom,
            this.GuestNameColumn,
            this.Surname,
            this.Phone,
            this.CheckInDate,
            this.LeaveDate,
            this.CheckInTime,
            this.LeaveTime,
            this.Price,
            this.PassportNum,
            this.Status,
            this.NoteTxtButton});
            this.dataGridView_Guests.Location = new System.Drawing.Point(15, 13);
            this.dataGridView_Guests.Name = "dataGridView_Guests";
            this.dataGridView_Guests.RowHeadersWidth = 51;
            this.dataGridView_Guests.RowTemplate.Height = 24;
            this.dataGridView_Guests.Size = new System.Drawing.Size(1187, 527);
            this.dataGridView_Guests.TabIndex = 0;
            // 
            // NameRoom
            // 
            this.NameRoom.HeaderText = "Номер";
            this.NameRoom.MinimumWidth = 6;
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.Width = 125;
            // 
            // GuestNameColumn
            // 
            this.GuestNameColumn.HeaderText = "Ім\'я";
            this.GuestNameColumn.MinimumWidth = 6;
            this.GuestNameColumn.Name = "GuestNameColumn";
            this.GuestNameColumn.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Прізвище";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Номер телефону";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // CheckInDate
            // 
            this.CheckInDate.HeaderText = "Дата заїзду";
            this.CheckInDate.MinimumWidth = 6;
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Width = 125;
            // 
            // LeaveDate
            // 
            this.LeaveDate.HeaderText = "Дата відїзду";
            this.LeaveDate.MinimumWidth = 6;
            this.LeaveDate.Name = "LeaveDate";
            this.LeaveDate.Width = 125;
            // 
            // CheckInTime
            // 
            this.CheckInTime.HeaderText = "Час заїзду";
            this.CheckInTime.MinimumWidth = 6;
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Width = 125;
            // 
            // LeaveTime
            // 
            this.LeaveTime.HeaderText = "Час виїзду";
            this.LeaveTime.MinimumWidth = 6;
            this.LeaveTime.Name = "LeaveTime";
            this.LeaveTime.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "До сплати";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // PassportNum
            // 
            this.PassportNum.HeaderText = "Паспортні дані";
            this.PassportNum.MinimumWidth = 6;
            this.PassportNum.Name = "PassportNum";
            this.PassportNum.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // NoteTxtButton
            // 
            this.NoteTxtButton.HeaderText = "Квитанція";
            this.NoteTxtButton.MinimumWidth = 6;
            this.NoteTxtButton.Name = "NoteTxtButton";
            this.NoteTxtButton.Text = "Отримати квитанцію";
            this.NoteTxtButton.UseColumnTextForButtonValue = true;
            this.NoteTxtButton.Width = 125;
            // 
            // GuestsTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_Guests);
            this.Name = "GuestsTableControl";
            this.Size = new System.Drawing.Size(1220, 556);
            this.Load += new System.EventHandler(this.GuestsTableControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Guests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn NoteTxtButton;
    }
}
