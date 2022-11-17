namespace InformSystem
{
    partial class MainForm
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
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtGmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSeach = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.insearchpos = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ПІБ:";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(177, 89);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(206, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Hint = "";
            this.txtPhoneNumber.Location = new System.Drawing.Point(177, 131);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.Size = new System.Drawing.Size(206, 23);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.TabStop = false;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 131);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(132, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Номер телефону:";
            // 
            // txtGmail
            // 
            this.txtGmail.Depth = 0;
            this.txtGmail.Hint = "";
            this.txtGmail.Location = new System.Drawing.Point(177, 176);
            this.txtGmail.MaxLength = 32767;
            this.txtGmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.PasswordChar = '\0';
            this.txtGmail.SelectedText = "";
            this.txtGmail.SelectionLength = 0;
            this.txtGmail.SelectionStart = 0;
            this.txtGmail.Size = new System.Drawing.Size(206, 23);
            this.txtGmail.TabIndex = 5;
            this.txtGmail.TabStop = false;
            this.txtGmail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 176);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Gmail:";
            // 
            // txtAdress
            // 
            this.txtAdress.Depth = 0;
            this.txtAdress.Hint = "";
            this.txtAdress.Location = new System.Drawing.Point(177, 229);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.SelectedText = "";
            this.txtAdress.SelectionLength = 0;
            this.txtAdress.SelectionStart = 0;
            this.txtAdress.Size = new System.Drawing.Size(206, 23);
            this.txtAdress.TabIndex = 7;
            this.txtAdress.TabStop = false;
            this.txtAdress.UseSystemPasswordChar = false;
            this.txtAdress.Click += new System.EventHandler(this.txtAdress_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 233);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Адреса:";
            // 
            // txtSeach
            // 
            this.txtSeach.Depth = 0;
            this.txtSeach.Hint = "";
            this.txtSeach.Location = new System.Drawing.Point(105, 371);
            this.txtSeach.MaxLength = 32767;
            this.txtSeach.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.PasswordChar = '\0';
            this.txtSeach.SelectedText = "";
            this.txtSeach.SelectionLength = 0;
            this.txtSeach.SelectionStart = 0;
            this.txtSeach.Size = new System.Drawing.Size(452, 23);
            this.txtSeach.TabIndex = 9;
            this.txtSeach.TabStop = false;
            this.txtSeach.UseSystemPasswordChar = false;
            this.txtSeach.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 375);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(60, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Пошук:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 412);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(585, 174);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.Icon = null;
            this.ButtonSave.Location = new System.Drawing.Point(500, 595);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Primary = false;
            this.ButtonSave.Size = new System.Drawing.Size(88, 36);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Зберегти";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Icon = null;
            this.ButtonCancel.Location = new System.Drawing.Point(396, 595);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = false;
            this.ButtonCancel.Size = new System.Drawing.Size(96, 36);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Видалити";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEdit.Depth = 0;
            this.ButtonEdit.Icon = null;
            this.ButtonEdit.Location = new System.Drawing.Point(305, 595);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Primary = false;
            this.ButtonEdit.Size = new System.Drawing.Size(83, 36);
            this.ButtonEdit.TabIndex = 13;
            this.ButtonEdit.Text = "Змінити";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.AutoSize = true;
            this.ButtonNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNew.Depth = 0;
            this.ButtonNew.Icon = null;
            this.ButtonNew.Location = new System.Drawing.Point(229, 595);
            this.ButtonNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Primary = false;
            this.ButtonNew.Size = new System.Drawing.Size(68, 36);
            this.ButtonNew.TabIndex = 14;
            this.ButtonNew.Text = "Новий";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // insearchpos
            // 
            this.insearchpos.AutoSize = true;
            this.insearchpos.Depth = 0;
            this.insearchpos.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insearchpos.Location = new System.Drawing.Point(25, 323);
            this.insearchpos.Margin = new System.Windows.Forms.Padding(0);
            this.insearchpos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.insearchpos.MouseState = MaterialSkin.MouseState.HOVER;
            this.insearchpos.Name = "insearchpos";
            this.insearchpos.Ripple = true;
            this.insearchpos.Size = new System.Drawing.Size(139, 30);
            this.insearchpos.TabIndex = 15;
            this.insearchpos.Text = "У пошуку роботи";
            this.insearchpos.UseVisualStyleBackColor = true;
            this.insearchpos.CheckedChanged += new System.EventHandler(this.insearchpos_CheckedChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(25, 284);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 16;
            this.materialLabel6.Text = "Посада:";
            // 
            // txtpos
            // 
            this.txtpos.Depth = 0;
            this.txtpos.Hint = "";
            this.txtpos.Location = new System.Drawing.Point(162, 280);
            this.txtpos.MaxLength = 32767;
            this.txtpos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpos.Name = "txtpos";
            this.txtpos.PasswordChar = '\0';
            this.txtpos.SelectedText = "";
            this.txtpos.SelectionLength = 0;
            this.txtpos.SelectionStart = 0;
            this.txtpos.Size = new System.Drawing.Size(244, 23);
            this.txtpos.TabIndex = 17;
            this.txtpos.TabStop = false;
            this.txtpos.UseSystemPasswordChar = false;
            this.txtpos.Click += new System.EventHandler(this.txtpos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 659);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.insearchpos);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdress;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSeach;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialFlatButton ButtonSave;
        private MaterialSkin.Controls.MaterialFlatButton ButtonCancel;
        private MaterialSkin.Controls.MaterialFlatButton ButtonEdit;
        private MaterialSkin.Controls.MaterialFlatButton ButtonNew;
        private MaterialSkin.Controls.MaterialCheckBox insearchpos;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpos;
    }
}