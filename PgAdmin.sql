create table Books
(
	Id serial primary key,
	Name varchar
);

create table Genre
(   
	Id serial primary key,
	GenreName varchar
);


create table Author
(
	Id serial primary key,
	FirstName varchar,
	LastName varchar
);


create table GenreBook
(
	BookId int references Books(Id),
	GenreId int references Genre(Id)
);

create table AuthorBook
(
	BookId int references Books(Id),
	AuthorId int references Author(Id)
);
insert into Books (Name) values ('Diphenhydramine Hydrochloride');
insert into Books (Name) values ('POLYETHYLENE GLYCOL 400');
insert into Books (Name) values ('Neomycin, Polymyxin B, Pramoxine HCl');
insert into Books (Name) values ('chloroxylenol');
insert into Books (Name) values ('Ampicillin Sodium');
insert into Books (Name) values ('diltiazem hydrochloride');
insert into Books (Name) values ('Aspirin');
insert into Books (Name) values ('Salsalate');
insert into Books (Name) values ('Triclosan');
insert into Books (Name) values ('Calcium Sennosides');


insert into Genre (GenreName) values ('dexamethasone');
insert into Genre (GenreName) values ('ALCOHOL');
insert into Genre (GenreName) values ('Acetaminophen, Chlorpheniramine Maleate, Dextromethorphan Hydrobromide, Phenylephrine Hydrochloride');
insert into Genre (GenreName) values ('Desoximetasone');
insert into Genre (GenreName) values ('Ziprasidone Hydrochloride');
insert into Genre (GenreName) values ('mesalamine');
insert into Genre (GenreName) values ('DIDANOSINE');
insert into Genre (GenreName) values ('HYOSCYAMINE SULFATE');
insert into Genre (GenreName) values ('Octinoxate and Titanium Dioxide');
insert into Genre (GenreName) values ('Carvedilol');

insert into Author (FirstName, LastName) values ('Loratadine, Pseudoephedrine Sulfate', 'Ampicillin sodium');
insert into Author (FirstName, LastName) values ('verapamil hydrochloride', 'emtricitabine');
insert into Author (FirstName, LastName) values ('Dicloxacillin Sodium', 'Lisinopril');
insert into Author (FirstName, LastName) values ('GOLDENSEAL and LOBARIA PULMONARIA and POTASSIUM DICHROMATE and PHOSPHORUS and MERCURIC SULFIDE and AMMONIUM CARBONATE and LEMNA MINOR and ARUM MACULATUM ROOT and MERCURIC IODIDE', 'ACTAEA SPICATA');
insert into Author (FirstName, LastName) values ('Benazepril Hydrochloride', 'NICOTINE');
insert into Author (FirstName, LastName) values ('Cetirizine Hydrochloride', 'Birch');
insert into Author (FirstName, LastName) values ('SODIUM FLUORIDE', 'Aluminum Zirconium Tetrachlorohydrex GLY');
insert into Author (FirstName, LastName) values ('Butalbital, Acetaminophen, and Caffeine', 'Fluconazole');
insert into Author (FirstName, LastName) values ('BENZALKONIUM CHLORIDE', 'Acetaminophen, Caffeine');
insert into Author (FirstName, LastName) values ('Boldo, Carduus Marianus, Curcuma Longa, Echinacea, Taraxacum Officinale, Magnesia Phosphorica, Gallbladder', 'Promethazine hydrochloride and phenylephrine hydrochloride');



insert into GenreBook (GenreId, BookId) values (8, 9);
insert into GenreBook (GenreId, BookId) values (10, 6);
insert into GenreBook (GenreId, BookId) values (5, 4);
insert into GenreBook (GenreId, BookId) values (6, 2);
insert into GenreBook (GenreId, BookId) values (8, 7);
insert into GenreBook (GenreId, BookId) values (9, 8);
insert into GenreBook (GenreId, BookId) values (4, 8);
insert into GenreBook (GenreId, BookId) values (3, 10);
insert into GenreBook (GenreId, BookId) values (9, 6);
insert into GenreBook (GenreId, BookId) values (10, 6);
insert into GenreBook (GenreId, BookId) values (4, 2);
insert into GenreBook (GenreId, BookId) values (10, 10);
insert into GenreBook (GenreId, BookId) values (2, 5);
insert into GenreBook (GenreId, BookId) values (3, 8);
insert into GenreBook (GenreId, BookId) values (4, 9);
insert into GenreBook (GenreId, BookId) values (5, 4);
insert into GenreBook (GenreId, BookId) values (4, 6);
insert into GenreBook (GenreId, BookId) values (3, 9);
insert into GenreBook (GenreId, BookId) values (7, 4);
insert into GenreBook (GenreId, BookId) values (5, 6);


insert into AuthorBook (BookId, AuthorId) values (2, 7);
insert into AuthorBook (BookId, AuthorId) values (8, 6);
insert into AuthorBook (BookId, AuthorId) values (4, 7);
insert into AuthorBook (BookId, AuthorId) values (8, 7);
insert into AuthorBook (BookId, AuthorId) values (10, 6);
insert into AuthorBook (BookId, AuthorId) values (7, 6);
insert into AuthorBook (BookId, AuthorId) values (11, 9);
insert into AuthorBook (BookId, AuthorId) values (9, 10);
insert into AuthorBook (BookId, AuthorId) values (7, 10);
insert into AuthorBook (BookId, AuthorId) values (6, 8);



select ab.AuthorId,ab.BookId,a.FirstName,a.LastName,b.Name 
from AuthorBook as ab
join Author as a on a.Id = ab.AuthorId
join Books as b on b.Id = ab.BookId

select gb.GenreId,gb.BookId,g.GenreName as Genrename,b.Name as BookName from GenreBook as gb join Genre as g on g.Id = gb.GenreId join Books as b on b.Id = gb.BookId

