Use SPMedicalGroup
GO

-- Seleciona o prontuario de uma pessoa:
Select NomeCliente, RGPaciente, CPFPaciente, AddPaciente, DataNasc, TellPaciente FROM Clientes WHERE Clientes_ID = 3
GO

-- Seleciona todos os prontuarios:
SELECT NomeCliente, DataNasc, TellPaciente, RGPaciente, CPFPaciente, AddPaciente FROM Clientes
GO

-- Seleciona Todas as Consultas
SELECT * FROM Consulta
GO

-- Seleciona as consultas de um paciente especifico
SELECT * FROM Consulta WHERE Clientes_ID = 2
GO

-- Seleciona Todos os Médicos
SELECT * FROM Medicos
GO

-- Seleciona Todos os Clientes
SELECT * FROM Clientes
GO


