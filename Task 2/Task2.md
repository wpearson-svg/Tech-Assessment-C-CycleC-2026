1. Open SQL Server Management Studio (or an equivalent SQL Management Software)
2. Connect to Northwind DB (Same DB as you used in Geek Week)
3. Write a query that shows each employee’s first name and the number of orders they have placed. Group the results by employee’s first name.

Please add your SQL query below AND add explanation of the query: 

```
SELECT e.FirstName, COUNT(o.orderid) AS order_count
FROM employees e
JOIN orders o ON e.employeeid = o.employeeid
GROUP BY e.firstname;
```
```
SELECT e.FirstName, COUNT(o.orderid) AS order_count
selecting the columns and counting the number of orders
FROM employees e
from the employees table and assing a nickname
JOIN orders o ON e.employeeid = o.employeeid
Join the tables via their employeeid columns
GROUP BY e.firstname;
Finally group by employee's first name
```

4. For submission commit and push this .md file to Github
