
use portfoilo ;
insert into Owners (BIO , FirstName , lastName , ImagePath ,AddressId )values ('Front-End dev | C#| Asp .Net Core | React','Hasan','Khaddour','avatar.jpg',1);

select * from Owners ;


insert into Address (StreetName , StreetNumber ,City ,ZipCode) values ('DS-BR' ,1 ,'Damascus',1234);


select * from Address ;


insert into Projects (Description , Budget ,OwnerId ,ProjectName) values ('a simple web site ' ,100,1,'myFirstWebSite');

insert into Projects (Description , Budget ,OwnerId ,ProjectName) values ('a back end  web service  ' ,100,1,'myFirstWebService');

insert into Projects (Description , Budget ,OwnerId ,ProjectName) values ('a single page app using react   ' ,400,1,'SPA');


select * from Projects ;