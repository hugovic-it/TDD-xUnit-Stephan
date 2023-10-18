using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoOnline.DominioTest.Cursos
{

    /*
    "Eu, enquanto administrador, quero criar e editar
    cursos para que sejam abertas mastriculas para o mesmo."

    Criterios de aceite:
    ->Criar yum curso com nome, carga horária, publico alvo e valor do curso.
    ->As opções para público alvo são: Estudante, Universitário, Empregado e Empregador.
    ->Todos os campos do curso são obrigatórios.
     */

    public class CursoTest
    {


        [Fact]
        public void DeveCriarCurso()
        {

            //Arrange
            string nome = "Informatica básica";
            double cargaHoraria = 80;
            string publicoAlvo = "Estudantes";
            double valor = 950;

            //Action
            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            //Assert
            Assert.Equal(nome, curso.Nome);
            Assert.Equal(cargaHoraria, curso.CargaHoraria);
            Assert.Equal(publicoAlvo, curso.PublicoAlvo);
            Assert.Equal(valor, curso.Valor);
        }
    }


    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public string PublicoAlvo { get; private set; }
        public double Valor { get; private set; }
        public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;  
        }



       
    }


}



