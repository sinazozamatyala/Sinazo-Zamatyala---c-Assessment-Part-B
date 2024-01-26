using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinazo_Zamatyala___c__Assessment_Part_B
{
    public partial class Form1 : Form
    {
        private List<string> wordList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newWord = txtWord.Text.Trim();
            if (!string.IsNullOrEmpty(newWord))
            {
                wordList.Add(newWord);
                UpdateWordList();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string selectedWord = GetSelectedWord();
            string updatedWord = txtWord.Text.Trim();

            if (!string.IsNullOrEmpty(selectedWord) && !string.IsNullOrEmpty(updatedWord))
            {
                int index = wordList.IndexOf(selectedWord);
                if (index != -1)
                {
                    wordList[index] = updatedWord;
                    UpdateWordList();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedWord = GetSelectedWord();
            if (!string.IsNullOrEmpty(selectedWord))
            {
                wordList.Remove(selectedWord);
                UpdateWordList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            wordList.Clear();
            UpdateWordList();
        }

        private void UpdateWordList()
        {
            listBox1.Items.Clear();
            foreach (string word in wordList)
            {
                listBox1.Items.Add(word);
            }
        }
        private string GetSelectedWord()
        {
            if (listBox1.SelectedIndex != -1)
            {
                return listBox1.SelectedItem.ToString();
            }
            return null;
        }

    }

}