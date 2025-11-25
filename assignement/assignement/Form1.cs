namespace assignement
{
    public partial class Form1 : Form
    {
        private string currentFile = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newNotepad = new Form1(); // Replace Form1 with your form class name
            newNotepad.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newNotepad = new Form1();
            newNotepad.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filter for text files or any files
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Optional: start in Documents folder
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Show the dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the selected file and display it in the textbox
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);

                // Store the current file path for saving later
                currentFile = openFileDialog.FileName;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                // No file selected yet, call Save As
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                // Save to existing file
                try
                {
                    File.WriteAllText(currentFile, textBox1.Text);
                    MessageBox.Show("File saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save As";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                    currentFile = saveFileDialog.FileName; // Remember the saved file path
                    MessageBox.Show("File saved successfully!", "Save As",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }
    }
}
