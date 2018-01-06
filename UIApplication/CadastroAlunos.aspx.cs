using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using UIApplication.Servico;
using System.Web.UI.HtmlControls;


namespace UIApplication
{
    public partial class CadastroAlunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CarregarTurmas();
            }
        }

        public void CadastrarAluno(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();
                AlunoDAL aDal = new AlunoDAL();

               
                if(ValidarCPF(txtCpf.Text))
                {
                    a.NomeAluno = txtNome.Text;
                    a.Matricula = Convert.ToInt32(txtMatricula.Text);
                    a.IdTurma = Convert.ToInt32(ddlTurma.SelectedItem.Value);
                    a.Cpf = txtCpf.Text;

                    aDal.Salvar(a);

                    lblMensagem.Text = "Aluno cadastrado com sucesso!";
                }
                else
                {
                    lblMensagem.Text = "Favor, informe um cpf válido!";                   
                }  
              
            }
            catch (Exception)
            {
                lblMensagem.Text = "Ocorreu um erro no cadastro!";
            }
            
        }

        public static bool ValidarCPF(string cpf)
        {
            Validations ws = new Validations();
            bool validado;
            validado = ws.ValidaCpf(cpf);
            if(validado)
            {
               return true;
            }
            else
            {
                return false;
            }                       
        }

        public void CarregarTurmas()
        {
            TurmaDAL tDal = new TurmaDAL();
            ddlTurma.DataSource = tDal.ListarTodas();
            ddlTurma.DataTextField = "NumeroTurma";
            ddlTurma.DataValueField = "IdTurma";
            ddlTurma.DataBind();          
        }
    }
}