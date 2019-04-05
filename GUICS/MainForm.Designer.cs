namespace GUICS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addfile_dialog = new System.Windows.Forms.OpenFileDialog();
            this.button_addpdf = new System.Windows.Forms.Button();
            this.label_file_list = new System.Windows.Forms.Label();
            this.button_combine = new System.Windows.Forms.Button();
            this.select_outdir_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_select_outdir = new System.Windows.Forms.Button();
            this.textBox_outfile = new System.Windows.Forms.TextBox();
            this.label_outfile_title = new System.Windows.Forms.Label();
            this.label_outputfolder_title = new System.Windows.Forms.Label();
            this.label_output_folder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label_success = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_reset_pdfs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addfile_dialog
            // 
            this.addfile_dialog.FileName = "addfile_dialog";
            this.addfile_dialog.Filter = "PDF file (*.pdf)|*.pdf";
            this.addfile_dialog.Title = "File select";
            this.addfile_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button_addpdf
            // 
            this.button_addpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addpdf.Location = new System.Drawing.Point(534, 50);
            this.button_addpdf.Name = "button_addpdf";
            this.button_addpdf.Size = new System.Drawing.Size(115, 45);
            this.button_addpdf.TabIndex = 1;
            this.button_addpdf.Text = "Add pdf";
            this.button_addpdf.UseVisualStyleBackColor = true;
            this.button_addpdf.Click += new System.EventHandler(this.button_addpdf_click);
            // 
            // label_file_list
            // 
            this.label_file_list.AutoSize = true;
            this.label_file_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_file_list.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file_list.Location = new System.Drawing.Point(6, 40);
            this.label_file_list.Name = "label_file_list";
            this.label_file_list.Size = new System.Drawing.Size(157, 16);
            this.label_file_list.TabIndex = 2;
            this.label_file_list.Text = "No files currently added";
            // 
            // button_combine
            // 
            this.button_combine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_combine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_combine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_combine.Location = new System.Drawing.Point(20, 501);
            this.button_combine.Name = "button_combine";
            this.button_combine.Size = new System.Drawing.Size(200, 92);
            this.button_combine.TabIndex = 3;
            this.button_combine.Text = "Combine PDFs";
            this.button_combine.UseVisualStyleBackColor = false;
            this.button_combine.Click += new System.EventHandler(this.button_combine_click);
            // 
            // select_outdir_dialog
            // 
            this.select_outdir_dialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.select_outdir_dialog.SelectedPath = "H:\\";
            // 
            // button_select_outdir
            // 
            this.button_select_outdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_outdir.Location = new System.Drawing.Point(25, 109);
            this.button_select_outdir.Name = "button_select_outdir";
            this.button_select_outdir.Size = new System.Drawing.Size(118, 59);
            this.button_select_outdir.TabIndex = 4;
            this.button_select_outdir.Text = "Change folder";
            this.button_select_outdir.UseVisualStyleBackColor = true;
            this.button_select_outdir.Click += new System.EventHandler(this.button_select_outdir_click);
            // 
            // textBox_outfile
            // 
            this.textBox_outfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_outfile.Location = new System.Drawing.Point(301, 126);
            this.textBox_outfile.Name = "textBox_outfile";
            this.textBox_outfile.Size = new System.Drawing.Size(194, 26);
            this.textBox_outfile.TabIndex = 5;
            this.textBox_outfile.Text = "combined.pdf";
            // 
            // label_outfile_title
            // 
            this.label_outfile_title.AutoSize = true;
            this.label_outfile_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outfile_title.Location = new System.Drawing.Point(214, 129);
            this.label_outfile_title.Name = "label_outfile_title";
            this.label_outfile_title.Size = new System.Drawing.Size(81, 18);
            this.label_outfile_title.TabIndex = 6;
            this.label_outfile_title.Text = "File name:";
            // 
            // label_outputfolder_title
            // 
            this.label_outputfolder_title.AutoSize = true;
            this.label_outputfolder_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputfolder_title.Location = new System.Drawing.Point(24, 63);
            this.label_outputfolder_title.Name = "label_outputfolder_title";
            this.label_outputfolder_title.Size = new System.Drawing.Size(57, 18);
            this.label_outputfolder_title.TabIndex = 9;
            this.label_outputfolder_title.Text = "Folder:";
            // 
            // label_output_folder
            // 
            this.label_output_folder.AutoSize = true;
            this.label_output_folder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_output_folder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_folder.ForeColor = System.Drawing.SystemColors.Control;
            this.label_output_folder.Location = new System.Drawing.Point(87, 63);
            this.label_output_folder.Name = "label_output_folder";
            this.label_output_folder.Size = new System.Drawing.Size(27, 18);
            this.label_output_folder.TabIndex = 10;
            this.label_output_folder.Text = "H:\\";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label_output_folder);
            this.groupBox1.Controls.Add(this.label_outputfolder_title);
            this.groupBox1.Controls.Add(this.label_outfile_title);
            this.groupBox1.Controls.Add(this.textBox_outfile);
            this.groupBox1.Controls.Add(this.button_select_outdir);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output file";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label_success);
            this.splitContainer1.Panel2.Controls.Add(this.label_error);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button_combine);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 604);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 162);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label_success
            // 
            this.label_success.AutoSize = true;
            this.label_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_success.ForeColor = System.Drawing.Color.LawnGreen;
            this.label_success.Location = new System.Drawing.Point(252, 536);
            this.label_success.Name = "label_success";
            this.label_success.Size = new System.Drawing.Size(0, 20);
            this.label_success.TabIndex = 15;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(252, 542);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 20);
            this.label_error.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.button_reset_pdfs);
            this.groupBox2.Controls.Add(this.button_addpdf);
            this.groupBox2.Controls.Add(this.label_file_list);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 217);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input files";
            // 
            // button_reset_pdfs
            // 
            this.button_reset_pdfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset_pdfs.Location = new System.Drawing.Point(534, 127);
            this.button_reset_pdfs.Name = "button_reset_pdfs";
            this.button_reset_pdfs.Size = new System.Drawing.Size(115, 45);
            this.button_reset_pdfs.TabIndex = 3;
            this.button_reset_pdfs.Text = "Clear all";
            this.button_reset_pdfs.UseVisualStyleBackColor = true;
            this.button_reset_pdfs.Click += new System.EventHandler(this.button_reset_pdfs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 656);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "PDFCombiner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog addfile_dialog;
        private System.Windows.Forms.Button button_addpdf;
        private System.Windows.Forms.Label label_file_list;
        private System.Windows.Forms.Button button_combine;
        private System.Windows.Forms.FolderBrowserDialog select_outdir_dialog;
        private System.Windows.Forms.Button button_select_outdir;
        private System.Windows.Forms.TextBox textBox_outfile;
        private System.Windows.Forms.Label label_outfile_title;
        private System.Windows.Forms.Label label_outputfolder_title;
        private System.Windows.Forms.Label label_output_folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reset_pdfs;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_success;
    }
}

