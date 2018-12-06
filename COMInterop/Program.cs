using System;
using System.Collections.Generic;
using System.Linq;
using COMInterop.Models;
using LinqToDB;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new Northwind())
            {
                var products = connection.Products;
                var employees = connection.Employees;
                var regions = connection.Regions;
                DisplayInExcel(products);
                DisplayInExcel(employees);
                DisplayInExcel(regions);
            }
        }

        static void DisplayInExcel<T>(IEnumerable<T> elements)
        {
            var excelApp = new Excel.Application();

            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            var typeOfElement = typeof(T).GetProperties();

            var column = 1;
            foreach (var prop in typeOfElement)
            {
                workSheet.Cells[1, column] = prop.Name;
                column++;
            }

            for (int i = 2; i <= elements.Count() + 1; i++)
            {
                for (int j = 1; j <= typeOfElement.Length; j++)
                {
                    workSheet.Cells[i, j] = typeOfElement[j - 1].GetValue(elements.ToArray()[i - 2]);
                }
            }

        }
    }
}
