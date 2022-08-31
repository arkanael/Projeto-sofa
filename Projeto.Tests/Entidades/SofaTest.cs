using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Tests.Entidades
{
    [TestClass]
    public  class SofaTest
    {
        List<Sofas> lista = new List<Sofas>();
        

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
                sofa.Registrar("Sofa teste", usuario);
            }
            catch (Exception e)
            {
                Assert.AreEqual(sofa.Nome, "Sofa teste");
            }


            Assert.AreEqual(sofa.Nome, "Sofa teste");

        }


        [TestMethod]
        public void AvaliarSofa()
        {


            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nome = "Guilherme";
            usuario.Login = "guilherme";
            usuario.Senha = "1234";
            usuario.Inspetor = false;

            Usuario usuarioAvaliador = new Usuario();
            usuarioAvaliador.Id = 2;
            usuarioAvaliador.Nome = "Marcos";
            usuarioAvaliador.Login = "marcos";
            usuarioAvaliador.Senha = "1234";
            usuarioAvaliador.Inspetor = true;

            Sofas sofa = new Sofas();

            try
            {
                sofa.Registrar("Sofa teste", usuario);
                sofa.Avaliar(true, usuarioAvaliador, 1);
                Debug.WriteLine($"Id: {sofa.Id}");
                Debug.WriteLine($"Nome: {sofa.Nome}");
                Debug.WriteLine($"Avaliado: {sofa.Avaliacao}");
                Debug.WriteLine($"Avaliado Por: {usuarioAvaliador.Nome}");
                Debug.WriteLine($"Data da avaliação: {sofa.DatAvaliacao}");

            }
            catch (Exception e)
            {
                Assert.AreEqual(sofa.Nome, "Sofa teste");
            }



            Assert.IsTrue(sofa.Avaliacao);

        }
    }
}
