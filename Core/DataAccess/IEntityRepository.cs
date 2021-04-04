//using Entities.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint T sadece class olabilir
    //IEntity : IEntity olabilir ya da IEntity implemente eden bir nesneolabilir
    //new() :new lenebilir olmalı.yani <> arasına interface koyarsan hata verecek
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
       
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
