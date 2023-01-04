using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DAL;
using Escola.DTO;

namespace Escola.BLL
{
    public class TurmaNoiteBLL
    {
        TurmaNoiteDAL objBLL = new TurmaNoiteDAL();

        //Cadastrar
        public void Cadastrar(TurmaNoiteDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Editar
        public void Editar(TurmaNoiteDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Excluir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar
        public TurmaNoiteDTO Seleciona(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Listar
        public List<TurmaNoiteDTO> Listar()
        {
            return objBLL.Listar();
        }
    }
}
