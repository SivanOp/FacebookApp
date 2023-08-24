using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic.Iterator
{
    public class FriendsIterator : IIteratorT<User>
    {
        private FacebookObjectCollection<User> m_FriendCollection;
        private int m_CurrentIndex;

        public FriendsIterator(FacebookObjectCollection<User> i_Collection)
        {
            this.m_FriendCollection = i_Collection;
            m_CurrentIndex = 0;
        }

        public bool MoveNext()
        {
            return ++m_CurrentIndex < m_FriendCollection.Count;
        }

        public User Current
        {
            get { return m_FriendCollection[m_CurrentIndex]; }
        }

        public void Reset()
        {
            m_CurrentIndex = 0;
        }

        public bool IsDone
        {
            get { return m_CurrentIndex >= m_FriendCollection.Count; }
        }

        public IEnumerable<User> NextItem
        {
            get
            {
                while (!this.IsDone)
                {
                    yield return Current;
                    this.MoveNext();
                }
            }
        }
    }
}
