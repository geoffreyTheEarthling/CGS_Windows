using CGS_DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Windows
{
    public partial class SellForm : Form
    {
        Gallery gallery = new Gallery();
        public SellForm(Gallery gallery)
        {
            InitializeComponent();
            this.gallery = gallery;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string message = gallery.sellPiece(txtArtpID.Text, 
                Convert.ToDouble(txtEstimate.Text));
            MessageBox.Show(message);

            message = gallery.saveArtPiecesInfo();
            MessageBox.Show(message);

            gallery.deleteArtpieceOnDisplay(txtArtpID.Text);

            txtArtpID.Clear();
            txtEstimate.Clear();    
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string allArtPieceInfo = gallery.getAllArtpiecesInfo();
            richTextBox1.AppendText(allArtPieceInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
