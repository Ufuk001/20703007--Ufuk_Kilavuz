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

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Tabloya ürün eklememizi sağlayan kod
        private void Button_ClickEkle(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Marka:  " + textBox1.Text);
            listBox1.Items.Add("Model:  " + textBox2.Text);
            listBox1.Items.Add("Bellek: " + textBox4.Text);
            listBox1.Items.Add("Fiyat:  " + textBox3.Text);
            listBox1.Items.Add("----------------------------");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        //Bütün tabloyu temizlemeye yarayan kod
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
          
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        //Tabloda tekli silme işlemini gerçekleştiren kod
        private void Button_ClickSil(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
        }

        //Fiyat kısmına yalnızca 'int' deger girmemizi sağlayan kod
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int i;
            if (!int.TryParse(textBox3.Text, out i))
            {
                MessageBox.Show("Lütfen Sayı Giriniz!");
                return;
            }
            
        }

        //listBox1 üzerindeki verilerin düzenleme, güncelleme işlemini sağlayan kod
        //listBox1 üzerindeki verilerden herhangi birisine tıklayarak textBox5 üzerine gelen veriyi istediğimiz gibi değiştirebiliriz
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textBox5.Text);
            }
            textBox5.Clear();
        }
        
        //listBox1 üzerindeki verileri textBox5 üzerine çeken kod
        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                textBox5.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
