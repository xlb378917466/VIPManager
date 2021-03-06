﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Repository
{
    public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;

        public QueryRepository(IDbContext context)
        {
            this._context = context;
        }
        public IQueryable<T> Entities => _context.Set<T>();
    }
}
