using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Tests.Entidades
{
    [TestClass]
    public  class SofaTest
    {
        [TestMethod]
        public void CadastarNovoSofa()
        {

            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nome = "Guilherme";
            usuario.Login = "guilherme";
            usuario.Senha = "1234";
            usuario.Inspetor = false;


            Sofas sofa = new Sofas();

            try
            {
                sofa.SetSofa("Sofa teste", usuario.Inspetor);
            }
            catch (Exception e)
            {
                Assert.AreEqual(sofa.Nome, "Sofa teste");
            }

            
            Assert.AreEqual(sofa.Nome, "Sofa teste");

        }
    }
}
