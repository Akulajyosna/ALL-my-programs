create database stringfn
select ascii('t') as itsascii
select len('hello') as itslength
--select format('0.981','percent')
select upper('jyo') as myname
select lower('JYO') as myname
select replace('jyo','y','o') as myname
select ltrim('  jyo')
select rtrim('jyo   ')
select reverse('jyo') as rev
select concat('hello','birthday') as result
select difference('joyreddy','outreddy')
select left('abcd',4) as name
select right('maya',2) as name
select replicate('name',2) as name
select space('jyo'+space(2)) as name
select stuff('abcdef', 2, 3, 'ijklmn') as name
select substring('jyoreddy',2,5) as name
SELECT STR(123.45, 6, 2)
select QUOTENAME('abc[]def');