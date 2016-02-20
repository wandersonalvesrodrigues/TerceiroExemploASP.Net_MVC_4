using System.ComponentModel.DataAnnotations;
namespace TerceiroExemploMVC.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage="O nome é Obrigatório")]
        public string Nome { get; set; }
        [StringLength(50,MinimumLength=5,ErrorMessage="A observação deve ficar entre 5 até 50 caracteres")]
        public string Observacao { get; set; }
        [Range(18,50,ErrorMessage="A pessoa deve possuir idade entre 18 até 50 anos")]
        public int Idade { get; set; }
        [Required(ErrorMessage="E-mail é obrigatório")]
        [RegularExpression(@"^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$",ErrorMessage="E-mail inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage="Login é obrigatório")]
        [System.Web.Mvc.Remote("LoginUnico","Pessoa",ErrorMessage="Pessoa já cadastrada")]
        public string Login { get; set; }
        [Required(ErrorMessage="A senha é obrigatória")]
        public string Senha { get; set; }
        [Required(ErrorMessage="O confirma senha é obrigatória")]
        [Compare("Senha",ErrorMessage="As senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}