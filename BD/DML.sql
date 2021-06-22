USE spmedgp
GO

INSERT INTO especialidade(tituloEspecialidade) VALUES 
('Ortopedista'),
('Farmaceutico'),
('Pediatra'),
('Cardiologista'),
('Neurologista'),
('Nutricionista');
GO

INSERT INTO situacao(tituloSituacao) VALUES
('Realizada'),
('Pendente'),
('Cancelada');
GO

INSERT INTO clinica(endereco, cnpj, nomeFantasia, razaoSocial) VALUES
('Penha', '3171503', 'Clinica Possarle', 'Possarlezada'),
('Carrao', '2645612', 'Clinica Lemos', 'Lemoszada'),
('Tatuape', '2131321', 'Clinica Helena', 'Helenazada');
GO

INSERT INTO medico(idEspecialidade, nome, crm) VALUES
(1, 'Possarle', '132161651'),
(5, 'Lemos', '121315386'),
(4, 'Helena', '164566594');
GO

INSERT INTO usuario( idTipoUsuario, email, senha) VALUES
( 1, 'possarle@gmail.com', '123123'),
( 2, 'lemos@gmail.com', '123123'),
( 1, 'helena@gmail.com', '123123');
GO

INSERT INTO consulta(idSituacao, idMedico, idClinica, datacon, relatorioMedico) VALUES
(1, 1, 1, '16/10/2001', 'o paciente encontrase em estado de observação pois bla bla bla'),
(2, 3, 3, '20/04/2021', 'paciente com sintomas de bla bla bla'),
(2, 2, 2, '19/01/2019', 'paciente com gripe e bla bla blm');
GO

INSERT INTO tipoUsuario(tituloTipoUsuario) VALUES
('administrador'),
('usuario');
GO

UPDATE medico
	SET idConsulta = 2 WHERE idMedico = 1
GO

UPDATE medico
	SET idConsulta = 3 WHERE idmedico = 2
GO

UPDATE medico 
	SET idconsulta = 1 WHERE idMedico = 3
GO

UPDATE consulta 
	SET idUsuario = 1 WHERE idConsulta = 1
GO

UPDATE consulta
	SET idUsuario = 2 WHERE idConsulta = 2
GO

UPDATE consulta	
	SET idUsuario = 3 WHERE idConsulta = 3
GO

UPDATE usuario
	SET idConsulta = 3 WHERE idUsuario = 1
GO

UPDATE usuario
	SET idConsulta = 2 WHERE idUsuario = 2
GO

UPDATE usuario
	SET idConsulta = 1 WHERE idUsuario = 3
GO