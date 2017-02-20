namespace prac9task1MVC1
{
    partial class EstablishmentsView
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
            this.gridEstablishments = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn5random = new System.Windows.Forms.Button();
            this.btnRecalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstablishments)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEstablishments
            // 
            this.gridEstablishments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstablishments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridEstablishments.Location = new System.Drawing.Point(12, 76);
            this.gridEstablishments.Name = "gridEstablishments";
            this.gridEstablishments.Size = new System.Drawing.Size(511, 230);
            this.gridEstablishments.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(407, 38);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(116, 23);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Open/Close";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 325);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn5random
            // 
            this.btn5random.Location = new System.Drawing.Point(129, 325);
            this.btn5random.Name = "btn5random";
            this.btn5random.Size = new System.Drawing.Size(91, 23);
            this.btn5random.TabIndex = 6;
            this.btn5random.Text = "Add 5 random";
            this.btn5random.UseVisualStyleBackColor = true;
            this.btn5random.Click += new System.EventHandler(this.btn5random_Click);
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.Location = new System.Drawing.Point(254, 325);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(107, 23);
            this.btnRecalculate.TabIndex = 7;
            this.btnRecalculate.Text = "Recalculate Rating";
            this.btnRecalculate.UseVisualStyleBackColor = true;
            this.btnRecalculate.Click += new System.EventHandler(this.btnRecalculate_Click);
            // 
            // EstablishmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 408);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.btn5random);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridEstablishments);
            this.Name = "EstablishmentsView";
            this.Text = "EstablishmentsView";
            ((System.ComponentModel.ISupportInitialize)(this.gridEstablishments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEstablishments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn5random;
        private System.Windows.Forms.Button btnRecalculate;
    }
}