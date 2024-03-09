using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Core.Entities;
using DevFreela.Core.Enums;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTest
    {
        [Fact]
        public void TestIfProjectStartWorks()
        {
            var project = new Project("Nome de Teste", "Descrição de teste",1,2,10000);
            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            

            project.Start();

            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            
        }
    }
}
