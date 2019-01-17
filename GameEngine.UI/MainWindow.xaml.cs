using GameEngine.Map;
using GameEngine.Mod.Standard;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
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

namespace GameEngine.UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private ScenarioManager scenarioManager;
        private Player player;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            player = new Player();

            scenarioManager = ScenarioManager.Load(@"C:\_TempFoloder\1.data", player, new List<string> { @"img\" });

            SetImage();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            SetImage();
        }

        private void SetImage()
        {
            if (scenarioManager == null)
            {
                return;
            }
            var ms = new MemoryStream();
            var image = scenarioManager.Scenarios.First().CreateImage((int)this.ActualHeight);
            image.Save(ms, ImageFormat.Bmp);
            var converter = new ImageSourceConverter();

            img.Source = (ImageSource)converter.ConvertFrom(ms);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            SetImage();
            MessageBox.Show("1");
        }
    }
}
