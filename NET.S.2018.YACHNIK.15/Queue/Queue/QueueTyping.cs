using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public class Queue<T> : IEnumerable<T>
    {
        #region Fields

        private T[] array;

        #endregion

        #region Constants

        private const int DEFAULTCAPACITY = 4;

        #endregion

        #region Properties

        public int Count { get; private set; }
        private int Version { get; set; }

        #endregion

        #region Constructors

        public Queue()
        {
            this.array = new T[DEFAULTCAPACITY];
            this.Count = 0;
            this.Version = 0;
        }

        public Queue(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(capacity)} can not be less or equal zero!");
            }

            this.array = new T[capacity];
            this.Count = 0;
            this.Version = 0;
        }

        public Queue(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentOutOfRangeException($"{nameof(collection)} can not be null!");
            }

            ICollection<T> copyCollection = collection as ICollection<T>;

            if (copyCollection != null)
            {
                int count = copyCollection.Count;
                array = new T[count];
                copyCollection.CopyTo(array, 0);
                Count = count;
            }
            else
            {
                Count = 0;

                array = new T[DEFAULTCAPACITY];

                foreach (var item in collection)
                {
                    Enequeue(item);
                }
            }
        }

        #endregion

        #region Public Methods

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Invalid operation, Queue is empty!");
            }

            Version++;

            T item = array[0];
            T[] newArray = new T[Count - 1];
            Array.Copy(this.array, 1, newArray, 0, this.Count - 1);

            for(int i = 0; i < this.Count - 1; i++)
            {
                array[i] = newArray[i];
            }

            array[Count - 1] = default(T);
            Count--;

            return item;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Invalid operation, queue is empty!");
            }

            return array[0];
        }

        public void Enequeue(T item)
        {
            if (Count == this.array.Length)
            {
                T[] newArray = new T[(this.array.Length == 0) ? DEFAULTCAPACITY : 2 * array.Length];
                Array.Copy(this.array, 0, newArray, 0, Count);
                this.array = newArray;
            }

            this.array[Count++] = item;

            Version++;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[Count];

            int i = 0;

            while (i < Count)
            {
                newArray[i] = this.array[i];
                i++;
            }

            return newArray;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            Array.Clear(this.array, 0, Count);
            Count = 0;
            Version++;
        }

        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #region Struct Enumerator

        private struct Enumerator : IEnumerator<T>
        {
            private readonly Queue<T> queue;
            private readonly int version;

            private int index;
            private T currentElement;

            public Enumerator(Queue<T> queue)
            {
                this.queue = queue;
                version = queue.Version;
                index = -1;
                currentElement = default(T);
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (version != queue.Version)
                {
                    throw new InvalidOperationException("Queue was changed!");
                }

                bool result;

                result = ++index >= 0 && index < this.queue.Count;

                currentElement = result ? queue.array[index] : default(T);

                return result;
            }

            public T Current
            {
                get
                {

                    if (index == queue.Count)
                    {
                        throw new InvalidOperationException("Iteration was ended!");
                    }

                    return currentElement;
                }
            }

            object IEnumerator.Current => this.Current;

            void IEnumerator.Reset()
            {
                if (version != queue.Version)
                {
                    throw new InvalidOperationException("Queue was changed!");
                }

                index = -1;

                currentElement = default(T);
            }
        }

        #endregion

    }
}
