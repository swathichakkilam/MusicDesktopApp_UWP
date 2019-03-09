using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WMPLib;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicLib
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlayPlaylist : Page
    {
        public  List<Song> songs = new List<Song>() { new Song() { SongName="GOT Trailer" }, new Song() { SongName = "Clouds" } };

        public PlayPlaylist()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SupplyLevels.ItemsSource = songs;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            var songName = button.Tag;
            songName = songName + ".";

            string uriToLaunch = @"https://www.youtube.com/watch?v=rlR4PJn8b8I";
            var uri = new Uri(uriToLaunch);

            var success = Windows.System.Launcher.LaunchUriAsync(uri);

            //MediaPlayer player = new MediaPlayer();
            //player.AudioCategory = MediaPlayerAudioCategory.Media;
            //player.Volume = 100;
            //player.Source = MediaSource.CreateFromUri(new Uri("D:\\GitHub\\MusicApp\\MusicLib\\MusicLib\\Songs\\" + button.Content + ".wav"));
            //player.Play();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SongsViewGrid_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlayMusic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }
}
