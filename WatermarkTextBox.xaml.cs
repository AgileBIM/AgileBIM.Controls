using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgileBIM.Controls
{
    /// <summary>
    /// Interaction logic for WatermarkTextBox.xaml
    /// </summary>
    public partial class WatermarkTextBox : TextBox, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
        private string _watermark = "Watermark Text";
        public string Watermark { get { return _watermark; } set { _watermark = value; NotifyPropertyChanged(nameof(Watermark)); } }
        private CornerRadius _radius = new CornerRadius(0);
        public CornerRadius BorderRadius { get { return _radius; } set { _radius = value; NotifyPropertyChanged(nameof(BorderRadius)); } }
        public CornerRadius BorderRadius2 { get { return new CornerRadius(_radius.TopLeft * 2, _radius.TopRight * 2, _radius.BottomRight * 2, _radius.BottomLeft * 2); } }

        public WatermarkTextBox()
        {
            InitializeComponent();
        }
    }
}
