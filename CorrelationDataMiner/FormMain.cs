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

        private void btnCalculateIntervals_Click(object sender, EventArgs e)
        {
            // Check if any file was left un-selected or any percentile left without an input
            if ((tbCorrPath.Text == String.Empty) || (tbSig1Path.Text == String.Empty) || (tbSig2Path.Text == String.Empty))
            {
                MessageBox.Show("Please make sure to select all three files using the corresponding 'Browse' button", "Missing File(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((nudCorrelation.Value == 0) || (nudSignalOne.Value == 0) || (nudSignalTwo.Value == 0))
            {
                MessageBox.Show("Please input a top percentile value for each data file", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Read files into global frames list
                ReadFiles();

                // Flag frames that meet correlation, signal one and signal two requirements
                SetCorrelationRequirement();
                SetSignalOneRequirement();
                SetSignalTwoRequirement();

                // Calculate Intervals
                CalculateIntervals();

                // Output Intervals to Excel spreadsheet
                OutputExcel();
            }

        }

        // Read and store files into global list of Frame objects
        private void ReadFiles()
        {
            ReadCorrelationFile();
            ReadSignalOneFile();
            ReadSignalTwoFile();
        }

        // Read correlation signal file and store into newly created Frame object
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

        // Read signal one file and store into frame object at appropriate position
        private void ReadSignalOneFile()
        {
            // Open StreamReader object for signal one file
            using (StreamReader reader = new StreamReader(signalOneFile))
            {
                string line = "";
                int position = 0;

                // Loop through all lines that are not read as null
                while ((line = reader.ReadLine()) != null)
                {
                    // Use position variable as index to find corresponding frame and store signal one value
                    framesList[position].SigOne = Convert.ToDouble(line);

                    // Increment position variable
                    position++;
                }
            }
        }

        // Read signal two file and store into frame object at appropriate position
        private void ReadSignalTwoFile()
        {
            // Open StreamReader object for signal two file
            using (StreamReader reader = new StreamReader(signalTwoFile))
            {
                string line = "";
                int position = 0;

                // Loop through all lines that are not read as null
                while ((line = reader.ReadLine()) != null)
                {
                    // Use position variable as index to find corresponding frame and store signal two value
                    framesList[position].SigTwo = Convert.ToDouble(line);

                    // Increment position variable
                    position++;
                }
            }
        }

        // Calculate correlation signal requirement and flag Frame objects that meet it
        private void SetCorrelationRequirement()
        {
            // Read requirement from numberUpDown tool
            double percentileCorrelation = Convert.ToDouble(nudCorrelation.Value / 100);

            // Check if user has entered a value for correlation signal percentile
            if (percentileCorrelation == 0)
            {
                MessageBox.Show("No percentile value entered for correlation signal requirement", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sort frames list by correlation signal in descending order
                framesList.Sort((x, y) => y.CorrSignal.CompareTo(x.CorrSignal));

                // Flag top percentile, defined by user
                for (int i = 0; i < (framesList.Count * percentileCorrelation); i++)
                {
                    framesList[i].MeetsCSReq = true;
                }
            }
        }

        // Calculate signal one requirement and flag Frame objects that meet it
        private void SetSignalOneRequirement()
        {
            // Read requirement from numberUpDown tool
            double percentileSignalOne = Convert.ToDouble(nudSignalOne.Value / 100);

            // Check if user has entered a value for signal one percentile
            if (percentileSignalOne == 0)
            {
                MessageBox.Show("No percentile value entered for signal one requirement", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sort frames list by signal one in descending order
                framesList.Sort((x, y) => y.SigOne.CompareTo(x.SigOne));

                // Flag top percentile, defined by user
                for (int i = 0; i < (framesList.Count * percentileSignalOne); i++)
                {
                    framesList[i].MeetsS1Req = true;
                }
            }
        }

        // Calculate signal one requirement and flag Frame objects that meet it
        private void SetSignalTwoRequirement()
        {
            // Read requirement from numberUpDown tool
            double percentileSignalTwo = Convert.ToDouble(nudSignalTwo.Value / 100);

            // Check if user has entered a value for signal two percentile
            if (percentileSignalTwo == 0)
            {
                MessageBox.Show("No percentile value entered for signal two requirement", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Sort frames list by signal two in descending order
                framesList.Sort((x, y) => y.SigTwo.CompareTo(x.SigTwo));

                // Flag top percentile, defined by user
                for (int i = 0; i < (framesList.Count * percentileSignalTwo); i++)
                {
                    framesList[i].MeetsS2Req = true;
                }
            }
        }

        // Calculate intervals in which all three flags on a Frame are set to true
        private void CalculateIntervals()
        {
            // firstIndex variable represents the first index in an interval of consequtive frames that meet all three requirements
            int firstIndex = 0;
            int lastIndex = 0;

            // Re-arrange global list of Frames by position, in ascending order
            framesList.Sort((x, y) => x.Position.CompareTo(y.Position));

            do
            {
                // Check if frame at firstIndex meets all three requirements
                if (framesList[firstIndex].MeetsCSReq && framesList[firstIndex].MeetsS1Req && framesList[firstIndex].MeetsS2Req)
                {
                    /*-------------------------------------firstIndex FOUND-------------------------------------*/

                    // Check if this firstIndex found is the last one in the list
                    if (firstIndex == (framesList.Count - 1))
                    {
                        // Create Interval object
                        Interval interval = new Interval(firstIndex, firstIndex);
                        interval.CalculateAverageCorrelation(framesList);
                        interval.CalculateAverageSignalOne(framesList);
                        interval.CalculateAverageSignalTwo(framesList);

                        // Add interval to intervalsList
                        intervalsList.Add(interval);
                    }
                    else
                    {
                        // Move to the next index in search for interval end
                        lastIndex = firstIndex + 1;

                        do
                        {
                            // Check if frame at lastIndex meets all three requirements
                            if (framesList[lastIndex].MeetsCSReq && framesList[lastIndex].MeetsS1Req && framesList[lastIndex].MeetsS2Req)
                            {
                                // Check if frame at lastIndex is the last frame in list
                                if (lastIndex == (framesList.Count - 1))
                                {
                                    // Create Interval
                                    Interval interval = new Interval(firstIndex, lastIndex);
                                    interval.CalculateAverageCorrelation(framesList);
                                    interval.CalculateAverageSignalOne(framesList);
                                    interval.CalculateAverageSignalTwo(framesList);

                                    // Add interval to intervalsList
                                    intervalsList.Add(interval);
                                }
                                else
                                {
                                    // Increment lastIndex
                                    lastIndex++;
                                }
                            }
                            else
                            {
                                // Create Interval object
                                Interval interval = new Interval(firstIndex, (lastIndex - 1));
                                interval.CalculateAverageCorrelation(framesList);
                                interval.CalculateAverageSignalOne(framesList);
                                interval.CalculateAverageSignalTwo(framesList);

                                // Add interval to intervalsList
                                intervalsList.Add(interval);

                                // Move firstIndex to the next index after this newly created interval
                                firstIndex = lastIndex + 1;

                                // Break out of the loop of finding the (already found) lastIndex
                                break;
                            }

                        } while (lastIndex < framesList.Count);
                    }
                }
                else
                {
                    // Increment firstIndex
                    firstIndex++;
                }

            } while (firstIndex < framesList.Count);

        }

        // Output Intervals to .xls file
        private void OutputExcel()
        {
            // Create Excel Application
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            // Make sure that the current system has Excel installed on it
            if (xlApp == null)
            {
                MessageBox.Show("Microsoft Excel is not properly installed on your current system.\n\nOutput file will be .txt", "Microsoft Excel Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Write to .txt file
            }
            else
            {
                MessageBox.Show("Microsoft Excel is recognized on your current system.\n\nOutput file will be .xls", "Microsoft Excel Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Write to .xls file
            }
        }

    }
}
