using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Escola.DTO;

namespace Escola.DAL
{
     public class ProfessorDAL: Conexao
    {
        //Cadastrar
        public void Cadastrar(ProfessorDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO PROFESSOR (Nome_Professor,Disciplina) VALUES(@v1,@v2)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.Nome_Professor);
                cmd.Parameters.AddWithValue("@v2", objCad.Disciplina);

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
        public void Editar(ProfessorDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Professor SET Nome_Professor=@v1,Disciplina=@v2 WHERE Id_Professor=@v3", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome_Professor);
                cmd.Parameters.AddWithValue("@v2", objEdita.Disciplina);
                cmd.Parameters.AddWithValue("@v3", objEdita.Id_Professor);
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
                cmd = new SqlCommand("DELETE FROM Professor WHERE Id_Professor=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objExclui);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o Professor!! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

        //selecionar
        public ProfessorDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Id_Professor,Nome_Professor,Disciplina  FROM Professor WHERE Id_Professor=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objSeleciona);
                dr = cmd.ExecuteReader();

                ProfessorDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new ProfessorDTO();
                    obj.Id_Professor = Convert.ToInt32(dr["Id_Professor"]);
                    obj.Nome_Professor= Convert.ToString(dr["Nome_Professor"]);
                    obj.Disciplina = Convert.ToString(dr["Disciplina"]);
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
        public List<ProfessorDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Id_Professor,Nome_Professor,Disciplina FROM Professor JOIN DISCIPLINA ON DISCIPLINA = Disciplina", conn);
                dr = cmd.ExecuteReader();
                List<ProfessorDTO> Lista = new List<ProfessorDTO>(); // lista vazia

                while (dr.Read())
                {
                    ProfessorDTO obj = new ProfessorDTO();
                    obj.Id_Professor= Convert.ToInt32(dr["Id_Professor"]);
                    obj.Nome_Professor = Convert.ToString(dr["Nome_Professor"]);
                    obj.Disciplina = Convert.ToString(dr["Disciplina"]);
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
