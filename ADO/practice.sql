--����
select * from Teacher order by tAge desc
--����Ĭ�Ϸ�ʽ
select * from Teacher order by tAge asc
--��ȡָ��������
select top 2 tId,tName from Teacher
--��ȡ�ٷ�֮����
select top 30 percent tId,tName from Teacher
--���������С��������ʦ
select top 2 * from Teacher order by tAge desc

--order by �������sql����е����

--distinct ���������������ȥ���ظ�������������ĳһ��
select tAge,tSex from Teacher where tAge=50
select distinct tAge,tSex from Teacher where tAge=50

------------------�ۺϺ���----------------
--������ж��ٸ�������
select COUNT(*) from Teacher
--�������С���ܣ�ƽ��ֵ
select MAX(tAge) from Teacher
select MIN(tAge) from Teacher
select Sum(tAge) from Teacher
select Avg(tAge) from Teacher

--Ҫ�ж�ĳһ�����Ƿ���Nullֵ is null�� not null
--sql�е�null��ʾ��֪��������C#��null����ʾʲô��û��

--������������null�����ǰ�0����
select * from Class
select cName,ISNULL(teacherID,2) from Class

select LEFT('ë��ϯ����',1)

select * from Teacher
--��ѯ�������εĵ���ʦ
select * from Teacher where LEFT(tName,1)='��'
--��ѯ���������д��н����� %�����������ַ�
select * from Teacher where tName like '%��%'

alter table Teacher add tPhone nvarchar(8) null

--�޶��绰������8λ����
alter table Teacher add constraint CK_Teacher_TPhone check(tPhone like '[0-9][0-9][0-9][0-9]
[0-9][0-9][0-9][0-9]')
insert into Teacher (tName,tSex,tAge,tSalary) values ('������1','��',30,3000)

select count(*) from Teacher
