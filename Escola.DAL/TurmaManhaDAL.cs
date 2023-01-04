using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using System.Data.SqlClient;

namespace Escola.DAL
{
    public class TurmaManhaDAL:Conexao
    {
        //Cadastrar
        public void Cadastrar(TurmaManhaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Turma_Manha(Nome_Aluno,Cod_Aluno) VALUES(@v1,@v2)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.Nome_Aluno);
                cmd.Parameters.AddWithValue("@v2", objCad.Cod_Aluno);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro no cadastro " + ex);
            }
            finally
            {
                Desconectar();
            }
        }


        //Editar
        public void Editar(TurmaManhaDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Turma_Manha SET Nome_Aluno=@v1,Cod_Aluno=@v2,Cod_Turma1=@v3 WHERE Cod_Turma1=@v3", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome_Aluno);
                cmd.Parameters.AddWithValue("@v2", objEdita.Cod_Aluno);
                cmd.Parameters.AddWithValue("@v3", objEdita.Cod_Turma1);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na edição!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        
        //Exlcuir
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Turma_Manha WHERE Cod_Turma1=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objExclui);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir!!" + ex);
            }
            finally
            {
                Desconectar();
            }

        }


        //selecionar
        public TurmaManhaDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Turma1,Nome_Aluno,Cod_Aluno FROM Turma_Manha JOIN TipoUsuario ON TipoUsuario WHERE Cod_Turma1=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objSeleciona);
                dr = cmd.ExecuteReader();

                TurmaManhaDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new TurmaManhaDTO();
                    obj.Cod_Turma1 = Convert.ToInt32(dr["Cod_Turma1"]);
                    obj.Nome_Aluno = Convert.ToString(dr["Nome_Aluno"]);
                    obj.Cod_Aluno = Convert.ToString(dr["Cod_Aluno"]);                }
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na busca!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }


        //listar
        public List<TurmaManhaDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Turma1,Nome_Aluno,Cod_Aluno FROM Turma_Manha JOIN TipoUsuario ON TipoUsuario = Cod_Turma1", conn);
                dr = cmd.ExecuteReader();
                List<TurmaManhaDTO> Lista = new List<TurmaManhaDTO>(); // lista vazia

                while (dr.Read())
                {
                    TurmaManhaDTO obj = new TurmaManhaDTO();
                    obj.Cod_Turma1 = Convert.ToInt32(dr["Cod_Turma1"]);
                    obj.Nome_Aluno = Convert.ToString(dr["Nome_Aluno"]);
                    obj.Cod_Aluno = Convert.ToString(dr["Cod_Aluno"]);
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


    }
}
