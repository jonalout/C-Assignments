using System;
using static System.Console;
class StudentArray
{
    static void Main()
    {
        int[] studentID = { 1012, 1033, 1156, 1569, 1970 };
        string [] firstName = { "Bones", "Welma", "Frank", "Hanes", "Jack" };
        string [] lastName = { "Smith", "Seger", "Mathers", "Solo", "Bush" };
        string [] status = { "freshman", "sophomore", "senior", "junior", "freshman" };
        bool isStudentID = false;
        Write("Please enter a student ID >>");
        int id = Convert.ToInt32(ReadLine());
        for (int i = 0; i < studentID.Length; i++)
        {
            if (studentID[i] == id) 
            {
                isStudentID = true;
                break;
            }
        }
        if (isStudentID) // or if (issStudentID == true)
            WriteLine("The student's first name is {0}", firstName);
        if (isStudentID) // or if (issStudentID == true)
            WriteLine("The student's last name is {0}", lastName);
        if (isStudentID) // or if (issStudentID == true)
            WriteLine("The student is a {0}", status);
        else
            WriteLine("Sorry - student not found");
    }
}