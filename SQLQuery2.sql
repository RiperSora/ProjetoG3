drop table Cliente

CREATE TABLE Cliente
(
    IdUsuario INT IDENTITY (1, 1) primary key NOT NULL,
    NomeDoCliente VARCHAR (100) NOT NULL,
    Senha VARCHAR (50)  NOT NULL,
    RG VARCHAR (50)  NOT NULL,
    CPF VARCHAR (50)      NOT NULL,
    Endereco VARCHAR (20)  NOT NULL,
    Telefone VARCHAR (20)  NOT NULL,
    Email VARCHAR (100)   NOT NULL,
    DataHoraCadastro DATETIME      NOT NULL,
);

