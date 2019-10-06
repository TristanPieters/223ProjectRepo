create table FUEL (
Fuel_ID int identity(1,1) primary key not null,
Fuel_Description nvarchar(50),
Fuel_Price_Per_Liter money,
Current_Fuel_Reserve decimal(10,3));

create table EMPLOYEE (
Emp_ID int identity(1,1) primary key not null,
Emp_FName nvarchar(50),
Emp_LName nvarchar(50),
Emp_CellNum nvarchar(10),
Emp_JOB nvarchar(50),
Emp_Email nvarchar(62));

create table WSHIFT (
Shift_ID int identity(1,1) primary key not null,
Emp_ID int foreign key references EMPLOYEE(Emp_ID),
Shift_StartT time(0),
Shift_EndT time(0),
Shift_Date date);

create table REWARD (
Reward_ID int identity(1,1) primary key not null,
Reward_Description nvarchar(50),
Reward_Amount decimal(10,2));

create table ACCOUNT (
Acc_ID int identity(1,1) primary key not null,
Acc_FName nvarchar(50),
Acc_LName nvarchar(50),
Acc_Email nvarchar(62),
Acc_Cellnum nvarchar(10),
Acc_IDnum nvarchar(13),
Acc_Debt money,
Acc_LSold decimal(18,0));

create table REWARD_ACCOUNT (
Reward_Acc int identity(1,1) primary key not null,
Acc_ID int foreign key references ACCOUNT(Acc_ID),
Reward_ID int foreign key references REWARD(Reward_ID),
R_DateRecieved date);

create table TRANSACT (
Trans_ID int identity(1,1) primary key not null,
Emp_ID int foreign key references EMPLOYEE(Emp_ID),
Acc_ID int foreign key references ACCOUNT(Acc_ID),
Fuel_ID int foreign key references FUEL(Fuel_ID),
Reward_ID int foreign key references REWARD(Reward_ID),
DateofSale date,
TimeofSale time(0),
Amount_Sold money,
Liters_Sold decimal(10,3));

create table FORDER (
Order_ID int identity(1,1) primary key not null,
Emp_ID int foreign key references EMPLOYEE(Emp_ID),
Fuel_ID int foreign key references FUEL(Fuel_ID),
Order_Date date,
Recieve_Date date,
Amt_PaidPerLiter money,
Amt_OrderdLiters decimal (10,3));

