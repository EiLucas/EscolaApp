using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using System.Data.SqlClient;

namespace Escola.DAL
{
    public class TurmaDAL:Conexao
    {
        //Cadastrar
        public void Cadastrar(TurmaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO TURMA(Nome,Periodo) VALUES(@v1,@v2)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.Nome);
                cmd.Parameters.AddWithValue("@v2", objCad.DescricaoPeriodo);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro no cadastro!! " + ex);
            }
            finally
            {
                Desconectar();
            }
        }

        //Editar
        public void Editar(TurmaDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE TURMA SET Nome=@v1,Periodo=@v2,Cod_Turma=@v3 WHERE Cod_Turma=@v3", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome);
                cmd.Parameters.AddWithValue("@v2", objEdita.DescricaoPeriodo);
                cmd.Parameters.AddWithValue("@v3", objEdita.Cod_Turma);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na edição! " + ex);
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
                cmd = new SqlCommand("DELETE FROM TURMA WHERE Cod_Turma=@v3", conn);
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
        public TurmaDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Turma,Nome,Periodo FROM TURMA JOIN PERIODO ON PERIODO WHERE Cod_Turma=@v3", conn);
                cmd.Parameters.AddWithValue("@v3", objSeleciona);
                dr = cmd.ExecuteReader();

                TurmaDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new TurmaDTO();
                    obj.Cod_Turma = Convert.ToInt32(dr["Cod_Turma"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.DescricaoPeriodo = Convert.ToString(dr["Periodo"]);
                }
                return obj;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na busca! " + ex);
            }
            finally
            {
                Desconectar();
            }

        }

       
        //listar
        public List<TurmaDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Turma,Nome,DescricaoPeriodo FROM TURMA JOIN PERIODO ON PERIODO = Cod_Periodo", conn);
                dr = cmd.ExecuteReader();
                List<TurmaDTO> Lista = new List<TurmaDTO>(); // lista vazia

                while (dr.Read())
                {
                    TurmaDTO obj = new TurmaDTO();
                    obj.Cod_Turma = Convert.ToInt32(dr["Cod_Turma"]);
                    obj.Nome = Convert.ToString(dr["Nome"]);
                    obj.DescricaoPeriodo = Convert.ToString(dr["DescricaoPeriodo"]);
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
