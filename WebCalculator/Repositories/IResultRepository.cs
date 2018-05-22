using System.Linq;
using WebCalculator.Models;

namespace WebCalculator.Repositories
{
    public interface IResultRepository
    {
        void Create(ResultModel result);

        ResultModel GetById(int id);

        IQueryable<ResultModel> GetAll();
    }
}
