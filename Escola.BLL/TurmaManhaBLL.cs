using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DAL;
using Escola.DTO;

namespace Escola.BLL
{
    public class TurmaManhaBLL
    {
        TurmaManhaDAL objBLL = new TurmaManhaDAL();

        //Cadastrar
        public void Cadastrar(TurmaManhaDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Editar
        public void Editar(TurmaManhaDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Excluir
        public void Excluir(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar
        public TurmaManhaDTO Seleciona(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Listar
        public List<TurmaManhaDTO> Listar()
        {
            return objBLL.Listar();
        }

    }
}
