using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using System.Data.SqlClient;

namespace Escola.DAL
{
    public class TurmaTardeDAL:Conexao
    {
        //Cadastrar
        public void Cadastrar(TurmaTardeDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Turma_Tarde(Nome_Aluno,Cod_Aluno) VALUES(@v1,@v2)", conn);
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
        public void Editar(TurmaTardeDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Turma_Tarde SET Nome_Aluno=@v1,Cod_Aluno=@v2,Cod_Turma2=@v3 WHERE Cod_Turma2=@v3", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome_Aluno);
                cmd.Parameters.AddWithValue("@v2", objEdita.Cod_Aluno);
                cmd.Parameters.AddWithValue("@v3", objEdita.Cod_Turma2);
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
                cmd = new SqlCommand("DELETE FROM Turma_Tarde WHERE Cod_Turma2=@v3", conn);
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
        public TurmaTardeDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Turma2,Nome_Aluno,Cod_Aluno FROM Turma_Tarde WHERE Cod_Turma2=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objSeleciona);
                dr = cmd.ExecuteReader();

                TurmaTardeDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new TurmaTardeDTO();
                    obj.Cod_Turma2 = Convert.ToInt32(dr["Cod_Turma2"]);
                    obj.Nome_Aluno = Convert.ToString(dr["Nome_Aluno"]);
                    obj.Cod_Aluno = Convert.ToString(dr["Cod_Aluno"]);
                }
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
        public List<TurmaTardeDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Turma2,Nome_Aluno,Cod_Aluno FROM Turma_Tarde", conn);
                dr = cmd.ExecuteReader();
                List<TurmaTardeDTO> Lista = new List<TurmaTardeDTO>(); // lista vazia

                while (dr.Read())
                {
                    TurmaTardeDTO obj = new TurmaTardeDTO();
                    obj.Cod_Turma2 = Convert.ToInt32(dr["Cod_Turma2"]);
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
