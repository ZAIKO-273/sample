using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sajdka
{
    public partial class Form1 : Form
    {
        string Input_str = "";  // 入力された数字
        double Result = 0;      // 計算結果
        string Operator = null; // 押された演算子

        double num1 = 0;
        double num2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label.Text = "0";
            Result = 0;
            num1 = 0;
            num2 = 0;
            Operator = null;

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // senderの詳しい情報を取り扱えるようにする
            Button btn = (Button)sender;

            // 押されたボタンの数字(または小数点の記号)
            string text = btn.Text;

            if (Text == ".")
            {
             if(Input_str == "")
                {
                    if (Result != 0)
                    {

                    }
                }
                else
                {
                    // [入力された数字]に連結する
                    Input_str += text;
                    // 画面上に数字を出す
                    label.Text = Input_str;
                    
                }
            }
            else
            {
                // [入力された数字]に連結する
                Input_str += text;
                // 画面上に数字を出す
                label.Text = Input_str;
            }

            if (Result != 0 && Operator == "")
            {
                Result = double.Parse(Input_str);
                
            }
            


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(Result == 0)
            {
                label1.Text = Input_str;
            }
            else
            {
                label1.Text = Result.ToString();
            }
            
            
            num1 = Result;   // 現在の結果
            num2 = 0;            // 入力された文字

            // 入力された文字が空欄なら、計算をスキップする
            if (Input_str != "")
            {
                // 入力した文字を数字に変換
                num2 = double.Parse(Input_str);

                // 四則計算
                if (Operator == "+")
                {
                    Result = num1 + num2;
                }
                if (Operator == "-")
                {
                    Result = num1 - num2;
                }
                if (Operator == "*")
                {
                    Result = num1 * num2;
                }
                if (Operator == "/")
                {
                    if (num2 == 0)
                    {
                        //メッセージボックスを表示する
                        MessageBox.Show("0除算です",
                            "Stop that action now",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        Result = num1 / num2;
                    }
                }

                // 演算子を押されていなかった場合、入力されている文字をそのまま結果扱いにする
                if (Operator == null)
                    Result = num2;
            }

            // 画面に計算結果を表示する
            label.Text = Result.ToString();
            // 今入力されている数字をリセットする
            Input_str = "";

            // 演算子をOperator変数に入れる
            Button btn = (Button)sender;
            Operator = btn.Text;

            label1.Text += Operator;

            if (Operator == "=")
            {
                Operator = "";
                label1.Text = Result.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
