namespace SharedContracts.DataContracts
{
    public class User
    {
        public int Id { get; set; }
        public bool Is_Delete { get; set; } // Baja
        public byte Id_Employment { get; set; } // Id_Empleo        
        public int Id_UCO { get; set; }
        public string User_Domain { get; set; } // Usuario_AD
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Employment Employment { get; set; }
        //public virtual abEmpleos abEmpleos { get; set; }
        //public virtual ICollection<abPeticiones_Abastecimiento> abPeticiones_Abastecimiento { get; set; }
        //public virtual ICollection<abRoles> abRoles { get; set; }
        //public virtual abUCOS abUCOS { get; set; }
        //public virtual ICollection<abTransacciones> abTransacciones { get; set; }
        //public virtual ICollection<abAdquisiciones> abAdquisiciones { get; set; }
        //public virtual ICollection<abAcciones> abAcciones { get; set; }
    }
}
