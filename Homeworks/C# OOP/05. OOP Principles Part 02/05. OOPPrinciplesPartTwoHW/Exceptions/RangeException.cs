using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class RangeException<T> : ApplicationException
    {
        private T startRange;
        private T endRange;

        public RangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
            this.StartRange = start;
            this.EndRange = end;
        }
        
        public RangeException(string message, T start, T end, Exception exception)
            : base(message, exception)
        {
            this.StartRange = start;
            this.EndRange = end;
        }

        public T StartRange 
        {
            get
            { 
                return this.startRange;
            }
            set 
            { 
                this.startRange = value;
            }
        }

        public T EndRange
        {
            get 
            { 
                return this.endRange;
            }
            set
            {
                this.endRange = value;
            }
        }
    }
}
