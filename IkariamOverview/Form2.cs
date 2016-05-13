using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkariamOverview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ServerTab st = new ServerTab();
            this.tabControl1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.tabControl1.TabPages.Add(st);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Add(new ServerTab());
        }
    }
}
