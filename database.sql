create table ArtistInfo(
ArtistId int AUTO_INCREMENT,
ArtistName nvarchar (50),
ArtistSummary nvarchar (500),
PRIMARY KEY (ArtistId)
);

insert into ArtistInfo (ArtistName,ArtistSummary) values ('Adele', 'Adele Laurie Blue Adkins MBE, född 5 maj 1988 i Tottenham i London, är en brittisk femtonfaldigt Grammy-belönad soul- och jazzsångerska och låtskrivare. 10 november 2007 blev hon den första att vinna i den nyinstiftade kategorin Kritikernas val på BRIT Awards.');

select * from ArtistInfo;
