using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MovieDatabase.Models;


namespace MovieDatabase.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            Movie m = new Movie();
            return View(m);
        }

        [HttpPost]
        public IActionResult Registration(Movie m)
        {
            if (ModelState.IsValid)
            {
                using (var connect = new MySqlConnection(Secret.Connection))
                {
                    string sql = $"insert into movies values(@id,@title,@genre,@year,@runtime)";
                    connect.Open(); connect.Execute(sql, new
                    {
                        id = m.Id,
                        title=m.Title,
                        genre=m.Genre.ToString(),
                        year=m.Year,
                        runtime=m.Runtime
                    });
                    connect.Close();
                }
                return RedirectToAction("List", m);
            }
            else
            {
                return View();
            }
        }        
        public IActionResult List()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();
                return View(movies);
            }

        }
    }
}
