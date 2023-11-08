using System.ComponentModel.DataAnnotations;

namespace user_service.Models
{

    public class Institution
    {
        public string? InstitutionName { get; set; }
        public string? Address { get; set; }
        public string? ZipCodes { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Contact { get; set; }

        public string? Url { get; set; }
        public List<string> AvailableExams { get; set; } = new List<string> { "Select", "ICSE", "CBSE CLASS X", "KARNATAKA SECONDARY X" };
        public string? SelectedExams { get; set; }
        public List<string?> AvailableFacility { get; set; } = new List<string?> { "Select", "DAY CUM RESIDENTIAL", "DAY SCHOOL", "RESIDENTIAL SCHOOL" };
        public string? SelectedFacility { get; set; }



        public string? SchoolCode { get; set; }

        public bool VerificationStatus { get; set; }

    }
    public class ZipCode
    {
        public string? ZipCodeValue { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public int CityId { get; set; }
    }
    public class Country
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
    }

    public class State
    {
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public int CountryId { get; set; }
    }

    public class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public int StateId { get; set; }
    }

    public class Module
    {
        public int ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public decimal ModuleAmount { get; set; }
        public bool IsSelected { get; set; }
    }

    public class SchoolRegistrationModule
    {
        public List<Module> AvailableModules { get; set; } = new List<Module>();
        public List<Module> SelectedModules { get; set; } = new List<Module>();
        public decimal TotalPrice { get; set; }
    }

    public class SchoolStatus
    {
        public bool Verification { get; set; }
        public bool Approval { get; set; }
        public bool Payment { get; set; }
    }
    public class InstitutionDto
    {
        public string SchoolCode { get; set; }
        public string InstitutionName { get; set; }
    }
}
