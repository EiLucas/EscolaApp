using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.DAL;

namespace Escola.BLL
{
    public class CursoBLL
    {
        CursoDAL objBLL = new CursoDAL();

        //Cadastrar
        public void Cadastrar(CursoDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Editar
        public void Editar(CursoDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Excluir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar
        public CursoDTO Seleciona(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Listar
        public List<CursoDTO> Listar()
        {
            return objBLL.Listar();
        }
    }
}
