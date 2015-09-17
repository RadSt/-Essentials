namespace Tack2
{
    public class ClassRoom
    {
        private Pupil[] pupils;
        
        public ClassRoom(Pupil p1,Pupil p2,Pupil p3,Pupil p4)
        {
            this.pupils = new Pupil[4];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            this.pupils = new Pupil[3];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            this.pupils = new Pupil[2];
            pupils[0] = p1;
            pupils[1] = p2;
        }
        public void Study()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }
        public void Read()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }
        public void Write()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }
        public void Relax()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }
    }
}