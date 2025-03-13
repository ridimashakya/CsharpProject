using CRUDoperation.Data;
using CRUDoperation.Models;
using CRUDoperation.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDoperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public WorkersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllWorkers()
        {
            return Ok(dbContext.AllWorkers.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetWorkerById(Guid id)
        {
            var worker = dbContext.AllWorkers.Find(id);

            if(worker is null)
            {
                return NotFound();
            }

            return Ok(worker);
        }

        [HttpPost]
        public IActionResult AddWorker(AddWorkerDto addWorkerDto)
        {
            var workerEntity = new Workers
            {
                Name = addWorkerDto.Name,
                Email = addWorkerDto.Email,
                Phone = addWorkerDto.Phone,
                Wages = addWorkerDto.Wages
            };

            dbContext.AllWorkers.Add(workerEntity);
            dbContext.SaveChanges();

            return Ok(workerEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateWorker(Guid id, UpdateWorkerDto updateWorkerDto)
        {
            var worker = dbContext.AllWorkers.Find(id);

            if(worker is null)
            {
                return NotFound();
            }

            worker.Name = updateWorkerDto.Name;
            worker.Email = updateWorkerDto.Email;
            worker.Phone = updateWorkerDto.Phone;
            worker.Wages = updateWorkerDto.Wages;

            dbContext.SaveChanges();
            return Ok(worker);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteWorker(Guid id)
        {
            var worker = dbContext.AllWorkers.Find(id);

            if(worker is null)
            {
                return NotFound();
            }
            dbContext.AllWorkers.Remove(worker);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
