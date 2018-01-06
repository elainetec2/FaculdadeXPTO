using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace UIApplication
{
    public partial class ConsultaAlunos : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregarAlunos();
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public void CarregarAlunos()
        {
            AlunoDAL a = new AlunoDAL();
            dtgAlunos.DataSource = a.ListarTodos();
            dtgAlunos.DataBind();
        }
    }
}