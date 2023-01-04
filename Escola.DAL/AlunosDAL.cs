using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Escola.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DAL
{
    public class AlunosDAL : Conexao

    {
        //Cadastrar
        public void Cadastrar(AlunosDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Alunos (Nome,Sobrenome,CPF,Senha,Endereco,Telefone,Email,Rua,Bairro,TipoUsuario) VALUES(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.Nome);
                cmd.Parameters.AddWithValue("@v2", objCad.Sobrenome);
                cmd.Parameters.AddWithValue("@v3", objCad.CPF);
                cmd.Parameters.AddWithValue("@v4", objCad.Senha);
                cmd.Parameters.AddWithValue("@v5", objCad.Endereco);
                cmd.Parameters.AddWithValue("@v6", objCad.Telefone);
                cmd.Parameters.AddWithValue("@v7", objCad.Email);
                cmd.Parameters.AddWithValue("@v8", objCad.Rua);
                cmd.Parameters.AddWithValue("@v9", objCad.Bairro);
                cmd.Parameters.AddWithValue("@v10", objCad.DescricaoTipoUsuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar!! " + ex);
            }
            finally
            {
                Desconectar();
            }
        }

        //Editar
        public void Editar(AlunosDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Alunos SET Nome=@v1,Sobrenome=@v2,CPF=@v3,Senha=@v4,Endereco=@v5,Telefone=@v6,Email=@v7,Rua=@v8,Bairro=@v9,TipoUsuario=@v10 WHERE Cod_Aluno=@v11", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome);
                cmd.Parameters.AddWithValue("@v2", objEdita.Sobrenome);
                cmd.Parameters.AddWithValue("@v3", objEdita.CPF);
                cmd.Parameters.AddWithValue("@v4", objEdita.Senha);
                cmd.Parameters.AddWithValue("@v5", objEdita.Endereco);
                cmd.Parameters.AddWithValue("@v6", objEdita.Telefone);
                cmd.Parameters.AddWithValue("@v7", objEdita.Email);
                cmd.Parameters.AddWithValue("@v8", objEdita.Rua);
                cmd.Parameters.AddWithValue("@v9", objEdita.Bairro);
                cmd.Parameters.AddWithValue("@v10", objEdita.DescricaoTipoUsuario);
                cmd.Parameters.AddWithValue("@v11", objEdita.Cod_Aluno);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        //Excluir
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Alunos WHERE Cod_Aluno=@v11", conn);
                cmd.Parameters.AddWithValue("@v11", objExclui);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o Aluno!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }


        //selecionar
        public AlunosDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Aluno,Nome,Sobrenome,CPF,Senha,Endereco,Telefone,Email,Rua,Bairro,TipoUsuario  FROM Alunos JOIN TipoUsuario ON TipoUsuario= IdTipoUsuario WHERE Cod_Aluno=@v11", conn);
                cmd.Parameters.AddWithValue("@v11", objSeleciona);
                dr = cmd.ExecuteReader();

                AlunosDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new AlunosDTO();
                    obj.Cod_Aluno = Convert.ToInt32(dr["Cod_Aluno"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.Sobrenome = Convert.ToString(dr["Sobrenome"]);
                    obj.CPF= Convert.ToString(dr["CPF"]);
                    obj.Senha = Convert.ToString(dr["Senha"]);
                    obj.Endereco = Convert.ToString(dr["Endereco"]);
                    obj.Telefone = Convert.ToString(dr["Telefone"]);
                    obj.Email = Convert.ToString(dr["Email"]);
                    obj.Rua = Convert.ToString(dr["Rua"]);
                    obj.Bairro = Convert.ToString(dr["Bairro"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["TipoUsuario"]);
                }
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        //selecionar com LIKE
        public AlunosDTO SelecionaNome(string objSelecionaNome)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Aluno,Nome,Sobrenome,CPF,Senha,Endereco,Telefone,Email,Rua,Bairro,DescricaoTipoUsuario  FROM Alunos JOIN TipoUsuario ON TipoUsuario = IdTipoAluno WHERE NomeAluno LIKE @v11", conn);
                cmd.Parameters.AddWithValue("@v11", "%" + objSelecionaNome + "%");
                dr = cmd.ExecuteReader();

                AlunosDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new AlunosDTO();
                    obj.Cod_Aluno = Convert.ToInt32(dr["Cod_Aluno"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.Sobrenome = Convert.ToString(dr["Sobrenome"]);
                    obj.CPF = Convert.ToString(dr["CPF"]);
                    obj.Senha = Convert.ToString(dr["Senha"]);
                    obj.Endereco = Convert.ToString(dr["Endereco"]);
                    obj.Telefone = Convert.ToString(dr["Telefone"]);
                    obj.Email = Convert.ToString(dr["Email"]);
                    obj.Rua= Convert.ToString(dr["Rua"]);
                    obj.Bairro = Convert.ToString(dr["Bairro"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["DescricaoTipoUsuario"]);
                }
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        //listar
        public List<AlunosDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Aluno,Nome,Sobrenome,CPF,Senha,Endereco,Telefone,Email,Rua,Bairro,DescricaoTipoUsuario FROM Alunos JOIN TipoUsuario ON TipoUsuario = IdTipoUsuario", conn);
                dr = cmd.ExecuteReader();
                List<AlunosDTO> Lista = new List<AlunosDTO>(); // lista vazia

                while (dr.Read())
                {
                    AlunosDTO obj = new AlunosDTO();
                    obj.Cod_Aluno = Convert.ToInt32(dr["Cod_Aluno"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.Sobrenome = Convert.ToString(dr["Sobrenome"]);
                    obj.CPF = Convert.ToString(dr["CPF"]);
                    obj.Senha = Convert.ToString(dr["Senha"]);
                    obj.Endereco = Convert.ToString(dr["Endereco"]);
                    obj.Telefone = Convert.ToString(dr["Telefone"]);
                    obj.Email = Convert.ToString(dr["Email"]);
                    obj.Rua = Convert.ToString(dr["Rua"]);
                    obj.Bairro = Convert.ToString(dr["Bairro"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["DescricaoTipoUsuario"]);
                    Lista.Add(obj);
                }
                return Lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        //autenticar
        public AlunosDTO Autentica(string objUser, string objSenha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Alunos WHERE Email=@v1 AND Senha=@v2", conn);
                cmd.Parameters.AddWithValue("@v1", objUser);
                cmd.Parameters.AddWithValue("@v2", objSenha);
                dr = cmd.ExecuteReader();

                AlunosDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new AlunosDTO();
                    obj.Cod_Aluno = Convert.ToInt32(dr["Cod_Aluno"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.Sobrenome = Convert.ToString(dr["Sobrenome"]);
                    obj.CPF = Convert.ToString(dr["CPF"]);
                    obj.Senha = Convert.ToString(dr["Senha"]);
                    obj.Endereco = Convert.ToString(dr["Endereco"]);
                    obj.Telefone = Convert.ToString(dr["Telefone"]);
                    obj.Email = Convert.ToString(dr["Email"]);
                    obj.Rua = Convert.ToString(dr["Rua"]);
                    obj.Bairro = Convert.ToString(dr["Bairro"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["TipoUsuario"]);
                }
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao logar!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        //selecionar Tudo
        public AlunosDTO SelecionaTD()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Alunos", conn);
                dr = cmd.ExecuteReader();

                AlunosDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new AlunosDTO();
                    obj.Cod_Aluno = Convert.ToInt32(dr["Cod_Aluno"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.Sobrenome = Convert.ToString(dr["Sobrenome"]);
                    obj.CPF = Convert.ToString(dr["CPF"]);
                    obj.Senha = Convert.ToString(dr["Senha"]);
                    obj.Endereco = Convert.ToString(dr["Endereco"]);
                    obj.Telefone = Convert.ToString(dr["Telefone"]);
                    obj.Email = Convert.ToString(dr["Email"]);
                    obj.Rua = Convert.ToString(dr["Rua"]);
                    obj.Bairro = Convert.ToString(dr["Bairro"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["DescricaoTipoUsuario"]);
                }
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

    }
}

