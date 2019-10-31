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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        const string token = "66seSTjHyMgSXpvYjQv0JSwec+JplIPrbOKGxvSBYd1FOzIv6wZNYJjqkeD/VvZkLQTjB9V6pBzT1RWfUKphrnPM3f1Q/tMOfDBV5dxQEydcCaK1WELa1sq5cn0fkEvJ7aP2aeVsE2+9/qFR++c3vQdB04t89/1O/w1cDnyilFU=";

        const string userId = "U0096373bcd4f49c93098761794303f96";

        private void button_text_Click(object sender, RoutedEventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

            bot.PushMessage(userId, "測試訊息");
        }

        private void button_line_picture_Click(object sender, RoutedEventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

            bot.PushMessage(userId, 1, 2);
        }

        private void button_picture_Click(object sender, RoutedEventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

            Uri imageUri = new Uri("https://i.imgur.com/kcQQ8P2.jpg");

            bot.PushMessage(userId, imageUri);
        }
    }
}
