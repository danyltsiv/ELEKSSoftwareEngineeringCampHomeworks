--1.1
;with FavoriteMovies as
(
 select 'Inception' as Name, NULL as Description, '2010-07-22' as PremiereDate, 21525641.00 as BoxOffice,
 19 as GenreKey
 union all
  select 'Shutter Island' as Name, NULL as Description, '2010-02-19' as PremiereDate, 11232242.00 as BoxOffice,
 19 as GenreKey
 )

 insert into Movie(Name,Description,PremiereDate,BoxOffice,GenreKey)
			select * from FavoriteMovies;

insert into Movie values
			('Psycho',NULL,'1960-04-22',40000000.00, 13),
			('Ace Ventura',NULL,'1993-06-13',8030000.00, 5),
			('The Shawshank Redemption',NULL,'1994-07-02',12300000.00, 8)
--1.2
insert into Actor(Name,BirthDate,SexEnum) values
		('Jim Carrey','1965-01-10',1),
		('Tim Robbins','1955-02-15',1),
		('Mark Ruffalo','1963-04-16',1),
		('Anthony Perkins','1925-06-02',1),
		('EllenPage','1992-07-20',2)

insert into Cast(ActorId,MovieId,CharacterName,Fee) values
					(27,9,'Ace Ventura',245352),
					(31,6,'Ariadna',123352),
					(29,7,'Lester Sheen',503302),
					(30,8,'Norman Bates',20000),
					(29,10,'Andy Dufrain',980000)

--1.3
update Cast set Fee=Fee+20000 
	output inserted.ActorId,inserted.CharacterName
	where CharacterName like 'C%'

--1.4
;with Recurs as 
(
select 1 as MovieId, 8 as Rank,'Great Movie' as Text, NULL as AuthorEmail
union all
select MovieId + 1, 8 as Rank, 'Great Movie' as Text, NULL as AuthorEmail
from Recurs
where MovieId+1 <= 10
)

insert into Feedback(MovieId, Rank, Text, AuthorEmail)
		select * from Recurs;
	
--1.5 doesn't work
create view ActorRoles as 
		select A.Name,C.CharacterName from Actor as A 
		join Cast as C on A.ActorId=C.ActorId

--1.6
;with newFeedback as
(
 select 5 as MovieId,7 as Rank,'Nice, but previous part was better' as Text, 'anonym@gmail.com' as AuthorEmail
 union all
 select  5 as MovieId,8 as Rank,'Great Movie' as Text, NULL as AuthorEmail
 union all
 select  5 as MovieId,9 as Rank,'Is "Rouge one" script somehow connected to this part?' as Text, NULL as AuthorEmail
 )
merge into Feedback as target
	using newFeedback as source
		on (target.MovieId=source.MovieId and target.Rank=source.Rank)
when matched then 
	update set Rank = source.Rank,Text=source.Text,AuthorEmail=source.AuthorEmail
when not matched by target then 
	insert( 
		MovieId,
		Rank,
		Text,
		AuthorEmail
		)
	 values(
	    source.MovieId,
	    source.Rank,
		source.Text,
		source.AuthorEmail
	 ) 
	 output $action,inserted.Rank,inserted.Text,inserted.AuthorEmail;

--2.1
alter table Feedback DROP CONSTRAINT CK_Rank;
alter table Feedback
add constraint CK_Rank Check
(Rank>=0 and Rank <=10)

--2.2 
create table dbo.Studio
(
StudioId int identity(1,1),
Name nvarchar(256) not null,
Location nvarchar(256) not null,
constraint PK_Studio primary key(StudioId)
) 

--2.3
alter table Studio add MovieId int
alter table dbo.Studio
add constraint FK_Studio_Movie foreign key(MovieId) 
references dbo.Movie(MovieId) on delete cascade

--2.4
insert into Studio values('Paramount Pictures', 'USA', 6)