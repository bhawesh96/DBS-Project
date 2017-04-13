

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

delimiter $$
create trigger update_no_of_complaints2 
after delete on reg_complaints
for each row
begin 
UPDATE policedetails 
SET 
    complaintsonhand = complaintsonhand - 1
WHERE
    policeid = OLD.PoliceID;
end;
$$
delimiter ;




alter table policedetails modify complaintsonhand int not null default 0;

alter table policedetails modify phone varchar(11);

insert into policedetails values('Mani1','manipal1','Rowdy Rathore','end point road','1977-07-14',9008318346,'Insepector','Manipal',0);

select * from policedetails;
select policeID,count(comp_id) from reg_complaints group by policeID;


delete from policedetails where policeID like '%a%';

insert into policedetails values('Mani2','manipal2','Sunny Deol','Eashwar nagar','1987-01-12','8009458346','Insepector','Manipal',0);
insert into policedetails values('Mang1','mangalore1','Abhay shetty','beside forum mall','1978-02-04','9008845646','Insepector','Managlore',0);
insert into policedetails values('Mang2','mangalore2','Smaaran Shetty','opp. ford showroom','1981-06-03','9000000111','Sub-Insepector','Managlore',0);
insert into policedetails values('udup1','udupi1','Ravi Shankar','kudanranagar','1983-09-21','9007698541','Insepector','Udupi',0);

insert into userdetails values('abcd12345','bhawesh','m','1997-02-16',1234567890,'lajpatnagar');
insert into userdetails values('defgh12345','rahul','m','1997-12-12',1876567890,'mumbai');
insert into userdetails values('aiuf12345','adarsh','m','1997-08-26',1884567890,'rampura');
insert into userdetails values('asff13545','mayank','m','1997-09-06',1734567890,'andheri');
insert into userdetails values('wxyz98765','krithika','f','1997-10-14',1777767890,'karkarduma');

select * from userdetails;

alter table reg_complaints change descirption description varchar(400) not null;

insert into reg_complaints values (1,'aaaa','criminal','manipal','hehehehehehe','abcd12345','Mani2');


insert into reg_complaints(title,Type, place, description, victim, policeid) values ('xdcefghf','criminal','Udupi','ahahahahaha','defgh12345','udup1');
insert into reg_complaints(title,Type, place, description, victim, policeid) values ('zzzz','Municipal','Mangalore','ahahahahaha','wxyz98765','mang1');
insert into reg_complaints(title,Type, place, description, victim, policeid) values ('yyyy','PIL','Mangalore','ahahahahaha','aiuf12345','mang2');
insert into reg_complaints(title,Type, place, description, victim, policeid) values ('xxxx','criminal','Mangalore','ahahahahaha','defgh12345','mang2');

insert into reg_complaints values (2,'bbbb','coporate','manipal','hehehehehehe','defgh12345','Mani1');


insert into reg_complaints values (3,'cccc','Municipal','manipal','hehehehehehe','aiuf12345','Mani2');

select * from reg_complaints;

Select comp_id,title,type,place,description,victim from reg_complaints where policeID = 'mani2';


DELIMITER //
CREATE PROCEDURE insertComplaint3(IN titl varchar(20), in typ varchar(20), in plac varchar(10), in descp varchar(400),in vic varchar(15))
 BEGIN
 declare p varchar(20);
 
select policeid into p from (select policeId, complaintsonhand as c from policedetails where place = plac) as A where c = (select min(c) from (select policeId, complaintsonhand as c from policedetails where place = plac) as B);
 insert into reg_complaints(title,Type, place, description, victim, policeid) values (titl,typ,plac,descp,vic,p) ;

 END //
DELIMITER ;

select * from reg_complaints;
call deleteComplaint(1);
select policeid from (select policeId, complaintsonhand as c from policedetails where place = 'Managlore') as A where c = (select min(c) from (select policeId, complaintsonhand as c from policedetails where place = 'manipal') as B);
 
 select * from policedetails;
 call insertComplaint('dddd', 'Criminal', 'Manipal' , 'hahahaha', 'abcd12345');
 
 use dbs_project;
 select * from reg_complaints;
 
 call insertComplaint3('ghgh', 'PIL', 'Manipal', 'aDFasd', 'asff13545 wsdf');
 
 insert into accused values ('abcd12345','2000-04-21','Manipal','kuavsd','left early');
 select exists(select * from accused where aadhaarno = 'abcd12345') as T;
 
 DELIMITER //
 CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteComplaint`(IN comid int)
BEGIN
 delete from reg_complaints where comp_id = comid;
 
 
 END//
 DELIMITER ;
 