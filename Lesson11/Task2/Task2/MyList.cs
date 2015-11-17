namespace Task2
{
    public class MyList<T>: IMyList<T>
    {
        private T[] cars;
        public MyList()
        {
            cars=new T[0];
        }

        public void Add(T entity)
        {
            var temp = new T[cars.Length + 1];
            for (int i = 0; i < cars.Length; i++)
            {
                temp[i] = cars[i];
            }
            temp[cars.Length] = entity;
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