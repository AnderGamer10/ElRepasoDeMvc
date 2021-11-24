using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRepaso.Models
{
    public class Usuario
    {
        public int Id { get; set; } //PK
        public string Nombre { get; set; }
        public List<Mascota> Mascotas { get; } = new List<Mascota>(); //EF Atr. de navegación

        public override string ToString() => $"{Id}:{Nombre} ({Mascotas.Count} Mascotas)";
    }
}
