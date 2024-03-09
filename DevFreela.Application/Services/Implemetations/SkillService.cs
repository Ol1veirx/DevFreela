using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DevFreela.Application.Services.Implemetations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;
        public SkillService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaConnection");
        }

        public List<SkillViewModel> GetAll()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                var skiilsViewModel = connection.Query<SkillViewModel>
                    ("SELECT Id, Description FROM Skills")
                    .ToList();

                return skiilsViewModel;
            }
        }
    }
}
