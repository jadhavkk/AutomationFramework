using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoTest
    {
        public  static object[] DemoValidData()
    
        {

            string[] dataSet1 = new string[2];
            dataSet1[0] = "peter";
            dataSet1[1] = "peter677";

            string[] dataSet2 = new string[2];
            dataSet2[0] = "jack";
            dataSet2[1] = "jack565";

            string[] dataSet3 = new string[2];
            dataSet3[0] = "paul";
            dataSet3[1] = "paul587";


             object[] allDataSet= new object[3]; //number of testcase
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;

            return allDataSet;


        }

        [Test,TestCaseSource(nameof(DemoValidData))]
        public void DemoValidLogin(string username,string password)
        {
            Console.WriteLine("Hi "+username+password);
        }
    }
}
