using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic.Iterator
{
    public class UserAggregate : IAggregateT<User>
    {
        private User m_User;

        public UserAggregate(User i_User)
        {
            this.m_User = i_User;
        }

        public IIteratorT<User> CreateIterator()
        {
            return new FriendsIterator(m_User.Friends);
        }
    }
}
