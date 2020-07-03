namespace BikesParking
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.SortById_button = new System.Windows.Forms.Button();
            this.SortByAddrbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid.Location = new System.Drawing.Point(185, 1);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(614, 449);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // SortById_button
            // 
            this.SortById_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SortById_button.BackColor = System.Drawing.Color.Transparent;
            this.SortById_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.SortById_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SortById_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortById_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortById_button.ForeColor = System.Drawing.Color.White;
            this.SortById_button.Location = new System.Drawing.Point(2, 402);
            this.SortById_button.Name = "SortById_button";
            this.SortById_button.Size = new System.Drawing.Size(177, 36);
            this.SortById_button.TabIndex = 12;
            this.SortById_button.Tag = "";
            this.SortById_button.Text = "Sort By ID";
            this.SortById_button.UseCompatibleTextRendering = true;
            this.SortById_button.UseVisualStyleBackColor = false;
            this.SortById_button.Click += new System.EventHandler(this.SortById_button_Click);
            this.SortById_button.MouseEnter += new System.EventHandler(this.SortById_button_MouseEnter);
            this.SortById_button.MouseLeave += new System.EventHandler(this.SortById_button_MouseLeave);
            // 
            // SortByAddrbutton1
            // 
            this.SortByAddrbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SortByAddrbutton1.BackColor = System.Drawing.Color.Transparent;
            this.SortByAddrbutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.SortByAddrbutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SortByAddrbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByAddrbutton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByAddrbutton1.ForeColor = System.Drawing.Color.White;
            this.SortByAddrbutton1.Location = new System.Drawing.Point(2, 360);
            this.SortByAddrbutton1.Name = "SortByAddrbutton1";
            this.SortByAddrbutton1.Size = new System.Drawing.Size(177, 36);
            this.SortByAddrbutton1.TabIndex = 13;
            this.SortByAddrbutton1.Tag = "";
            this.SortByAddrbutton1.Text = "Sort By Address";
            this.SortByAddrbutton1.UseCompatibleTextRendering = true;
            this.SortByAddrbutton1.UseVisualStyleBackColor = false;
            this.SortByAddrbutton1.Click += new System.EventHandler(this.SortByAddrbutton1_Click);
            this.SortByAddrbutton1.MouseEnter += new System.EventHandler(this.SortByAddrbutton1_MouseEnter);
            this.SortByAddrbutton1.MouseLeave += new System.EventHandler(this.SortByAddrbutton1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BikesParking.Properties.Resources.milky_way_2695569_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortByAddrbutton1);
            this.Controls.Add(this.SortById_button);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button SortById_button;
        private System.Windows.Forms.Button SortByAddrbutton1;
    }
}

