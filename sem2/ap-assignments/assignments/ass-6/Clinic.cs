using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ass_6
{
    public delegate void DValid(string msg);
    public class Clinic : IEnumerable
    {
        event DValid EventValid;
        SortedList<string, Patient> pList;
        public Clinic()
        {
            pList = new SortedList<string, Patient>();
            EventValid = new DValid(showMessage);
        }

        public void AddNewPatient()
        {
            while (true)
            {
                Patient p = new Patient();
                p.accept();
                try
                {
                    if (pList.ContainsKey(p.pID))
                    {
                        EventValid("the id is already been used");
                    }
                    else
                    {
                        pList.Add(p.pID, p);
                        break;
                    }
                }catch(Exception e)
                {
                    EventValid(e.Message);
                }
                
            }
            

            //Console.WriteLine(pList.Count);
            //Console.ReadKey();
            
            
            
            
            
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in pList.Values)
            {
                yield return item;
            }
        }

        public Patient Search(string patientCode)
        {
            if (pList.ContainsKey(patientCode))
            {
                foreach(Patient item in pList.Values)
                {
                    if (patientCode.ToLower().Equals(item.pID.ToLower()))
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public void remove(string patientCode)
        {
            if (pList.ContainsKey(patientCode))
            {
                pList.Remove(patientCode);
            }
        }
        public void showMessage(string s)
        {
            Console.WriteLine(s);
        }


    }
}
