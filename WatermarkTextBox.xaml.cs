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
    public partial class WatermarkTextBox : TextBox
    { 
        public WatermarkTextBox()
        {
            InitializeComponent();
        }



        public CornerRadius BorderRadius
        {
            get { return (CornerRadius)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(WatermarkTextBox), new PropertyMetadata(new CornerRadius(0)));



        public Brush FocusedBorderColor
        {
            get { return (Brush)GetValue(FocusedBorderProperty); }
            set { SetValue(FocusedBorderProperty, value); }
        }
        public static readonly DependencyProperty FocusedBorderProperty =
            DependencyProperty.Register("FocusedBorder", typeof(Brush), typeof(WatermarkTextBox), new PropertyMetadata(new BrushConverter().ConvertFromString("#FF569DE5") as Brush));



        public Brush WatermarkColor
        {
            get { return (Brush)GetValue(WatermarkColorProperty); }
            set { SetValue(WatermarkColorProperty, value); }
        }
        public static readonly DependencyProperty WatermarkColorProperty =
            DependencyProperty.Register("WatermarkColor", typeof(Brush), typeof(WatermarkTextBox), new PropertyMetadata(Brushes.LightGray));



        public FontFamily WatermarkFontFamily
        {
            get { return (FontFamily)GetValue(WatermarkFontFamilyProperty); }
            set { SetValue(WatermarkFontFamilyProperty, value); }
        }
        public static readonly DependencyProperty WatermarkFontFamilyProperty =
            DependencyProperty.Register("WatermarkFontFamily", typeof(FontFamily), typeof(WatermarkTextBox), new PropertyMetadata());



        public string Watermark
        {
            get { return (string)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }
        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(string), typeof(WatermarkTextBox), new PropertyMetadata(""));



    }
}
