﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        TiendaContext context = new();
        public async Task<IActionResult> Index()
        {
            return View(await context.Productos.ToListAsync());
        }
        // GET: Estudiantes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await context.Productos
                .FirstOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }
    }
}
