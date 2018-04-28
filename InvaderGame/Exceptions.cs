
using System;

namespace InvaderGame
{
    class InvaderGameException : Exception
    {
        public InvaderGameException()
        {
        }
        public InvaderGameException(string message): base(message)
        {

        }
    }

    class OutOfBoundsException: InvaderGameException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(String message): base(message)
        {

        }
    }
}
