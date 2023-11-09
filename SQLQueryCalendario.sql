select *from Calendario
drop table Calendario
SELECT * FROM Calendario WHERE YEAR(DataCalendario) = 2024;

CREATE TABLE Calendario (
    IdEvento INT IDENTITY (1, 1) NOT NULL,
    Evento VARCHAR (200) NOT NULL,
    Horario varchar(20) not null,
    DataCalendario VARCHAR (50) NOT NULL,
);