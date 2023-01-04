using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.DAL;


namespace Escola.BLL
{
    public class ProfessorBLL
    {
        ProfessorDAL objBLL = new  ProfessorDAL();

        //Cadastrar
        public void Cadastrar(ProfessorDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }


        //Editar
        public void Editar(ProfessorDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Excluir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar

        public ProfessorDTO Selecionar(int objModelo)
        {
          return  objBLL.Seleciona(objModelo);
        }

        //Listar
        public List<ProfessorDTO> Listar ()
        {
           return objBLL.Listar();
        }
    }
}
