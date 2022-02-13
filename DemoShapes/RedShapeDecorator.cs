using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShapes
{
    public class RedShapeDecorator : ShapeDecorator
    {

        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {

        }

        public override void draw()
        {
            base.draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
