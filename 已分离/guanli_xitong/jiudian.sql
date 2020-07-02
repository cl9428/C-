
--创建jiudian_guanli数据库
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

--创建guest数据表
	CREATE TABLE guest
	(
		房号 Varchar(10) NOT NULL,
		姓名 Varchar(11) NOT NULL,
		性别 Varchar(2) NULL,
		身份证号 Varchar(30) NULL
	)
--给guest表添加记录
	insert into guest
		select '0001','黄一' , '男' ,  '140109199911050069' UNION
		select '0002','李二' , '男' ,  '142106199412030041' UNION
		select '0003','田三' , '女' ,  '147892156410122105' UNION
		select '0004','王四' , '女' ,  '158654198510100213' UNION
		select '0005','张五' , '男' ,  '147159198702050141'
	GO

	select * from guest




--创建yuangong数据表
	CREATE TABLE yuangong
	(
		工号 Varchar(10) NOT NULL,
		员工职位 Varchar(11) NOT NULL,
		员工姓名 Varchar(20) NULL,
		密码 Varchar(10) NULL
	)
--给yuangong表添加记录
	insert into yuangong
		select '0001','经理','黄一' ,  '150069' UNION
		select '0002','前台','李二' ,  '142130' UNION
		select '0003','秘书','田三' ,  '789215' UNION
		select '0004','兼职','王四' ,  '158654' UNION
		select '0005','后厨','张五' ,  '147159'
	GO

	select * from yuangong
	
	--创建user1表
	CREATE TABLE user1
	(
		账号 varchar(10) not null,
		密码 varchar(10) not null
		
	)
	

--给user1用户表添加数据
	insert into user1
		select 'admin','123' 
		GO
		
	select * from user1
	select * from guest
	select * from yuangong

