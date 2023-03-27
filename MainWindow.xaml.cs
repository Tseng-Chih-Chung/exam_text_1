using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exam_text_1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //說 Hellow world---------------------------------------------
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txttalk.Text = "Hellow world";
            //讓文字輸入框寫上Hellow world";
        }

        //帳密登入-----------------------------------------------------
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "abc" && txtPassword.Text == "123") 
            {
                txtInfo.Text = "登入成功";
                //帳號=abc且密碼=123 寫登入成功
            }
            else
            {
                txtInfo.Text = "登入失敗";
                //帳號!=abc 或 密碼!=123 寫登入失敗
            }
        }

        //計算BMI-----------------------------------------------------
        double high,heavy,a,b;//宣告浮點數 身高,體重,公分轉公尺,公尺平方
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(txtheight.Text, out high)==true && double.TryParse(txtweight.Text, out heavy)==true)
            {
                if (high != 0 && heavy != 0)
                {
                    b = high / 100;
                    a = b * b;
                    
                    txtBMI.Text = string.Format("{0:0.#}", heavy / a);
                    txtInfo1.Text = "計算成功";
                    //如果身高體重皆能轉換且都不為0則進行計算
                    //b是把公分轉公尺
                    //a是身高平方
                    //BMI換算 體重(公斤)/身高平方 四捨五入至小數點1位 並提醒計算成功
                }
                else
                {
                    txtInfo1.Text = "請輸入正確數字";
                    //如果身高體重皆能轉換 但其中一個為0則不進行計算 並提醒計算失敗
                }
            }
            else 
            {
                txtInfo1.Text = "請輸入正確數字";
                //如果身高體重皆不能轉換 則提醒計算失敗
            }
        }
        //溫度換算-----------------------------------------------------
        double celsius,fahrenheit,output;
        void Fahrenheit_to_Celsius_conversione()//°F轉 °C 的函式
        {
            celsius = (output - 32) * 5 / 9;
            txtCelsius.Text = celsius.ToString();
        }
        void Celsius_conversione_to_Fahrenheit()//°C轉 °F的函式
        {
            fahrenheit = (output * 9 / 5) + 32;
            txtFahrenheit.Text = fahrenheit.ToString();
        }
        private void txtFahrenheit_KeyUp(object sender, KeyEventArgs e)
        {
            if(double.TryParse(txtFahrenheit.Text,out output)==true)
            {
                Fahrenheit_to_Celsius_conversione();
                txtInfo2.Text = "計算正確";
                //如果華氏能轉換成功 則用函示進行運算 並提醒計算成功
            }
            else 
            {
                txtInfo2.Text = "計算錯誤";
                //如果華氏不能轉換成功 則計算失敗
            }
        }
        
        private void txtCelsius_KeyUp(object sender, KeyEventArgs e)
        {
            if(double.TryParse(txtCelsius.Text,out output)==true)
            {
                Celsius_conversione_to_Fahrenheit();
                txtInfo2.Text = "計算正確";
                //如果攝氏能轉換成功 則用函示進行運算 並提醒計算成功
            }
            else
            {
                txtInfo2.Text = "計算錯誤";
                //如果攝氏不能轉換成功 則提醒計算失敗
            }
        }
        
    }
}
