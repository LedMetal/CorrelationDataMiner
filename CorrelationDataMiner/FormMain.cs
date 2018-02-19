using CorrelationDataMiner.bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrelationDataMiner
{
    public partial class FormMain : Form
    {
        // Global Variables
        string correlationFile, signalOneFile, signalTwoFile;
        List<Frame> framesList;
        List<Interval> intervalsList;

        public FormMain()
        {
            InitializeComponent();

            // Initialize global variables
            correlationFile = "";
            signalOneFile = "";
            signalTwoFile = "";
            framesList = new List<Frame>();
            intervalsList = new List<Interval>();
        }

        private void btnBrowseCorr_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog object to select correlation signal file
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Select Correlation File...",
                Filter = "TXT Files|*.txt",
                InitialDirectory = @"C:\"
            };

            // Display fileDialog and check if user selected a file
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save selected file's path
                correlationFile = fileDialog.FileName;

                // Display file path in read-only textbox
                tbCorrPath.Text = correlationFile;
            }
        }

        private void btnBrowseSig1_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog object to select signal one file
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Select Signal 1 File...",
                Filter = "TXT Files|*.txt",
                InitialDirectory = @"C:\"
            };

            // Display fileDialog and check if user selected a file
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save selected file's path
                signalOneFile = fileDialog.FileName;

                // Display file path in read-only textbox
                tbSig1Path.Text = signalOneFile;
            }
        }

        private void btnCalculateIntervals_Click(object sender, EventArgs e)
        {
            ReadFiles();
        }

        private void btnBrowseSig2_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog object to select signal two file
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Select Signal 2 File...",
                Filter = "TXT Files|*.txt",
                InitialDirectory = @"C:\"
            };

            // Display fileDialog and check if user selected a file
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save selected file's path
                signalTwoFile = fileDialog.FileName;

                // Display file path in read-only textbox
                tbSig2Path.Text = signalTwoFile;
            }
        }

        // Read and store files into global list of Frame objects
        private void ReadFiles()
        {
            ReadCorrelationFile();
        }

        private void ReadCorrelationFile()
        {
            // Open StreamReader object for correlation file
            using (StreamReader reader = new StreamReader(correlationFile))
            {
                string line = "";
                int position = 0;

                // Loop through all lines that are not read as null
                while ((line = reader.ReadLine()) != null)
                {
                    // Increment position variable
                    position++;

                    // Add new frame object to global list, saving the frame's position and correlation signal
                    framesList.Add(new Frame() { Position = position, CorrSignal = Convert.ToDouble(line) });
                }
            }
        }

    }
}
