/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: Alexander Hoang
* Assignment: Profile Card
*
* Description:
* Collect personal, academic and additional information from user
* while calculating derived data and displaying them through a profile card.
*
**************************************************************/

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        Console.WriteLine("Welcome! Thank you for using the Student Profile Card generator today.");
        Console.WriteLine("To generate your profile card, we will need to collect some information from you pertaining from Personal Information, Academic Information, and Additional Details.\n");

        Console.WriteLine("Let's start by gathering some personal information.\n");
        Console.Write("Full Name: ");
        string fullName = Console.ReadLine();
        Console.Write("Hometown (City, State): ");
        string hometown = Console.ReadLine();
        Console.Write("Favorite Color: ");
        string favoriteColor = Console.ReadLine();
        Console.Write("Dream Job: ");
        string dreamJob = Console.ReadLine();
        Console.WriteLine("Personal information completed!\n");

        Console.WriteLine("Now, let's move on to your academic information.\n");
        Console.WriteLine("\nPlease enter the following academic information:");
        Console.WriteLine("Major: ");
        string major = Console.ReadLine();
        Console.WriteLine("GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());
        Console.WriteLine("Graduation Year: ");
        int graduationYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Are you a full-time student? (yes/no): ");
        string fullTime = Console.ReadLine();
        bool isFullTime = fullTime.ToLower() == "yes";
        Console.WriteLine("Academic information completed!\n");

        Console.WriteLine("2/3s of the way there, let's gather some additional details.\n");
        Console.WriteLine("Please enter the following additional details:");
        Console.WriteLine("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());
        Console.WriteLine("Favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Additional details completed!\n");

        Console.WriteLine("Processing your profile card...\n");
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine($"- Full Name: {fullName}");
        Console.WriteLine($"- Hometown: {hometown}");
        Console.WriteLine($"- Favorite Color: {favoriteColor}");
        Console.WriteLine($"- Dream Job: {dreamJob}\n");
        Console.WriteLine("ACADEMIC DETAILS");
        Console.WriteLine($"- Major: {major}");
        Console.WriteLine($"- GPA: {gpa:F2}");
        Console.WriteLine($"- Graduation Year: {graduationYear}");
        Console.WriteLine($"- Full-Time Student: {(isFullTime ? "Yes" : "No")}\n");
        Console.WriteLine("CALCULATED STATISTICS");
        int birthYear = 2026 - age;
        int yearsToGraduation = graduationYear - 2026;
        int heightFeet = (int)(heightInches / 12);
        int heightRemainingInches = (int)(heightInches % 12);
        bool isHonorStudent = gpa >= 3.5;
        int ageInMonths = age * 12;
        Console.WriteLine($"- Birth Year: {birthYear}");
        Console.WriteLine($"- Years to Graduation: {yearsToGraduation}");
        Console.WriteLine($"- Height: {heightFeet} feet, {heightRemainingInches} inches");
        Console.WriteLine($"- Honor Student: {(isHonorStudent ? "Yes" : "No")}");
        Console.WriteLine($"- Age: {age} years");
        Console.WriteLine($"- Age in Months: {ageInMonths}\n");
        Console.WriteLine($"- Favorite Number: {favoriteNumber}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
