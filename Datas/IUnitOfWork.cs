using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Datas
{
    public interface IUnitOfWork
    {
        IUserRepostory UserRepostorys { get; }
        void Complete();
    }
}
