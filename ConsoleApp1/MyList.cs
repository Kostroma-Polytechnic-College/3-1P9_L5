using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyList<UserType>
    {
        public class Item
        {
            public UserType Value;
            public Item Next;
        }
        Item head;

        public void Add(UserType value)
        {
            Item newItem = new Item() { Value = value };
            if(head == null)
            {
                head = newItem;
                return;
            }
            Item currentItem = head;
            while (currentItem.Next != null)
                currentItem = currentItem.Next;
            currentItem.Next = newItem;
        }

        public UserType Get(int index)
        {
            Item currentItem = head;
            for (int i = 0; i < index; i++)
                currentItem = currentItem.Next;
            return currentItem.Value;
        }
    }
}
