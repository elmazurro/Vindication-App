using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class ComboBoxItem
    {
        public object Content{ get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
