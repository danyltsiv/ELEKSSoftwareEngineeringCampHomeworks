--1
select m.Name, t.Amount from Genre as m 
		join (
				select GenreKey,sum(BoxOffice) as Amount 
				from Movie group by GenreKey
			 ) as t
	on m.GenreKey=t.GenreKey;	
--2 
select CharacterName,Fee from Cast where Fee in (select min(Fee) from Cast)		

--3
select A.Name,Datediff(year, A.BirthDate,GETUTCDATE()) as Age, A.Sex,sum(C.Fee) 
		from Actor as A 
		join Cast as C on A.ActorId=C.ActorId 
		group by Name,BirthDate,Sex;
			
--4
select a.Sex, sum(b.Fee) as Amount 
			from Actor as a join Cast as b 
			on a.ActorId=b.ActorId
			group by Sex;

--5		
select Movie.Name,Actor.Name,Tab.Max from 
			(
				select max(T.Fee) as Max,T.MovieId 
				from (
				select M.MovieId as MovieId,C.Fee from Movie as M 
				join Cast as C on M.MovieId=C.MovieId 
				join Actor as A on A.ActorId = C.ActorId
					 ) as T group by T.MovieId
			 ) as Tab join Movie
		on Tab.MovieId = Movie.MovieId 
		join Cast on Cast.MovieId = Tab.MovieId
		join Actor on Actor.ActorId = Cast.ActorId;

--6
select T.Name,T.PremiereDate,T.BoxOffice,T.AverageRank from 
				(
				select Name,PremiereDate,BoxOffice,avg(Feedback.Rank) as AverageRank from Feedback 
				join Movie on Movie.MovieId=Feedback.MovieId  
				group by Name,PremiereDate,BoxOffice
				) as T 
			where T.AverageRank > 6;

--7
select M.Name, C.CharacterName, A.Name,Year(M.PremiereDate) as PlayYear from Movie as M 
					join Cast as C on M.MovieId=C.MovieId
					join Actor as A on  C.ActorId=A.ActorId 
					where Year(M.PremiereDate)>2000;

--8
select Actor.Name,ISNULL(Cast.CharacterName,'no data'), T.MaxFee from 
			(
			select A.ActorId,  max(C.Fee) as MaxFee from Actor as A 
			join Cast as C on C.ActorId=A.ActorId
			group by A.ActorId) as T 
		join Cast on T.ActorId=Cast.ActorId
		join Actor on T.ActorId=Actor.ActorId 
	order by Name;

--9
select A.Name,M.Name,C.Fee from Actor as A
	join Cast as C on A.ActorId=C.ActorId
	join Movie as M on C.MovieId=M.MovieId
	order by A.Name,C.Fee;

--10
select M.Name from Movie as M
	join Cast as C on M.MovieId=C.MovieId
	where M.BoxOffice/C.Fee > 10;


--11
select Actor.Name,DATEDIFF(YEAR,Actor.BirthDate,GETDATE()) as Age,Movie.Name from 
	(
			select min(M.MovieId) FirstM, C.ActorId from Movie as M
			join Cast as C on M.MovieId=C.MovieId 
			group by C.ActorId
	) as T
		join Actor on Actor.ActorId=T.ActorId
		join Movie on Movie.MovieId=T.FirstM; 

--12
select M.Name,M.Description,M.PremiereDate,T.CastFee from
		(
		select MovieId,Sum(Fee) as CastFee from Cast  
		group by MovieId Having Sum(Fee) > 400000
		) as T 
	join Movie as M on T.MovieId=M.MovieId
	order by T.CastFee;

--13
select M.Name,M.BoxOffice-T.CastFee as Result from (
		select MovieId,Sum(Fee) as CastFee from Cast  
		group by MovieId
		) as T join Movie as M on T.MovieId=M.MovieId
		order by Result;

--14
select M.Name, M.BoxOffice, M.PremiereDate,
	G.Name,ISNULL(F.Text,'no comments found') as Comment 
	from 
	(
	select MovieId, max(Rank) as MaxRank from Feedback
	group by MovieId
	) as T
	join Feedback as F on T.MovieId=F.MovieId
	join Movie as M on F.MovieId=M.MovieId
	join Genre as G on G.GenreKey=M.GenreKey;

--15
select M.Name,M.PremiereDate,G.Name,T.AverageFee from Genre as G
		join Movie as M on M.GenreKey=G.GenreKey 
		join	
		(
		select M.MovieId,avg(C.Fee) as AverageFee from Movie as M
		join Cast as C on M.MovieId=C.MovieId 
		group by M.MovieId
		) as T on T.MovieId = M.MovieId

--16
select G.Name,min(T.MovieCount) as MovieCount,sum(M.BoxOffice) as Average,count(C.ActorId) 
	as ActorCount from	
	(
		select G.GenreKey, count(M.MovieId) as MovieCount from Movie as M 
		join Genre as G on G.GenreKey=M.GenreKey
		group by G.GenreKey
	 ) as T join
	Genre as G on G.GenreKey=T.GenreKey
	join Movie as M on M.GenreKey=G.GenreKey
	join Cast as C on C.MovieId=M.MovieId group by G.Name;

--17
select A.Name, G.Name as Genre from Genre as G 
	join Movie as M on G.GenreKey=M.GenreKey
	join Cast as C on M.MovieId=C.MovieId
	join Actor as A on C.ActorId=A.ActorId where G.Name='Horror' or G.Name='Thriller'; 

--18	
	select T.Male,M.Female from
	(select  T2.Name as Male from 
	(select max(T.Male) as MaxM from (select G.Name, count(A.Sex) as Male from Genre G join Movie M on M.GenreKey=G.GenreKey
	join Cast C on C.MovieId=M.MovieId
	join Actor A on A.ActorId=C.ActorId where A.Sex='Male' group by G.Name) T ) T1
	join 
	(select G.Name, count(A.Sex) as Male from Genre G join Movie M on M.GenreKey=G.GenreKey
	join Cast C on C.MovieId=M.MovieId
	join Actor A on A.ActorId=C.ActorId where A.Sex='Male' group by G.Name) T2 on T2.Male=T1.MaxM)  T
	cross join
	(select  T2.Name as Female from 
	(select max(T.Male) as MaxM from (select G.Name, count(A.Sex) as Male from Genre G join Movie M on M.GenreKey=G.GenreKey
	join Cast C on C.MovieId=M.MovieId
	join Actor A on A.ActorId=C.ActorId where A.Sex='Female' group by G.Name) T ) T1
	join 
	(select G.Name, count(A.Sex) as Male from Genre G join Movie M on M.GenreKey=G.GenreKey
	join Cast C on C.MovieId=M.MovieId
	join Actor A on A.ActorId=C.ActorId where A.Sex='Female' group by G.Name) T2 on T2.Male=T1.MaxM) M;

--19
select Tab.Name from
(select A.Name from Genre as G join Movie as M on M.GenreKey=G.GenreKey
	join Cast as C on C.MovieId=M.MovieId 
	join Actor as A on A.ActorId=C.ActorId where G.Name='Thriller') as Tab
	where Tab.Name NOT IN
	(select A.Name from Genre as G join Movie as M on M.GenreKey=G.GenreKey
	join Cast as C on C.MovieId=M.MovieId 
	join Actor as A on A.ActorId=C.ActorId where G.Name='Sci-Fi');

--20
select  [1] Male,[2] Female
from (select Sex ,ActorId from Actor) d
PIVOT (Count(ActorId) for d.Sex in([1],[2]) ) dd;