using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Projects
{
    public class rectangle
    {
        private int width; //instanzvariabeln
        private int height;

        private Color LineColor = Color.White;

        //public string name;
        public string name;

        public int Width
        {
            get
            {
                return this.width; //"this" Referenz zur jetztigen Instanz
            }
            set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height; //"this" Referenz zur jetztigen Instanz
            }
            set
            {
                if(value >= 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("width", "Width must be greater or equal then 0.");
                }
                this.height = value;
            }
        }

        public int Area
        {
            get
            {
                return this.width* this.height;
            }
        }
        /* public string Name
         {
             get
             {
                 return this.name;
             }
             set 
             { 
                 this.name = value; 
             }
         }
        */
        public string Name { get; set; } = "Rechteck";
    }
}
