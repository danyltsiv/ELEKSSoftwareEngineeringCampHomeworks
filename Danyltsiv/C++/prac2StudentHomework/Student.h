#pragma once
#include <string>
#include <iostream>
#include <vector>

using namespace std;

class Student
{
public:
	int m_number;
	string m_name;

public:
	Student();
	Student(int number, string name);
	~Student(void);

	//used for sort algoritm, comparing by number
	bool operator < (const Student& student) const;
	virtual void Show();	//перегружена в AdvStudent
};

class AdvStudent : public Student
{
public:
	int m_number;
	string m_name;

public:
	AdvStudent(int number, string name);
	~AdvStudent(void);

	virtual void Show();
};

class StudentsClass
{
	vector<Student*> vStudens;

public:
	void AddStudents(vector<Student*> students);
	bool AddStudent(Student* student);
	bool RemoveStudent(Student* student);
	void ShowStudents();
	void SortStudents();
};