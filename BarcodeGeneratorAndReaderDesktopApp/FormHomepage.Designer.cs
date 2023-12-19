namespace BarcodeGeneratorAndReaderDesktopApp
{
    partial class FormHomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            tabBarcodeProcesses = new TabControl();
            tabGenerateBarcode = new TabPage();
            buttonSelectPathToExportBarcode = new Button();
            groupBoxBarcodeExportPath = new GroupBox();
            labelSelectedBarcodeExportPath = new Label();
            textBoxSelectedBarcodeExportPath = new TextBox();
            buttonGenerateBarcode = new Button();
            groupBox1 = new GroupBox();
            labelMessageInsideBarcode = new Label();
            textBoxMessageInsideBarcode = new TextBox();
            tabReadBarcode = new TabPage();
            buttonSelectBarcodePath = new Button();
            groupBoxSelectedBarcodePath = new GroupBox();
            labelSelectedBarcodePath = new Label();
            textBoxSelectedBarcodePath = new TextBox();
            buttonReadBarcode = new Button();
            openFileDialog = new OpenFileDialog();
            tabBarcodeProcesses.SuspendLayout();
            tabGenerateBarcode.SuspendLayout();
            groupBoxBarcodeExportPath.SuspendLayout();
            groupBox1.SuspendLayout();
            tabReadBarcode.SuspendLayout();
            groupBoxSelectedBarcodePath.SuspendLayout();
            SuspendLayout();
            // 
            // tabBarcodeProcesses
            // 
            tabBarcodeProcesses.Controls.Add(tabGenerateBarcode);
            tabBarcodeProcesses.Controls.Add(tabReadBarcode);
            tabBarcodeProcesses.Dock = DockStyle.Fill;
            tabBarcodeProcesses.Location = new System.Drawing.Point(0, 0);
            tabBarcodeProcesses.Name = "tabBarcodeProcesses";
            tabBarcodeProcesses.SelectedIndex = 0;
            tabBarcodeProcesses.Size = new System.Drawing.Size(559, 441);
            tabBarcodeProcesses.TabIndex = 0;
            // 
            // tabGenerateBarcode
            // 
            tabGenerateBarcode.Controls.Add(buttonSelectPathToExportBarcode);
            tabGenerateBarcode.Controls.Add(groupBoxBarcodeExportPath);
            tabGenerateBarcode.Controls.Add(buttonGenerateBarcode);
            tabGenerateBarcode.Controls.Add(groupBox1);
            tabGenerateBarcode.Location = new System.Drawing.Point(4, 24);
            tabGenerateBarcode.Name = "tabGenerateBarcode";
            tabGenerateBarcode.Padding = new Padding(3);
            tabGenerateBarcode.Size = new System.Drawing.Size(551, 413);
            tabGenerateBarcode.TabIndex = 0;
            tabGenerateBarcode.Text = "Generate Barcode";
            tabGenerateBarcode.UseVisualStyleBackColor = true;
            // 
            // buttonSelectPathToExportBarcode
            // 
            buttonSelectPathToExportBarcode.Location = new System.Drawing.Point(3, 184);
            buttonSelectPathToExportBarcode.Name = "buttonSelectPathToExportBarcode";
            buttonSelectPathToExportBarcode.Size = new System.Drawing.Size(185, 50);
            buttonSelectPathToExportBarcode.TabIndex = 5;
            buttonSelectPathToExportBarcode.Text = "Select Path to Export Barcode";
            buttonSelectPathToExportBarcode.UseVisualStyleBackColor = true;
            buttonSelectPathToExportBarcode.Click += buttonSelectPathToExportBarcode_Click;
            // 
            // groupBoxBarcodeExportPath
            // 
            groupBoxBarcodeExportPath.Controls.Add(labelSelectedBarcodeExportPath);
            groupBoxBarcodeExportPath.Controls.Add(textBoxSelectedBarcodeExportPath);
            groupBoxBarcodeExportPath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBoxBarcodeExportPath.Location = new System.Drawing.Point(3, 240);
            groupBoxBarcodeExportPath.Name = "groupBoxBarcodeExportPath";
            groupBoxBarcodeExportPath.Size = new System.Drawing.Size(545, 85);
            groupBoxBarcodeExportPath.TabIndex = 4;
            groupBoxBarcodeExportPath.TabStop = false;
            // 
            // labelSelectedBarcodeExportPath
            // 
            labelSelectedBarcodeExportPath.AutoSize = true;
            labelSelectedBarcodeExportPath.Dock = DockStyle.Top;
            labelSelectedBarcodeExportPath.Location = new System.Drawing.Point(3, 25);
            labelSelectedBarcodeExportPath.Name = "labelSelectedBarcodeExportPath";
            labelSelectedBarcodeExportPath.Size = new System.Drawing.Size(210, 21);
            labelSelectedBarcodeExportPath.TabIndex = 1;
            labelSelectedBarcodeExportPath.Text = "Selected Barcode Export Path";
            // 
            // textBoxSelectedBarcodeExportPath
            // 
            textBoxSelectedBarcodeExportPath.Dock = DockStyle.Bottom;
            textBoxSelectedBarcodeExportPath.Location = new System.Drawing.Point(3, 53);
            textBoxSelectedBarcodeExportPath.Name = "textBoxSelectedBarcodeExportPath";
            textBoxSelectedBarcodeExportPath.ReadOnly = true;
            textBoxSelectedBarcodeExportPath.Size = new System.Drawing.Size(539, 29);
            textBoxSelectedBarcodeExportPath.TabIndex = 2;
            // 
            // buttonGenerateBarcode
            // 
            buttonGenerateBarcode.Location = new System.Drawing.Point(3, 370);
            buttonGenerateBarcode.Name = "buttonGenerateBarcode";
            buttonGenerateBarcode.Size = new System.Drawing.Size(545, 40);
            buttonGenerateBarcode.TabIndex = 4;
            buttonGenerateBarcode.Text = "Generate Barcode";
            buttonGenerateBarcode.UseVisualStyleBackColor = true;
            buttonGenerateBarcode.Click += buttonGenerateBarcode_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelMessageInsideBarcode);
            groupBox1.Controls.Add(textBoxMessageInsideBarcode);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(551, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // labelMessageInsideBarcode
            // 
            labelMessageInsideBarcode.AutoSize = true;
            labelMessageInsideBarcode.Dock = DockStyle.Top;
            labelMessageInsideBarcode.Location = new System.Drawing.Point(3, 25);
            labelMessageInsideBarcode.Name = "labelMessageInsideBarcode";
            labelMessageInsideBarcode.Size = new System.Drawing.Size(233, 21);
            labelMessageInsideBarcode.TabIndex = 1;
            labelMessageInsideBarcode.Text = "Message to write inside barcode";
            // 
            // textBoxMessageInsideBarcode
            // 
            textBoxMessageInsideBarcode.Dock = DockStyle.Bottom;
            textBoxMessageInsideBarcode.Location = new System.Drawing.Point(3, 53);
            textBoxMessageInsideBarcode.Name = "textBoxMessageInsideBarcode";
            textBoxMessageInsideBarcode.Size = new System.Drawing.Size(545, 29);
            textBoxMessageInsideBarcode.TabIndex = 2;
            // 
            // tabReadBarcode
            // 
            tabReadBarcode.Controls.Add(buttonSelectBarcodePath);
            tabReadBarcode.Controls.Add(groupBoxSelectedBarcodePath);
            tabReadBarcode.Controls.Add(buttonReadBarcode);
            tabReadBarcode.Location = new System.Drawing.Point(4, 24);
            tabReadBarcode.Name = "tabReadBarcode";
            tabReadBarcode.Padding = new Padding(3);
            tabReadBarcode.Size = new System.Drawing.Size(551, 413);
            tabReadBarcode.TabIndex = 1;
            tabReadBarcode.Text = "Read Barcode";
            tabReadBarcode.UseVisualStyleBackColor = true;
            // 
            // buttonSelectBarcodePath
            // 
            buttonSelectBarcodePath.Location = new System.Drawing.Point(6, 6);
            buttonSelectBarcodePath.Name = "buttonSelectBarcodePath";
            buttonSelectBarcodePath.Size = new System.Drawing.Size(185, 50);
            buttonSelectBarcodePath.TabIndex = 9;
            buttonSelectBarcodePath.Text = "Select Barcode";
            buttonSelectBarcodePath.UseVisualStyleBackColor = true;
            buttonSelectBarcodePath.Click += buttonSelectBarcodePath_Click;
            // 
            // groupBoxSelectedBarcodePath
            // 
            groupBoxSelectedBarcodePath.Controls.Add(labelSelectedBarcodePath);
            groupBoxSelectedBarcodePath.Controls.Add(textBoxSelectedBarcodePath);
            groupBoxSelectedBarcodePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBoxSelectedBarcodePath.Location = new System.Drawing.Point(3, 62);
            groupBoxSelectedBarcodePath.Name = "groupBoxSelectedBarcodePath";
            groupBoxSelectedBarcodePath.Size = new System.Drawing.Size(545, 85);
            groupBoxSelectedBarcodePath.TabIndex = 7;
            groupBoxSelectedBarcodePath.TabStop = false;
            // 
            // labelSelectedBarcodePath
            // 
            labelSelectedBarcodePath.AutoSize = true;
            labelSelectedBarcodePath.Dock = DockStyle.Top;
            labelSelectedBarcodePath.Location = new System.Drawing.Point(3, 25);
            labelSelectedBarcodePath.Name = "labelSelectedBarcodePath";
            labelSelectedBarcodePath.Size = new System.Drawing.Size(162, 21);
            labelSelectedBarcodePath.TabIndex = 1;
            labelSelectedBarcodePath.Text = "Selected Barcode Path";
            // 
            // textBoxSelectedBarcodePath
            // 
            textBoxSelectedBarcodePath.Dock = DockStyle.Bottom;
            textBoxSelectedBarcodePath.Location = new System.Drawing.Point(3, 53);
            textBoxSelectedBarcodePath.Name = "textBoxSelectedBarcodePath";
            textBoxSelectedBarcodePath.ReadOnly = true;
            textBoxSelectedBarcodePath.Size = new System.Drawing.Size(539, 29);
            textBoxSelectedBarcodePath.TabIndex = 2;
            // 
            // buttonReadBarcode
            // 
            buttonReadBarcode.Location = new System.Drawing.Point(0, 367);
            buttonReadBarcode.Name = "buttonReadBarcode";
            buttonReadBarcode.Size = new System.Drawing.Size(545, 40);
            buttonReadBarcode.TabIndex = 8;
            buttonReadBarcode.Text = "Read Barcode";
            buttonReadBarcode.UseVisualStyleBackColor = true;
            buttonReadBarcode.Click += buttonReadBarcode_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // FormHomepage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(559, 441);
            Controls.Add(tabBarcodeProcesses);
            Name = "FormHomepage";
            Text = "Homepage";
            tabBarcodeProcesses.ResumeLayout(false);
            tabGenerateBarcode.ResumeLayout(false);
            groupBoxBarcodeExportPath.ResumeLayout(false);
            groupBoxBarcodeExportPath.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabReadBarcode.ResumeLayout(false);
            groupBoxSelectedBarcodePath.ResumeLayout(false);
            groupBoxSelectedBarcodePath.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabBarcodeProcesses;
        private TabPage tabGenerateBarcode;
        private TabPage tabReadBarcode;
        private OpenFileDialog openFileDialog;
        private TextBox textBoxMessageInsideBarcode;
        private Label labelMessageInsideBarcode;
        private Button buttonGenerateBarcode;
        private GroupBox groupBox1;
        private Button buttonSelectPathToExportBarcode;
        private GroupBox groupBoxBarcodeExportPath;
        private Label labelSelectedBarcodeExportPath;
        private TextBox textBoxSelectedBarcodeExportPath;
        private Button buttonSelectBarcodePath;
        private GroupBox groupBoxSelectedBarcodePath;
        private Label labelSelectedBarcodePath;
        private TextBox textBoxSelectedBarcodePath;
        private Button buttonReadBarcode;
    }
}