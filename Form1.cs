using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalAlgorithmScheme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textRules = rules.Text;
            string[] myRules = textRules.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);//левая колонка

            string[] myBefore = new string[myRules.Length];//Что должно встречаться
            string[] myAfter  = new string[myRules.Length];//На что должно заменяться

            for(int i=0;i< myRules.Length; i++)
            {
                string[] myPair = myRules[i].Split(new String[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                myBefore[i] = myPair[0];
                if (!myPair[1].Contains('E'))//Если E не найдено
                {
                    myAfter[i] = myPair[1];
                }
                else//Удаляем E с правой части
                {
                    int indexE = myAfter[i].IndexOf('E');

                    myAfter[i] = myPair[1].Remove(indexE, myAfter[i].Length);
                }
            }
            string word = inputStr.Text;
            solution.Text = word;

            int j = 0;
            int k = 0;//кол-во действий программы
            while(j< myRules.Length)
            {
                if (word.Contains(myBefore[j])|| myBefore[j].Contains("E"))
                {
                    if (myBefore[j].Contains("E"))
                    {
                        if (myAfter[j][0] != '.')
                        {
                            word = word.Insert(0, myAfter[j]);
                            solution.Text += "->" + word;
                            j = 0;
                        }
                        else
                        {
                            string myAfterlast = "";
                            if (myAfter[j].Length != 1)
                            {
                                myAfterlast = myAfter[j].Substring(1);
                            }
                            word = word.Insert(0, myAfterlast);
                            solution.Text += "->" + word;
                            break;
                        }
                    }
                    int index = word.IndexOf(myBefore[j]);
                    if (myAfter[j][0] == '.' && index!=-1)//Если встречена точка в правой части, то заканчиваем замены
                    {
                        string myAfterlast = "";
                        if (myAfter[j].Length != 1)
                        {
                            myAfterlast = myAfter[j].Substring(1);
                        }
                        word = word.Remove(index, myBefore[j].Length).Insert(index, myAfterlast);
                        solution.Text += "->" + word;
                        break;
                    }
                    else
                    {
                        if(index != -1)
                        {
                            word = word.Remove(index, myBefore[j].Length).Insert(index, myAfter[j]);
                            solution.Text += "->" + word;
                            j = 0;
                        }
                    }
                }
                else
                {
                    j++;
                }
                k++;//Прошло одно действие
                if (k == 700)
                {
                    MessageBox.Show("Произошло зацикливание!");
                    break;
                }
            }
            if (k != 700)
            {
                outputStr.Text = word;
            }
        }
    }
}
