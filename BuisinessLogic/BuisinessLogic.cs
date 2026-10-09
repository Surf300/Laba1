using Model;
namespace BL;

public class BusinessLogic
{
    private List<Student> students = new List<Student>();

    public void AddStudent(string newName, string newSpeciality, string newGroup) //метод теперь принимает не объект класса student, а три строки
    //тем самым сохраняется инкапсуляция, до этого была ошибка, view обращалось к model,
    //так как Student собиралсяя внутри view, теперь view просто отправляет данные в logic
    {
        Student newStudent = new Student();
        newStudent.Name = newName;
        newStudent.Speciality = newSpeciality;
        newStudent.Group = newGroup;
        students.Add(newStudent);
    }
    public bool DeleteStudent(int index) //убрал Console.WriteLine для использования в Form, возвращает bool
    {
        if (index < 0 || index >= students.Count)
            return false;

        students.RemoveAt(index);
        return true;
    }
    //удалил метод ShowStudents, так как для Form и консоли нужны разные методы
    //в каждом проекте свои методы для вывода студентов
    public List<Student> GetStudents()
    {
        return students;
    }

    public Dictionary<string, int> GetHistogram() //возвращает словарь вместо Console.WriteLine для использования в Form
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (Student student in students)
        {
            if (!result.ContainsKey(student.Speciality))
                result.Add(student.Speciality, 1);
            else
                result[student.Speciality]++;
        }

        return result;
    }
}