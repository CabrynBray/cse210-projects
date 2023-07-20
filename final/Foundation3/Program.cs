using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("30 struben ave", "JHB", "Gauteng", "SA");
        Lectures lecturesEvent = new Lectures("Programming with Classes", "Into to C#", "18/07/2023", "6pm", address1, "Cabryn Bray", 50);
        lecturesEvent.DisplayStanderdDetails();
        lecturesEvent.GetFullDetails();
        lecturesEvent.GetShortDescription();

        Address address2 = new Address("27 lys ave", "Durban", "KZN", "SA");
        Receptions receptionEvent = new Receptions("Jarom's Wedding", "Jarom is geting married", "24/03/2027", "3pm", address2, "Ethan Coming Ethanbray@gamil.com");
        receptionEvent.DisplayStanderdDetails();
        receptionEvent.GetFullDetails();
        receptionEvent.GetShortDescription();

        Address address3 = new Address("987 main", "NY", "NY", "USA");
        OutDoorGaterings OutDoorEvent = new OutDoorGaterings("Nadia's Home coming", "Nadia is come home for christmas", "2024/12/24", "2pm", address3, "sunny");
        OutDoorEvent.DisplayStanderdDetails();
        OutDoorEvent.GetFullDetails();
        OutDoorEvent.GetShortDescription();

    }
}