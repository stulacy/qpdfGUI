using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GUICS
{
    public partial class MainForm : Form
    {
        List<string> selectedFiles = new List<string>();
        string qpdfPath = Escape("G:\\Miscellaneous\\Applications\\qpdf-8.4.0\\bin\\qpdf.exe");
        string firstArgs = "--empty --pages";

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Does nothing
        }
        

        private void button_addpdf_click(object sender, EventArgs e)
        {
            DialogResult = addfile_dialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string fn = addfile_dialog.FileName;
                selectedFiles.Add(fn);
                label_error.Text = "";
                label_success.Text = "";

                // Ideally would have a direct binding between text box and this array
                label_file_list.Text = String.Join("\n", selectedFiles);
            }
            
        }


        private void button_combine_click(object sender, EventArgs e)
        {
            if (selectedFiles.Count == 0)
            {
                label_error.Text = "Please select one or more files to combine!";
                return;
            }   

            // Build up arguments
            List<string> escapedFiles = selectedFiles.Select(x => Escape(x)).ToList();
            string filesJoined = string.Join(" ", escapedFiles);

            string outputPath = Path.Combine(select_outdir_dialog.SelectedPath, textBox_outfile.Text);
            string fullCmd = string.Join(" ", 
                                         new[] {firstArgs, filesJoined, "--", Escape(outputPath)}
                                         );

            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = qpdfPath;
                    myProcess.StartInfo.Arguments = fullCmd;
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.Start();
                    myProcess.WaitForExit();
                    
                    // Check if file exists. Not confirmation that conversion worked but better than nothing
                    if (File.Exists(outputPath))
                    {
                        label_success.Text = "Combined successfully!";
                    }
                    else
                    {
                        label_error.Text = "Something went wrong, check settings and try again.";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                label_error.Text = "Something went wrong, check settings and try again.";
            }
        }

        private void button_select_outdir_click(object sender, EventArgs e)
        {
            DialogResult = select_outdir_dialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                label_output_folder.Text = select_outdir_dialog.SelectedPath;
            }
        }

        public static string Escape(string s)
        {
            return s.Contains(" ") ? string.Format("\"{0}\"", s) : s;
        }

        private void button_reset_pdfs_Click(object sender, EventArgs e)
        {
            // Likewise would prefer a direct binding between list and textlabel
            selectedFiles.Clear();
            label_file_list.Text = "";
            label_success.Text = "";
        }
    }   
}
