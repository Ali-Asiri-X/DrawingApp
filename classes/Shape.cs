using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.classes
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics,Pen pen);
        public abstract String getInformation();
        public abstract String getName();
        public abstract Boolean isSelected();
        public abstract bool ContainsPoint(Point point);
        public abstract void setSelected(bool state);
    }
   
}
