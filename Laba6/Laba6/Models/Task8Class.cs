using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    class Worker : IComparable<Worker>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Worker other)
        {
            if (other == null) return 1;
            return Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Salary: {Salary:C}";
        }
    }

    class WorkerComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            int result = x.Age.CompareTo(y.Age);

            if (result == 0)
            {
                result = x.Salary.CompareTo(y.Salary);
            }

            return result;
        }
    }

    class WorkerCollection : IEnumerable<Worker>
    {
        private List<Worker> workers = new List<Worker>();

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            return workers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
