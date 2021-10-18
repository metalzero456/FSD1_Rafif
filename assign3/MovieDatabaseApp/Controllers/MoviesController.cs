using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieDatabaseApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MovieDatabaseApp.Data;

namespace MovieDatabaseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MoviesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MoviesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                select Id,Name,Genre,Duration,
                DATE_FORMAT(ReleaseDate, '%Y-%m-%d') as ReleaseDate
                from movie.movies
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpGet("{id}")]
        public JsonResult GetId(int id)
        {
            string query = @"
                select Id,Name,Genre,Duration,
                DATE_FORMAT(ReleaseDate, '%Y-%m-%d') as ReleaseDate
                from movie.movies
                where Id = @Id
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(ItemData item)
        {
            string query = @"
                insert into movie.movies (Name, Genre, Duration, ReleaseDate)
                values
                (@Name, @Genre, @Duration, @ReleaseDate);
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Name", item.Name);
                    myCommand.Parameters.AddWithValue("@Genre", item.Genre);
                    myCommand.Parameters.AddWithValue("@Duration", item.Duration);
                    myCommand.Parameters.AddWithValue("@ReleaseDate", item.ReleaseDate);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Movie Added Successfully");
        }

        [HttpPut("{id}")]
        public JsonResult Put(ItemData item, int id)
        {
            string query = @"
                update movie.movies set 
                Name = @Name,
                Genre = @Genre,
                Duration = @Duration,
                ReleaseDate = @ReleaseDate
                where Id = @Id;
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
                    myCommand.Parameters.AddWithValue("@Name", item.Name);
                    myCommand.Parameters.AddWithValue("@Genre", item.Genre);
                    myCommand.Parameters.AddWithValue("@Duration", item.Duration);
                    myCommand.Parameters.AddWithValue("@ReleaseDate", item.ReleaseDate);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Movie Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                delete from movie.movies
                where Id = @Id;
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
               
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Movie Deleted Successfully");
        }

    }
}
