using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil badPupil=new BadPupil();
            Pupil gooPupil=new GoodPupil();
            Pupil excPupil=new ExcelentPupil();
            ClassRoom classRoom=new ClassRoom(badPupil,gooPupil,excPupil);
            classRoom.Study();
            classRoom.Read();
            classRoom.Write();
            classRoom.Relax();

            Console.ReadKey();
        }
    }
}
