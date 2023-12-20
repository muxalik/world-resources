namespace world_resources
{
    partial class ResourcePage
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
            this.resourcesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.countriesButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.resourcesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesDataSet = new world_resources.resourcesDataSet();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcesButton
            // 
            this.resourcesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resourcesButton.FlatAppearance.BorderSize = 0;
            this.resourcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resourcesButton.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.resourcesButton.Location = new System.Drawing.Point(165, 12);
            this.resourcesButton.Name = "resourcesButton";
            this.resourcesButton.Size = new System.Drawing.Size(112, 40);
            this.resourcesButton.TabIndex = 0;
            this.resourcesButton.Text = "Ресурсы";
            this.resourcesButton.UseVisualStyleBackColor = false;
            this.resourcesButton.Click += new System.EventHandler(this.resourcesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.usersButton.Location = new System.Drawing.Point(544, 12);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(174, 40);
            this.usersButton.TabIndex = 1;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // countriesButton
            // 
            this.countriesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countriesButton.FlatAppearance.BorderSize = 0;
            this.countriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countriesButton.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.countriesButton.Location = new System.Drawing.Point(283, 12);
            this.countriesButton.Name = "countriesButton";
            this.countriesButton.Size = new System.Drawing.Size(104, 40);
            this.countriesButton.TabIndex = 2;
            this.countriesButton.Text = "Страны";
            this.countriesButton.UseVisualStyleBackColor = false;
            this.countriesButton.Click += new System.EventHandler(this.countriesButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.historyButton.Location = new System.Drawing.Point(393, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(145, 40);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "Статистика";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::world_resources.Properties.Resources.close;
            this.pictureBox4.Location = new System.Drawing.Point(838, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // resourcesDataSetBindingSource
            // 
            this.resourcesDataSetBindingSource.DataSource = this.resourcesDataSet;
            this.resourcesDataSetBindingSource.Position = 0;
            // 
            // resourcesDataSet
            // 
            this.resourcesDataSet.DataSetName = "resourcesDataSet";
            this.resourcesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(12, 131);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(866, 428);
            this.sfDataGrid1.TabIndex = 10;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.button1.Location = new System.Drawing.Point(14, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.button2.Location = new System.Drawing.Point(132, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResourcePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.countriesButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.resourcesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResourcePage";
            this.Text = "Панель управления";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourcePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourcePage_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resourcesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button countriesButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.BindingSource resourcesDataSetBindingSource;
        private resourcesDataSet resourcesDataSet;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}