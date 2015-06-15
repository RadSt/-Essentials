using System;
using System.Diagnostics.Contracts;

namespace Task2
{
    public class ClassRoom
    {
        Random rand=new Random();
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p0)
        {
            pupils[0] = p0;
            pupils[1] = GeneratePupil();
        }
        public ClassRoom(Pupil p1,Pupil p2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
        }
        public ClassRoom(Pupil p1,Pupil p2,Pupil p3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
        }
        public ClassRoom(Pupil p1,Pupil p2,Pupil p3,Pupil p4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }

        private Pupil GeneratePupil()
        {
            int r = rand.Next(1, 4);
            switch (r)
            {
                case 1: return new ExcelentPupil();
            }
        }
    }
}