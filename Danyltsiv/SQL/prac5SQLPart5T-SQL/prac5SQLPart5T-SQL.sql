--1
create function CountOfActors(@MovieId int)
			returns int
as 
	begin
			declare @count int
			select @count = count(ActorId)
				from Cast 
				where MovieId = @MovieId
			return @count
	end;	
	go

--2
create function RolesAndFee(@ActorId int)
		returns @Table table ([Role] varchar(50), [Fee] money)
	as
		begin
			insert into @Table select CharacterName,Fee from Cast where @ActorId=ActorId
			return		
		end;
go

--3
create procedure GetActorByName 
					@Name nvarchar(256)
		as 
			begin
			select * from Actor where Name=@Name
		end
go

--4
create procedure FilterForRoles
			@minmoney money,
			@MovieName nvarchar(256) = 'Empty',
			@ActorName nvarchar(256) = 'Empty'
			
	as
		begin
		if @MovieName = 'Empty' and @ActorName ='Empty'
			select A.Name,C.CharacterName,C.Fee,M.Name from Actor as A
			join Cast as C on C.ActorId=A.ActorId 
			join Movie as M on M.MovieId=C.MovieId
			where C.Fee > @minmoney
		 else if @MovieName != 'Empty' and @ActorName = 'Empty'
				select A.Name,C.CharacterName,C.Fee,M.Name from Actor as A
				join Cast as C on C.ActorId=A.ActorId 
				join Movie as M on M.MovieId=C.MovieId
				where C.Fee > @minmoney and M.Name=@MovieName
					else
						select A.Name,C.CharacterName,C.Fee,M.Name from Actor as A
						join Cast as C on C.ActorId=A.ActorId 
						join Movie as M on M.MovieId=C.MovieId
						where C.Fee > @minmoney and A.Name=@ActorName and M.Name=@MovieName
		end
go

--5
create procedure CreateMovie
			@MovieName nvarchar(128),
			@Description nvarchar(512),
			@PremiereDate date,
			@BoxOffice money,
			@GenreKey int
	as 
		begin
			insert into Movie values(@MovieName,@Description,@PremiereDate,@BoxOffice,@GenreKey)
		end
go

create procedure ReadMovie
			@MovieId int
	as
		begin
			select * from Movie where Movie.MovieId=@MovieId
		end
go

create procedure UpdateMovie
			@MovieId int,
			@MovieName nvarchar(128),
			@Description nvarchar(512),
			@PremiereDate date,
			@BoxOffice money,
			@GenreKey int
	as 
		begin
			update Movie set 
				Name=@MovieName,
				Description=@Description,
				PremiereDate=@PremiereDate,
				BoxOffice=@BoxOffice,
				GenreKey=@GenreKey
			where Movie.MovieId=@MovieId  	
		end
go

create procedure DeleteMovie
				@MovieId int
	as
		begin
			delete from Movie where MovieId=@MovieId
		end
go

--6 not working
create type ListOfRoles as table
(
MovieId int not null,
CharacterName nvarchar(128) not null,
Fee money not null
)
go
create procedure AddActorWithRoles
		@ActorName nvarchar(256),
		@BirthDate date,
		@Sex tinyint,
		@List ListOfRoles readonly
	as 
		begin
			insert into Actor values (@ActorName,@BirthDate,@Sex);
			declare @ActorId int;
			set @ActorId = (select ActorId from Actor where Name=@ActorName); 
			insert into Cast(ActorId,MovieId,CharacterName,Fee)  
			select @ActorId, * from @List; 
		end
go

create table ##TembTab(	
	MovieId int not null,
	CharacterName nvarchar(128) not null,
	Fee money not null
	)
	insert into ##TembTab values
	(2,'Mr Smith',100000),
	(3,'Mr White',200000),
	(4,'Mr Mouse',300000);

exec AddActorWithRoles 'Brad Pitt','1993-01-01',1,##TempTab

--7
create trigger UpOfficeBox
		on Feedback after insert,update
	as 
		declare @oldRank int, @newRank int , @MovieId int
	begin
		if update(Rank)
		begin
		select @newRank=Rank,@MovieId=MovieId from inserted;
			if @newRank > 5
				update Movie set BoxOffice=BoxOffice+10 where MovieId=@MovieId 
		end
		end
go