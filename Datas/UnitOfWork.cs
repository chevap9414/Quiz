using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Datas
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationSqlContext context;

        public UnitOfWork(ApplicationSqlContext context)
        {
            this.context = context;
            UserRepostorys = new UserRepository(context);
        }
        public IUserRepostory UserRepostorys { get; private set; }

        public void Complete()
        {
            context.SaveChanges();
        }
    }
}
