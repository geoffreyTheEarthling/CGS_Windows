using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_DLL;

namespace CGS_Windows
{
    public partial class mainForm : Form
    {
        Gallery gallery = new Gallery();
        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_AddCur_Click(object sender, EventArgs e)
        {
            string message = gallery.addCurator(txt_IdCur.Text, txt_fnameCur.Text, txt_lnameCur.Text);
            MessageBox.Show(message);
            txt_IdCur.Clear();
            txt_fnameCur.Clear();
            txt_lnameCur.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_ViewCur_Click(object sender, EventArgs e)
        {
            string allCuratorsInfo = gallery.getAllCuratorsInfo();
            richTextBox.AppendText(allCuratorsInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = gallery.addArtist(textBtxt_IDArtistox3.Text, txt_fnameArtist.Text, 
                txt_lnameArtist.Text);
            MessageBox.Show(message);
            textBtxt_IDArtistox3.Clear();
            txt_fnameArtist.Clear();
            txt_lnameArtist.Clear();`
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string allArtistsInfo = gallery.getAllArtistsInfo();
            richTextBox.AppendText(allArtistsInfo);
        }

        private void btn_AddArtPiece_Click(object sender, EventArgs e)
        {
            string message = gallery.addArtPiece(txtID.Text, txtCuratorID.Text, txtArtistID.Text,
                txtTitle.Text, Convert.ToInt32(txtYear.Text), Convert.ToDouble(txtValue.Text));
            MessageBox.Show(message);
            txtID.Clear();
            txtCuratorID.Clear();
            txtArtistID.Clear();
            txtTitle.Clear();
            txtYear.Clear();
            txtValue.Clear();
        }

        private void btn_ListPieces_Click(object sender, EventArgs e)
        {
            string allArtpiecesInfo = gallery.getAllArtpiecesInfo();
            richTextBox.AppendText(allArtpiecesInfo);
        }

        private void btn_SellArtPiece_Click(object sender, EventArgs e)
        {
            SellForm sellform = new SellForm(gallery);
            sellform.ShowDialog();
            //SellForm sellform = new SellForm();
            //sellform.Visible = true;
            //sellform.Activate();

        }

        private void btn_SaveCur_Click(object sender, EventArgs e)
        {
            string message = gallery.saveCuratorsInfo();
            MessageBox.Show(message);
        }

        private void btnSaveArtist_Click(object sender, EventArgs e)
        {
            string message = gallery.saveArtistsInfo();
            MessageBox.Show(message);
        }

        private void btnSaveArtPiece_Click(object sender, EventArgs e)
        {
            string message = gallery.saveArtPiecesInfo();
            MessageBox.Show(message);
        }

    }
}
