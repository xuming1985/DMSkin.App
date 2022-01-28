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

namespace MarkUI.Demo
{
    /// <summary>
    /// Interaction logic for LampControl.xaml
    /// </summary>
    public partial class LampControl : UserControl
    {
        public LampControl()
        {
            InitializeComponent();
            CompositionTarget.Rendering += UpdateRectangle;
        }

        private void UpdateRectangle(object sender, EventArgs e)
        {
            this.GeometryText.Clip = this.MyEllipseGeometry;
        }
    }
}
