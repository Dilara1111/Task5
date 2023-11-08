using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Tapşırıq:
            //Student classınız olsun. int[] Grades propertysi olsun.
            //Studentdən obyekt yaradıb grades-i set edəndə arrayin yalnız cüt ədədlərindən ibarət yeni bir array set olunsun.
            //Yəni əgər mən
            //Student st = new Student();
            //st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }
            //yazıramsa st.Grades { 2,4,6,8}-ə bərabər olsun//  
            Student st = new Student();
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        }
    }
}
