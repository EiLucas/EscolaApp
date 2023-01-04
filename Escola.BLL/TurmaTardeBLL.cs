using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.DAL;

namespace Escola.BLL
{
    public class TurmaTardeBLL
    {
        TurmaTardeDAL objBLL = new TurmaTardeDAL();

        //Cadastrar
        public void Cadastrar(TurmaTardeDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Editar
        public void Editar(TurmaTardeDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Excluir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar
        public TurmaTardeDTO Seleciona(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Listar
        public List<TurmaTardeDTO> Listar()
        {
            return objBLL.Listar();
        }
    }
}
