using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IntranetProdCr.Models;

namespace IntranetProdCr.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly INT_PROD_CRContext _context;

        public UsuariosController(INT_PROD_CRContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var iNT_PROD_CRContext = _context.Usuarios.Include(u => u.EmCodigoNavigation).Include(u => u.IdNavigation);
            return View(await iNT_PROD_CRContext.ToListAsync());
        }

        // GET: Usuarios
        public async Task<IActionResult> IndexUser()
        {
            var iNT_PROD_CRContext = _context.Usuarios.Include(u => u.EmCodigoNavigation).Include(u => u.IdNavigation);
            return View(await iNT_PROD_CRContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.EmCodigoNavigation)
                .Include(u => u.IdNavigation)
                .FirstOrDefaultAsync(m => m.UsCodigo == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["EmCodigo"] = new SelectList(_context.Empresas, "EmCodigo", "EmCodigo");
            ViewData["Id"] = new SelectList(_context.AspNetUsers, "Id", "Id");
          //  var usuario = _context.Usuarios.Include(u => u.EmCodigoNavigation).Include(u => u.IdNavigation);

            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsCodigo,UsNombre1,UsNombre2,UsNombre3,UsApellido1,UsApellido2,UsEstado,UsActivo,UsJefe,UsGerencia,UsCambio,UsTerminos,EmCodigo,Id")] Usuario usuario)
        {
           
            // Console.WriteLine(usuario.EmCodigoNavigation);
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            /*else {
                var message = string.Join(" | ", ModelState.Values
        .SelectMany(v => v.Errors)
        .Select(e => e.ErrorMessage));
                Console.WriteLine( message);
            }*/
            ViewData["EmCodigo"] = new SelectList(_context.Empresas, "EmCodigo", "EmCodigo", usuario.EmCodigo);
            ViewData["Id"] = new SelectList(_context.AspNetUsers, "Id", "Id", usuario.Id);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["EmCodigo"] = new SelectList(_context.Empresas, "EmCodigo", "EmCodigo", usuario.EmCodigo);
            ViewData["Id"] = new SelectList(_context.AspNetUsers, "Id", "Id", usuario.Id);
            ViewData["idC"] = id;
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int idC, [Bind("UsCodigo,UsNombre1,UsNombre2,UsNombre3,UsApellido1,UsApellido2,UsEstado,UsActivo,UsJefe,UsGerencia,UsCambio,UsTerminos,EmCodigo,Id")] Usuario usuario)
        {
            //Console.WriteLine(id);
            //int idC = 11;
            if (idC != usuario.UsCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsCodigo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmCodigo"] = new SelectList(_context.Empresas, "EmCodigo", "EmCodigo", usuario.EmCodigo);
            ViewData["Id"] = new SelectList(_context.AspNetUsers, "Id", "Id", usuario.Id);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.EmCodigoNavigation)
                .Include(u => u.IdNavigation)
                .FirstOrDefaultAsync(m => m.UsCodigo == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'INT_PROD_CRContext.Usuarios'  is null.");
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return _context.Usuarios.Any(e => e.UsCodigo == id);
        }
    }
}
