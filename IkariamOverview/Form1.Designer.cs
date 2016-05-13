namespace IkariamOverview
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerTabs = new System.Windows.Forms.TabControl();
            this.st1 = new System.Windows.Forms.TabPage();
            this.Overview = new System.Windows.Forms.TabControl();
            this.Resource = new System.Windows.Forms.TabPage();
            this.Building = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RespurceGV = new System.Windows.Forms.DataGridView();
            this.BuildingGV = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IkariamIDLabel = new System.Windows.Forms.Label();
            this.IkariamID = new System.Windows.Forms.TextBox();
            this.ServerTabs.SuspendLayout();
            this.st1.SuspendLayout();
            this.Overview.SuspendLayout();
            this.Resource.SuspendLayout();
            this.Building.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RespurceGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerTabs
            // 
            this.ServerTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerTabs.Controls.Add(this.st1);
            this.ServerTabs.Location = new System.Drawing.Point(3, 24);
            this.ServerTabs.Name = "ServerTabs";
            this.ServerTabs.SelectedIndex = 0;
            this.ServerTabs.Size = new System.Drawing.Size(937, 606);
            this.ServerTabs.TabIndex = 0;
            // 
            // st1
            // 
            this.st1.Controls.Add(this.IkariamID);
            this.st1.Controls.Add(this.IkariamIDLabel);
            this.st1.Controls.Add(this.textBox2);
            this.st1.Controls.Add(this.Url);
            this.st1.Controls.Add(this.Refresh);
            this.st1.Controls.Add(this.textBox1);
            this.st1.Controls.Add(this.label1);
            this.st1.Controls.Add(this.Overview);
            this.st1.Location = new System.Drawing.Point(4, 22);
            this.st1.Name = "st1";
            this.st1.Padding = new System.Windows.Forms.Padding(3);
            this.st1.Size = new System.Drawing.Size(929, 580);
            this.st1.TabIndex = 0;
            this.st1.Text = "tabPage1";
            this.st1.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            this.Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Overview.Controls.Add(this.Resource);
            this.Overview.Controls.Add(this.Building);
            this.Overview.Location = new System.Drawing.Point(6, 119);
            this.Overview.Name = "Overview";
            this.Overview.SelectedIndex = 0;
            this.Overview.Size = new System.Drawing.Size(923, 461);
            this.Overview.TabIndex = 0;
            // 
            // Resource
            // 
            this.Resource.Controls.Add(this.RespurceGV);
            this.Resource.Location = new System.Drawing.Point(4, 22);
            this.Resource.Name = "Resource";
            this.Resource.Padding = new System.Windows.Forms.Padding(3);
            this.Resource.Size = new System.Drawing.Size(915, 464);
            this.Resource.TabIndex = 0;
            this.Resource.Text = "Resource";
            this.Resource.UseVisualStyleBackColor = true;
            // 
            // Building
            // 
            this.Building.Controls.Add(this.BuildingGV);
            this.Building.Location = new System.Drawing.Point(4, 22);
            this.Building.Name = "Building";
            this.Building.Padding = new System.Windows.Forms.Padding(3);
            this.Building.Size = new System.Drawing.Size(915, 435);
            this.Building.TabIndex = 1;
            this.Building.Text = "Building";
            this.Building.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "SessionID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 22);
            this.textBox1.TabIndex = 2;
            // 
            // RespurceGV
            // 
            this.RespurceGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RespurceGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RespurceGV.Location = new System.Drawing.Point(3, 0);
            this.RespurceGV.Name = "RespurceGV";
            this.RespurceGV.RowTemplate.Height = 24;
            this.RespurceGV.Size = new System.Drawing.Size(912, 465);
            this.RespurceGV.TabIndex = 0;
            // 
            // BuildingGV
            // 
            this.BuildingGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuildingGV.Location = new System.Drawing.Point(0, 0);
            this.BuildingGV.Name = "BuildingGV";
            this.BuildingGV.RowTemplate.Height = 24;
            this.BuildingGV.Size = new System.Drawing.Size(915, 439);
            this.BuildingGV.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(783, 14);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // Url
            // 
            this.Url.AutoSize = true;
            this.Url.Location = new System.Drawing.Point(12, 45);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(23, 12);
            this.Url.TabIndex = 4;
            this.Url.Text = "Url:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(660, 22);
            this.textBox2.TabIndex = 5;
            // 
            // IkariamIDLabel
            // 
            this.IkariamIDLabel.AutoSize = true;
            this.IkariamIDLabel.Location = new System.Drawing.Point(14, 81);
            this.IkariamIDLabel.Name = "IkariamIDLabel";
            this.IkariamIDLabel.Size = new System.Drawing.Size(56, 12);
            this.IkariamIDLabel.TabIndex = 6;
            this.IkariamIDLabel.Text = "IkaraimID:";
            // 
            // IkariamID
            // 
            this.IkariamID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IkariamID.Location = new System.Drawing.Point(87, 81);
            this.IkariamID.Name = "IkariamID";
            this.IkariamID.Size = new System.Drawing.Size(660, 22);
            this.IkariamID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 631);
            this.Controls.Add(this.ServerTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ServerTabs.ResumeLayout(false);
            this.st1.ResumeLayout(false);
            this.st1.PerformLayout();
            this.Overview.ResumeLayout(false);
            this.Resource.ResumeLayout(false);
            this.Building.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RespurceGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ServerTabs;
        private System.Windows.Forms.TabPage st1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Overview;
        private System.Windows.Forms.TabPage Resource;
        private System.Windows.Forms.TabPage Building;
        private System.Windows.Forms.DataGridView RespurceGV;
        private System.Windows.Forms.DataGridView BuildingGV;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Url;
        private System.Windows.Forms.TextBox IkariamID;
        private System.Windows.Forms.Label IkariamIDLabel;
    }
}

