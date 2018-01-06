using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AlunoDAL
    {
        public List<Aluno> ListarTodos()
        {
            ModelContainer con = new ModelContainer();
            try
            {
                return con.Aluno.OrderBy(a => a.Matricula).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Salvar(Aluno a)
        {
            ModelContainer con = new ModelContainer();
            try
            {                
                con.Aluno.Add(a);

                con.SaveChanges();
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
