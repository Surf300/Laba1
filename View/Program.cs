using Model;
using BL;
using TestData;

BusinessLogic logic = new BusinessLogic();

foreach (Student student in TestStudents.Students)
{
    logic.AddStudent(student);
}

List <Student> students = logic.GetStudents();

logic.ShowStudents(students);

Console.WriteLine($"\n Удалён сдудент с ID 0 \n");

logic.DeleteStudent(0);

logic.ShowStudents(students);

Console.WriteLine("\nГистограмма распределения студентов по специальности");

logic.Gistogramma(students);