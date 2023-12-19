using IronBarCode;

namespace BarcodeGeneratorAndReaderDesktopApp
{
    public partial class FormHomepage : Form
    {
        public FormHomepage()
        {
            InitializeComponent();
        }

        private void buttonSelectPathToExportBarcode_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBoxSelectedBarcodeExportPath.Text = fbd.SelectedPath;
                }
            }
        }
        private void buttonGenerateBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMessageInsideBarcode.Text))
            {
                MessageBox.Show("You have to write something inside barcode");
            }
            else if (string.IsNullOrEmpty(textBoxSelectedBarcodeExportPath.Text))
            {
                MessageBox.Show("You have to select path to export barcode");
            }
            else
            {
                try
                {
                    string messageInsideBarcode = textBoxMessageInsideBarcode.Text;
                    string exportedBarcodePath = $"{textBoxSelectedBarcodeExportPath.Text}/{Guid.NewGuid()}.png";

                    var myBarcode = BarcodeWriter.CreateBarcode(messageInsideBarcode, BarcodeWriterEncoding.Code128);
                    myBarcode.SaveAsPng(exportedBarcodePath);

                    MessageBox.Show($"Barcode successfully created at {exportedBarcodePath}");
                }
                catch (Exception)
                {
                    MessageBox.Show($"Error during creating barcode. Please try again.");
                }
            }
        }
        private void buttonSelectBarcodePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxSelectedBarcodePath.Text = dlg.FileName;
                }
            }
        }
        private void buttonReadBarcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSelectedBarcodePath.Text))
            {
                MessageBox.Show("You have to select any barcode");
            }

            try
            {
                var resultFromFile = BarcodeReader.Read(textBoxSelectedBarcodePath.Text);
                if(resultFromFile is null)
                {
                    MessageBox.Show("Image you selected is not barcode");
                }
                else
                {
                    string message = "";

                    resultFromFile.ToList().ForEach((value) =>
                    {
                        message += value;
                    });

                    MessageBox.Show($"Message inside barcode is : {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
