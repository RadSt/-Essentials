namespace Task2
{
    public class CarCollection<T> where T:class
    {
        private T[] cars;
        public CarCollection(int n)
        {
            cars=new T[0];
        }

        public void Add(T entity)
        {
            var temp = new T[cars.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = entity;
            }
            cars = temp;
        }

        public T this [int index]
        {
            get
            {
                return cars[index];
            }
        }

        public int Count { get { return cars.Length; } }

        public void Clear()
        {
            cars=new T[0];
        }
    }
}