/* 1st
SELECT t1.emp, t1.emp_fname, t2.DeptName
FROM Employee AS t1 LEFT JOIN Department AS t2
ON t1.dept = t2.Dept_no;
go
CREATE VIEW dept_views AS
SELECT t1.emp, t1.emp_fname,t1.dept, t2.DeptName
FROM Employee AS t1 LEFT JOIN Department AS t2
ON t1.dept = t2.Dept_no;
go
SELECT * FROM dept_views
WHERE dept='d3';
*/
/* 2nd
select * from Project
go
CREATE VIEW proj_views AS
SELECT t1.project_no, t1.project_name,t1.Budget, t2.Job
FROM Project AS t1 LEFT JOIN Works_on AS 
t2 ON t1.project_no = t2.project_no;

go

SELECT project_no,project_name,Job 
FROM proj_views
*/
/* 3(1) rd
SELECT t1.emp, t1.emp_fname, t2.DeptName
FROM Employee AS t1 LEFT JOIN Department AS t2
ON t1.dept = t2.Dept_no;
go
CREATE VIEW dept_views AS
SELECT t1.emp, t1.emp_fname,t1.dept, t2.DeptName
FROM Employee AS t1 LEFT JOIN Department AS t2
ON t1.dept = t2.Dept_no;
go
SELECT * FROM dept_views
WHERE dept='d3';
*/
/*3(2)
select * from Project
go
CREATE VIEW proj_views AS
SELECT t1.project_no, t1.project_name,t1.Budget, t2.Job
FROM Project AS t1 LEFT JOIN Works_on AS 
t2 ON t1.project_no = t2.project_no;

go

SELECT project_no,project_name,Job 
FROM proj_views
*/
/* 3(3)
CREATE VIEW Employees_view AS
SELECT t1.emp_fname, t1.emp_lname,t2.Job,t2.enter_date
FROM Employee AS t1 LEFT JOIN Works_on AS 
t2 ON t1.emp = t2.emp_no;
go
SELECT * FROM Employees_view
-- SELECT DATEDIFF(MM, '1988/06/01', getDate()) AS No_of_Month
 --SELECT DATEPART(MM,GETDATE())
 WHERE DATEDIFF(MM, '1988/06/01', getDate())> 6;
 */
