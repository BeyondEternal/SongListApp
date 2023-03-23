using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongListApp.Shared.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Artista { get; set; }
    }
}
