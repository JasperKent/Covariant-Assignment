using System.Collections.Generic;

namespace CovariantAssignment
{
    public class BagOfFruit
    {
        private List<Fruit> _items = new List<Fruit>();

        public virtual Fruit Get(int idx) => _items[idx];
        public virtual void Add(Fruit f) => _items.Add(f);
    }
}
