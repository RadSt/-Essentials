using System;

namespace Task2
{
    public class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("GoodPupil Read()");
        }

        public override void Study()
        {
            Console.WriteLine("GoodPupil Study()");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil Write()");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil Relax()");
        }
    }
}