using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        public static bool IsShabatExist(Node<ShabatRecievers> shabat ,int day, int month, int year)
        {
            while(shabat != null)
            {
                if(shabat.GetValue().GetDay() == day&&shabat.GetValue().GetMonth()==month&&shabat.GetValue().GetYear()==year)
                {
                    return true;
                }
                shabat=shabat.GetNext();
            }
            return false;
        }
        public static Node<ShabatRecievers> DeleteSick(Node<ShabatRecievers> shabat,string name)
        {
            Node<ShabatRecievers> head = shabat;
            if(shabat.GetValue().GetParent1()==name||shabat.GetValue().GetParent2()==name)
            {
                head = head.GetNext();
                shabat.SetNext(null);
                return head;
            }
            while(shabat != null)
            {
                //עשיתי אצל שירה!!!!
            }
            return head;
        }
        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();


        }
    }
}