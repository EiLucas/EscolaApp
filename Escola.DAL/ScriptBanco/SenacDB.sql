USE LucasAlves

CREATE TABLE Alunos
(
Cod_Aluno INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome VARCHAR(50) NOT NULL,
Sobrenome VARCHAR(50) NOT NULL,
CPF VARCHAR(20) NOT NULL,
Senha VARCHAR(6) NOT NULL,
Endereco VARCHAR(20) NOT NULL,
Telefone VARCHAR(15) NOT NULL,
Email VARCHAR(30) NOT NULL,
Rua VARCHAR(50) NOT NULL,
Bairro VARCHAR(50) NOT NULL,
TipoUsuario INT NOT NULL,

FOREIGN KEY(TipoUsuario) REFERENCES TipoUsuario
);

CREATE TABLE TipoUsuario
(
IdTipoUsuario INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
DescricaoTipoUsuario VARCHAR(50) NOT NULL
);

SELECT Cod_Aluno,Nome,CPF,Senha,Endereco,Telefone,Email,Rua,Bairro,DescricaoTipoUsuario 
FROM Alunos JOIN TipoUsuario ON TipoUsuario=IdTipoUsuario;

INSERT INTO TipoUsuario VALUES('Administrador')
INSERT INTO TipoUsuario VALUES('Aluno')

SELECT * FROM TipoUsuario
--------------------------------------------------------------------------------------------

CREATE TABLE Professor
(
Id_Professor INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome_Professor VARCHAR(50) NOT NULL,
Disciplina INT NOT NULL

FOREIGN KEY(Disciplina) REFERENCES DISCIPLINA
);

---------------------------------------------------------------------------------------------
CREATE TABLE DISCIPLINA
(
Cod_Disciplina INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome_Disciplina VARCHAR(50) NOT NULL,
Horario_inicio VARCHAR(14) NOT NULL,
Horario_Termino VARCHAR(20) NOT NULL,
Periodo INT NOT NULL,

FOREIGN KEY(Periodo) REFERENCES Periodo
);

SELECT Cod_Disciplina,Nome_Disciplina,Horario_Inicio,Horario_Termino,DescricaoPeriodo 
FROM DISCIPLINA JOIN Periodo ON Periodo=Cod_Periodo

------------------------------------------------------------------------------------------------
CREATE TABLE Periodo
(
Cod_Periodo INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
DescricaoPeriodo VARCHAR(50) NOT NULL
);

----------------------------------------------------------------------------------------------------
CREATE TABLE Curso
(
Cod_Curso INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome_Curso VARCHAR(50) NOT NULL,
Carga_Horaria VARCHAR(100) NOT NULL
);

----------------------------------------------------------------------------------------

CREATE TABLE Turma
(
Cod_Turma INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome VARCHAR(50) NOT NULL,
Periodo INT NOT NULL

FOREIGN KEY (Periodo) REFERENCES Periodo
);

SELECT Cod_Turma,Nome,DescricaoPeriodo
FROM Turma JOIN Periodo ON Periodo=Cod_Periodo;

INSERT INTO Turma VALUES('Turma1', 1)
INSERT INTO Turma VALUES('Turma2', 2)
INSERT INTO Turma VALUES('Turma3', 3)

SELECT * FROM Turma


INSERT INTO Periodo VALUES('Manhã');
INSERT INTO Periodo VALUES('Tarde');
INSERT INTO Periodo VALUES('Noite');

SELECT * FROM Periodo


CREATE TABLE Turma_Manha
(
Cod_Turma1 INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome_Aluno VARCHAR(50) NOT NULL,
Cod_Aluno INT NOT NULL,
);

CREATE TABLE Turma_Tarde
(
Cod_Turma2 INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome_Aluno VARCHAR(50) NOT NULL,
Cod_Aluno INT NOT NULL,
);

CREATE TABLE Turma_Noite
(
Cod_Turma3 INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nome_Aluno VARCHAR(50) NOT NULL,
Cod_Aluno INT NOT NULL,
);

SELECT * FROM Periodo
SELECT * FROM Alunos
SELECT * FROM Turma
SELECT * FROM Professor
SELECT * FROM DISCIPLINA



