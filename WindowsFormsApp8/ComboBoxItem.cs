using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class ComboBoxItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id; 
        }
    }
}
