using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DAL;
using Escola.DTO;

namespace Escola.BLL
{
    public class TurmaBLL
    {
        TurmaDAL objBLL = new TurmaDAL();

        //Cadastrar
        public void Cadastrar(TurmaDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Editar
        public void Editar(TurmaDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Exlcuir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar
        public TurmaDTO Seleciona(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Listar
        public List<TurmaDTO> Listar()
        {
            return objBLL.Listar();
        }
    }
}
