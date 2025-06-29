DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Departments;
CREATE TABLE Departments (
    DepartmentID INTEGER PRIMARY KEY,
    DepartmentName TEXT
);
CREATE TABLE Employees (
    EmployeeID INTEGER PRIMARY KEY,
    FirstName TEXT,
    LastName TEXT,
    DepartmentID INTEGER,
    Salary REAL,
    JoinDate TEXT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');
SELECT 
    D.DepartmentName,
    COUNT(E.EmployeeID) AS EmployeeCount
FROM 
    Departments D
LEFT JOIN 
    Employees E ON D.DepartmentID = E.DepartmentID
WHERE 
    D.DepartmentID = 3
GROUP BY 
    D.DepartmentName;
