using System.Globalization;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription, CultureInfo.InvariantCulture);
        
        // string[] date = appointmentDateDescription.Split(' ')[0].Split('/');
        // string[] time = appointmentDateDescription.Split(' ')[1].Split(':');
        //
        // int[] DNT = new int[6];
        //
        // for (int i = 0; i <= 2; i++)
        // {
        //     DNT[i] = Int32.Parse(date[i]);
        //     DNT[i+3] = Int32.Parse(time[i]);
        // }
        //
        // return new DateTime(DNT[2], DNT[0], DNT[1], DNT[3], DNT[4], DNT[5]);

    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate.CompareTo(DateTime.Now) < 0;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int heure = appointmentDate.Hour;
        return heure >= 12 && heure < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Today.Year, 9, 15);
    }
}
