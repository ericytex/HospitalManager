using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlfaWebApplication1.Models
{
    public class PatientRegisterModel
    {

        [System.ComponentModel.DataAnnotations.Display(Name = "Id")]
        public int id { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Middle name is required.")]
        public string MiddleName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patient File Number is required.")]
        public string PatientFileNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enrolled Date is required.")]
        public string EnrolledDate { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Marital Status is required.")]
        public string MaritalStatus { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Date of Birth is required.")]
        public string DateOfBirth { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Age is required.")]
        public string Age { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "National ID Number is required.")]
        public string NationalIDNo { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cell Phone Number is required.")]
        public string CellPhoneNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Home Phone Number is required.")]
        public string HomePhoneNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Occupation is required.")]
        public string Occupation { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Employer is required.")]
        public string Employer { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Employer Phone Number is required.")]
        public string EmployerPhoneNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason for visit is required.")]
        public string ReasonForVisit { get; set; }
    }
}