using System;
using System.IO;
using System.Windows.Forms;
namespace PdfRotator {
    /// <summary>
    /// frmMain
    /// </summary>
    public partial class frmMain : Form {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain() {
            InitializeComponent();
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e) {
            cboRotation.SelectedIndexChanged += cboRotation_SelectedIndexChanged;
            cboRotation.SelectedIndex = 0;
        }
        /// <summary>
        /// Show Error
        /// </summary>
        /// <param name="message"></param>
        private void ShowError(string message) {
            lblError.Text = message;
            lblError.Visible = true;
        }
        /// <summary>
        /// Output File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOutputFile_Click(object sender, EventArgs e) {
            try {
                var dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    txtOutputFile.Text = dlg.FileName;
            } catch (Exception ex) {
                ShowError(ex.Message);
            }
        }
        /// <summary>
        /// Input File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInputFile_Click(object sender, EventArgs e) {
            try {
                var dlg = new OpenFileDialog();
                dlg.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (dlg.ShowDialog(this) == DialogResult.OK) {
                    txtInputFile.Text = dlg.FileName;
                    txtOutputFile.Text = dlg.FileName;
                }
            } catch (Exception ex) {
                ShowError(ex.Message);
            }
        }
        /// <summary>
        /// Rotate Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRotate_Click(object sender, EventArgs e) {
            try {
                var deleteInputFile = false;
                var originalFilePath = txtInputFile.Text;
                if (txtInputFile.Text == txtOutputFile.Text) {
                    deleteInputFile = true;
                    var ext = Path.GetExtension(txtInputFile.Text);
                    var fileName = Path.GetFileName(txtInputFile.Text);
                    var filePath = Path.GetDirectoryName(txtInputFile.Text) + @"\";
                    var newFileName = System.Guid.NewGuid().ToString() + ext;
                    System.IO.File.Move(txtInputFile.Text, filePath + newFileName);
                    txtInputFile.Text = filePath + newFileName;
                }
                PdfHelper.RotatePdf(txtInputFile.Text, txtOutputFile.Text, Convert.ToInt32(txtRotation.Text));
                if (deleteInputFile) {
                    System.IO.File.Delete(txtInputFile.Text);
                    txtInputFile.Text = txtOutputFile.Text;
                }
                MessageBox.Show("Complete");
            } catch (Exception ex) {
                ShowError(ex.Message);
            }
        }
        /// <summary>
        /// Rotation Type Selected Index Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboRotation_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cboRotation.SelectedIndex) {
                case 0:
                    cboRotation.Text = "90";
                    break;
                case 1:
                    cboRotation.Text = "180";
                    break;
                case 2:
                    cboRotation.Text = "270";
                    break;
            }
        }
    }
}