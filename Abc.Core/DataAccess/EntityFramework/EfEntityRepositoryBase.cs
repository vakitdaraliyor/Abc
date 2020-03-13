using Abc.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {  
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            // bana bir context olustur ve filtreye uygun sonucu Get ir 
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            // bana bir context olustur ve eger filtre bos ise tum listeyi getir
            // filtre dolu ise kosulu saglayan listeyi getir
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity Entity)
        {
            using (var context = new TContext())
            {
                // benim nesnemle ilgili bir entry olustur
                var addedEntity = context.Entry(Entity);
                // onun eklenecek bir nesne oldugunu anla
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(Entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
