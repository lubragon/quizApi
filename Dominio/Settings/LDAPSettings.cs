namespace QuizApi.Dominio.Settings
{
    public class LdapSettings
    {
        public string Servidor { get; set; } = string.Empty;
        public int Porta { get; set; }
        public string Grupo { get; set; } = string.Empty;
        public string Dominio { get; set; } = string.Empty;
        public string DominioURL { get; set; } = string.Empty;

				public string Usuario {get; set;} = string.Empty;
    }
}
