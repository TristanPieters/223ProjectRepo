create table FUEL (
Fuel_ID int identity(1,1) primary key not null,
Fuel_Description nvarchar(50),
Fuel_Price_Per_Liter money,
Current_Fuel_Reserve decimal(10,3) );

create table EMPLOYEE (
Emp_ID int identity(1,1) primary key not null,
ShiftTime time(7),
Emp_FName nvarchar(50),
Emp_LName nvarchar(50),
Emp_CellNum nvarchar(50),
Emp_JOB nvarchar(50),
Emp_Email nvarchar(62),
Emp_Username nvarchar (10),
Emp_Password nvarchar(8) );

create table ACCOUNT (
Acc_ID int identity(1,1) primary key not null,
Acc_FName nvarchar(50),
Acc_LName nvarchar(50),
Acc_Email nvarchar(62),
Acc_Cellnum nvarchar(9),
Acc_IDnum nvarchar(13),
Acc_Debt money,
Acc_LSold decimal(18,0));

create table REWARD (
Reward_ID int identity(1,1) primary key not null,
Reward_Detail nvarchar(50));

create table REWARD_ACCOUNT (
Acc_ID int not null,
Reward_ID int not null,
R_DateRecieved date,
constraint fk_RA_Account foreign key (Acc_ID) references ACCOUNT(Acc_ID),
constraint fk_RA_Reward foreign key (Reward_ID) references REWARD(Reward_ID),
constraint pk_RA primary key (Acc_ID,Reward_ID) );

create table TRANSACT (
Trans_ID int identity(1,1) primary key not null,
Emp_ID int foreign key references EMPLOYEE(Emp_ID),
Acc_ID int foreign key references ACCOUNT(Acc_ID),
Fuel_ID int foreign key references FUEL(Fuel_ID),
Reward_ID int foreign key references REWARD(Reward_ID),
Dateofsale date,
Amount_Liters_Sold decimal(10,3),
Liters_Sold decimal(10,3));

create table FORDER (
Order_ID int identity(1,1) primary key not null,
Emp_ID int,
Order_Date date,
Recieve_Date date,
constraint fk_FO_Employee foreign key (Emp_ID) references EMPLOYEE(Emp_ID));

create table ORDER_DETAIL (
Order_ID int not null,
Fuel_ID int not null,
Amt_PaidPerLiter money,
Amt_OrderdLiters decimal (18,3),
constraint fk_OD_Forder foreign key (Order_ID) references FORDER(Order_ID),
constraint fk_OD_Fuel foreign key (Fuel_ID) references FUEL(Fuel_ID),
constraint pk_OD primary key (Order_ID,Fuel_ID) );