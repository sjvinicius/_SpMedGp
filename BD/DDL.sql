CREATE DATABASE spmedgp
GO

USE spmedgp
GO

CREATE TABLE especialidade (
	idEspecialidade INT PRIMARY KEY IDENTITY,
	tituloEspecialidade VARCHAR(50),
)
GO

CREATE TABLE tipoUsuario(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	tituloTipoUsuario VARCHAR

)
GO

CREATE TABLE situacao (
	idSituacao INT PRIMARY KEY IDENTITY,
	tituloSituacao VARCHAR(50),
)
GO

CREATE TABLE clinica(
	idClinica INT PRIMARY KEY IDENTITY,
	endereco VARCHAR(20),
	cnpj VARCHAR(14),
	nomeFantasia VARCHAR(50),
	razaoSocial VARCHAR(50),

)
GO

CREATE TABLE consulta(
	idConsulta INT PRIMARY KEY IDENTITY,
	idSituacao INT FOREIGN KEY REFERENCES situacao(idSituacao),
	idMedico INT FOREIGN KEY REFERENCES medico(idMedico),
	idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario),
	datacon DATE,
	relatorioMedico TEXT,
)
GO

CREATE TABLE medico(
	idMedico INT PRIMARY KEY IDENTITY,
	idConsulta INT FOREIGN KEY REFERENCES consulta(idConsulta),
	idEspecialidade INT FOREIGN KEY REFERENCES especialidade(idEspecialidade),
	nome VARCHAR(20),
	crm VARCHAR(12)

)
GO

CREATE TABLE usuario(
	idUsuario INT PRIMARY KEY IDENTITY,
	idConsulta INT FOREIGN KEY REFERENCES consulta(idConsulta),
	idTipoUsuario INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario),
	email VARCHAR(50),
	senha VARCHAR(50),

)
GO

ALTER TABLE consulta
ADD idMedico INT FOREIGN KEY REFERENCES medico(idMedico);
GO