using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class MetaData<T>
    {
        public string ReturnCode { get; set; }
        public string ErrorMessage { get; set; }
        public int TotalRecord { get; set; }
        public T Results { get; set; }
    }
}
