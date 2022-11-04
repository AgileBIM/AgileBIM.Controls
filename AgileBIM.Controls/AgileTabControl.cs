using System;
using System.Collections.Generic;
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
    public class AgileTabControl : TabControl
    {
        private static Type ThisControl = typeof(AgileTabControl);


        public Thickness HeaderPanelMargin { get { return (Thickness)GetValue(HeaderPanelMarginProperty); } set { SetValue(HeaderPanelMarginProperty, value); } }
        public static readonly DependencyProperty HeaderPanelMarginProperty =
            DependencyProperty.Register("HeaderPanelMargin", typeof(Thickness), ThisControl, new PropertyMetadata(new Thickness(0)));


        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), ThisControl, new PropertyMetadata(new CornerRadius(0)));


        public object TabBlankSpaceContent { get { return (object)GetValue(TabBlankSpaceContentProperty); } set { SetValue(TabBlankSpaceContentProperty, value); } }
        public static readonly DependencyProperty TabBlankSpaceContentProperty =
            DependencyProperty.Register("TabBlankSpaceContent", typeof(object), ThisControl, new PropertyMetadata());


    }
}
