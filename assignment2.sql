/* assignment2.1.1
SELECT * 
FROM Project
 INNER JOIN Works_on
 ON Project.project_no= Works_on.project_no;
 */
 
 /*1.ca
 --SELECT *
--FROM Project;
--SELECT *
--FROM Works_on
SELECT * FROM Project 
CROSS JOIN Works_on
*/
/* 1.b
--SELECT *
--FROM Project
--Natural Join Works_on;

select * 
from Project  
join Works_on  on Project.project_no=Works_on.project_no;
*/

/*2nd
SELECT emp_no,Job

FROM Project 
CROSS JOIN Works_on
WHERE project_name= 'Gemini';
*/

/* 3rd
SELECT emp_fname,emp_lname

FROM  Employee
CROSS JOIN Department
WHERE DeptName= 'Research' OR DeptName='Account';
*/

/* 4 th
select enter_date 
from Works_on  
Inner join Employee  on Works_on.emp_no=Employee.emp
WHERE Job='Clerk' AND dept='d1';
*/
/*5 th
select project_name 
--select *
from Project  
Inner join Works_on  on Works_on.project_no=Project.project_no
GROUP BY project_name
          HAVING  COUNT('Clerk') > 2;
          */
          
 /* 6th
 SELECT emp_fname,emp_lname 
FROM Employee
 INNER JOIN Works_on
 INNER JOIN Project
 --ON Employee.emp= Works_on.emp_no
 ON Project.project_no= Works_on.project_no 
 ON Works_on.emp_no=Employee.emp
 WHERE Job='manager' AND project_name='Mercury';
 */
 /*8 th
 select e1.emp 
from Employee
e1 join Department e2 on e1.dept=e2.Dept_no;
*/
/* 7 th
Select e.emp_fname,e.emp_lname 
from Employee 
e join Works_on w1 on e.emp=w1.emp_no 
inner join Works_on w2 on w1.enter_date=w2.enter_date
*/
/* 9th(1)
select emp
--select *
from Employee  
Inner join Department  on Employee.dept=Department.Dept_no
WHERE DeptName='Marketing';
*/
/*9th(2)
select emp 
from Employee 
where dept in(select Dept_no from Department where DeptName='Marketing' );
*/



 
