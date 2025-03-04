/*
	��Kcopy
*/
--===== Formula 1. �إ߷s�W�� =====--
CREATE TABLE TBname
(
	id int PRIMARY KEY not null identity(1,1),
	username varchar(50) not null unique,		   --varchar  ���^��
	created_at datetime not null default GETDATE()
);
INSERT TBname (product_name,price)
VALUES ('item',25);
SELECT * 
FROM TBname;

--===== Formula 2. �d�� Query �� =====--
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
--Table �Ы� �R�� ���m
CREATE TABLE TBname
--�R����Ӫ�� �L�k�M�z identity
DROP TABLE TBname	  
--���m��M�z identity �B�R���ƾڮɫO�d���
TRUNCATE TABLE TBname 
---------------------------------------
--============= DATA ===============--
--------Create, C �s�W���
INSERT TBname (product_name,price)
VALUES ('item',25);
-----------------------------------

----------Read, R �d�߸��-----------------------------------------
--All
SELECT * 
FROM TBname;
--------------------
--WHERE ����
SELECT * FROM employee WHERE emp_name='Tom' ;
SELECT * FROM employee WHERE emp_name!='Tom' ;
SELECT * FROM employee WHERE [name] ='Tom' and age = 20; ;

------------------------------------------------
--JOIN  (INNER LEFT RIGHT FULL �|��) (����i�fAND)
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
--Aggregate Fun. �E�X���------
SELECT count(id) FROM comments --
SELECT sum(id) FROM comments --
SELECT avg(id) FROM comments --
SELECT max(id) FROM comments --
SELECT min(id) FROM comments --
----------------------------------------------

--�Ƨ� ORDER BY
SELECT * FROM TBname ORDER BY price asc 
SELECT * FROM TBname ORDER BY price desc 
--��e(�h��)���
SELECT TOP (20) * FROM products ORDER BY price 
--���L�e�X���è���X��
SELECT  * FROM products 
ORDER BY id
OFFSET 5 rows
FETCH NEXT 10 rows only
--HAVING �`�Ω���ի᪺DATA�z�� (����i�f AND)
SELECT photos_id, count(*) FROM comments
WHERE photos_id <3
GROUP BY photos_id
HAVING aggregateFunction(column) > value AND condition2 

--�l�d��
SELECT * FROM TBname 
WHERE price 
> (SELECT max(price) FROM products WHERE department = 'Toys')
--�ҽk�j�M LIKE
-- % <==== wildcard ���l���e
SELECT * FROM products WHERE p_name LIKE '%Ball%';
-- _ <======��h�֦�ƪ����
SELECT * FROM products WHERE price LIKE '__';

SELECT * FROM products WHERE weights LIKE '_'
and p_name LIKE '%soap%';
----------------------------------------------------------------------

-------------Update, U �ק� �����A�ק�
SELECT * FROM employee WHERE emp_department = 'Account';
update employee set emp_department = 'Accounting' 
WHERE emp_department = 'Account';
SELECT * FROM employee WHERE emp_department = 'Accounting';
-------------------------------------------------------

-------------Delete, D �R�� ���d�A�R
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









