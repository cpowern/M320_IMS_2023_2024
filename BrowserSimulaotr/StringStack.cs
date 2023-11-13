using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{
    public class StringStack
    {
        string[] values;
        int index;        
        public StringStack(int size)
        {
            values = new string[size];
            index = 0;
        }
        public void Push(string value)
        {
            if (index < values.Length)
            {
                values[index++] = value;
            }
            else
            {
                Console.WriteLine("Du kannst keine weiteren URL's hinzufügen");
            }

            Console.WriteLine($"Pushed value: {value}");
        }

        public string Pop()
        {
            if (index > 0)
            {
                string poppedValue = values[index - 1];
                values[--index] = null; // Löschen des Werts
                Console.WriteLine($"Popped value: {poppedValue}");
                Console.WriteLine($"Current state of the array: [{string.Join(", ", values)}]");
                return poppedValue;
            }
            else
            {
                Console.WriteLine("Der Stack ist leer");
                return null;
            }
        }

        public string Peak()
        {
            if(index > 0)
            {
                return values[index- 1];
            }
            else
            {
                Console.WriteLine("Der Stack ist leer.");
                return null;
            }
        }

        public void Clear()
        {
            Array.Clear(values, 0, values.Length);
            index = 0;
        }

        public bool IsEmpty
        {
            get { return index == 0; }
        }

        public int Count
        {
            get { return index; }
        }

        public bool IsFull
        {
            get { return index == values.Length; }
        }

    }
}
