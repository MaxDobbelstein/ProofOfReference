using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfReference
{
    public class ProofOfReference
    {
        private List<int> testList = new List<int>();

        public void FirstMethod()
        {
            Console.WriteLine("first method. adding 3 integers to class member testList");
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
        }

        public void SecondMethod()
        {
            Console.WriteLine("second method. printing count of class member testlist, create new list (testlist = new List<int>() ) printing count of testlist");
            Console.WriteLine(testList.Count); //will show 3 
            testList = new List<int>();
            Console.WriteLine(testList.Count); //will show 0
        }

        public void ThirdMethod()
        {
            Console.WriteLine("third method. Printing count of class member testlist(expected count = 0). Creating local list (localTestList), add 3 ints, print count. Pass localTestList to fourthmethod, and print count of localTestList(which will 0)" );
            Console.WriteLine(testList.Count); //will show 0 
            var localTestList = new List<int>();
            localTestList.Add(1);
            localTestList.Add(2);
            localTestList.Add(3);
            Console.WriteLine(localTestList.Count); //will show 3
            FourthMethod(localTestList);
            Console.WriteLine(localTestList.Count); //will show 0

            Console.WriteLine("passing class member testList to fifthmethod(will add 2 integer)");
            FifthMethod(testList);
            Console.WriteLine("showing count of class member test list which will show 2");
            Console.WriteLine(testList.Count); //will show 2 
        }

        private void FourthMethod(List<int> referenceList)
        {

            Console.WriteLine(referenceList.Count); //will show 3 
            referenceList = new List<int>();
            Console.WriteLine(referenceList.Count); //will show 0
            
        }

        private void FifthMethod(List<int> referenceList)
        {
            Console.WriteLine(referenceList.Count); //will show 0
            referenceList.Add(1);
            referenceList.Add(2);
        }



    }
}
