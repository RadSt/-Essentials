using System;
using System.Diagnostics.Contracts;

namespace Task2
{
    public class ClassRoom
    {
        private Random rand = new Random();
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p0)
        {
            pupils[0] = p0;
            pupils[1] = GeneratePupil();
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil p0, Pupil p1)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil p0, Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = p3;
        }

        private Pupil GeneratePupil()
        {
            int r = rand.Next(1, 4);
            switch (r)
            {
                case 1:
                    return new ExcelentPupil();
                case 2:
                    return new GoodPupil();
                case 3:
                    return new BadPupil();
            }
            return new BadPupil();
        }

        public void Study()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
            }
        }

        public void Write()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
            }
        }

        public void Read()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Read();
            }
        }

        public void Relax()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Relax();
            }
        }
    }
}