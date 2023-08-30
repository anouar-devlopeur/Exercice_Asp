create database  revesion
use revesion
create table categorie(
idCat int primary key,
nomcat varchar(30)
)
insert into Organisateur values(1,'bhbn','anwar','login','1234')
create table Organisateur(
idOrg int primary key,
nomOrg varchar(30),
prenomOrg varchar(30),
emailOrg varchar(30),
passOrg varchar(30)
)
select* from Organisateur
create table Campagne(
idCamp int primary key,
nomCamp varchar(30),
descriptio varchar(30),
dateCreation date,
dateFin date,
montantCamp float,
nomBeneficiare varchar(30),
prenBeneficiare varchar(30),
dateDernierePart date,
idCat int references categorie(idCat),
idOrg int references Organisateur(idOrg)
)
select c.idCamp,c.nomCamp,count(c.montantCamp)as montant,c.nomBeneficiare from Campagne c,categorie cat,Organisateur o
where c.idCat=cat.idCat and c.idOrg=o.idOrg
group by c.idCamp,c.nomCamp,c.nomBeneficiare
create table Participant(
idP int primary key,
nomP varchar(30),
prenomP varchar(30),
emailP varchar(30),
passP varchar(30)
)
insert into Participant values(1,'basa','amin','login','1234')
create table Participation(
idPart  int primary key,
dateParti   date,
montantPart float,
idCamp int references Campagne(idCamp),
idP int references Participant(idP)
)
