using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomGraphics
{
    public class CustomGraphics : Control
    {
        private static int slip = 0;
        private Font font;
        private SolidBrush Brushtext;
        private Point point = new Point(0, 0);
        private Timer Mytimer;

        public CustomGraphics()
        {
            Brushtext = new SolidBrush(Color.Black);
            font = new Font(Font, FontStyle.Regular);
            this.DoubleBuffered = true;
            Mytimer = new System.Windows.Forms.Timer() { Interval = 35 };
            AnimationSpeed = 5;
            Mytimer.Enabled = true;
            Mytimer.Tick += delegate { slip += AnimationSpeed; Invalidate(); };

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (DesignMode) {
                pe.Graphics.DrawString(" Литке Надежда\n" + " Лабораторная работа №6\n" + " Вариант 3\n" + " Отображать вращающийся\n"
                    + " в вертикальной плоскости\n" +
                    " шестиугольник", font, Brushtext, point);
            }
            else {
                var middle = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
                var point1 = new Point(0, Height / 2);
                var point2 = new Point(-Width / 4, Height / 4);
                var point3 = new Point(-Width / 4, -Height / 4);
                var point4 = new Point(0, -Height / 2);
                var point5 = new Point(Width / 4, -Height / 4);
                var point6 = new Point(Width / 4, Height / 4);

                pe.Graphics.TranslateTransform(middle.X, middle.Y);
                pe.Graphics.RotateTransform(slip);

                using (var Ppen = new Pen(ForeColor))
                    pe.Graphics.DrawPolygon(Ppen, new Point[] { point1, point2, point3, point4, point5, point6 });
            }
        }
        [
         Browsable(true),
         Category("Speed"),
         Description("Скорость анимации"),
         DefaultValue(5),
        ]
        public int AnimationSpeed { get; set; }
    }
}

