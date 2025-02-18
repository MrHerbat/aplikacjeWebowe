using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw11_layout.Models;

public class MyGame
{
    public int Id { get; set; }
    
    [DisplayName("Podaj Tytuł")]
    [Required(ErrorMessage = "Tytuł jest wymagany")]
    public string Title { get; set; }
    
    [DisplayName("Podaj gatunek")]
    [Required(ErrorMessage = "Gatunek jest wymagany")]
    public string Genre { get; set; }
    
    [DisplayName("Podaj nazwę studia")]
    [Required(ErrorMessage = "Studio jest wymagane")]
    public string Studio { get; set; }
    
    [DisplayName("Podaj cene")]
    [Required(ErrorMessage = "Cena jest wymagana")]
    [Range(0, 400, ErrorMessage = "Cena musi być z przedziału 0-400")]
    public decimal? Price { get; set; }
}