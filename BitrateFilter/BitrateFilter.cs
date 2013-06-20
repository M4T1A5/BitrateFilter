using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BitrateFilter
{
    public partial class BitrateFilter : Form
    {
        // Path to the folder we want to filter files from
        String path;

        public BitrateFilter()
        {
            InitializeComponent();

            // Set the default value of the combo box
            filetypeComboBox.SelectedItem = filetypeComboBox.Items[0];
        }

        private void musicDirButton_Click(object sender, EventArgs e)
        {
            // Show the folder select dialog (code moves forward once dialog closes)
            musicDirDialog.ShowDialog();

            // Assume the path points somewhere valid
            if (musicDirDialog.SelectedPath != String.Empty)
            {
                // Set the path and the label below the select button
                path = musicDirDialog.SelectedPath;
                musicDirLabel.Text = path;
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            // TODO: actually filter the bitrate nonsense
        }
    }
}
