using EventsManager.Application.Dtos;
using EventsManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EventsManager.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IApplicationTaskService applicationTaskService;

        public TaskController(IApplicationTaskService applicationTaskService)
        {
            this.applicationTaskService = applicationTaskService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationTaskService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationTaskService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] TaskDto taskDto)
        {
            try
            {
                if (taskDto == null)
                {
                    return NotFound();
                }

                applicationTaskService.Add(taskDto);
                return Ok("Task criada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] TaskDto taskDto)
        {
            try
            {
                if (taskDto == null)
                {
                    return NotFound();
                }

                applicationTaskService.Update(taskDto);
                return Ok("Task atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] TaskDto taskDto)
        {
            try
            {
                if (taskDto == null)
                {
                    return NotFound();
                }

                applicationTaskService.Add(taskDto);
                return Ok("Task removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}