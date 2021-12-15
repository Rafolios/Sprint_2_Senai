CREATE DATABASE SPMedicalGroup
GO

USE SPMedicalGroup
GO


CREATE TABLE TipoUsuario(
	TipoUsuario_ID tinyint primary key identity (1,1),
	TipoNome TEXT,
)
GO

CREATE TABLE Usuario(
	Usuario_ID tinyint primary key identity (1,1),
	TipoUsuario_ID tinyint foreign key references TipoUsuario (TipoUsuario_ID),
)
GO

CREATE TABLE Administrador (
	Admin_ID tinyint primary key identity (1,1),
	Usuario_ID tinyint foreign key references Usuario (Usuario_Id),
	NomeAdmin TEXT,
)
GO

CREATE TABLE Clientes(
	Clientes_ID tinyint primary key identity(1,1),
	Usuario_ID tinyint foreign key references Usuario (Usuario_Id),
	NomeCliente TEXT,
	DataNasc TEXT,
	TellPaciente TEXT,
	RGPaciente TEXT,
	CPFPaciente TEXT,
	AddPaciente TEXT,
)
GO

CREATE TABLE Clinica(
	Clinica_ID tinyint primary key identity(1,1),
	Admin_ID tinyint foreign key references Administrador(Admin_Id),
	AddClinica TEXT,
	RazaoSocial TEXT,
	Horarioabrir TEXT,
	Horariofechar TEXT,
)
GO

CREATE TABLE Especialidade(
	Especialidade_ID tinyint primary key identity (1,1),
	NomeEspecialidade text,
)
GO

CREATE TABLE Medicos(
	Medico_ID tinyint primary key identity(1,1),
	Clinica_ID tinyint foreign key references Clinica (Clinica_ID),
	Especialidade_ID Tinyint foreign key references Especialidade (Especialidade_ID),
	Usuario_ID tinyint foreign key references Usuario (Usuario_ID),
	CRMMedico TEXT,
	NomeMedico varchar(30),
)
GO

CREATE TABLE Consulta(
	Consulta_ID tinyint primary key identity (1,1),
	Medico_ID tinyint foreign key references Medicos (Medico_ID),
	Clientes_ID tinyint foreign key references Clientes (Clientes_ID),
	DataConsulta TEXT,
	DescConsulta TEXT,
)
GO

