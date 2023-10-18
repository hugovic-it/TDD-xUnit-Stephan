using ExpectedObjects;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoOnline.DominioTest.Cursos;

/*
"Eu, enquanto administrador, quero criar e editar
cursos para que sejam abertas mastriculas para o mesmo."

Criterios de aceite:
->Criar yum curso com nome, carga horária, publico alvo e valor do curso.
->As opções para público alvo são: Estudante, Universitário, Empregado e Empreendedor.
->Todos os campos do curso são obrigatórios.
 */
public class CursoTest
{
    [Fact]
    public void DeveCriarCurso()
    {
        //Arrange
        var cursoEsperado = new
        {
            Nome = "Informatica básica",
            CargaHoraria = (double)80,
            PublicoAlvo = PublicoAlvo.Estudante,
            Valor = (double)950
        };

        //Act //Action
        var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

        //Assert
        cursoEsperado.ToExpectedObject().ShouldMatch(curso);
    }
}

public enum PublicoAlvo
{
    Estudante,
    Universitario,
    Empregado,
    Empreendedor
}

public class Curso
{
    public string Nome { get; private set; }
    public double CargaHoraria { get; private set; }
    public PublicoAlvo PublicoAlvo { get; private set; }
    public double Valor { get; private set; }
    public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
    {
        Nome = nome;
        CargaHoraria = cargaHoraria;
        PublicoAlvo = publicoAlvo;
        Valor = valor;  
    }



   
}



