using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DAL;
using Escola.DTO;

namespace Escola.BLL
{
    public class DisciplinaBLL
    {
        DisciplinaDAL objBLL = new DisciplinaDAL();

        //Cadastrar
        public void Cadastrar(DisciplinaDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }
        
        //Editar
        public void Editar(DisciplinaDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }
        
        
        //Excluir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar

        public DisciplinaDTO Seleciona(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Listar

        public List<DisciplinaDTO> Listar()
        {
            return objBLL.Listar();
        }


    }
}
