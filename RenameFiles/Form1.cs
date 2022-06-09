using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class frmPrincipal : Form
    {
        //private static readonly string ExecutionPath = (System.AppDomain.CurrentDomain.BaseDirectory);
        private static string ExecutionPath = (System.AppDomain.CurrentDomain.BaseDirectory);

        private static readonly string ExeNameWithPath = Application.ExecutablePath;

        private static readonly string ExecutionExeName = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath);

        public frmPrincipal()
        {
            InitializeComponent();
        }


        // Events
        #region Events
        /// <summary>
        /// Button to add the text to all the files.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event.</param>
        private void btnRename_Click(object sender, EventArgs e)
        {
            //ExecutionPath = @"D:\DevProjects\RenameFiles\RenameFiles\TestFolder";

            if (!string.IsNullOrEmpty(txtRename.Text))
            {
                // Rename files
                AddToFiles(txtRename.Text);

                MessageBox.Show("The text was ADDED to all the files.", "Add Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No text inserted.", "Remove Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Button to remove the text from all the files.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event.</param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //ExecutionPath = @"D:\DevProjects\RenameFiles\RenameFiles\TestFolder";

            if (!string.IsNullOrEmpty(txtRemove.Text))
            {
                // Remove from files
                RemoveFromFiles(txtRemove.Text);

                MessageBox.Show("The text was REMOVED from all the files.", "Remove Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No text inserted.", "Remove Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// EXIT the program.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event.</param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        // Methods
        #region Private methods
        /// <summary>
        /// Add a sufix at the end to all the files of the actual directory.
        /// </summary>
        private static void AddToFiles(string textToAdd)
        {
            foreach (string fullFileName in Directory.GetFiles(ExecutionPath, "*.*", SearchOption.AllDirectories))
            {
                Console.WriteLine(fullFileName);

                string path = "";
                string fileName = "";
                string extension = "";
                string finalFullName = "";

                try
                {
                    if (fullFileName != ExeNameWithPath)
                    {
                        path = "";
                        fileName = "";
                        extension = "";
                        finalFullName = "";

                        // Split the path, fileName and extension
                        SplitPathAndName(fullFileName, ref path, ref fileName);
                        SplitNameAndExtension(fileName, ref fileName, ref extension);

                        // Prepare the new name of the file
                        fileName = fileName + textToAdd + "." + extension;
                        finalFullName = Path.Combine(ExecutionPath, fileName);

                        Console.WriteLine(finalFullName);

                        // Rename the file
                        if (!File.Exists(finalFullName))
                        {
                            System.IO.File.Move(fullFileName, finalFullName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file " + fileName + " exists in the folder. \n" + "The file was NOT renamed.", "Add Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //throw ex;
                }
            }
        }

        /// <summary>
        /// Rremove a text to all the files of the actual directory.
        /// </summary>
        private static void RemoveFromFiles(string textToRemove)
        {
            foreach (string fullFileName in Directory.GetFiles(ExecutionPath, "*.*", SearchOption.AllDirectories))
            {
                string path = "";
                string fileName = "";
                string extension = "";
                string finalFullName = "";

                try
                {
                    Console.WriteLine(fullFileName);

                    if (fullFileName != ExeNameWithPath)
                    {
                        path = "";
                        fileName = "";
                        extension = "";
                        finalFullName = "";

                        // Split the path, fileName and extension
                        SplitPathAndName(fullFileName, ref path, ref fileName);
                        SplitNameAndExtension(fileName, ref fileName, ref extension);

                        // Prepare the new name of the file
                        fileName = fileName.Replace(textToRemove, "");
                        fileName = fileName + "." + extension;
                        finalFullName = Path.Combine(ExecutionPath, fileName);

                        Console.WriteLine(finalFullName);

                        // Rename the file
                        if (!File.Exists(finalFullName))
                        {
                            System.IO.File.Move(fullFileName, finalFullName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file " + fileName + " exists in the folder. \n" + "The file was NOT renamed.", "Remove Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //throw ex;
                }
            }
        }
        #endregion


        #region Files
        /// <summary>
        /// It splits a full path into Path and FileName.
        /// </summary>
        /// <param name="originalPathName">Original Path+FileName to be splitted.</param>
        /// <param name="Path">Ref Path.</param>
        /// <param name="filename">Ref FileName.</param>
        private static void SplitPathAndName(string originalPathName, ref string Path, ref string filename)
        {
            // Searching for the last "\" (folder)
            int n = originalPathName.LastIndexOf(@"\");
            // Path
            Path = originalPathName.Substring(0, n + 1);
            // FileName 
            filename = originalPathName.Substring(n + 1);
        }
        /// <summary>
        /// It splits a file name into the name and the extension.
        /// </summary>
        /// <param name="originalName">Original filename to be splitted.</param>
        /// <param name="fileName">File name.</param>
        /// <param name="extension">File extension.</param>
        private static void SplitNameAndExtension(string originalName, ref string fileName, ref string extension)
        {
            // Searching for the last "." (extension)
            int n = originalName.LastIndexOf(@".");
            // Path
            fileName = originalName.Substring(0, n);
            // FileName 
            extension = originalName.Substring(n + 1);
        }
        #endregion
    }
}
