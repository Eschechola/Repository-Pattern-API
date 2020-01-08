using System;
using CamadasRepository.Domain.Entities;
using CamadasRepository.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CamadasRepository.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private BaseService<User> service = new BaseService<User>();
        
        public IActionResult Index()
        {
            return Ok("API REST - Padrão Repository - conceitos de Domain Design Driven");
        }

        [HttpPost]
        [Route("user-insert")]
        public IActionResult Insert([FromBody] User user)
        {
            try
            {
                service.Insert(user);

                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new{ message = ex.Message.ToString() });
            }
        }


        [HttpPut]
        [Route("user-update")]
        public IActionResult Update([FromBody] User user)
        {
            try
            {
                service.Update(user);

                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message.ToString() });
            }
        }

        [HttpDelete]
        [Route("user-delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message.ToString() });
            }
        }


        [HttpGet]
        [Route("user-getall")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(service.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message.ToString() });
            }
        }


        [HttpGet]
        [Route("user-get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message.ToString() });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message.ToString() });
            }
        }

    }
}