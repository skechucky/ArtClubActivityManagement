﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace ArtClubActivityManagement
{
    public partial class Membriimetadata2
    {
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        // [System.Web.Mvc.Remote("isUsernameAvaliable", "Cont", ErrorMessage = "Username Folosit")] uncomment contController.cs => json isUsernameAvaliable
        public string Username { get; set; }
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola nu se potriveste!!!")]
        [Display(Name = "Repeta Parola")]
        public string RPassword { get; set; }
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        public string Nume { get; set; }
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        public string Prenume { get; set; }
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Adresa de mail invalida")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Completati campul", AllowEmptyStrings = false)]
        [Display(Name = "Functie")]
        public string ID_NumeFunctie { get; set; }

    }





}