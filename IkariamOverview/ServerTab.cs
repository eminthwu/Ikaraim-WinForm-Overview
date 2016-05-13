using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkariamOverview
{
    public partial class ServerTab : TabPage
    {
        public TabControl Overview { get; set; }

        public TabPage Resource { get; set; }

        public TabPage Building { get; set; }

        public TextBox SessionID { get; set; }

        public Label IkariamIDLabel { get; set; }

        public TextBox IkariamID { get; set; }

        public DataGridView RespurceGV { get; set; }

        public DataGridView BuildingGV { get; set; }

        public Label SessionLabel { get; set; }

        public Button Refreshbtn { get; set; }

        public Label UrlLabel { get; set; }

        public TextBox Url { get; set; }

        public GetData Data
        {
            get
            {
                if (this._Data == null)
                    this._Data = new GetData();

                return this._Data;
            }
        }

        private GetData _Data { get; set; }

        //  public Button

        public ServerTab()
        {
            Inia();
        }

        private void CombineData(object sender, EventArgs e)
        {
            try
            {

            this.Data.Server = this.Url.Text.Trim();
            this.Data.SessionID = this.SessionID.Text.Trim();
            this.Data.IkariamID = this.IkariamID.Text.Trim();
            this.Data.Get();
            this.RespurceGV.DataSource = this.Data.Resources;
            //RespurceGV.DataMember = "Test";
            }
            catch(Exception)
            {

            }

        }
    }
}
