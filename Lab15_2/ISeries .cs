using System;

namespace Lab15_2
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int start;
        int current;
        int difference = 1;
        public int getNext()
        {
            int value = current;
            current += difference;
            return value;
        }

        public void reset()
        {
            current = start;
        }

        public void setStart(int x)
        {
            start = x;
            current = start;
        }
    }

    class GeomProgression : ISeries
    {
        int start;
        int current;
        int ratio = 2;
        public int getNext()
        {
            int value = current;
            current += ratio;
            return value;
        }

        public void reset()
        {
            current = start;
        }

        public void setStart(int x)
        {
            start = x;
            current = start;
        }
    }
}
