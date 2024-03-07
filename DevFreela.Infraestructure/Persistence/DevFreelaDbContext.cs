using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Infraestructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu primeiro projeto", "Minha descrição", 1, 1, 100000),
                new Project("Meu primeiro projeto", "Minha descrição", 1, 1, 200000)

            };

            Users = new List<User>
            {
                new User("Lidson", "liedson@hotmail.com", new DateTime(2003, 9, 5))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
            };
        }
        public List<Project> Projects { get;  set; }
        public List<User> Users { get;  set; }
        public List<Skill> Skills { get;  set; }
    }
}
