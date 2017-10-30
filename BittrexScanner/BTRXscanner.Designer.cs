namespace BittrexScanner
{
    partial class BTRXscanner
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataScreen = new System.Windows.Forms.DataGridView();
            this.Ticker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultiplierBox = new System.Windows.Forms.TextBox();
            this.scanLag = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.MultiplierLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.ConsiderSize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataScreen
            // 
            this.dataScreen.AllowUserToAddRows = false;
            this.dataScreen.AllowUserToDeleteRows = false;
            this.dataScreen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataScreen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataScreen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataScreen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataScreen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataScreen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticker,
            this.Side,
            this.Price,
            this.Ratio,
            this.TimeStamp});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataScreen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataScreen.Location = new System.Drawing.Point(12, 40);
            this.dataScreen.MultiSelect = false;
            this.dataScreen.Name = "dataScreen";
            this.dataScreen.ReadOnly = true;
            this.dataScreen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataScreen.RowHeadersVisible = false;
            this.dataScreen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataScreen.Size = new System.Drawing.Size(561, 273);
            this.dataScreen.TabIndex = 4;
            // 
            // Ticker
            // 
            this.Ticker.HeaderText = "Ticker";
            this.Ticker.Name = "Ticker";
            this.Ticker.ReadOnly = true;
            this.Ticker.Width = 112;
            // 
            // Side
            // 
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Width = 112;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 113;
            // 
            // Ratio
            // 
            this.Ratio.HeaderText = "Ratio";
            this.Ratio.Name = "Ratio";
            this.Ratio.ReadOnly = true;
            this.Ratio.Width = 112;
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.Width = 112;
            // 
            // MultiplierBox
            // 
            this.MultiplierBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MultiplierBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MultiplierBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplierBox.ForeColor = System.Drawing.Color.White;
            this.MultiplierBox.Location = new System.Drawing.Point(217, 8);
            this.MultiplierBox.Name = "MultiplierBox";
            this.MultiplierBox.Size = new System.Drawing.Size(85, 23);
            this.MultiplierBox.TabIndex = 2;
            this.MultiplierBox.Text = "1";
            this.MultiplierBox.TextChanged += new System.EventHandler(this.MultiplierBox_TextChanged);
            // 
            // scanLag
            // 
            this.scanLag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scanLag.AutoSize = true;
            this.scanLag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.scanLag.ForeColor = System.Drawing.Color.White;
            this.scanLag.Location = new System.Drawing.Point(9, 316);
            this.scanLag.Name = "scanLag";
            this.scanLag.Size = new System.Drawing.Size(64, 17);
            this.scanLag.TabIndex = 7;
            this.scanLag.Text = "BTRX lag";
            // 
            // depthBox
            // 
            this.depthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.depthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.depthBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depthBox.ForeColor = System.Drawing.Color.White;
            this.depthBox.Location = new System.Drawing.Point(64, 8);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(72, 23);
            this.depthBox.TabIndex = 1;
            this.depthBox.Text = "1";
            this.depthBox.TextChanged += new System.EventHandler(this.depthBox_TextChanged);
            // 
            // DepthLabel
            // 
            this.DepthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DepthLabel.ForeColor = System.Drawing.Color.White;
            this.DepthLabel.Location = new System.Drawing.Point(12, 9);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(46, 17);
            this.DepthLabel.TabIndex = 9;
            this.DepthLabel.Text = "Depth";
            // 
            // MultiplierLabel
            // 
            this.MultiplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MultiplierLabel.AutoSize = true;
            this.MultiplierLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.MultiplierLabel.ForeColor = System.Drawing.Color.White;
            this.MultiplierLabel.Location = new System.Drawing.Point(142, 9);
            this.MultiplierLabel.Name = "MultiplierLabel";
            this.MultiplierLabel.Size = new System.Drawing.Size(69, 17);
            this.MultiplierLabel.TabIndex = 10;
            this.MultiplierLabel.Text = "Multiplier";
            // 
            // countLabel
            // 
            this.countLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.countLabel.ForeColor = System.Drawing.Color.White;
            this.countLabel.Location = new System.Drawing.Point(128, 316);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(103, 17);
            this.countLabel.TabIndex = 11;
            this.countLabel.Text = "Market 000/000";
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.check.AutoSize = true;
            this.check.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.check.Location = new System.Drawing.Point(329, 12);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 3;
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // ConsiderSize
            // 
            this.ConsiderSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsiderSize.AutoSize = true;
            this.ConsiderSize.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConsiderSize.Location = new System.Drawing.Point(308, 12);
            this.ConsiderSize.Name = "ConsiderSize";
            this.ConsiderSize.Size = new System.Drawing.Size(15, 14);
            this.ConsiderSize.TabIndex = 12;
            this.ConsiderSize.UseVisualStyleBackColor = true;
            this.ConsiderSize.CheckedChanged += new System.EventHandler(this.ConsiderSize_CheckedChanged);
            // 
            // BTRXscanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(586, 342);
            this.Controls.Add(this.ConsiderSize);
            this.Controls.Add(this.check);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.MultiplierLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.scanLag);
            this.Controls.Add(this.MultiplierBox);
            this.Controls.Add(this.dataScreen);
            this.Name = "BTRXscanner";
            this.Text = "BTRXscanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BTRXscanner_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataScreen;
        private System.Windows.Forms.TextBox MultiplierBox;
        private System.Windows.Forms.Label scanLag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label MultiplierLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.CheckBox ConsiderSize;
    }
}

