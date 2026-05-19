using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMvc.Controllers
{
    public class AlunoController : Controller
    {
        // Atalho de acesso: /Aluno ou /Aluno/Index
        public IActionResult Index()
        {
            ViewBag.Nome = "Ana Silva";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = 3;

            return View();
        }

        // Atalho de acesso: /Aluno/Detalhes/1
        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            ViewBag.Nome = "Ana Silva";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Situacao = "Matriculado";

            return View();
        }
    }
}
