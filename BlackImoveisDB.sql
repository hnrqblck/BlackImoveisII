DROP DATABASE IF EXISTS BlackImoveis;

CREATE DATABASE BlackImoveis;
USE BlackImoveis;

CREATE TABLE IF NOT EXISTS Imoveis(
Id int PRIMARY KEY AUTO_INCREMENT,
Nome varchar(100),
Sobrenome varchar(100),
Email varchar(50),
Telefone int,
Tipo varchar(30),
TipoServico varchar (30),
Financiamento varchar (30),
Endereco text,
Cidade varchar(30),
Sala int,
Quarto int,
Suite int,
Varanda varchar(20),
QrtoReversivel varchar(20),
Armarios varchar(20),
WCSocial varchar(20),
Cozinha varchar(20),
Copa varchar(20),
ArmariosCozinha varchar(20),
AreaServico varchar(20),
WCServico varchar(20),
Piscina varchar(20),
SLFesta varchar(20),
Garagem varchar(20),
AreaUtil decimal (10,2),
ValorImovel decimal (10,2),
Condominio decimal (10,2),
IPTU decimal (10,2),
Comentario text,
Bairro varchar(50),
Titulo varchar(200),
Descricao text,
Post bool
);

