using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class RoomFullException : Exception
    {
        public RoomFullException(string message) : base(message) 
        { 
        }
    }
}
