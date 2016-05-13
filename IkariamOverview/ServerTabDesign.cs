using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkariamOverview
{
    public partial class ServerTab
    {
        public void Inia()
        {
            this.Overview = new TabControl();
            this.Resource = new TabPage();
            this.Building = new TabPage();

            this.SessionID = new TextBox();
            this.SessionLabel = new Label();

            this.IkariamIDLabel = new System.Windows.Forms.Label();
            this.IkariamID = new TextBox();

            this.Url = new TextBox();
            this.UrlLabel = new Label();

            this.Refreshbtn = new Button();

            this.RespurceGV = new System.Windows.Forms.DataGridView();
            this.BuildingGV = new System.Windows.Forms.DataGridView();

       

            this.Overview.SuspendLayout();
            this.SuspendLayout();

            // 
            // serverTab
            // 
            this.Controls.Add(this.SessionID);
            this.Controls.Add(this.SessionLabel);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.Overview);
            this.Controls.Add(this.IkariamID);
            this.Controls.Add(this.IkariamIDLabel);

            this.Location = new System.Drawing.Point(4, 22);
            //this.Name = "st1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1500, 606);
            this.TabIndex = 0;
            this.Text = "外面傳入的server Name";
            this.UseVisualStyleBackColor = true;

            // 
            // Overview
            // 
            this.Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
          | System.Windows.Forms.AnchorStyles.Left)
          | System.Windows.Forms.AnchorStyles.Right)));
            this.Overview.Controls.Add(this.Resource);
            this.Overview.Controls.Add(this.Building);
            this.Overview.Location = new System.Drawing.Point(6, 110);
            this.Overview.Name = "Overview";
            this.Overview.SelectedIndex = 0;
            this.Overview.Size = new System.Drawing.Size(1500, 499);
            this.Overview.TabIndex = 0;

            // 
            // Resource
            // 
            this.Resource.Location = new System.Drawing.Point(4, 22);
            this.Resource.Name = "Resource";
            this.Resource.Padding = new System.Windows.Forms.Padding(3);
            this.Resource.Size = new System.Drawing.Size(1480, 464);
            this.Resource.TabIndex = 0;
            this.Resource.Text = "Resource";
            this.Resource.UseVisualStyleBackColor = true;
            this.Resource.Controls.Add(this.RespurceGV);

            // 
            // Building
            // 
            this.Building.Location = new System.Drawing.Point(4, 22);
            this.Building.Name = "Building";
            this.Building.Padding = new System.Windows.Forms.Padding(3);
            this.Building.Size = new System.Drawing.Size(915, 464);
            this.Building.TabIndex = 1;
            this.Building.Text = "Building";
            this.Building.UseVisualStyleBackColor = true;

            // 
            // SessionLabel
            // 
            this.SessionLabel.AutoSize = true;
            this.SessionLabel.Location = new System.Drawing.Point(10, 16);
            this.SessionLabel.Name = "label1";
            this.SessionLabel.Size = new System.Drawing.Size(54, 12);
            this.SessionLabel.TabIndex = 1;
            this.SessionLabel.Text = "SessionID:";


            // 
            // SessionID
            // 
            this.SessionID.Location = new System.Drawing.Point(87, 16);
            this.SessionID.Name = "textBox1";
            this.SessionID.Size = new System.Drawing.Size(660, 22);
            this.SessionID.TabIndex = 2;

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
            this.RespurceGV.Size = new System.Drawing.Size(1480, 465);
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
            this.BuildingGV.Size = new System.Drawing.Size(915, 468);
            this.BuildingGV.TabIndex = 0;            

            // 
            // Refresh
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(783, 14);
            this.Refreshbtn.Name = "Refresh";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 3;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += CombineData;

            // 
            // Url
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(12, 45);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(23, 12);
            this.UrlLabel.TabIndex = 4;
            this.UrlLabel.Text = "Url:";

            // 
            // textBox2
            // 
            this.Url.Location = new System.Drawing.Point(87, 49);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(660, 22);
            this.Url.TabIndex = 5;

            this.Overview.ResumeLayout(false);
            this.Resource.ResumeLayout(false);
            this.Building.ResumeLayout(false);

            // 
            // IkariamIDLabel
            // 
            this.IkariamIDLabel.AutoSize = true;
            this.IkariamIDLabel.Location = new System.Drawing.Point(14, 81);
            this.IkariamIDLabel.Name = "IkariamIDLabel";
            this.IkariamIDLabel.Size = new System.Drawing.Size(56, 12);
            this.IkariamIDLabel.TabIndex = 6;
            this.IkariamIDLabel.Text = "IkariamID:";
            // 
            // IkariamID
            // 
            this.IkariamID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IkariamID.Location = new System.Drawing.Point(87, 81);
            this.IkariamID.Name = "IkariamID";
            this.IkariamID.Size = new System.Drawing.Size(660, 22);
            this.IkariamID.TabIndex = 7;
        }

       
    }
}
