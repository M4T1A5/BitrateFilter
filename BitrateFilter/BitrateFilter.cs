using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BitrateFilter
{
    public partial class BitrateFilter : Form
    {
        // Path to the folder we want to filter files from
        private String searchPath = string.Empty;

        // Timer to show errors
        private Timer t = new Timer();

        public BitrateFilter()
        {
            InitializeComponent();

            // Set the default value of the combo box
            filetypeComboBox.SelectedItem = filetypeComboBox.Items[0];

            // Handler for when time runs out(the timer ticks)
            t.Tick += timerHandler;
        }

        private void musicDirButton_Click(object sender, EventArgs e)
        {
            // Show the folder select dialog (code moves forward once dialog closes)
            musicDirDialog.ShowDialog();

            // Check that the path equals to something
            if (musicDirDialog.SelectedPath == string.Empty) return;

            // Set the path and the label below the select button
            searchPath = musicDirDialog.SelectedPath;
            musicDirLabel.Text = searchPath;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            processBitrate();
        }

        private void processBitrate()
        {
            // List of files in dir
            List<string> files;

            // Get the file list if directory is set
            if (searchPath != string.Empty)
            {
                files = getFiles();
                processProgressBar.Maximum = files.Count;
            }
            else
            {
                sendMessage("Directory not set");
                return;
            }

            // Get the bitrateFilter
            ushort bitrateFilter;
            if (bitrateTextBox.Text != string.Empty)
            {
                try
                {
                    bitrateFilter = ushort.Parse(bitrateTextBox.Text);
                }
                catch (OverflowException)
                {
                    sendMessage("Bitrate not set");
                    return;
                }
            }
            else
            {
               sendMessage("Bitrate not set");
                return;
            }

            foreach (var file in files)
            {
                processProgressBar.PerformStep();

                //parse file name
                var name =
                    file.Substring(file.LastIndexOf("\\") + 1);
                //parse file path
                var path =
                    file.Substring(0, file.LastIndexOf("\\"));

                var bitrate = BitrateInfo.GetBitrate(name, path);

                // Bitrate was not found so dont bother adding it to the list
                if (bitrate == -1)
                    continue;

                if (lessThanRadioButton.Checked)
                {
                    if (bitrate < bitrateFilter)
                    {
                        addFile(name, path, bitrate);
                    }
                }
                else if (greaterThanRadioButton.Checked)
                {
                    if (bitrate > bitrateFilter)
                    {
                        addFile(name, path, bitrate);
                    }
                }
            }

            // Fixes the rendering problem with long treeviews(stupid .net)
            filteredFilesTreeView.Nodes[0].Expand();
            filteredFilesTreeView.Nodes[0].Collapse();

            // Reset progressbar
            processProgressBar.Value = 0;
            sendMessage("Done");
        }

        private List<string> getFiles()
        {
            string[] fileArray;

            var filter = filetypeComboBox.SelectedItem.ToString();
            if (filter == string.Empty || filter == "*")
            {
                fileArray = Directory.GetFiles(searchPath, "*.*", SearchOption.AllDirectories);
            }
            else
            {
                fileArray = Directory.GetFiles(searchPath, "*." + filter, SearchOption.AllDirectories);
            }

            var list = new List<string>(fileArray);
            list.Reverse(); // Get the correct order

            return list;
        }

        private void addFile(string name, string path, int bitrate)
        {
            // Nodes of the treeview
            var nodes = filteredFilesTreeView.Nodes;

            if (!nodes.ContainsKey(path))
            {
                nodes.Add(path, path);
            }

            nodes.Find(path, false)[0].Nodes.Add(string.Format("{0,-5} {1,10} kbps", name, bitrate));
        }

        // Show message to user
        private void sendMessage(string message, int time = 1000)
        {
            processLabel.Text = message;
            t.Interval = time; // Defaults to 1 second
            t.Start();
        }

        // Reset error label
        private void timerHandler(object sender, EventArgs e)
        {
            t.Stop();
            processLabel.Text = "";
        }
    }
}
