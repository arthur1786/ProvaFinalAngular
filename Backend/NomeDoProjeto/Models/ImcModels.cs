using System.ComponentModel.DataAnnotations;

namespace Backend.Models{

    public class ImcModels{
        [Key]

        public int Id {get;set;}
        public double altura {get;set;}
        public double peso {get;set;}
        public double imc {get;set;}
        public string classificacao{get;set;}
        public int UsuarioId{get;set;}
        public Usuario usuario{get;set;}

    }
}