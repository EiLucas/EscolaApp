using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;

namespace Escola.DAL
{
    public class CursoDAL:Conexao
    {
        //Cadastrar
        public void Cadastrar(CursoDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO CURSO(Nome_Curso,Carga_Horaria) VALUES(@v1,@v2)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.Nome_Curso);
                cmd.Parameters.AddWithValue("@v2", objCad.Carga_Horaria);               
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
        public void Editar(CursoDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE CURSO SET Nome_Curso=@v1,Carga_Horaria=@v2 WHERE Cod_Curso=@v3", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome_Curso);
                cmd.Parameters.AddWithValue("@v2", objEdita.Carga_Horaria);
                cmd.Parameters.AddWithValue("@v3", objEdita.Cod_Curso);
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

        //Excluir
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM CURSO WHERE Cod_Curso=@v3", conn);
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
        public CursoDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Curso,Nome_Curso,Carga_Horaria FROM CURSO WHERE Cod_Curso=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objSeleciona);
                dr = cmd.ExecuteReader();

                CursoDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new CursoDTO();
                    obj.Cod_Curso = Convert.ToInt32(dr["Cod_Curso"]);
                    obj.Nome_Curso = Convert.ToString(dr["Nome_Curso"]);
                    obj.Carga_Horaria = Convert.ToString(dr["Carga_Horaria"]);                   
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
        public List<CursoDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Curso,Nome_Curso,Carga_Horaria FROM CURSO Cod_Curso", conn);
                dr = cmd.ExecuteReader();
                List<CursoDTO> Lista = new List<CursoDTO>(); // lista vazia

                while (dr.Read())
                {
                    CursoDTO obj = new CursoDTO();
                    obj.Cod_Curso = Convert.ToInt32(dr["Cod_Curso"]);
                    obj.Nome_Curso = Convert.ToString(dr["Nome_Curso"]);
                    obj.Carga_Horaria = Convert.ToString(dr["Carga_Horaria"]);                   
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
