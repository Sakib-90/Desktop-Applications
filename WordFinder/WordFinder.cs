using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinder
{
    public partial class WordFinder : Form
    {
        public WordFinder()
        {
            InitializeComponent();
            wordCountLabel.Visible = false;
            sentenceCountLabel.Visible = false;

            articleRichTextBox.Text = "hi i am sakib. sakib is me sakib. that is why i am sakib, Sakib. sakibulhasan and me sakib. sakiB is montagonusticuslong.";
            wordSearchingTextBox.Text = "sakib";
        }

        private void searchButoon_Click(object sender, EventArgs e)
        {
            sentenceListBox.Items.Clear();
            wordCountLabel.Visible = true;
            sentenceCountLabel.Visible = true;

            int wordIndex = 0;
            int wordCount = 0;
            int sentenceCount = 0;

            string[] patternArray = new string[1000];
            patternArray[0] = " " + wordSearchingTextBox.Text.ToLower() + ".";
            patternArray[1] = " " + wordSearchingTextBox.Text.ToLower() + ",";
            patternArray[2] = " " + wordSearchingTextBox.Text.ToLower() + " ";

            string[] sentenceAray = articleRichTextBox.Text.Split('.');
            for (int i = 0; i < 3; i++)
            {
                while (wordIndex < articleRichTextBox.Text.ToLower().LastIndexOf(patternArray[i]))
                {
                    articleRichTextBox.Find(patternArray[i], wordIndex, articleRichTextBox.TextLength, RichTextBoxFinds.None);
                    articleRichTextBox.SelectionBackColor = Color.YellowGreen;
                    wordIndex = articleRichTextBox.Text.ToLower().IndexOf(patternArray[i], wordIndex) + 1;
                    wordCount++;
                }
                wordIndex = 0;


                foreach (string j in sentenceAray)
                {
                    string singleSentence = j + ".";
                    if (singleSentence.ToLower().Contains(patternArray[i]) && !sentenceListBox.Items.Contains(j))
                    {
                        sentenceListBox.Items.Add(j);
                        sentenceCount++;
                    }
                }
            }
            wordCountLabel.Text = wordCount.ToString();
            sentenceCountLabel.Text = sentenceCount.ToString();
        }
    }
}
