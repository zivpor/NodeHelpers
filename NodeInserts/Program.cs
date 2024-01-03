using NodeClass;
namespace NodeInserts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> lst = new Node<int>(4, new Node<int>(1, new Node<int>(1, new Node<int>(1))));
            Console.WriteLine(NodeHelper.CountNoOfDuplicationV2(lst,4));
        }
    }
}