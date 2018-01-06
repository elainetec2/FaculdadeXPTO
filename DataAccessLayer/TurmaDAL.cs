using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TurmaDAL
    {
        public List<Turma> ListarTodas()
        {
            ModelContainer con = new ModelContainer();
            try
            {
                return con.Turma.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
