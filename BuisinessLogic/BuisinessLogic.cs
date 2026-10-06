using Model;

namespace BL;

public class BusinessLogic
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DeleteStudent(int index)
    {
        students.RemoveAt(index);
    }

    public List<Student> GetStudents()
    {
        return students;
    }

    public void ShowStudents(List<Student> students)
    {
        Console.WriteLine($"ID | Имя | Специальность | Группа");
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{i} | {students[i].Name} | {students[i].Speciality} | {students[i].Group}");
        }
    }

    public void Gistogramma(List<Student> students)

    {
        Dictionary<string, int> studentsSpeciality = new Dictionary<string, int>();

        foreach (Student student in students)

        {
            if (!studentsSpeciality .ContainsKey(student.Speciality))

            {
                studentsSpeciality .Add(student.Speciality, 1);
            }

            else

            {
                studentsSpeciality [student.Speciality]++;
            }
        }
        foreach (KeyValuePair<string, int> Speciality in studentsSpeciality)
        {
            Console.WriteLine($"{Speciality.Key} - {Speciality.Value}");
        }
    }
}