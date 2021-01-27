using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



#if DEBUG
namespace AgileBIM.Controls
{
    public class AgileToggleButton : AgileBIM.XamlTemplates.AgileToggleButtonDesigner { }
}

namespace AgileBIM.XamlTemplates
#else
namespace AgileBIM.Controls
#endif
{
#if DEBUG    
    public partial class AgileToggleButtonDesigner : ToggleButton
#else
    public class AgileToggleButton : ToggleButton
#endif
    {

        

#if DEBUG
        private static Type ThisControl = typeof(AgileToggleButtonDesigner);
#else
        private static Type ThisControl = typeof(AgileToggleButton);
        private string Template64 = "PENvbnRyb2xUZW1wbGF0ZSBUYXJnZXRUeXBlPSJ7eDpUeXBlIFRvZ2dsZUJ1dHRvbn0iIHhtbG5zPSJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dpbmZ4LzIwMDYveGFtbC9wcmVzZW50YXRpb24iIHhtbG5zOng9Imh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd2luZngvMjAwNi94YW1sIj4gICAgICAgICAgICANCiAgICAgICAgICAgIDxCb3JkZXIgeDpOYW1lPSJib3JkZXIiIA0KICAgICAgICAgICAgICAgICAgICBCb3JkZXJCcnVzaD0ie1RlbXBsYXRlQmluZGluZyBCb3JkZXJCcnVzaH0iIA0KICAgICAgICAgICAgICAgICAgICBCb3JkZXJUaGlja25lc3M9IntUZW1wbGF0ZUJpbmRpbmcgQm9yZGVyVGhpY2tuZXNzfSIgDQogICAgICAgICAgICAgICAgICAgIENvcm5lclJhZGl1cz0ie0JpbmRpbmcgQm9yZGVyUmFkaXVzLCBSZWxhdGl2ZVNvdXJjZT17UmVsYXRpdmVTb3VyY2UgQW5jZXN0b3JUeXBlPVRvZ2dsZUJ1dHRvbn19IiANCiAgICAgICAgICAgICAgICAgICAgQmFja2dyb3VuZD0ie1RlbXBsYXRlQmluZGluZyBCYWNrZ3JvdW5kfSIgDQogICAgICAgICAgICAgICAgICAgIFNuYXBzVG9EZXZpY2VQaXhlbHM9IlRydWUiPg0KICAgICAgICAgICAgICAgIDxHcmlkIEhvcml6b250YWxBbGlnbm1lbnQ9IlN0cmV0Y2giIFZlcnRpY2FsQWxpZ25tZW50PSJTdHJldGNoIj4NCiAgICAgICAgICAgICAgICAgICAgPENvbnRlbnRQcmVzZW50ZXIgeDpOYW1lPSJjb250ZW50UHJlc2VudGVyIg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBSZWNvZ25pemVzQWNjZXNzS2V5PSJUcnVlIiANCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgQ29udGVudFRlbXBsYXRlPSJ7VGVtcGxhdGVCaW5kaW5nIENvbnRlbnRUZW1wbGF0ZX0iIA0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBDb250ZW50PSJ7VGVtcGxhdGVCaW5kaW5nIENvbnRlbnR9IiANCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgQ29udGVudFN0cmluZ0Zvcm1hdD0ie1RlbXBsYXRlQmluZGluZyBDb250ZW50U3RyaW5nRm9ybWF0fSIgDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIEZvY3VzYWJsZT0iRmFsc2UiIA0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBIb3Jpem9udGFsQWxpZ25tZW50PSJ7QmluZGluZyBIb3Jpem9udGFsQ29udGVudEFsaWdubWVudCwgUmVsYXRpdmVTb3VyY2U9e1JlbGF0aXZlU291cmNlIEFuY2VzdG9yVHlwZT1Ub2dnbGVCdXR0b259fSIgDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIE1hcmdpbj0ie1RlbXBsYXRlQmluZGluZyBQYWRkaW5nfSIgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICANCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgU25hcHNUb0RldmljZVBpeGVscz0ie1RlbXBsYXRlQmluZGluZyBTbmFwc1RvRGV2aWNlUGl4ZWxzfSIgDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFZlcnRpY2FsQWxpZ25tZW50PSJ7QmluZGluZyBWZXJ0aWNhbENvbnRlbnRBbGlnbm1lbnQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iLz4NCiAgICAgICAgICAgICAgICAgICAgPFZpZXdib3ggTWFyZ2luPSIxIiBWaXNpYmlsaXR5PSJDb2xsYXBzZWQiIHg6TmFtZT0iQ2hlY2tNYXJrIj4NCiAgICAgICAgICAgICAgICAgICAgICAgIDxQYXRoIFdpZHRoPSI3Ig0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgSGVpZ2h0PSI3Ig0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgU25hcHNUb0RldmljZVBpeGVscz0iRmFsc2UiDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICBTdHJva2VFbmRMaW5lQ2FwPSJSb3VuZCINCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFN0cm9rZVN0YXJ0TGluZUNhcD0iUm91bmQiDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICBTdHJva2U9IntCaW5kaW5nIEZvcmVncm91bmQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICBTdHJva2VUaGlja25lc3M9IjEiPg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxQYXRoLlN0eWxlPg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8U3R5bGUgVGFyZ2V0VHlwZT0ie3g6VHlwZSBQYXRofSI+DQoNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxTdHlsZS5UcmlnZ2Vycz4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8RGF0YVRyaWdnZXIgQmluZGluZz0ie0JpbmRpbmcgSXNDaGVja2VkLCBSZWxhdGl2ZVNvdXJjZT17UmVsYXRpdmVTb3VyY2UgQW5jZXN0b3JUeXBlPVRvZ2dsZUJ1dHRvbn19IiBWYWx1ZT0iVHJ1ZSI+DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxTZXR0ZXIgUHJvcGVydHk9IkRhdGEiIFZhbHVlPSJNIDEgNCBMIDMgNi41IE0gMyA2LjUgTCA2IDAuNSIvPg0KDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgPC9EYXRhVHJpZ2dlcj4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8RGF0YVRyaWdnZXIgQmluZGluZz0ie0JpbmRpbmcgSXNDaGVja2VkLCBSZWxhdGl2ZVNvdXJjZT17UmVsYXRpdmVTb3VyY2UgQW5jZXN0b3JUeXBlPVRvZ2dsZUJ1dHRvbn19IiBWYWx1ZT0iRmFsc2UiPg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8U2V0dGVyIFByb3BlcnR5PSJEYXRhIiBWYWx1ZT0iTSAwLjUgMC41IEwgNi41IDYuNSBNIDAuNSA2LjUgTCA2LjUgMC41Ii8+DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgPC9EYXRhVHJpZ2dlcj4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDwvU3R5bGUuVHJpZ2dlcnM+DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDwvU3R5bGU+DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgPC9QYXRoLlN0eWxlPg0KDQogICAgICAgICAgICAgICAgICAgICAgICA8L1BhdGg+DQogICAgICAgICAgICAgICAgICAgIDwvVmlld2JveD4NCiAgICAgICAgICAgICAgICA8L0dyaWQ+DQogICAgICAgICAgICA8L0JvcmRlcj4NCiAgICAgICAgICAgIDxDb250cm9sVGVtcGxhdGUuVHJpZ2dlcnM+ICAgICAgICAgICAgICAgIA0KICAgICAgICAgICAgICAgIDxEYXRhVHJpZ2dlciBCaW5kaW5nPSJ7QmluZGluZyBDaGVja1Zpc2liaWxpdHksIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBTZWxmfX0iIFZhbHVlPSJWaXNpYmxlIj4NCiAgICAgICAgICAgICAgICAgICAgPFNldHRlciBQcm9wZXJ0eT0iVmlzaWJpbGl0eSIgVGFyZ2V0TmFtZT0iQ2hlY2tNYXJrIiBWYWx1ZT0iVmlzaWJsZSIvPg0KICAgICAgICAgICAgICAgICAgICA8U2V0dGVyIFByb3BlcnR5PSJWaXNpYmlsaXR5IiBUYXJnZXROYW1lPSJjb250ZW50UHJlc2VudGVyIiBWYWx1ZT0iQ29sbGFwc2VkIi8+DQogICAgICAgICAgICAgICAgPC9EYXRhVHJpZ2dlcj4NCiAgICAgICAgICAgICAgICA8VHJpZ2dlciBQcm9wZXJ0eT0iSXNDaGVja2VkIiBWYWx1ZT0iVHJ1ZSI+DQogICAgICAgICAgICAgICAgICAgIDxTZXR0ZXIgUHJvcGVydHk9IkJhY2tncm91bmQiIFRhcmdldE5hbWU9ImJvcmRlciIgVmFsdWU9IntCaW5kaW5nIEJhY2tncm91bmRDaGVja2VkLCBSZWxhdGl2ZVNvdXJjZT17UmVsYXRpdmVTb3VyY2UgQW5jZXN0b3JUeXBlPVRvZ2dsZUJ1dHRvbn19Ii8+DQogICAgICAgICAgICAgICAgICAgIDxTZXR0ZXIgUHJvcGVydHk9IkJvcmRlckJydXNoIiBUYXJnZXROYW1lPSJib3JkZXIiIFZhbHVlPSJ7QmluZGluZyBCb3JkZXJCcnVzaENoZWNrZWQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iLz4NCiAgICAgICAgICAgICAgICAgICAgPFNldHRlciBQcm9wZXJ0eT0iVGV4dEJsb2NrLkZvcmVncm91bmQiIFRhcmdldE5hbWU9ImNvbnRlbnRQcmVzZW50ZXIiIFZhbHVlPSJ7QmluZGluZyBGb3JlZ3JvdW5kQ2hlY2tlZCwgUmVsYXRpdmVTb3VyY2U9e1JlbGF0aXZlU291cmNlIEFuY2VzdG9yVHlwZT1Ub2dnbGVCdXR0b259fSIvPg0KICAgICAgICAgICAgICAgIDwvVHJpZ2dlcj4NCiAgICAgICAgICAgICAgICA8VHJpZ2dlciBQcm9wZXJ0eT0iSXNFbmFibGVkIiBWYWx1ZT0iRmFsc2UiPg0KICAgICAgICAgICAgICAgICAgICA8U2V0dGVyIFByb3BlcnR5PSJCYWNrZ3JvdW5kIiBUYXJnZXROYW1lPSJib3JkZXIiIFZhbHVlPSJ7QmluZGluZyBCYWNrZ3JvdW5kRGlzYWJsZWQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iLz4NCiAgICAgICAgICAgICAgICAgICAgPFNldHRlciBQcm9wZXJ0eT0iQm9yZGVyQnJ1c2giIFRhcmdldE5hbWU9ImJvcmRlciIgVmFsdWU9IntCaW5kaW5nIEJvcmRlckJydXNoRGlzYWJsZWQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iLz4NCiAgICAgICAgICAgICAgICAgICAgPFNldHRlciBQcm9wZXJ0eT0iVGV4dEJsb2NrLkZvcmVncm91bmQiIFRhcmdldE5hbWU9ImNvbnRlbnRQcmVzZW50ZXIiIFZhbHVlPSJ7QmluZGluZyBGb3JlZ3JvdW5kRGlzYWJsZWQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iLz4NCiAgICAgICAgICAgICAgICA8L1RyaWdnZXI+DQogICAgICAgICAgICAgICAgPFRyaWdnZXIgUHJvcGVydHk9IklzTW91c2VPdmVyIiBWYWx1ZT0iVHJ1ZSI+DQogICAgICAgICAgICAgICAgICAgIDxTZXR0ZXIgUHJvcGVydHk9IkJhY2tncm91bmQiIFRhcmdldE5hbWU9ImJvcmRlciIgVmFsdWU9IntCaW5kaW5nIEJhY2tncm91bmRIb3ZlciwgUmVsYXRpdmVTb3VyY2U9e1JlbGF0aXZlU291cmNlIEFuY2VzdG9yVHlwZT1Ub2dnbGVCdXR0b259fSIvPg0KICAgICAgICAgICAgICAgICAgICA8U2V0dGVyIFByb3BlcnR5PSJCb3JkZXJCcnVzaCIgVGFyZ2V0TmFtZT0iYm9yZGVyIiBWYWx1ZT0ie0JpbmRpbmcgQm9yZGVyQnJ1c2hIb3ZlciwgUmVsYXRpdmVTb3VyY2U9e1JlbGF0aXZlU291cmNlIEFuY2VzdG9yVHlwZT1Ub2dnbGVCdXR0b259fSIvPg0KICAgICAgICAgICAgICAgICAgICA8U2V0dGVyIFByb3BlcnR5PSJUZXh0QmxvY2suRm9yZWdyb3VuZCIgVGFyZ2V0TmFtZT0iY29udGVudFByZXNlbnRlciIgVmFsdWU9IntCaW5kaW5nIEZvcmVncm91bmRIb3ZlciwgUmVsYXRpdmVTb3VyY2U9e1JlbGF0aXZlU291cmNlIEFuY2VzdG9yVHlwZT1Ub2dnbGVCdXR0b259fSIvPg0KICAgICAgICAgICAgICAgIDwvVHJpZ2dlcj4NCiAgICAgICAgICAgICAgICA8VHJpZ2dlciBQcm9wZXJ0eT0iSXNQcmVzc2VkIiBWYWx1ZT0iVHJ1ZSI+DQogICAgICAgICAgICAgICAgICAgIDxTZXR0ZXIgUHJvcGVydHk9IkJhY2tncm91bmQiIFRhcmdldE5hbWU9ImJvcmRlciIgVmFsdWU9IntCaW5kaW5nIEJhY2tncm91bmRQcmVzc2VkLCBSZWxhdGl2ZVNvdXJjZT17UmVsYXRpdmVTb3VyY2UgQW5jZXN0b3JUeXBlPVRvZ2dsZUJ1dHRvbn19Ii8+DQogICAgICAgICAgICAgICAgICAgIDxTZXR0ZXIgUHJvcGVydHk9IkJvcmRlckJydXNoIiBUYXJnZXROYW1lPSJib3JkZXIiIFZhbHVlPSJ7QmluZGluZyBCb3JkZXJCcnVzaFByZXNzZWQsIFJlbGF0aXZlU291cmNlPXtSZWxhdGl2ZVNvdXJjZSBBbmNlc3RvclR5cGU9VG9nZ2xlQnV0dG9ufX0iLz4NCiAgICAgICAgICAgICAgICAgICAgPFNldHRlciBQcm9wZXJ0eT0iVGV4dEJsb2NrLkZvcmVncm91bmQiIFRhcmdldE5hbWU9ImNvbnRlbnRQcmVzZW50ZXIiIFZhbHVlPSJ7QmluZGluZyBGb3JlZ3JvdW5kUHJlc3NlZCwgUmVsYXRpdmVTb3VyY2U9e1JlbGF0aXZlU291cmNlIEFuY2VzdG9yVHlwZT1Ub2dnbGVCdXR0b259fSIvPg0KICAgICAgICAgICAgICAgIDwvVHJpZ2dlcj4NCiAgICAgICAgICAgIDwvQ29udHJvbFRlbXBsYXRlLlRyaWdnZXJzPg0KICAgICAgICA8L0NvbnRyb2xUZW1wbGF0ZT4=";
#endif


#if DEBUG
        public AgileToggleButtonDesigner() { InitializeComponent(); }
#else
        public AgileToggleButton()
        {
            string decoded = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Template64));
            System.IO.StringReader sr = new System.IO.StringReader(decoded);
            System.Xml.XmlReader xr = System.Xml.XmlReader.Create(sr);
            ControlTemplate ct = (ControlTemplate)System.Windows.Markup.XamlReader.Load(xr);

            DefaultStyleKey = ThisControl;
            Template = ct;            
            this.HorizontalContentAlignment = HorizontalAlignment.Center;
            this.VerticalContentAlignment = VerticalAlignment.Center;
        }
#endif

        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), ThisControl, new PropertyMetadata(new CornerRadius(0)));



        public Brush BorderBrushHover { get { return (Brush)GetValue(BorderBrushHoverProperty); } set { SetValue(BorderBrushHoverProperty, value); } }
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"))));

        public Brush BackgroundHover { get { return (Brush)GetValue(BackgroundHoverProperty); } set { SetValue(BackgroundHoverProperty, value); } }
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"))));

        public Brush ForegroundHover { get { return (Brush)GetValue(ForegroundHoverProperty); } set { SetValue(ForegroundHoverProperty, value); } }
        public static readonly DependencyProperty ForegroundHoverProperty =
            DependencyProperty.Register("ForegroundHover", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public Brush BorderBrushChecked { get { return (Brush)GetValue(BorderBrushCheckedProperty); } set { SetValue(BorderBrushCheckedProperty, value); } }
        public static readonly DependencyProperty BorderBrushCheckedProperty =
            DependencyProperty.Register("BorderBrushChecked", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF245A83"))));

        public Brush BackgroundChecked { get { return (Brush)GetValue(BackgroundCheckedProperty); } set { SetValue(BackgroundCheckedProperty, value); } }
        public static readonly DependencyProperty BackgroundCheckedProperty =
            DependencyProperty.Register("BackgroundChecked", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBCDDEE"))));

        public Brush ForegroundChecked { get { return (Brush)GetValue(ForegroundCheckedProperty); } set { SetValue(ForegroundCheckedProperty, value); } }
        public static readonly DependencyProperty ForegroundCheckedProperty =
            DependencyProperty.Register("ForegroundChecked", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public Brush BorderBrushPressed { get { return (Brush)GetValue(BorderBrushPressedProperty); } set { SetValue(BorderBrushPressedProperty, value); } }
        public static readonly DependencyProperty BorderBrushPressedProperty =
            DependencyProperty.Register("BorderBrushPressed", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"))));

        public Brush BackgroundPressed { get { return (Brush)GetValue(BackgroundPressedProperty); } set { SetValue(BackgroundPressedProperty, value); } }
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"))));

        public Brush ForegroundPressed { get { return (Brush)GetValue(ForegroundPressedProperty); } set { SetValue(ForegroundPressedProperty, value); } }
        public static readonly DependencyProperty ForegroundPressedProperty =
            DependencyProperty.Register("ForegroundPressed", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public Brush BorderBrushDisabled { get { return (Brush)GetValue(BorderBrushDisabledProperty); } set { SetValue(BorderBrushDisabledProperty, value); } }
        public static readonly DependencyProperty BorderBrushDisabledProperty =
            DependencyProperty.Register("BorderBrushDisabled", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"))));

        public Brush BackgroundDisabled { get { return (Brush)GetValue(BackgroundDisabledProperty); } set { SetValue(BackgroundDisabledProperty, value); } }
        public static readonly DependencyProperty BackgroundDisabledProperty =
            DependencyProperty.Register("BackgroundDisabled", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"))));

        public Brush ForegroundDisabled { get { return (Brush)GetValue(ForegroundDisabledProperty); } set { SetValue(ForegroundDisabledProperty, value); } }
        public static readonly DependencyProperty ForegroundDisabledProperty =
            DependencyProperty.Register("ForegroundDisabled", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"))));




        public Visibility CheckVisibility { get { return (Visibility)GetValue(CheckVisibilityProperty); } set { SetValue(CheckVisibilityProperty, value); } }
        public static readonly DependencyProperty CheckVisibilityProperty =
            DependencyProperty.Register("CheckVisibility", typeof(Visibility), ThisControl, new PropertyMetadata(Visibility.Collapsed));


    }
}
