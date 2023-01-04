using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Escola.DTO;

namespace Escola.DAL
{
    public class DisciplinaDAL : Conexao

    {
        //Cadastrar
        public void Cadastrar(DisciplinaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO DISCIPLINA (Nome_Disciplina,Horario_Inicio, Horario_Termino, Periodo) VALUES(@v1,@v2,@v3,@v4)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.Nome_Disciplina);
                cmd.Parameters.AddWithValue("@v2", objCad.Horario_inicio);
                cmd.Parameters.AddWithValue("@v3", objCad.Horario_Termino);
                cmd.Parameters.AddWithValue("@v4", objCad.DescricaoPeriodo);
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
        public void Editar(DisciplinaDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE DISCIPLINA SET Nome_Disciplina=@v1, Horario_Inicio=@v2,Horario_Termino=@v3,Periodo=@v4 WHERE Cod_Disciplina=@v5", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome_Disciplina);
                cmd.Parameters.AddWithValue("@v2", objEdita.Horario_inicio);
                cmd.Parameters.AddWithValue("@v3", objEdita.Horario_Termino);
                cmd.Parameters.AddWithValue("@v4", objEdita.DescricaoPeriodo);
                cmd.Parameters.AddWithValue("@v5", objEdita.Cod_Disciplina);
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


        //Ecluir
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM DISCIPLINA WHERE Cod_Disciplinar=@v5", conn);
                cmd.Parameters.AddWithValue("@v5", objExclui);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir a Disciplina!! " + ex);
            }
            finally
            {
                Desconectar();
            }
        }

        //Seleciona
        public DisciplinaDTO Seleciona(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Disciplina,Nome_Disciplina,Horario_Inicio,Horario_Termino,Periodo FROM DISCIPLINA JOIN PERIODO ON PERIODO=Cod_Periodo WHERE Cod_Disciplina=@v5", conn);
                cmd.Parameters.AddWithValue("@v5", objSeleciona);
                dr = cmd.ExecuteReader();

                DisciplinaDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new DisciplinaDTO();
                    obj.Cod_Disciplina = Convert.ToInt32(dr["Cod_Disciplina"]);
                    obj.Nome_Disciplina = Convert.ToString(dr["Nome_Disciplina"]);
                    obj.Horario_inicio = Convert.ToString(dr["Horario_Inicio"]);
                    obj.Horario_Termino = Convert.ToString(dr["Horario_Termino"]);
                    obj.DescricaoPeriodo = Convert.ToString(dr["Periodo"]);
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


        //Listar
        public List<DisciplinaDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Disciplina,Nome_Disciplina,Horario_Inicio,Horario_Termino,DescricaoPeriodo FROM DISCIPLINA JOIN Periodo ON Periodo=Cod_Periodo", conn);
                dr = cmd.ExecuteReader();
                List<DisciplinaDTO> Lista = new List<DisciplinaDTO>(); // lista vazia

                while (dr.Read())
                {
                    DisciplinaDTO obj = new DisciplinaDTO();
                    obj.Cod_Disciplina = Convert.ToInt32(dr["Cod_Disciplina"]);
                    obj.Nome_Disciplina = Convert.ToString(dr["Nome_Disciplina"]);
                    obj.Horario_inicio = Convert.ToString(dr["Horario_Inicio"]);
                    obj.Horario_Termino = Convert.ToString(dr["Horario_Termino"]);
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





