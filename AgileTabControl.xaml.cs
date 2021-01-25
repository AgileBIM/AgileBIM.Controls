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
    public partial class AgileTabControl : TabControl
    {
        public AgileTabControl()
        {
            InitializeComponent();
        }


        public Thickness MarginHeaderPanel { get { return (Thickness)GetValue(MarginHeaderPanelProperty); } set { SetValue(MarginHeaderPanelProperty, value); } }
        public static readonly DependencyProperty MarginHeaderPanelProperty =
            DependencyProperty.Register("MarginHeaderPanel", typeof(Thickness), typeof(AgileTabControl), new PropertyMetadata(new Thickness(0)));



        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(AgileTabControl), new PropertyMetadata(new CornerRadius(0)));


        public object TabBlankSpaceContent { get { return (object)GetValue(TabBlankSpaceContentProperty); } set { SetValue(TabBlankSpaceContentProperty, value); } }
        public static readonly DependencyProperty TabBlankSpaceContentProperty =
            DependencyProperty.Register("TabBlankSpaceContent", typeof(object), typeof(AgileTabControl), new PropertyMetadata());


    }
}
