using System;

namespace Task_2
{
    public struct Worker
    {
        private string fio;
        private string post;
        private int employmentYear;

        public string Fio { get { return fio; }  }
        public string Post { get { return post; }  }
        public int EmploymentYear { get { return employmentYear; } }

        public Worker(string fio, string post, int employmentYear)
        {
            this.fio = fio;
            this.post = post;
            this.employmentYear = employmentYear;
        }

        public string Show()
        {
            return String.Format("ФИО: {0} \n Должность: {1} \n Год принятия: {2} \n",fio,post,employmentYear);
        }

    }
}