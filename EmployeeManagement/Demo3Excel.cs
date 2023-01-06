using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Demo3Excel {


        [Test]
        public void DemoExcelRead() {
            XLWorkbook book = new XLWorkbook(@"C:\\Users\\komalj\\Desktop\\SeleniumC#22\\AutomationFramework\\EmployeeManagement\\TestData\\Orange_data.xlsx");


            IXLWorksheet sheet = book.Worksheet("InvalidLoginData");

            IXLRange range = sheet.RangeUsed();

            /* string value =range.Cell(1,1).GetString();
            range.Cell(1, 2).GetString();

             range.Cell(1, 3).GetString();

             range.Cell(2,1 ).GetString();
             range.Cell(3, 1).GetString();
            Console.WriteLine(value);*/

            /* for(int r=2; r<=4; r++) { 

                 for(int c=1; c<=4; c++)
                 {
                     string value = range.Cell(r,c).GetString();
                     Console.WriteLine(value);



                 }


             } book.Dispose();


             }*/

            object[] obj = new object[3];
           



            for ( int r=1; r <=;r++)
            {
              

                // string[]  create
                for (int c=1; c <= dataSet1.Length; c++)
                {

                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);

                }

               // Load string[] to object[]
            }




           book.Dispose();
            // make sure object[] is ready with all test case



            



            
        
        }
    }
}
