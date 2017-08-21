

use dbs_project;

CREATE TABLE PoliceDetails (
    PoliceID VARCHAR(20),
    password VARCHAR(20),
    name VARCHAR(20),
    Address VARCHAR(20),
    DOB DATE,
    Designation VARCHAR(30),
    place VARCHAR(10),
    complaintsonhand INT,
    PRIMARY KEY (PoliceID)
);

CREATE TABLE UserDetails (
    AadhaarNo VARCHAR(15),
    Name VARCHAR(20),
    Sex CHAR(1),
    DOB DATE,
    Phone INT,
    address VARCHAR(50),
    PRIMARY KEY (AadhaarNo)
);

alter table policedetails add phone int after dob;

CREATE TABLE Reg_complaints (
    Comp_id VARCHAR(10) NOT NULL,
    title VARCHAR(20) NOT NULL,
    Type VARCHAR(20) NOT NULL,
    Place VARCHAR(10) NOT NULL,
    Descirption VARCHAR(400) NOT NULL,
    Victim VARCHAR(15) NOT NULL,
    PoliceID VARCHAR(20) NOT NULL,
    PRIMARY KEY (comp_id),
    FOREIGN KEY (PoliceId)
        REFERENCES policedetails (PoliceID),
    FOREIGN KEY (victim)
        REFERENCES userdetails (AadhaarNo)
);

CREATE TABLE Accused (
    aadhaarno VARCHAR(15) NOT NULL,
    Date DATE NOT NULL,
    Place VARCHAR(10) NOT NULL,
    Description VARCHAR(400) NOT NULL,
    ActionTaken VARCHAR(200) NOT NULL,
    PRIMARY KEY (aadhaarno),
    FOREIGN KEY (aadhaarno)
        REFERENCES userdetails (aadhaarno)
);

alter table reg_complaints change comp_id comp_id int auto_increment not null;

delimiter $$
create trigger update_no_of_complaints 
after insert on reg_complaints
for each row
begin 
UPDATE policedetails 
SET 
    complaintsonhand = complaintsonhand + 1
WHERE
    policeid = NEW.PoliceID;
end;
$$
delimiter ;

alter table policedetails modify complaintsonhand int not null default 0;

alter table policedetails modify phone varchar(11);

insert into policedetails values('Mani1','manipal1','Rowdy Rathore','end point road','1977-07-14',9008318346,'Insepector','Manipal',0);

select * from policedetails;

delete from policedetails where policeID like '%a%';

insert into policedetails values('Mani2','manipal2','Sunny Deol','Eashwar nagar','1987-01-12','8009458346','Insepector','Manipal',0);
insert into policedetails values('Mang1','mangalore1','Abhay shetty','beside forum mall','1978-02-04','9008845646','Insepector','Managlore',0);
insert into policedetails values('Mang2','mangalore2','Smaaran Shetty','opp. ford showroom','1981-06-03','9000000111','Sub-Insepector','Managlore',0);
insert into policedetails values('udup1','udupi1','Ravi Shankar','kudanranagar','1983-09-21','9007698541','Insepector','Udupi',0);
