// using Elevate.QuizApi.Services.Interfaces;
// using Novell.Directory.Ldap;
// using System;

// namespace Elevate.QuizApi.Services
// {
//     public class LdapService : ILDAPService
//     {
//         private readonly LdapConnection _ldapConnection;
//         private readonly LDAPSettings _ldapSettings;

//         public LdapService(LDAPSettings ldapSettings)
//         {
//             _ldapConnection = new LdapConnection();
//             _ldapSettings = ldapSettings;
//             _ldapConnection.Connect(_ldapSettings.Servidor, _ldapSettings.Porta);
//         }

//         public void Login(string usuarioLdap, string senha)
//         {
//             try
//             {
//                 _ldapConnection.Bind($"{usuarioLdap}{_ldapSettings.DominioURL}", senha);
//             }
//             catch (Exception)
//             {
//                 throw new UnauthorizedAccessException("Usuário e/ou senha inválidos");
//             }
//         }

//         public void ValidarGrupoUsuario(string usuarioLdap)
//         {
//             var resultado = Buscar(usuarioLdap, new string[] { "memberOf" });

//             try
//             {
//                 if (resultado.HasMore())
//                     resultado.Next();
//                 else
//                 {
//                     throw new BadRequestException("Usuário não possui acesso ao FO Seminovos");
//                 }
//             }
//             catch (LdapException)
//             {
//                 throw new BadRequestException("Usuário não possui acesso ao FO Seminovos");
//             }
//         }

//         public Usuario BuscarDadosUsuario(string usuarioLdap)
//         {
//             Login(_ldapSettings.Usuario, _ldapSettings.Senha);
//             var resultado = Buscar(usuarioLdap, new string[] { "name", "mail" });
//             try
//             {
//                 if (resultado.HasMore())
//                 {
//                     var proximoRegistro = resultado.Next();

//                     return new Usuario()
//                     {
//                         Email = proximoRegistro.getAttribute("mail").StringValue,
//                         Nome = proximoRegistro.getAttribute("name").StringValue
//                     };
//                 }
//             }
//             catch (LdapException)
//             {
//                 throw new BadRequestException("Dados não localizados no LDAP");
//             }
//             throw new BadRequestException("Dados não localizados no LDAP");
//         }

//         private LdapSearchResults Buscar(string usuario, string[] atributos = null)
//         {
//             var restricao = _ldapConnection.SearchConstraints;
//             restricao.ReferralFollowing = true;
//             _ldapConnection.Constraints = restricao;

//             return _ldapConnection.Search(
//                 _ldapSettings.Dominio,
//                 LdapConnection.SCOPE_SUB,
//                 $"(&(sAMAccountName={usuario})(memberOf={_ldapSettings.Grupo}))",
//                 atributos,
//                 false
//             );
//         }
//     }
// }
