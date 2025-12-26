using System.Dynamic;

namespace ExaminationExample ;
// Base class for HOD and Examiner
class Employee
{
    public int EmployeeId{get; set;}
    public string EmployeeName{get;set;}
    public int DepartmentId{get; set;}
}

class HOD : Employee
{
    public string Responsibility{get; set;}
}

class Examiner : Employee
{
    public bool IsExternal{get; set;}
}
// Department of HOD and Examiner
class Department
{
    public int DepartmentId{get; set;}
    public string DepartmentName{get; set;}
}

// Semester of Students whose exam we have to schedule
class Semester
{
    public int SemesterId{get; set;}
    public int SemesterNumber{get; set;}
}

class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
}
class Batch
{
    public int BatchId { get; set; }
    public string BatchName { get; set; }

        // Students
    public Student Student1;
    public Student Student2;
    public Student Student3;
    
    public Student Student4;
    public Student Student5;
    
}

class Student
{
    public int StudentId{get; set;}
    public string StudentName{get; set;}
    public int SemesterId{get; set;}
}

class Exam
{
    public int ExamId { get; set; }
    public string Subject { get; set; }
    public DateTime ExamDate { get; set; }
    public TimeSpan ExamTime { get; set; }

    public int SemesterId { get; set; }
    public int DepartmentId { get; set; }

    public int CreatedByHodId { get; set; }
}

public class ExaminerAssignment
{
    public int AssignmentId { get; set; }
    public int ExamId { get; set; }
    public int ExaminerId { get; set; }
    
}

class Room
{
    public int RoomId{get; set;}
    public int Capacity{get;set;}
    public string RoomNo{get; set;}
}


class ExaminationExampleClass
{
    
}
