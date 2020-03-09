using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudNESS.Models;

namespace CrudNESS.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UserContext _context;

        public UsuarioController(UserContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuario/Create
        public IActionResult AdicionarOuEditar(int id = 0)
        {
            if (id == 0)
                return View(new Usuario());
            else
                return View(_context.Usuarios.Find(id));
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarOuEditar([Bind("Id,Nome,Cpf,Telefone")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Id == 0)
                    _context.Add(usuario);
                else
                    _context.Update(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Excluir(int? id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
