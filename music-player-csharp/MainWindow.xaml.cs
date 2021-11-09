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
using System.Media;

namespace music_player_csharp
{
    public partial class MainWindow : Window
    {
        // Path to the music/sound
        static string source = @"G:\music.wav";
        // Initialize player
        SoundPlayer player = new SoundPlayer(source);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            
            player.Play();
            label_status.Content = "playing";
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            label_status.Content = "pause";
        }
    }
}
