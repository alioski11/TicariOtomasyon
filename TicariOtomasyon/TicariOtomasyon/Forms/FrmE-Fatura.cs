using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon.Forms
{
    public partial class FrmE_Fatura : Form
    {
        public FrmE_Fatura()
        {
            InitializeComponent();
        }

        private void FrmE_Fatura_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://portal.efatura.gov.tr/efatura/egiris.jsp");
        }
    }
}
