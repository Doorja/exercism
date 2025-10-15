static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
        throw new NotImplementedException("Please implement the (static) Appointment.Schedule() method");
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if(DateTime.Now > appointmentDate){
            return true;
        }
        return false;
        throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if(appointmentDate.Hour>=12 && appointmentDate.Hour<18){
            return true;
        }
        return false;
        
        throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
        
        throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
