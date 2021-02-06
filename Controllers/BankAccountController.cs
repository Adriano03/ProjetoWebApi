using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoWebApi.Data;
using ProjetoWebApi.Models;

namespace ProjetoWebApi.Controllers
{
    [ApiController]
    [Route("v1/bankAccounts")]

    public class bankAccountController: ControllerBase
    {
        [HttpGet]
        [Route("")]
        
        public async Task<ActionResult<List<BankAccount>>> Get([FromServices] DataContext context)
        {
            var bankAccounts = await context.BankAccounts.ToListAsync();
            return bankAccounts;
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<ActionResult<BankAccount>> GetById([FromServices] DataContext context, int id)
        {
            var bankAccount = await context.BankAccounts
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
            return bankAccount;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<BankAccount>> Post(
            [FromServices] DataContext context,
            [FromBody]BankAccount model)
        {
            if (ModelState.IsValid)
            {
                context.BankAccounts.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }

}