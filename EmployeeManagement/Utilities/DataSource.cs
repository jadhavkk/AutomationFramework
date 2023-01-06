using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
      
        public static object[] InvalidLoginData()

        {

            string[] dataSet1 = new string[3];
            dataSet1[0] = "peter";
            dataSet1[1] = "peter677";
            dataSet1[2] = "Invalid credential";                


            string[] dataSet2 = new string[3];
            dataSet2[0] = "jack";
            dataSet2[1] = "jack565";
            dataSet2[2] = "Invalid credential";

            string[] dataSet3 = new string[3];
            dataSet3[0] = "paul";
            dataSet3[1] = "paul587";
            dataSet3[2] = "Invalid credential";

            object[] allDataSet = new object[3]; //number of testcase
               allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;

            return allDataSet;


        }





        public static object[] ValidLoginData()

        {

            string[] dataSet1 = new string[6];
            dataSet1[0] = "Admin";
            dataSet1[1] = "admin123";
            dataSet1[2] = "john";
            dataSet1[3] = "w";
            dataSet1[4] = "sick";
            dataSet1[5] = "john sick";

            string[] dataSet2 = new string[6];
            dataSet2[0] = "Admin";
            dataSet2[1] = "admin123";
            dataSet2[2] = "paul";
            dataSet2[3] = "j";
            dataSet2[4] = "writer";
            dataSet2[5] = "best writer ";



            object[] allDataSet = new object[2]; //number of testcase
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
           

            return allDataSet;


        }



        public static object[] InvalidLoginData2()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray
                (@"C:\Users\komalj\Desktop\SeleniumC#22\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx", "InvalidLoginTest");
            return data;
        }


        public static object[] AddEmployeeTest()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray
                (@"C:\Users\komalj\Desktop\SeleniumC#22\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx", "AddEEmployeeTest");
            return data;
        }
    }
}


