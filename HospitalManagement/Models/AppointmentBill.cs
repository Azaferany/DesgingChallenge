namespace HospitalManagement.Models;

public class Appointment
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
    
    public double TotalAmount { get; set; }
    public List<Payment> Payments { get; set; }

}