using FontAwesome.Sharp;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DarkVin_Admin_Pane.User_Controls
{
    /// <summary>
    /// Interaction logic for InfoCard.xaml
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(InfoCard));

         public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(string), typeof(InfoCard));

         public FontAwesome.Sharp.IconChar Icon
        {
            get { return (FontAwesome.Sharp.IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(FontAwesome.Sharp.IconChar), typeof(InfoCard));

         public Color Background1
        {
            get { return (Color)GetValue(Background1Property); }
            set { SetValue(Background1Property, value); }
        }

        public static readonly DependencyProperty Background1Property = DependencyProperty.Register("Background1", typeof(Color), typeof(InfoCard));

         public Color Background2
        {
            get { return (Color)GetValue(Background2Property); }
            set { SetValue(Background2Property, value); }
        }

        public static readonly DependencyProperty Background2Property = DependencyProperty.Register("Background2", typeof(Color), typeof(InfoCard));

        public Color EclipseBackground1 
        {
            get { return (Color)GetValue(EclipseBackground1Property); }
            set { SetValue(EclipseBackground1Property, value); }
        }

        public static readonly DependencyProperty EclipseBackground1Property = DependencyProperty.Register("EclipseBackground1", typeof(Color), typeof(InfoCard));
        public Color EclipseBackground2        {
            get { return (Color)GetValue(EclipseBackground2Property); }
            set { SetValue(EclipseBackground2Property, value); }
        }

        public static readonly DependencyProperty EclipseBackground2Property = DependencyProperty.Register("EclipseBackground2", typeof(Color), typeof(InfoCard));
    }
}
