--降序
select * from Teacher order by tAge desc
--升序，默认方式
select * from Teacher order by tAge asc
--获取指定的数量
select top 2 tId,tName from Teacher
--获取百分之多少
select top 30 percent tId,tName from Teacher
--获得年龄最小的两个老师
select top 2 * from Teacher order by tAge desc

--order by 必须放在sql语句中的最后

--distinct 对整个结果集进行去除重复项，而不是针对于某一列
select tAge,tSex from Teacher where tAge=50
select distinct tAge,tSex from Teacher where tAge=50

------------------聚合函数----------------
--求表中有多少个数据项
select COUNT(*) from Teacher
--求最大，最小，总，平均值
select MAX(tAge) from Teacher
select MIN(tAge) from Teacher
select Sum(tAge) from Teacher
select Avg(tAge) from Teacher

--要判断某一个列是否是Null值 is null和 not null
--sql中的null表示不知道，不是C#的null，表示什么都没有

--结果集中如果有null，我们按0处理。
select * from Class
select cName,ISNULL(teacherID,2) from Class

select LEFT('毛主席万岁',1)

select * from Teacher
--查询所有姓宋的的老师
select * from Teacher where LEFT(tName,1)='宋'
--查询所有名字中带有江的人 %代表多个任意字符
select * from Teacher where tName like '%宋%'

alter table Teacher add tPhone nvarchar(8) null

--限定电话号码是8位数字
alter table Teacher add constraint CK_Teacher_TPhone check(tPhone like '[0-9][0-9][0-9][0-9]
[0-9][0-9][0-9][0-9]')
insert into Teacher (tName,tSex,tAge,tSalary) values ('罗永浩1','男',30,3000)

select count(*) from Teacher
