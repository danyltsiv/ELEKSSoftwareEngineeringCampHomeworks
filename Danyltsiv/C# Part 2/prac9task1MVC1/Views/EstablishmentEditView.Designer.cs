namespace prac9task1MVC1
{
    partial class EstablishmentEditView
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
            this.radioOpened = new System.Windows.Forms.RadioButton();
            this.radioClosed = new System.Windows.Forms.RadioButton();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblOpened = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioOpened
            // 
            this.radioOpened.AutoSize = true;
            this.radioOpened.Location = new System.Drawing.Point(75, 123);
            this.radioOpened.Name = "radioOpened";
            this.radioOpened.Size = new System.Drawing.Size(63, 17);
            this.radioOpened.TabIndex = 0;
            this.radioOpened.TabStop = true;
            this.radioOpened.Text = "Opened";
            this.radioOpened.UseVisualStyleBackColor = true;
            // 
            // radioClosed
            // 
            this.radioClosed.AutoSize = true;
            this.radioClosed.Location = new System.Drawing.Point(144, 123);
            this.radioClosed.Name = "radioClosed";
            this.radioClosed.Size = new System.Drawing.Size(57, 17);
            this.radioClosed.TabIndex = 1;
            this.radioClosed.TabStop = true;
            this.radioClosed.Text = "Closed";
            this.radioClosed.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(75, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 2;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(75, 48);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 3;
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(75, 87);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(100, 20);
            this.textRating.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(12, 90);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating";
            // 
            // lblOpened
            // 
            this.lblOpened.AutoSize = true;
            this.lblOpened.Location = new System.Drawing.Point(12, 125);
            this.lblOpened.Name = "lblOpened";
            this.lblOpened.Size = new System.Drawing.Size(45, 13);
            this.lblOpened.TabIndex = 8;
            this.lblOpened.Text = "Opened";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(29, 159);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 23);
            this.bntSave.TabIndex = 9;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EstablishmentEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 194);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.lblOpened);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.radioClosed);
            this.Controls.Add(this.radioOpened);
            this.Name = "EstablishmentEditView";
            this.Text = "EstablishmentEditView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioOpened;
        private System.Windows.Forms.RadioButton radioClosed;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblOpened;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button btnCancel;
    }
}