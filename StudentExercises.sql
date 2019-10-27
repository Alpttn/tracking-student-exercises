﻿--Create tables for each entity. These should match the dbdiagram ERD you created in Student Exercises Part 1.
CREATE TABLE Cohort (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(55) NOT NULL, 
);
CREATE TABLE Student (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(55) NOT NULL,
    LastName VARCHAR(55) NOT NULL,
    SlackHandle VARCHAR(55) NOT NULL,
    CohortId INTEGER NOT NULL,
	CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);
CREATE TABLE Instructor (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(55) NOT NULL,
    LastName VARCHAR(55) NOT NULL,
    SlackHandle VARCHAR(55) NOT NULL,
    Speciality VARCHAR(55) NOT NULL,
    CohortId INTEGER NOT NULL,
	CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id),
);
CREATE TABLE Exercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(55) NOT NULL,
    Language VARCHAR(55) NOT NULL,
);
--join table
CREATE TABLE StudentExercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    StudentId INTEGER NOT NULL,
    ExerciseId INTEGER NOT NULL,
	CONSTRAINT FK_StudentExercise_Student FOREIGN KEY(StudentId) REFERENCES Student(Id),
	CONSTRAINT FK_StudentExercise_Exercise FOREIGN KEY(ExerciseId) REFERENCES Exercise(Id),
);
--Populate each table with data. You should have 2-3 cohorts, 5-10 students, 4-8 instructors, 2-5 exercises and each
INSERT INTO Cohort (Name) VALUES ('C34');
INSERT INTO Cohort (Name) VALUES ('C35');
INSERT INTO Cohort (Name) VALUES ('C36');
INSERT INTO STUDENT (FirstName, LastName, SlackHandle, CohortId) VALUES ('Allie','Patton','alpttn', 1 )
INSERT INTO STUDENT (FirstName, LastName, SlackHandle, CohortId) VALUES ('Thomas','Shelby','TheBest', 1 )
INSERT INTO STUDENT (FirstName, LastName, SlackHandle, CohortId) VALUES ('Arthur','Shelby','HelloArthur', 2 )
INSERT INTO STUDENT (FirstName, LastName, SlackHandle, CohortId) VALUES ('John','Shelby','lilBro', 3 )
INSERT INTO STUDENT (FirstName, LastName, SlackHandle, CohortId) VALUES ('Polly','Gray','Gypsy', 3 )
INSERT INTO INSTRUCTOR (FirstName, LastName, SlackHandle, Speciality, CohortId) VALUES ('Andy','Collins','askingAlot', 'Pointing', 1)
INSERT INTO INSTRUCTOR (FirstName, LastName, SlackHandle, Speciality, CohortId) VALUES ('Jenna','Solis','stuffedAnimals', 'Singing', 2)
INSERT INTO INSTRUCTOR (FirstName, LastName, SlackHandle, Speciality, CohortId) VALUES ('Bryan','Neilson','highFive', 'High fiving', 3)
--Added steven and jisie
INSERT INTO INSTRUCTOR (FirstName, LastName, SlackHandle, Speciality, CohortId) VALUES ('Steve','Brownlee','SB', 'Dad Jokes', 1)
INSERT INTO INSTRUCTOR (FirstName, LastName, SlackHandle, Speciality, CohortId) VALUES ('Jisie','David','JD', 'Dancing', 3)
INSERT INTO EXERCISE (Name, Language) VALUES ('Urban Planner', 'JavaScript')
INSERT INTO EXERCISE (Name, Language) VALUES ('Urban Planner II', 'JavaScript')
INSERT INTO EXERCISE (Name, Language) VALUES ('List Employees', 'C#')
INSERT INTO EXERCISE (Name, Language) VALUES ('Address Book', 'JavaScript')
INSERT INTO STUDENTEXERCISES (StudentId, ExerciseId) VALUES (1,1)
INSERT INTO STUDENTEXERCISES (StudentId, ExerciseId) VALUES (1,2)

