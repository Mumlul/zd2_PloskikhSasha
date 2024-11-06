using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace yp_2
{
    static class PhoneBookLoader
    {

        public static void Load(PhoneBook phoneBook)
        {
            Excel.Application excelApp = new Excel.Application();
            string filePath = @"C:\PLOSKIKH\yp-2\bin\Debug\contacts.xlsx";
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            int rowCount = worksheet.UsedRange.Rows.Count;

            for(int i = 1; i <= rowCount; i++)
            {
                Contact con = new Contact();
                
              
                con.Name = worksheet.Cells[i, 1].Value.ToString();
                con.Phone = worksheet.Cells[i, 2].Value.ToString();
                phoneBook.AddContact(con);
            }



            excelApp.Visible = false;
            workbook.Close(false);
            excelApp.Quit();


            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);


        }

       



        public static void Save(List<Contact> contact)
        {
            Excel.Application excelApp = new Excel.Application();
            string filePath = @"C:\PLOSKIKH\yp-2\bin\Debug\contacts.xlsx";
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            for (int i = 0; i < contact.Count; i++)
            {
                worksheet.Cells[i + 1, 1].Value = contact[i].Name; 
                worksheet.Cells[i + 1, 2].Value = contact[i].Phone; 
            }

            workbook.Save();
            workbook.Close();
            excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }
}
