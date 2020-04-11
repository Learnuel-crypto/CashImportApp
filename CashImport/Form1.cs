using System;
using System.IO;
using System.Windows.Forms;

using FileEncrypt;
using System.IO.IsolatedStorage;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CashImport
    {
    public partial class CashImportForm : Form
        {
        public CashImportForm()
            {
            InitializeComponent(); 
            }
        FileInfo info;
        bool deleteFile = false;
        string encFileName; string encFileExtension = null;
        string decrepted_file_path = null;
        string destination_File = null;
        private DataEncryptor dataCryptor = new DataEncryptor();
        private void btnSelectFile_Click(object sender , EventArgs e)
            {
            try {
                ReadDataPath();
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.RestoreDirectory = true;
                fileDialog.Title = "Select File";
                fileDialog.Filter = "data files (*.enc)|*.enc";
                fileDialog.FilterIndex = 1;
                fileDialog.DefaultExt = "enc";
                fileDialog.CheckFileExists = false;
                fileDialog.ValidateNames = false;
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = false;


                if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                    info = new FileInfo(fileDialog.FileName);
                    dataCryptor.inPutFilePath(fileDialog.FileName);
                    dataCryptor.FileType(info.Extension);
                    txtFileName.Text = info.Name;
                    dataCryptor.FileType(info.Name.Substring(0 , info.Name.Length - info.Extension.Length) , info.Extension); 
                    dataCryptor.outPutFilePath(decrepted_file_path); 
                    }
                }catch(Exception ex)
                {
                MessageBox.Show(ex.Message , "Import Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }

        void ReadDataPath()
            {
            try
                {
                 string path =Application.StartupPath;
                string filename = "\\DataPath.txt";
                var newpath = path.Substring(0, path.IndexOf("\\"));
                 destination_File = newpath + filename;
                if (File.Exists(destination_File))
                {

                    using (StreamReader reader = new StreamReader(destination_File))
                    {
                        decrepted_file_path = reader.ReadLine();
                    }
                }
                else
                {
                    throw new Exception("Path not found");
                }
                }  
                
            catch (Exception ex)
                {
                throw new Exception(ex.Message); 
                }
            } 
        private  void btnimport_Click(object sender , EventArgs e)
            {
                try
                {
                    lbInfor.Visible = true;
                    //to decrypt the file
                    if (string.IsNullOrEmpty(txtFileName.Text))
                    {
                        throw new Exception("Select output folder");
                    }

                    var dbname = txtFileName.Text.Substring(0, txtFileName.Text.LastIndexOf(".")).ToLower();
                    if (dbname == "cashdeskdb")
                    {
                        encFileExtension = ".mdf";
                        encFileName = "CASHDESKDB";
                    }
                    else if (dbname == "cashdeskdb_log")
                    {
                        encFileExtension = ".ldf";
                        encFileName = "CASHDESKDB_log";
                    }
                     
                    dataCryptor.FileDetails(info.Name.Substring(0, info.Name.Length - info.Extension.Length),
                        info.Extension, encFileExtension);
                    dataCryptor.isDeletePlainFile(deleteFile);
                    dataCryptor.DecryptFile();
                   File.SetAttributes(decrepted_file_path + "\\" + encFileName + encFileExtension,
                       FileAttributes.Hidden);
                    MessageBox.Show("Import Successfull", "Completed");
                    lbInfor.Visible = false;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access denied" , "Import Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            catch (Exception ex)
                { 
                MessageBox.Show(ex.Message , "Import Error" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                lbInfor.Visible = false;
                }
            }
        
        private void btnClose_Click(object sender , EventArgs e)
            {
                try
                {
                    if (MessageBox.Show("Are the two Files Imported ?", "Confirm Import", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ReadDataPath();
                        File.Delete(destination_File);
                        string appName = decrepted_file_path + "\\WindowsFormsApplication1.exe";
                        ProcessStartInfo info = new ProcessStartInfo(appName);
                        info.UseShellExecute = true;
                        info.Verb = "runas";
                        Process.Start(info);
                        Application.ExitThread();
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Could not access file\nExecute Cash Desk from your Desktop\nData import Was successfull" , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    Application.Exit();
                }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("File was not found\nExecute Cash Desk from your Desktop\nData import Was successfull" , "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception)
                {
                MessageBox.Show("Specified File was not found\nExecute Cash Desk from your Desktop\nData import Was successfull" , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);

                Application.Exit();
                }
            }

        private void CashImportForm_FormClosed(object sender , FormClosedEventArgs e)
            {
                try
                {
                    ReadDataPath();
                    File.Delete(destination_File);
                    string appName = decrepted_file_path + "\\WindowsFormsApplication1.exe";
                    ProcessStartInfo info = new ProcessStartInfo(appName);
                    info.UseShellExecute = true;
                    info.Verb = "runas";
                    Process.Start(info);
                    Application.ExitThread();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Could not access file\nExecute Cash Desk from your Desktop\nData import Was successfull" , "Cash Desk" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("File was not found\nExecute Cash Desk from your Desktop\nData import Was successfull" , "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Specified File was not found\nExecute Cash Desk from your Desktop\nData import Was successfull" , "Cash Desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void CashImportForm_Load(object sender, EventArgs e)
        {

        }
        }
    }
