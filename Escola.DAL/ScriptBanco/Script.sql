INSERT INTO DISCIPLINA VALUES('Hardware','13:30')

SELECT * FROM Curso


SELECT Cod_Disciplina,Nome_Disciplina,Horario_inicio,Horario_Termino, DescricaoPeriodo
FROM DISCIPLINA JOIN Periodo ON Periodo=Cod_Periodo;


SELECT Cod_Aluno,Nome,CPF,Senha,Endereco,Telefone,Email,Rua,Bairro,DescricaoTipoUsuario 
FROM Aluno JOIN TipoUsuario ON TipoUsuario=IdTipoUsuario;

INSERT INTO TipoUsuario VALUES('Administrador')
INSERT INTO TipoUsuario VALUES('Aluno')



SELECT * FROM ALUNO


INSERT INTO PERIODO VALUES('Manhã')
INSERT INTO PERIODO VALUES('Tarde')
INSERT INTO PERIODO VALUES('Noite')

SELECT * FROM Periodo


INSERT INTO Turma VALUES ('Turma_Manhã',1)
INSERT INTO Turma VALUES ('Turma_Tarde',2)
INSERT INTO Turma VALUES ('Turma_Noite',3)

SELECT * FROM Turma

SELECT Cod_Turma,Nome,DescricaoPeriodo
FROM Turma JOIN Periodo ON Periodo=Cod_Periodo;
