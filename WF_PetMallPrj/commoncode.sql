/*
	方便copy
*/
--===== Formula 1. 建立新增用 =====--
CREATE TABLE TBname
(
	id int PRIMARY KEY not null identity(1,1),
	username varchar(50) not null unique,		   --varchar  中英文
	created_at datetime not null default GETDATE()
);
INSERT TBname (product_name,price)
VALUES ('item',25);
SELECT * 
FROM TBname;

--===== Formula 2. 查詢 Query 用 =====--
SELECT */[aggregate] FROM TB1 / SubQuery
JOIN TB2 ON col = col
WHERE condition
GROUP BY col/[aggregate]
HAVING condition/[aggregate]


--=========== DataBase ==========--
CREATE DATABASE DB 
DROP DATABASE DB
--===============================--

--============= Table ==============--
--------------------------------------
--Table 創建 刪除 重置
CREATE TABLE TBname
--刪除整個表格 無法清理 identity
DROP TABLE TBname	  
--重置能清理 identity 且刪除數據時保留欄位
TRUNCATE TABLE TBname 
---------------------------------------
--============= DATA ===============--
--------Create, C 新增資料
INSERT TBname (product_name,price)
VALUES ('item',25);
-----------------------------------

----------Read, R 查詢資料-----------------------------------------
--All
SELECT * 
FROM TBname;
--------------------
--WHERE 條件
SELECT * FROM employee WHERE emp_name='Tom' ;
SELECT * FROM employee WHERE emp_name!='Tom' ;
SELECT * FROM employee WHERE [name] ='Tom' and age = 20; ;

------------------------------------------------
--JOIN  (INNER LEFT RIGHT FULL 四種) (條件可搭AND)
SELECT *
FROM comments
JOIN users
ON comments.users_id = users.id

SELECT c.contents, urls
FROM comments AS c
JOIN photos AS p
ON c.photos_id = p.id

SELECT *  
FROM table1
JOIN table2 ON table1.id = table2.id AND table1.date = table2.date
----------------------------------------
--GROUP
SELECT users_id FROM comments
GROUP BY users_id
---------------------------------
--Aggregate Fun. 聚合函數------
SELECT count(id) FROM comments --
SELECT sum(id) FROM comments --
SELECT avg(id) FROM comments --
SELECT max(id) FROM comments --
SELECT min(id) FROM comments --
----------------------------------------------

--排序 ORDER BY
SELECT * FROM TBname ORDER BY price asc 
SELECT * FROM TBname ORDER BY price desc 
--選前(多少)資料
SELECT TOP (20) * FROM products ORDER BY price 
--跳過前幾筆並取後幾筆
SELECT  * FROM products 
ORDER BY id
OFFSET 5 rows
FETCH NEXT 10 rows only
--HAVING 常用於分組後的DATA篩選 (條件可搭 AND)
SELECT photos_id, count(*) FROM comments
WHERE photos_id <3
GROUP BY photos_id
HAVING aggregateFunction(column) > value AND condition2 

--子查詢
SELECT * FROM TBname 
WHERE price 
> (SELECT max(price) FROM products WHERE department = 'Toys')
--模糊搜尋 LIKE
-- % <==== wildcard 表其餘內容
SELECT * FROM products WHERE p_name LIKE '%Ball%';
-- _ <======找多少位數的資料
SELECT * FROM products WHERE price LIKE '__';

SELECT * FROM products WHERE weights LIKE '_'
and p_name LIKE '%soap%';
----------------------------------------------------------------------

-------------Update, U 修改 先找到再修改
SELECT * FROM employee WHERE emp_department = 'Account';
update employee set emp_department = 'Accounting' 
WHERE emp_department = 'Account';
SELECT * FROM employee WHERE emp_department = 'Accounting';
-------------------------------------------------------

-------------Delete, D 刪除 先查再刪
SELECT * FROM employee WHERE emp_name = 'Johnny';
DELETE  FROM employee WHERE emp_name = 'Johnny';
SELECT * FROM employee 
--====================================--

--============= PK FK ===============--
CREATE TABLE photos(
	id int PRIMARY KEY not null identity(1,1),
	urls varchar(300),
	users_id int
	FOREIGN KEY (users_id) REFERENCES otherTable(id)
);
--===================================--









