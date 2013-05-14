using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CMVData
{
    public class ImmutableList<T>
    {
        /// <summary>
        /// An expandable store for starting data and new data shared across a set of immutable lists.
        /// Will grow from insert and add alterations but will never shrink.
        /// </summary>
        private List<T> sharedData;
        /// <summary>
        /// The previous state of this list, changed after each alteration.
        /// </summary>
        private ImmutableList<T> previousState;
        /// <summary>
        /// List of objects in the sharedData that represent the current state of the ImmutableList
        /// </summary>
        private List<T> list;

        /// <summary>
        /// A description of the last change made to this version of the list.
        /// </summary>
        /// <see cref="ListChanges"/>
        /// <see cref="PreviousState"/>
        private string description;

        /* Constructors */
        public ImmutableList()
        {
            List<T> indexedData = new List<T>();
            Initialise(indexedData, "new list: 0 items");
        }

        public ImmutableList(IList<T> indexedData)
        {
            Initialise(indexedData, String.Format("new list: {0} items", indexedData.Count));
        }

        public ImmutableList(IList<T> indexedData, string name)
        {
            Initialise(indexedData, name);
        }

        private void Initialise(IList<T> indexedData, string name)
        {
            description = name;
            sharedData = new List<T>(indexedData);
            previousState = this;

            Flatten(CreateRange(sharedData, 0, sharedData.Count - 1));
        }

        /* Public methods */
        public ImmutableList<T> Add(T item)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("add item: 1 item at {0}", Count));
            ilist.sharedData.Add(item);

            Range<T> existingItems, newItem;
            existingItems = CreateRange(list, 0, Count - 1);
            newItem = CreateRange(ilist.sharedData, ilist.sharedData.Count - 1, ilist.sharedData.Count - 1);

            ilist.Flatten(existingItems, newItem);
            return ilist;
        }

        public ImmutableList<T> AddRange(ICollection<T> items)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("add range: {1} items at {0}", Count, items.Count));
            ilist.sharedData.AddRange(items);

            Range<T> existingItems, newItems;
            existingItems = CreateRange(list, 0, Count - 1);
            newItems = CreateRange(ilist.sharedData, ilist.sharedData.Count - items.Count, ilist.sharedData.Count - 1);

            ilist.Flatten(existingItems, newItems);
            return ilist;
        }

        public ImmutableList<T> Clear()
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("clear list: removed {0} items", Count));

            ilist.list = new List<T>();
            return ilist;
        }

        public bool Contains(T item)
        {
            foreach (T listItem in list)
            {
                if (listItem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] userArray, int index)
        {
            foreach (T item in list)
            {
                userArray.SetValue(item, index);
                index = index + 1;
            }
        }

        public ImmutableList<T> Crop(int start, int end)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("crop: between {0} and {1}", start, end));

            Range<T> keptItems;
            keptItems = CreateRange(list, start, end);

            ilist.Flatten(keptItems);
            return ilist;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        public List<T> GetRange(int start, int end)
        {
            List<T> returnList = new List<T>();
            Range<T> range = new Range<T>(list, start, end);

            List<T> source = this.list;
            int length = range.Length;
            start = range.Start;

            if (range.IsValid())
            {
                for (int i = 0; i <= length; i++)
                {
                    returnList.Add(source[start + i]);
                }
            }

            return returnList;
        }

        public int IndexOf(T checkItem)
        {
            int index = 0;
            foreach (T item in list)
            {
                if (item.Equals(checkItem))
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }

        public ImmutableList<T> Insert(int index, T item)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("insert: 1 item at {0}", index));
            sharedData.Add(item);

            Range<T> previousItems, newItem, nextItems;
            previousItems = CreateRange(list, 0, index - 1);
            newItem = CreateRange(sharedData, sharedData.Count - 1, sharedData.Count - 1);
            nextItems = CreateRange(list, index, Count - 1);

            ilist.Flatten(previousItems, newItem, nextItems);
            return ilist;
        }

        public ImmutableList<T> InsertRange(int index, T[] items)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("insert range: {1} items at {0}", index, items.Length));
            sharedData.AddRange(items);

            Range<T> previousItems, newItems, nextItems;
            previousItems = CreateRange(list, 0, index - 1);
            newItems = CreateRange(ilist.sharedData, ilist.sharedData.Count - items.Length, ilist.sharedData.Count - 1);
            nextItems = CreateRange(list, index, Count - 1);

            ilist.Flatten(previousItems, newItems, nextItems);
            return ilist;
        }

        public ImmutableList<T> Remove(T item)
        {
            int index = IndexOf(item);

            if (index > 0)
            {
                return RemoveAt(index);
            }

            return this;
        }

        public ImmutableList<T> RemoveRange(int start, int end)
        {
            int length = Math.Abs(start - end);
            ImmutableList<T> ilist = CreateVersion(String.Format("remove range: {0} items between {1} and {2}", length, start, end));

            Range<T> previousItems, nextItems;
            previousItems = CreateRange(list, 0, start - 1);
            nextItems = CreateRange(list, end + 1, Count - 1);

            ilist.Flatten(previousItems, nextItems);
            return ilist;
        }

        public ImmutableList<T> RemoveAt(int index)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("remove at: 1 item at {0}", index));

            Range<T> previousItems, nextItems;
            previousItems = CreateRange(list, 0, index - 1);
            nextItems = CreateRange(list, index + 1, Count - 1);

            ilist.Flatten(previousItems, nextItems);
            return ilist;
        }

        public ImmutableList<T> Replace(int index, T item)
        {
            ImmutableList<T> ilist = CreateVersion(String.Format("replace: 1 item at {0}", index));
            ilist.sharedData.Add(item);

            Range<T> previousItems, replacedItem, nextItems;
            previousItems = CreateRange(list, 0, index - 1);
            replacedItem = CreateRange(ilist.sharedData, ilist.sharedData.Count - 1, ilist.sharedData.Count - 1);
            nextItems = CreateRange(list, index + 1, Count - 1); // skip out the replaced item

            ilist.Flatten(previousItems, replacedItem, nextItems);
            return ilist;
        }

        public ImmutableList<T> ReplaceRange(int start, int end, T[] items)
        {
            int length = end - start;
            ImmutableList<T> ilist = CreateVersion(String.Format("replace range: {1} items at {0} with {2} items", start, length, items.Length));
            ilist.sharedData.AddRange(items);

            Range<T> previousItems, newItems, nextItems;
            previousItems = CreateRange(list, 0, start - 1);
            newItems = CreateRange(ilist.sharedData, ilist.sharedData.Count - items.Length, ilist.sharedData.Count - 1);
            nextItems = CreateRange(list, end + 1, Count - 1); // skip out the replaced items

            ilist.Flatten(previousItems, newItems, nextItems);
            return ilist;
        }

        /* Private methods */
        private void Flatten(params Range<T>[] rangeList)
        {
            list = new List<T>();

            /* Copy references from source into local list */
            List<T> source;
            int length, start;
            foreach (Range<T> range in rangeList)
            {
                source = range.Source;
                length = range.Length;
                start = range.Start;

                if (range.IsValid())
                {
                    for (int i = 0; i <= length; i++)
                    {
                        list.Add(source[start + i]);
                    }
                }
            }
        }
        
        private T itemAt(int index)
        {
            return list[index];
        }

        private ImmutableList<T> CreateVersion(string name)
        {
            ImmutableList<T> ilist = new ImmutableList<T>(list, name);
            ilist.previousState = this;

            return ilist;
        }

        private Range<T> CreateRange(List<T> source, int start, int end)
        {
            return new Range<T>(source, start, end);
        }

        /* Properties */
        public T this[int index]
        { 
            get {
                return itemAt(index);
            }
            set
            {
                Replace(index, value);
            }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<ImmutableList<T>> ListChanges
        {
            get
            {
                List<ImmutableList<T>> list = new List<ImmutableList<T>>();
                list.Add(this);
                if (previousState != this)
                {
                    list.AddRange(previousState.ListChanges);
                }
                return list;
            }
        }

        public ImmutableList<T> PreviousState
        {
            get { return previousState; }
        }

        public List<T> List
        {
            get { return list; }
        }

        public IList<T> SourceData
        {
            get { return sharedData; }
        }

        public override string ToString()
        {
            return String.Format("Description: {0}, Changes: {1}, Count: {2}", Description, ListChanges.Count, Count);
        }

        /// <summary>
        /// Represents a range with a start and an end.
        /// </summary>
        public struct Range<S>
        {
            private List<S> src;
            private int s;
            private int e;

            public Range(List<S> source, int start, int end)
            {
                src = source;
                s = start;
                e = end;

                Normalise();
            }

            public List<S> Source
            {
                get { return src; }
            }

            public int Start
            {
                get { return s; }
            }

            public int End
            {
                get { return e; }
            }

            public int Length
            {
                get { return (int)Math.Abs(e - s); }
            }

            private void Normalise()
            {
                int t;

                /* Make the start value less than the end value */
                if (s > e)
                {
                    t = s;
                    s = e;
                    e = t;
                }
            }

            public bool IsValid()
            {
                /* Make the start and end values are within a valid range */
                if (e > src.Count - 1)
                    return false;
                if (s < 0)
                    return false;

                return true;
            }
        }
    }
}
