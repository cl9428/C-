
--����jiudian_guanli���ݿ�
	CREATE DATABASE jiudian_guanli
	ON PRIMARY
	(
		NAME = jiudian_guanli_data,
		FILENAME = 'D:\jiudian_guanli.mdf',
		SIZE = 4MB,
		MAXSIZE = 10MB,
		FILEGROWTH = 1MB
	)
	LOG ON
	(
		NAME = jiudian_guanli_log,
		FILENAME = 'D:\jiudian_guanli.ldf',
		SIZE = 1MB,
		MAXSIZE = 5MB,
		FILEGROWTH = 1MB
	)
	GO

use jiudian_guanli
go

--����guest���ݱ�
	CREATE TABLE guest
	(
		���� Varchar(10) NOT NULL,
		���� Varchar(11) NOT NULL,
		�Ա� Varchar(2) NULL,
		���֤�� Varchar(30) NULL
	)
--��guest����Ӽ�¼
	insert into guest
		select '0001','��һ' , '��' ,  '140109199911050069' UNION
		select '0002','���' , '��' ,  '142106199412030041' UNION
		select '0003','����' , 'Ů' ,  '147892156410122105' UNION
		select '0004','����' , 'Ů' ,  '158654198510100213' UNION
		select '0005','����' , '��' ,  '147159198702050141'
	GO

	select * from guest




--����yuangong���ݱ�
	CREATE TABLE yuangong
	(
		���� Varchar(10) NOT NULL,
		Ա��ְλ Varchar(11) NOT NULL,
		Ա������ Varchar(20) NULL,
		���� Varchar(10) NULL
	)
--��yuangong����Ӽ�¼
	insert into yuangong
		select '0001','����','��һ' ,  '150069' UNION
		select '0002','ǰ̨','���' ,  '142130' UNION
		select '0003','����','����' ,  '789215' UNION
		select '0004','��ְ','����' ,  '158654' UNION
		select '0005','���','����' ,  '147159'
	GO

	select * from yuangong
	
	--����user1��
	CREATE TABLE user1
	(
		�˺� varchar(10) not null,
		���� varchar(10) not null
		
	)
	

--��user1�û����������
	insert into user1
		select 'admin','123' 
		GO
		
	select * from user1
	select * from guest
	select * from yuangong

