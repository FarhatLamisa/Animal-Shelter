CREATE TABLE Animal(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY ,
Name varchar(10) NOT NULL,
Breed varchar(20) NOT NULL,
Vaccinated varchar(20) NOT NULL,
Neutered varchar(20) NOT NULL,
PhotoLink varchar(MAX) NULL,
HealthConditions varchar(MAX) NULL,
FoundFrom varchar(200) NOT NULL,
);
select * from Animal