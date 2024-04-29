using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace EFCode.Models
{
    public class Homepagemodel
    {
        public List<string> RequestId { get; set; }
        
        public string Username { get; set; }

        //[DataType(DataType.Password)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string Password { get; set; }
        public string message { get; set; }
        public List<string> Requestmessage { get; set; }
        public List<string> StudentId { get; set; }
        
        public List<string> RequestedSlot { get; set; }
        public List<string> RequestStatus { get; set; }
        //public List<string> TimeSlots { get; set; }
        public DateTime SelectedDate { get; set; }
        public string SelectedTime { get; set; }
        public IEnumerable<SelectListItem> TimeSlots { get; set; }
        public Homepagemodel()
        {
            RequestId = new List<string>();
            StudentId = new List<string>();
            RequestedSlot = new List<string>();
            RequestStatus = new List<string>();
            Requestmessage = new List<string>();
            //TimeSlots = new List<string>();

        }
        [BindProperty]
        public DateTime? SelectedDate1 { get; set; }

        /*public Homepagemodel()
        {
        }*/
        //public LoginModel Model1 { get; set; }
        //ublic FooterModel Model2 { get; set; }
        //public IndexModel Model3 { get; set; }
    }
}

    /*public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class FooterModel
    {
        public string Copyright { get; set; }
    }

    public class IndexModel
    {
        public string TabActive { get; set; }
        public string WelcomeText { get; set; }
        public LoginModel Login { get; set; }
        public FooterModel Footer { get; set; }
    }*/

