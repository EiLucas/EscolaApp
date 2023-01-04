using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.DAL;

namespace Escola.BLL
{
    public class AlunosBLL
    {
        AlunosDAL objBLL = new AlunosDAL();


        //Cadastrar
        public void CadastrarAluno(AlunosDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Editar
        public void EditarAluno(AlunosDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Excluir
        public void ExcluirAluno(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Selecionar
        public AlunosDTO SelecionaAluno(int objModelo)
        {
            return objBLL.Seleciona(objModelo);
        }

        //Selecionar com LIKE
        public AlunosDTO SelecionaNomeAluno(string objModelo)
        {
            return objBLL.SelecionaNome(objModelo);
        }

        //Listar
        public List<AlunosDTO> ListarAluno()
        {
           return objBLL.Listar();
        }

        //Autenticar
        public AlunosDTO AutenticaAluno(string objUser, string objSenha)
        {
            AlunosDTO user = objBLL.Autentica(objUser, objSenha);

            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Deu erro!!");
            }            
        }

        //Selecionar Tudo
        public AlunosDTO SelecionaTD()
        {
            return objBLL.SelecionaTD();
        }
    }
}
