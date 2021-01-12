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

namespace InstagramClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class MovieData
        {
            private BitmapImage _ImageData;
            public BitmapImage ImageData
            {
                get { return this._ImageData; }
                set { this._ImageData = value; }
            }

        }

        public MainWindow()
        {
            InitializeComponent();

            this.TvBox.ItemsSource = new MovieData[]
            {
                new MovieData{ ImageData=LoadImage("Images\\beach-2089936_1920.jpg")},
                new MovieData{ ImageData=LoadImage("Images\\gallery-3114279_1920.jpg")},
                new MovieData{ ImageData=LoadImage("Images\\horses-1149974_1280.jpg")},
                new MovieData{ ImageData=LoadImage("Images\\landscape-1802337_1920.jpg")},
                new MovieData{ ImageData=LoadImage("Images\\parent-863085_1920.jpg")},
                new MovieData{ ImageData=LoadImage("Images\\pedestrians-1209316_1920.jpg")}
            };


        }

        // for this code image needs to be a project resource
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/InstagramClone;component/" + filename));
        }

        private void Top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
