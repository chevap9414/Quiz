using QuizDemo.Datas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Datas
{
    public class UserRepository : GenericRepository<User>, IUserRepostory
    {
        public UserRepository(ApplicationSqlContext context) : base(context)
        {
        }
    }
}
