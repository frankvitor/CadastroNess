Create database NESS

use NESS

create table tbUsuario (
    Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nome varchar(100) NOT NULL,
    Cpf varchar(11) NOT NULL,
    Telefone varchar(11)
);

INSERT INTO tbUsuario (Nome, Cpf, Telefone) VALUES ('Frank Vitor', '43820902880', '11984689461');
INSERT INTO tbUsuario (Nome, Cpf, Telefone) VALUES ('Elias', '61134452080', '11972328569');
INSERT INTO tbUsuario (Nome, Cpf, Telefone) VALUES ('Paulo', '15184501053', '11965894523');
INSERT INTO tbUsuario (Nome, Cpf, Telefone) VALUES ('Kaue', '22985904005', '11987541236');

Select * from tbUsuario
Select * from tbUsuario where Nome like '%Frank%'

Update tbUsuario set Nome = 'Vitor' where Id = 1

Delete tbUsuario where Id = 5





