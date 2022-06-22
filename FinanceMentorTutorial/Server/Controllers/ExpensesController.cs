using FinanceMentorTutorial.Server.Storage;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceMentorTutorial.Shared;

namespace FinanceMentorTutorial.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController: ControllerBase
    {
        private readonly IRepository<Expense> _expenseRepository;
        public ExpensesController(IRepository<Expense> expenceRepository)
        {
            _expenseRepository = expenceRepository;
        }

        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            return _expenseRepository.GetAll()
                .OrderBy(expense => expense.Date);
        }

        [HttpPost]
        public void Post(Expense expense)
        {
            _expenseRepository.Add(expense);
        }

        [HttpDelete("{id?}")]
        public void Delete(Guid id)
        {
            var entity = _expenseRepository.GetAll()
                .Single(item => item.Id == id);
            _expenseRepository.Remove(entity);
        }
    }
}
