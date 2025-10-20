using EmprestimoLivros.Data;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoController : Controller
    {
        #region Construtor

        private readonly string mensagemDeErro = "Algo não esta certo, tente novamente mais tarde.";
        private readonly ApplicationDbContext _applicationDbContext;

        public EmprestimoController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        #endregion Construtor

        #region Get

        [Description("Retorna todos os empréstimos para o usuário.")]
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos = _applicationDbContext.Emprestimo;

            return View(emprestimos);
        }

        [Description("Retorna página de cadastro para novo empréstimo.")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [Description("Busca emprestimo informado e retorna página de Edição para o empréstimo.")]
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            return BuscaEmpresaPorId(id);
        }

        [Description("Retorna página de exclusão para o empréstimo selecionado.")]
        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            return BuscaEmpresaPorId(id);
        }

        #endregion Get

        #region Post

        [Description("Cadastra novo empréstimo.")]
        [HttpPost]
        public IActionResult Cadastrar(EmprestimoModel emprestimos)
        {
            if (ModelState.IsValid && emprestimos.Fornecedor != null)
            {
                _applicationDbContext.Emprestimo.Add(emprestimos);
                _applicationDbContext.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }
            else
            {
                TempData["MensagemFalha"] = mensagemDeErro;
                return View();
            }
        }

        #endregion Post

        #region Put

        [Description("Edita o empréstimo selecionado.")]
        [HttpPost]
        public IActionResult Editar(EmprestimoModel emprestimo)
        {
            if (ModelState.IsValid && emprestimo.Id > 0)
            {
                _applicationDbContext.Emprestimo.Update(emprestimo);
                _applicationDbContext.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }
            else
            {
                TempData["MensagemFalha"] = mensagemDeErro;
                return View();
            }
        }

        #endregion Put

        #region Delete

        [Description("Exclui o empréstimo selecionado.")]
        [HttpPost]
        public IActionResult Excluir(EmprestimoModel emprestimo)
        {
            if (emprestimo == null || emprestimo.Id <= 0)
            {
                TempData["MensagemFalha"] = mensagemDeErro;
                return View();
            }

            _applicationDbContext.Emprestimo.Remove(emprestimo);
            _applicationDbContext.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão realizada com sucesso!";

            return RedirectToAction("Index");
        }

        #endregion Delete

        #region Método Privado

        private IActionResult BuscaEmpresaPorId(int? id)
        {
            EmprestimoModel? emprestimo = null;

            if (id != null && id > 0)
                emprestimo = _applicationDbContext.Emprestimo.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null || emprestimo.Id <= 0)
            {
                TempData["MensagemFalha"] = mensagemDeErro;
                return NotFound();
            }

            return View(emprestimo);
        }

        #endregion Método Privado
    }
}
