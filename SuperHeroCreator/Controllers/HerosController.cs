using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroCreator.Data;
using SuperHeroCreator.Models;

namespace SuperHeroCreator.Controllers
{
	public class HerosController : Controller
	{
		private ApplicationDbContext _context;
		public HerosController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: HerosController
		public ActionResult Index()
		{
			//add queries
			var hero = _context.Heros;
			return View(hero);
		}

		// GET: HerosController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: HerosController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: HerosController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Hero hero)
		{
			try
			{
				//adds hero to db
				_context.Heros.Add(hero);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
				
			}
			catch
			{
				return View();
			}
		}

		// GET: HerosController/Edit/5
		public ActionResult Edit(int id)
		{
			var findid = _context.Heros.Find(id);
			return View(findid);
		}

		// POST: HerosController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Hero hero)
		{
			try
			{
				_context.Heros.Update(hero);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: HerosController/Delete/5
		public ActionResult Delete(int id)
		{
			var deleteid = _context.Heros.Find(id);
			return View(deleteid);
		}

		// POST: HerosController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Hero hero)
		{
			try
			{
				_context.Heros.Remove(hero);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
