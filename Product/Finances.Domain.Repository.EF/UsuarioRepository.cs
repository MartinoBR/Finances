using System;
using Finances.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Finances.Domain.Repository.EF
{
    public class UsuarioRepository : FinancesCRUDRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FinancesContext dbContext)
         : base(dbContext)
        {
        }

        protected override DbSet<Usuario> DbSet { get { return Context.Usuarios; } }

        public virtual Usuario GetUsuarioByLoginSenha(string login, string senha)
        {
            return GetOne(u => u.Login == login && u.Senha == senha);
        }
    }
}