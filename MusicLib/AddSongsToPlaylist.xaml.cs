using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicLib
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddSongsToPlaylist : Page
    {
        public  List<string> songs = new List<string>();
        public AddSongsToPlaylist()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var playlist = (Playlist)e.Parameter;

            for (int i=0; i<playlist.NoOfSongs; i++)
            {
                this.songs.Add("Song " + i);
            }

            DataContext = this;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PlayPlaylist));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
