using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Novell.Directory.Ldap;
using QuizApi.Dominio.Settings;
using System;

namespace Elevate.QuizApi.Services
{
    public class LdapService : ILDAPService
    {
        private readonly LdapConnection _ldapConnection;
        private readonly LdapSettings _ldapSettings;

        public LdapService(LdapSettings ldapSettings)
        {
            _ldapConnection = new LdapConnection();
            _ldapSettings = ldapSettings;
            _ldapConnection.Connect(_ldapSettings.Servidor, _ldapSettings.Porta);
        }

        public void Login(string usuarioLdap, string senha)
        {
            try
            {
                _ldapConnection.Bind($"{usuarioLdap}{_ldapSettings.DominioURL}", senha);
            }
            catch (Exception)
            {
                throw new UnauthorizedAccessException("Usuário e/ou senha inválidos");
            }
        }

        public UsuarioDto BuscarDadosUsuario(string usuarioLdap, string senha)
        {
            Login(usuarioLdap, senha);
            var resultado = Buscar(usuarioLdap, ["name", "mail"]);
            try
            {
                if (resultado.HasMore())
                {
                    var proximoRegistro = resultado.Next();

                    return new UsuarioDto()
                    {
                        Email = proximoRegistro.getAttribute("mail").StringValue,
                        Nome = proximoRegistro.getAttribute("name").StringValue
                    };
                }
            }
            catch (LdapException)
            {
                throw new Exception("Dados não localizados no LDAP");
            }
            throw new Exception("Dados não localizados no LDAP");
        }

        private LdapSearchResults Buscar(string usuario, string[] atributos)
        {
            var restricao = _ldapConnection.SearchConstraints;
            restricao.ReferralFollowing = true;
            _ldapConnection.Constraints = restricao;

            return _ldapConnection.Search(
                _ldapSettings.Dominio,
                LdapConnection.SCOPE_SUB,
                $"(&(sAMAccountName={usuario}){_ldapSettings.Grupo})",
                atributos,
                false
            );
        }
    }
}
