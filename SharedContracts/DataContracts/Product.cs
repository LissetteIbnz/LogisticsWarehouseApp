using System.ComponentModel.DataAnnotations;

namespace SharedContracts.DataContracts
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // Nombre
        public string NOC { get; set; }
        public string Part_Number { get; set; }
        public string Authorization_Method { get; set; } // Via_Autorizacion
        public bool Is_External { get; set; } // Es_SIGLE
        public string Image_Path { get; set; } // Figura
        public bool Published { get; set; } // Publicado
        public int Id_Authorization_Method { get; set; } // Id_Via_Autorizacion
    }
}
