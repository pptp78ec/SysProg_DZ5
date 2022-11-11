using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SysProg_DZ5
{
    public partial class Form1 : Form
    {
        private int NumSentences { set; get; }
        private int NumWords { set; get; }
        private int NumCharacters { set; get; }
        private int NumSentExcl { set; get; }
        private int NumSentQuest { set; get; }

        private bool taskRunnigFlag = false;

        private string resultsstring = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (taskRunnigFlag == false)
            {
                resultsstring = "";
                if (checkBox1.CheckState != CheckState.Checked && checkBox1.CheckState != CheckState.Checked && checkBox1.CheckState != CheckState.Checked && checkBox1.CheckState != CheckState.Checked && checkBox1.CheckState != CheckState.Checked)
                    resultsstring = "Задачи не выбраны";
                taskRunnigFlag = true;
                try
                {
                    if (checkBox1.CheckState == CheckState.Checked)
                    {
                        NumSentences = Task<int>.Factory.StartNew(() =>
                        {
                            int numsentences = 0;
                            foreach (char el in textBox1.Text)
                            {
                                if (el == '.' || el == '!' || el == '?')
                                {
                                    numsentences++;
                                }
                            }
                             //Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => { NumSentences = numsentences; }));
                             return numsentences;
                        }).Result;
                        
                        resultsstring += $"Кол-во предложений: {NumSentences}\n";
                    }
                    if (checkBox2.CheckState == CheckState.Checked)
                    {
                        NumCharacters = Task<int>.Factory.StartNew(() =>
                        {
                            return textBox1.Text.Length;
                        }).Result;

                        resultsstring += $"Кол-во символов: {NumCharacters}\n";
                    }
                    if (checkBox3.CheckState == CheckState.Checked)
                    {
                        NumWords = Task<int>.Factory.StartNew(() =>
                        {
                            string[] words = textBox1.Text.Split(new char[] { ' ', ',', '.', '.', '?','!', ':', ';'});
                            return words.Length;
                        }).Result;

                        resultsstring += $"Кол-во слов: {NumWords}\n";
                    }
                    if (checkBox4.CheckState == CheckState.Checked)
                    {
                        NumSentExcl = Task<int>.Factory.StartNew(() =>
                        {
                            int numsentences = 0;
                            foreach (char el in textBox1.Text)
                            {
                                if (el == '!' && Char.IsLetter(textBox1.Text[textBox1.Text.IndexOf(el) - 1]))
                                {
                                    numsentences++;
                                }
                            }
                            return numsentences;

                        }).Result;

                        resultsstring += $"Кол-во воскл. предложений: {NumSentExcl}\n";
                    }
                    if (checkBox4.CheckState == CheckState.Checked)
                    {
                        NumSentQuest = Task<int>.Factory.StartNew(() =>
                        {
                            int numsentences = 0;
                            foreach (char el in textBox1.Text)
                            {
                                if (el == '!' && Char.IsLetter(textBox1.Text[textBox1.Text.IndexOf(el) - 1]))
                                {
                                    numsentences++;
                                }
                            }
                            return numsentences;

                        }).Result;

                        resultsstring += $"Кол-во вопрос. предложений: {NumSentQuest}\n";
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    taskRunnigFlag = false;
                    MessageBox.Show(resultsstring, "Результаты");
                    if(checkBox6.CheckState == CheckState.Checked)
                    {
                        using (System.IO.FileStream fs = new System.IO.FileStream("OutputResult.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
                        {
                            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.Default);
                            sw.WriteLine("Результаты:");
                            sw.Write(resultsstring);
                        }
                    }
                }
            }

        }
    }
}
