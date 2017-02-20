#include "Student.h"
#include <algorithm>

Student::Student():
	m_number(0),
	m_name("unknown")
{
}

Student::Student(int number, string name):
	m_number(number),
	m_name(name)
{
}


Student::~Student(void)
{
}

void Student::Show()
{
	cout<<"Student number: "<<m_number<<" name: "<<m_name<<endl;
}

bool Student::operator < (const Student& student) const
{
	return (this->m_number < student.m_number);
}

AdvStudent::AdvStudent(int number, string name):
	Student(number, name)
{
}

AdvStudent::~AdvStudent(void)
{
}

void AdvStudent::Show()
{
	cout<<"AdvStudent showing - ";
	Student::Show();
}

bool StudentsClass::AddStudent(Student* student)
{
	bool bUnique = true;

	//check for a student with same id
	//reject, if exists
	for(vector<Student*>::iterator it = vStudens.begin(); it != vStudens.end(); it++)
	{
		if((*it)->m_number == student->m_number)
		{
			bUnique = false;
			break;
		}
	}

	if(bUnique)
		vStudens.push_back(student);

	return bUnique;
}

void StudentsClass::AddStudents(vector<Student*> students)
{
	for (vector<Student*>::iterator it = students.begin(); it != students.end(); it++)
	{
		StudentsClass::AddStudent(*(it));
	}
}

bool StudentsClass::RemoveStudent(Student* student)
{
	for (vector<Student*>::iterator it = vStudens.begin(); it != vStudens.end();it++)
	{
		if ((*it)->m_name == student->m_name && (*it)->m_number == student->m_number)
		{
			vStudens.erase(it);
			return true;
		}
	}
	return false;
}

void StudentsClass::ShowStudents()
{
	for(vector<Student*>::iterator it = vStudens.begin(); it != vStudens.end(); it++)
	{
		//it has pointers interface 
		(*it)->Show();

		//same 
		//(*it).Show();
	}
}

void StudentsClass::SortStudents()
{
	std::sort(vStudens.begin(), vStudens.end());
}