using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongListApp.Shared.Model
{
    public class Song
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must to add a title")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "You must to add an artist")]
        public string? Artist { get; set; }
    }
}
