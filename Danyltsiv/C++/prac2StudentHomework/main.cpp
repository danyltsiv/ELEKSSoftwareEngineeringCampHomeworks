#include "Student.h"

template<class T>
class templateClass
{
	T field;

public:
	templateClass(T arg)
	{
		field = arg;
	}

	T getField()
	{
		return field;
	}

	void setField(T arg)
	{
		field = arg;
	}

	void showField()
	{
		field.Show();
	}
};

int main()
{
	Student* student1 = new Student(1, "Anton");
	Student* student2 = new Student(2, "Ruslan");
	Student* student3= new Student(3, "Alex");
	AdvStudent* student4 = new AdvStudent(4, "Genius");
	AdvStudent* student5= new AdvStudent(5, "Albert");

	templateClass<Student> templateObjStudent(*student1);

	//get Student field and call Show method
	templateObjStudent.getField().Show();

	//call showField template class method
	templateObjStudent.showField();

	
	StudentsClass studClass;
	/*studClass.AddStudent(&student5);
	studClass.AddStudent(&student2);
	studClass.AddStudent(&student3);
	studClass.AddStudent(&student1);
	studClass.AddStudent(&student4);*/
	vector<Student*> students;
	students.push_back(student3);
	students.push_back(student2);
	students.push_back(student5);
	students.push_back(student1);
	students.push_back(student4);
	studClass.AddStudents(students);

	cout<<"show students before sort"<<endl;
	studClass.ShowStudents();

	cout<<"sorting..."<<endl;
	studClass.SortStudents();

	cout<<"show students after sort"<<endl;
	studClass.ShowStudents();

	studClass.RemoveStudent(student1);
	studClass.RemoveStudent(student5);
	cout << "Studenti pislya VIDALENNIA" << endl;
	studClass.ShowStudents();

	// uncomment to see it's not buildable with int because of "showField" method

	//templateClass<int> templateObjInt(1);
	//templateObjInt.showField();

	cin.get();

	return 0;
}

/*
������ ��������:

1. � ���� StudentsClass �������

	vector<Student*> vStudens; �� vector<Student> vStudens;
	��������, �� ���� �� �������� :) (�������� ����������)

2. ��������� ������������ �������� �������� � ���������� ������� � ������� �����, 
	���� ������ ��������� �� ������� ������ � ����������, �������� ����

	�������������, �� ���� �������� ��� ����� ��������� �������� � �����, ������ ��������,

3. ������� ������ ��� �������� vStudens � ���.

4. ����������� �������� ��������� �������� � ������ (� ������ ������� ���� ���������� �� �����������)



*/