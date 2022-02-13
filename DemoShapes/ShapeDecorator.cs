using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShapes
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void draw()
        {
            decoratedShape.draw();
        }
    }
}
