using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Task91522.Views
{
    /// <summary>
    /// Interaction logic for CartesianPlaneView.xaml
    /// </summary>
    public partial class CartesianPlaneView : Window
    {
        public CartesianPlaneView()
        {
            InitializeComponent();
        }

        private void File_OnClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Browse Files",
                Filter = "Json files (*.json)|*.json"
            };

            if (dialog.ShowDialog() == true)
            {
                this.FilePathTextBox.Text = dialog.FileName;

                this.FilePathTextBox
                    .GetBindingExpression(TextBox.TextProperty)
                    ?.UpdateSource();
            }
        }

    }
}
