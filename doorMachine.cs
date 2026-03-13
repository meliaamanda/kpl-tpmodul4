using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_103082400039
{
    internal class doorMachine
    {
        enum State { Terkunci, Terbuka }

        private State currentState;

        public doorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void bukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void kunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
