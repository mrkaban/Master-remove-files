/*
 * File Killer
 * Permanent deletion of files.
 * © by Thiseas 21/11/2009  version 1.0
 *              08/03/2010  version 1.5
 * The program is distributed under the terms of the GNU General Public License 
 * Developed in C# 2008
 * 
 * -------------------------------------------------------------------------------------------------
 * Version 1.5 Updates
 * 1. Overcome the 2Gb file size barrier. Now any file size can be deleted.
 * 2. Before rename the file check if the new filename already exist. 
 *    In case that exists, choose another name.
 * 3. Some fixes/adjustments in the user interface.
 * 4. Fix the code to handle all exceptions, not only IOExceptions.
 **********************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace FileKiller
{

    public partial class Form1 : Form
    {
        public const int iBufferLength = 1024000; // Declare 1Mb buffer.

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                insertSelectedFilesIntoArray();
            }
        }

        private void insertSelectedFilesIntoArray()
        {
            string filename;
            bool bFileAlreadyExistInGrid = false;

            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                bFileAlreadyExistInGrid = false;
                filename = openFileDialog1.FileNames[i];

                // Insert it into the Grid if not exist.
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (filename == (string)dataGridView1.Rows[j].Cells[0].Value)
                    {
                        bFileAlreadyExistInGrid = true;
                        break;
                    }
                }
                if (bFileAlreadyExistInGrid)
                    continue;

                dataGridView1.Rows.Add(openFileDialog1.FileNames[i]);
            }

             updateStatusLine();
        }

        private void button_ClearGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            updateStatusLine();       
        }

        private void Button_KillFiles_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Не указаны файлы для удаления. Таблица пуста.","Ой!");
            }
            else if (MessageBox.Show("Вы уверены, что хотите навсегда удалить файлы, которые указаны в таблице?",
                                "Удалить навсегда!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                killTheFiles();
            }
        }

        private void killTheFiles()
        {
            int i = 0;
                
            while (i < dataGridView1.Rows.Count)
            {
                string filename = (string)dataGridView1.Rows[i].Cells[0].Value;
                if (killFile(filename))
                    dataGridView1.Rows.RemoveAt(i);
                else
                    i++;

            }
        }

        private void updateStatusLine()
        {
            label_NumOfFiles.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateStatusLine();
        }

        private bool killFile(string filename)
        {
            bool ret = true;
            try
            {
                byte[] rowDataBuffer;

                // I open a stream w/o the fileshare flag defined. This declines sharing of the current file. 
                // Any request to open the file (by this process or another process) will fail until 
                // the file is closed.
                using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite))
                {

                    Cursor.Current = Cursors.WaitCursor;

                    FileInfo f = new FileInfo(filename);
                    long count = f.Length;
                    long offset = 0;
                    rowDataBuffer = new byte[iBufferLength];
                    while (count >= 0)
                    {
                        int iNumOfDataRead = stream.Read(rowDataBuffer, 0, iBufferLength);
                        // I have inside the rowDataBuffer array the contents of a fragment of the file.
                        if (iNumOfDataRead == 0)
                        {
                            break;
                        }
                        // I will apply the transformations to the rowDataBuffer array and then i will 
                        // write it back to the file.
                        if (radioButton_RandomData.Checked)
                        {
                            Random randombyte = new Random();
                            randombyte.NextBytes(rowDataBuffer);
                        }
                        else if (radioButton_Blanks.Checked)
                        {
                            for (int i = 0; i < iNumOfDataRead; i++)
                                rowDataBuffer[i] = 0;
                        }
                        else
                        {
                            for (int i = 0; i < iNumOfDataRead; i++)
                                rowDataBuffer[i] = Convert.ToByte(Convert.ToChar(Convert.ToInt32(numericUpDown2.Value)));
                        }
                        // Write the new contents back to the file.
                        for (int i = 0; i < numericUpDown1.Value; i++)
                        {
                            stream.Seek(offset, SeekOrigin.Begin);
                            stream.Write(rowDataBuffer, 0, iNumOfDataRead);
                        }

                        // Calculate the new offset & count
                        offset += iNumOfDataRead;
                        count -= iNumOfDataRead;
                    } //while
                } // using

                // Substitude every filename character with random numbers from 0 to 9.
                string newName = "";
                do
                {
                    Random random = new Random();
                    string cleanName = Path.GetFileName(filename);
                    string dirName = Path.GetDirectoryName(filename);

                    int iMoreRandomLetters = random.Next(9);
                    // for more security, don't use only the size of the original filename but add some random letter.
                    for (int i = 0; i < cleanName.Length + iMoreRandomLetters; i++)
                    {
                        newName += random.Next(9).ToString();
                    }
                    newName = dirName + "\\" + newName;
                } while (File.Exists(newName));

                //Rename the file to the new random name.
                File.Move(filename, newName);

                //Delete the file now.
                File.Delete(newName);

            }
            catch 
            {
                ret = false;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return ret;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            About1 about = new About1();
            about.ShowDialog();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label_letter.Text = Convert.ToChar(Convert.ToInt32(numericUpDown2.Value)).ToString();
        }

        private void radioButton_ASCII_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = radioButton_ASCII.Checked;
            label_letter.Enabled = radioButton_ASCII.Checked;
        }

    }
}
