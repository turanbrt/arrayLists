using System.Collections;
using System.Linq.Expressions;

namespace arrayLists;

class Program
{
    static void Main(string[] args)
    {
        //array list
        //system collecitons namespace

        ArrayList list1=new ArrayList();
    
       // list1.Add("TURAN");
        //list1.Add(2);
       // list1.Add(true);
      //  list1.Add('c');

      // Console.WriteLine(list1[1]);
       

        //AddRange
       // Console.WriteLine("ADDRAGE");

        String[] colourString={"red,green,blue,orange"};
        List<int> numbersList=new List<int>{1,299,3,2,53,21,32};

       //list1.AddRange(colourString);
        list1.AddRange(numbersList);

        foreach(var index in list1){
            Console.WriteLine(index);
        }   

        //sort
        Console.WriteLine("****SORT****");
      // list1.Sort();

        list1.Sort();

        foreach(var index in list1){
            Console.WriteLine(index);
        } 
        //BinarrySearch
       Console.WriteLine("****BinarrySearch****");
       Console.WriteLine(list1.BinarySearch(53));        
        //Reverse
        Console.WriteLine("****Reverse****");
        list1.Reverse();
          foreach(var index in list1){
            Console.WriteLine(index);
        } 
        //clear
        Console.WriteLine("***clear***");
        list1.Clear();
           foreach(var index in list1){
            Console.WriteLine(index);
        } 
        
    }
}
