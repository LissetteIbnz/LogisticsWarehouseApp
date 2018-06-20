using System.Collections.Generic;

namespace SharedContracts.DataContracts
{
    public class Employment
    {
        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
