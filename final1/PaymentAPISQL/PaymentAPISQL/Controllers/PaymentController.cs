using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentAPISQL.Models.Dtos;
using PaymentAPISQL.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace PaymentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PaymentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public PaymentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                select paymentId,cardOwnerName, cardNumber,
                DATE_FORMAT(expirationDate, '%Y-%m-%d') as expirationDate,
                securityCode
                from payments.payments
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("MySQLConnection");
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
                select paymentId,cardOwnerName,cardNumber,
                DATE_FORMAT(expirationDate, '%Y-%m-%d') as expirationDate,
                securityCode
                from payments.payments
                where paymentId = @Id
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("MySQLConnection");
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
        public JsonResult Post(Payment item)
        {
            string query = @"
                insert into payments.payments (cardOwnerName, cardNumber, expirationDate, securityCode)
                values
                (@cardOwnerName, @cardNumber, @expirationDate, @securityCode);
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("MySQLConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@cardOwnerName", item.cardOwnerName);
                    myCommand.Parameters.AddWithValue("@cardNumber", item.cardNumber);
                    myCommand.Parameters.AddWithValue("@expirationDate", item.expirationDate);
                    myCommand.Parameters.AddWithValue("@securityCode", item.securityCode);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Payment added Successfully!");
        }

        [HttpPut("{id}")]
        public JsonResult Put(Payment item, int id)
        {
            string query = @"
                update payments.payments set 
                cardOwnerName = @cardOwnerName,
                cardNumber = @cardNumber,
                expirationDate = @expirationDate,
                securityCode = @securityCode
                where paymentId = @Id;
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("MySQLConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);
                    myCommand.Parameters.AddWithValue("@cardOwnerName", item.cardOwnerName);
                    myCommand.Parameters.AddWithValue("@cardNumber", item.cardNumber);
                    myCommand.Parameters.AddWithValue("@expirationDate", item.expirationDate);
                    myCommand.Parameters.AddWithValue("@securityCode", item.securityCode);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Payment Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                delete from payments.payments
                where paymentId = @Id;
            ";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("MySQLConnection");
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
            return new JsonResult("Payment Deleted Successfully");
        }

    }
}
