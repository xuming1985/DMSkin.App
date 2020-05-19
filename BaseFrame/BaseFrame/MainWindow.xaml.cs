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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaseFrame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Storyboard sto;
        private Storyboard sto2;
        private Storyboard sto3;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddAnimation()
        {
            if(sto == null)
            {
                sto = new Storyboard();
                ThicknessAnimationUsingKeyFrames thicknessAnimation = new ThicknessAnimationUsingKeyFrames();
                thicknessAnimation.AutoReverse = true;
                thicknessAnimation.RepeatBehavior = RepeatBehavior.Forever;
                thicknessAnimation.KeyFrames = new ThicknessKeyFrameCollection();

                var keyFrame = new EasingThicknessKeyFrame();
                keyFrame.Value = new Thickness(1);
                keyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1));
                thicknessAnimation.KeyFrames.Add(keyFrame);

                Storyboard.SetTarget(thicknessAnimation, border);
                Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("BorderThickness"));
                sto.Children.Add(thicknessAnimation);
            }

            if(sto2 == null)
            {
                var b = border2;
                sto2 = (Storyboard)border2.Resources["Storyboard2"];
            }
            if(sto3 == null)
            {
                txt3.RenderTransformOrigin = new Point(0.5, 0.5);
                var tfg = new TransformGroup();
                tfg.Children.Add(new ScaleTransform());
                txt3.RenderTransform = tfg;

                sto3 = new Storyboard();

                DoubleAnimationUsingKeyFrames widthAnimation = new DoubleAnimationUsingKeyFrames();
                widthAnimation.AutoReverse = true;
                widthAnimation.RepeatBehavior = RepeatBehavior.Forever;
                widthAnimation.KeyFrames = new DoubleKeyFrameCollection();

                var widthKeyFrame = new EasingDoubleKeyFrame();
                widthKeyFrame.Value = 1.5;
                widthKeyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1));
                widthAnimation.KeyFrames.Add(widthKeyFrame);

                Storyboard.SetTarget(widthAnimation, txt3);
                Storyboard.SetTargetProperty(widthAnimation, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"));

                DoubleAnimationUsingKeyFrames heightAnimation = new DoubleAnimationUsingKeyFrames();
                heightAnimation.AutoReverse = true;
                heightAnimation.RepeatBehavior = RepeatBehavior.Forever;
                heightAnimation.KeyFrames = new DoubleKeyFrameCollection();

                var heightKeyFrame = new EasingDoubleKeyFrame();
                heightKeyFrame.Value = 1.5;
                heightKeyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1));
                heightAnimation.KeyFrames.Add(heightKeyFrame);

                Storyboard.SetTarget(heightAnimation, txt3);
                Storyboard.SetTargetProperty(heightAnimation, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"));


                sto3.Children.Add(widthAnimation);
                sto3.Children.Add(heightAnimation);
            }
        }

        private void ckStory_Click(object sender, RoutedEventArgs e)
        {
            if (ckStory.IsChecked == true)
            {
                AddAnimation();
                sto.Begin();

                sto2.Begin();
                sto3.Begin();
            }
            else
            {
                sto.Stop();
                sto2.Stop();
                sto3.Stop();
            }
        }
    }
}
