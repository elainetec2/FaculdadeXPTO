//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aluno
    {
        public int IdAluno { get; set; }
        public Nullable<int> IdTurma { get; set; }
        public string NomeAluno { get; set; }
        public Nullable<int> Matricula { get; set; }
        public string Cpf { get; set; }
    
        public virtual Turma Turma { get; set; }
    }
}