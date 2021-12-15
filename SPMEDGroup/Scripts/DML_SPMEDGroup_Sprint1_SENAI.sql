USE SPMEGroup
GO


INSERT INTO TipoUsuario(TipoNome)
VALUES ('Admin'), ('Cliente')
GO

INSERT INTO Usuario(TipoUsuario_ID)
VALUES  (1), (2), (2), (2), (2), (2), (2), (2), (2), (2), (2), (2)
GO

INSERT INTO Administrador(Usuario_ID, NomeAdmin)
VALUES (1, 'Carlos'), (2, 'Claudio')
GO

INSERT INTO Clientes(Usuario_ID, NomeCliente, DataNasc, TellPaciente, RGPaciente, CPFPaciente, AddPaciente)
VALUES (5, 'Ligia', '10/13/1983', '11 3456-7654', '43522543-5', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000'), (6, 'Alexandre', '7/23/2001', '11 98765-6543', '32654345-7', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200'), (7, 'Fernando', '10/10/1978', '11 97208-4453', '54636525-3', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200'), (8, 'Henrique', '10/13/1985', '11 3456-6543', '54366362-5', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030'), (9, 'João', '8/27/1975', '11 7656-6377', '53254444-1', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380'), (10, 'Bruno', '3/21/1972','11 95436-8769','54566266-7','79799299004','Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001' ), (11, 'Mariana','3/5/2018','','54566266-8','13771913039','R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140' )
GO

INSERT INTO Clinica (Admin_ID, AddClinica, RazaoSocial, Horarioabrir, Horariofechar)
VALUES (1, 'Av. Barão Limeira, 532, São Paulo, SP', 'SP Medical Group', '10:30', '10:30')
GO

INSERT INTO Especialidade(NomeEspecialidade)
VALUES ('Acupuntura'), ('Anestesiologia'), ('Angiologia'), ('Cardiologia'), ('Cirurgia Cardiovascular'), ('Cirurgia de Mão'), ('Cirurgia do Aparelho Digestivo'), ('Cirurgia Geral'), ('Cirurgia Pediatrica'), ('Cirurgia Plastica'), ('Cirurgia Torácica'), ('Cirurgia Vascular'), ('Dermatologia'), ('Radioterapia'), ('Urologia'), ('Pediatria'), ('Psiquiatria')
GO

INSERT INTO Medicos(Clinica_ID, Especialidade_ID, Usuario_ID, CRMMedico, NomeMedico)
VALUES (1,2,1, '54356-SP', 'Ricardo Lemos'), (1,17,2, '53452-SP', 'Roberto Possarle'), (1,16,3, '65463-SP', 'Helena Strada')
GO

INSERT INTO Consulta(Medico_ID, Clientes_ID, DataConsulta, DescConsulta)
VALUES (3, 3, '12/05',  'Dor na coluna' ), (4, 2, '15/07', 'Dores nos tornozelos'), (5, 7, '18/09', 'Consulta rotineira Pediatrica')
GO