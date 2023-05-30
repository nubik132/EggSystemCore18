using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;

//====================================================
// Описание работы классов и методов исходника на:
// https://www.interestprograms.ru
// Исходные коды программ и игр
//====================================================

namespace WpfAnimation.MyCode
{
    class ColorBrushAnimation : CommonMembers
    {

        public ColorBrushAnimation(FrameworkElement parent) : base(parent) { }

        public void ColorRectangleAnimation(Shape shape, Color init, Color to1)
        {
            var colorInit = init;
            double time = 0.1;

            
            SolidColorBrush scb = (SolidColorBrush)shape.Fill;

            // Если объект замороженный, то его нельзя модифицировать.
            if (shape.Fill.IsFrozen == true)
            {
                // Создаём новую кисть для управления цветом фигуры.
                // или клон который можно модифицировать.
                //SolidColorBrush scb = new SolidColorBrush();
                scb = ((SolidColorBrush)shape.Fill).Clone();

                shape.Fill = scb;
            }

            // Теперь можно управлять цветной кистью и
            // значит цветом фигуры.
            shape.Fill = scb;

            // Объекту анимации создаём уникальное имя
            // и регистрируем его в области 
            string regname = "anim_" + shape.Name;

            // Чтобы имя не повторялось.
            //if (parent.FindName(regname) != null) parent.UnregisterName(regname);

            parent.RegisterName(regname, scb);

            var color1 = new ColorAnimation
            {
                From = colorInit,
                To = to1,
                Duration = new Duration(TimeSpan.FromSeconds(time)),
                Name = "color1_" + shape.Name
            };

            if (storyboard.Children.FirstOrDefault(e => e.Name == color1.Name) == null)
            {
                Storyboard.SetTargetName(color1, regname);
                Storyboard.SetTargetProperty(color1, new PropertyPath(SolidColorBrush.ColorProperty));
                storyboard.Children.Add(color1);
            }

            var color2 = new ColorAnimation
            {
                From = to1,
                To = colorInit,
                Duration = new Duration(TimeSpan.FromSeconds(time)),
                BeginTime = TimeSpan.FromSeconds(time),
                Name = "color4_" + shape.Name
            };

            if (storyboard.Children.FirstOrDefault(e => e.Name == color2.Name) == null)
            {
                Storyboard.SetTargetName(color2, regname);
                Storyboard.SetTargetProperty(color2, new PropertyPath(SolidColorBrush.ColorProperty));
                storyboard.Children.Add(color2);
            }


            //storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.Begin(parent);
        }
    }
}
