using EmprestimoLivros.Helper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivros.Models
{
    [Table("Emprestimo")]
    public class EmprestimoModel
    {
        #region Propriedades (colunas da tabela)

        [Key]
        [Description("Identificador")]
        public int Id { get; set; }

        [Description("Nome de quem vai receber o livro. String obrigatoria.")]
        [Required(ErrorMessage = "Digete o nome do Recebedor.")]
        public string? Recebedor { get; set; }

        [Description("Nome de quem está fornecendo o livro. String obrigatoria.")]
        [Required(ErrorMessage = "Digete o nome do Fornecedor.")]
        public string? Fornecedor { get; set; }

        [Description("Nome do livro. String obrigatoria.")]
        [Required(ErrorMessage = "Digete o nome do Livro.")]
        public string? LivroEmprestado { get; set; }

        [Description("Data da última atualização, último emprestimo ou devolução. Datetime padrão horário de Brasília UTC-3")]
        public DateTime? DataUltimaAtualizacao { get; set; } = DateTime.UtcNow.ToDateTimeBrasilia();

        #endregion Propriedades (colunas da tabela)
    }
}
