using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LordTextBox
{

    public partial class Form1 : Form
    {
        SaveFileDialog sfd = new SaveFileDialog();

        OpenFileDialog ofd = new OpenFileDialog();
        public string contents = string.Empty;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Untitled";
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.FromArgb(255, 77, 62);
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.ForeColor = Color.FromArgb(255, 77, 62);
            BackColor = Color.FromArgb(30, 30, 30);

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textEditorByLord4tbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/ilord4tb");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void theme1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.FromArgb(83, 173, 255);
            richTextBox1.BackColor = Color.FromArgb(0, 40, 40);
            menuStrip1.BackColor = Color.FromArgb(0, 40, 40);
            menuStrip1.ForeColor = Color.FromArgb(83, 173, 255);
            BackColor = Color.FromArgb(0, 40, 40);
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.FromArgb(0, 40, 40);
            richTextBox1.BackColor = Color.White;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.FromArgb(0, 40, 40);
            BackColor = Color.White;
        }

        private void jToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/511j");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    sfd.Title = "Save";
                    if (SaveFile() == 0)
                        return;
                    else
                    {
                        richTextBox1.Text = "";
                        this.Text = "Untitled";
                    }
                    contents = "";
                }
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Text = "";
                    this.Text = "Untitled";
                    contents = "";
                }
                else
                {
                    richTextBox1.Focus();
                }
            }
            else
            {
                this.Text = "Untitled";
                richTextBox1.Text = "";
                contents = "";
            }

        }
        private int SaveFile()
        {
            sfd.Filter = "Text Documents|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                richTextBox1.Focus();
                return 0;
            }
            else
            {
                contents = richTextBox1.Text;
                if (this.Text == "Untitled")
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                else
                {
                    sfd.FileName = this.Text;
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = sfd.FileName;
                return 1;
            }


        }
        private void OpenFile()
        {
            ofd.Filter = "Text Documents|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                richTextBox1.Focus();
            else
            {
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                this.Text = ofd.FileName;
                contents = richTextBox1.Text;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != contents)
            {
                DialogResult dr = MessageBox.Show("Do You want to save the changes made to " + this.Text, "Save", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    SaveFile();
                    OpenFile();
                }
                else if (dr == DialogResult.No)
                {
                    OpenFile();
                }
                else
                {
                    richTextBox1.Focus();
                }
            }
            else
                OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Text Documents|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                richTextBox1.Focus();
            }
            else
            {
                contents = richTextBox1.Text;
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

                this.Text = sfd.FileName;
            }
        }

        private void lord4tb4465ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
