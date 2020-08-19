using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("")]
        [HttpGet]
        public ActionResult findAll() {
            return Ok(_context.Usuario);
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult findById(int id) {
            return Ok(_context.Usuario.Find(id));
        }

        [Route("")]
        [HttpPost]
        public ActionResult create([FromBody] Usuarios usuarios) {
            _context.Usuario.Add(usuarios);
            _context.SaveChanges();
            return Ok();
        }

        [Route("{id}")]
        [HttpPut]
        public ActionResult update(int id, [FromBody] Usuarios usuarios) {
            _context.Usuario.Update(usuarios);
            _context.SaveChanges();
            return Ok();
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult delete(int id) {
            _context.Usuario.Remove(_context.Usuario.Find(id));
            _context.SaveChanges();
            return Ok();
        }

    }
}
