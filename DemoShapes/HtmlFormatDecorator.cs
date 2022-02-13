using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShapes
{
    public class HtmlFormatDecorator : ShapeDecorator
    {
        public HtmlFormatDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("Show the Shape in HTML formato <div></div>");
        }
    }
}
