using System;
using System.Net;
using System.Windows;
using HtmlAgilityPack;

namespace HamletApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
        
            string url = "https://www.gutenberg.org/files/1524/1524-0.txt";

            using (WebClient client = new WebClient())
            {
                try
                {
                    
                    string text = client.DownloadString(url);

                 
                    HamletTextBox.Text = text;
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Помилка при завантаженні тексту: " + ex.Message);
                }
            }
        }
    }
}