namespace CovariantAssignment
{
    public class BagOfApples : BagOfFruit
    {
        public new Apple Get(int idx) => (Apple)base.Get(idx);
        public void Add(Apple a) => base.Add(a);
    }
}
