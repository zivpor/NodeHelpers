using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NodeClass
{
    internal class NodeHelper
    {
        #region IsExists
        public static bool IsExists<T>(Node<T> list, T value)
        {
            while(list!=null)
            {
                if (list.GetValue().Equals(value))
                    return true;
                list = list.GetNext();
            }
            return false; 
        }
        #endregion

        #region Count Nodes
        public static int CountList<T>(Node<T> head)
        {
            int counter = 0;
            while (head != null)
            {
                counter++;
                head = head.GetNext();//i++
            }
            return counter;
        }
        #endregion

        #region IsSorted
        public static bool IsSorted(Node<int> ls)
        {
            //כל עוד יש שתי חוליות בשרשרת
            while (ls != null && ls.HasNext())
            {
                //אם לא ממוין

                #region אופציה נוספת
                //Node<int> next=ls.GetNext();
                //if(ls.GetValue()>next.GetValue())
                //return false;
                #endregion
                if (ls.GetValue() > ls.GetNext().GetValue())
                    return false;
                //נתקדם הלאה (כמו לקדם אינדקס במערך
                ls = ls.GetNext();
            }
            return true;
        }
        #endregion

        #region -------------------------------------------
        #endregion

        #region Add To Start
        public static void AddAfterNode1<T>(Node<T> node,T value)
        {
            node.SetNext(new Node<T>(value, node.GetNext()));
        }
        #endregion
        #region Add to End
        public static void Append<T>(Node<T> lst,T value)
        {
           //find last node
            while(lst.HasNext())
            {
                lst = lst.GetNext();
            }
            //add a new node after it
            lst.SetNext(new Node<T>(value));
        }
        #endregion

        #region Add To Middle In Sorted Linked Nodes
        public static void AddToMiddle(Node<int> lst, int val)
        {
            Node<int> toInsert=new Node<int>(val);
            //find the location to insert the node
            while(lst.HasNext()&&lst.GetValue()>lst.GetNext().GetValue())
            {
                lst = lst.GetNext();
            }
            //connect the new node to the list
            toInsert.SetNext(lst.GetNext());
            //connect the "before Node" to the new node
            lst.SetNext(toInsert);

        }
        #endregion
        #region Excersise
        public static void AddAfterValue<T>(Node<T> lst,T after,T value)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Create Methods
        public static Node<double> CreateDoubleList()
        {
           throw new NotImplementedException("To Do"); 
        }
        public static Node<int> CreateIntList()
        {
            Node<int> head = null;
            const int END = -1;

            Console.WriteLine("Please enter first value or -1 to END");
            int value = int.Parse(Console.ReadLine());
            while (value != END)
            {
              //ToDo
            }
            return head;
        }
        public static Node<int> CreateRecursiveList(Node<int> ls)
        {
            throw new NotImplementedException("To Do"); 
        }
        #endregion


        #region Delete

        /// <summary>
        /// פעולה המוחקת את החוליה העוקבת
        /// </summary>
        /// <param name="node"></param>
        /// <returns>מחזירה את החוליה שנמחקה</returns>
        public static Node<T> DeleteAfterNode<T>(Node<T> node )
        {
           throw new NotImplementedException();
        }


        #endregion

        #region Excercises

        public static Node<char> Reverse(Node<char> text)
        {

            throw new NotImplementedException();
           
           
        }

        public static Node<char> ReverseWithDummy(Node<char>text)
        {


            throw new NotImplementedException();
        }




        public static bool IsEqual<X>(Node<X> ls1, Node<X>ls2)
        {
           throw new NotImplementedException("To do");               

        }

        #endregion

    }
}
