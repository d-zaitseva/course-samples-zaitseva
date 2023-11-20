using System;
using System.Collections.Generic;

namespace Models
{
    public class QueueControl
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;

        public QueueControl(int size)
        {
            QueueLine = new Queue<string>();
            Size = size;
        }

        public Queue<string> QueueLine { get; private set; }
        public int Size { get; private set; }
        public void Enqueue(string person)
        {
            QueueLine.Enqueue(person);
            CheckCount();
        }
        public void Dequeue()
        {
            if (QueueLine.Count == 0)
            {
                Notify?.Invoke($"Queue is empty");
            }
            else
            {
                QueueLine.Dequeue();
                CheckCount();
            }
        }

        public void Clear()
        {
            QueueLine?.Clear();
            Notify?.Invoke($"Queue is empty");
        }

        private void CheckCount()
        {
            if (QueueLine == null)
                throw new NullReferenceException();
            else if (QueueLine.Count == 0)
                Notify?.Invoke($"Queue is empty");
            else if (QueueLine.Count > Size)
                Notify?.Invoke($"Queue is longer then {Size}");
            else return;
        }
    }
}
