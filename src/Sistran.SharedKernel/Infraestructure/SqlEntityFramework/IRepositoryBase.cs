﻿using Sistran.SharedKernel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sistran.SharedKernel.Infraestructure.SqlEntityFramework
{
    public interface IRepositoryBase<T>
        where T : AggregateRoot
    {
        void Add(T obj);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        T FindById(params object[] keys);   
        void Remove(T obj);
        void Update(T obj);
    }
}