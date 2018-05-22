using System.Collections.Generic;
using System.Linq;
using WebCalculator.Models;

namespace WebCalculator.Repositories
{
    public class ResultStubRepository : IResultRepository
    {
        private readonly IList<ResultModel> _resultModels;

        public ResultStubRepository()
        {
            _resultModels = new List<ResultModel>();
        }

        public void Create(ResultModel result)
        {
            result.Id = _resultModels.Count;
            _resultModels.Add(result);
        }

        public IQueryable<ResultModel> GetAll()
        {
            return _resultModels.ToList().AsQueryable();
        }

        public ResultModel GetById(int id)
        {
            if (id < 0 || id >= _resultModels.Count)
                return null;
            return _resultModels[id];
        }
    }
}
