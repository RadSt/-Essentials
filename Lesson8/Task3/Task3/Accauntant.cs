using System.Runtime.InteropServices;

namespace Task3
{
    public class Accauntant
    {
        public bool AskForBonus(Workers worker, int hours)
        {
            if ((int) worker <= hours)
            {
                return true;
            }
            return false;
        }
    }
}