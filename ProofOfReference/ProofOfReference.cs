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
            Console.WriteLine("testList.Count (expected 3)");
            Console.WriteLine(testList.Count); //will show 3 
            Console.WriteLine("creating new List on class object testlist");
            testList = new List<int>();
            Console.WriteLine("testList.Count (expected 0)");
            Console.WriteLine(testList.Count); //will show 0
        }

        public void ThirdMethod()
        {
            Console.WriteLine("third method. Printing count of class member testlist(expected count = 0). Creating local list (localTestList), add 3 ints, print count. Pass localTestList to fourthmethod, and print count of localTestList(which will 0)" );
            Console.WriteLine("testList.Count (expected 0)");
            Console.WriteLine(testList.Count); //will show 0 
            var localTestList = new List<int>();
            localTestList.Add(1);
            localTestList.Add(2);
            localTestList.Add(3);
            Console.WriteLine("localTestList.Count (expected 3)");
            Console.WriteLine(localTestList.Count); //will show 3
            Console.WriteLine("passing localTestList to FourthMethod (will create a new List)");
            FourthMethod(localTestList);
            Console.WriteLine("back in 3rd Method. ");
            Console.WriteLine("localTestList.Count (expected 0)");
            Console.WriteLine(localTestList.Count); //will show 0

            Console.WriteLine("passing class member testList to fifthmethod(will add 2 integer)");
            FifthMethod(testList);
            Console.WriteLine("testList.Count (expected 2)");
            Console.WriteLine(testList.Count); //will show 2 
        }

        private void FourthMethod(List<int> referenceList)
        {
            Console.WriteLine("FourthMethod - List as Parameter");
            Console.WriteLine("referenceList.Count (expected 3)");
            Console.WriteLine(referenceList.Count); //will show 3 
            Console.WriteLine("referenceList = new List()");
            referenceList = new List<int>();
            Console.WriteLine("referenceList.Count (expected 0)");
            Console.WriteLine(referenceList.Count); //will show 0
            Console.WriteLine("FourthMethod end");
        }

        private void FifthMethod(List<int> referenceList)
        {
            Console.WriteLine("FifthMethod");
            Console.WriteLine("referenceList.Count (expected 0)");
            Console.WriteLine(referenceList.Count); //will show 0
            Console.WriteLine("adding 2 integers to referenceList");
            referenceList.Add(1);
            referenceList.Add(2);
            Console.WriteLine("FifthMethod end");
        }



    }
}
