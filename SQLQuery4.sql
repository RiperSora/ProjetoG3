CREATE TABLE Album (
    IdAlbum          INT           IDENTITY (1, 1) PRIMARY KEY,
    NomeAlbum       VARCHAR (50)  NOT NULL,
    Descricao       VARCHAR (100) NOT NULL,
    DataHoraCadastro DATETIME      NOT NULL,
    FkCliente        INT           NOT NULL,
    FOREIGN KEY (FkCliente) REFERENCES Cliente(IdUsuario)
);

select * from Album