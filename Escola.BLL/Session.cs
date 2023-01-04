using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.DTO;
using Escola.DAL;

namespace Escola.BLL
{
    public class Session
    {
        //usuario
        private static string _nomealuno;


        public static string nomealuno
        {
            get { return Session._nomealuno; }
            set { Session._nomealuno = value; }
        }
    }
}
