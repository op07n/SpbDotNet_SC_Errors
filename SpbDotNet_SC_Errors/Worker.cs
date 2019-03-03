namespace SpbDotNet_SC_Errors
{
    public static class Worker
    {
        public static string GetPersonProfession(
            Person ps, 
            Profession pf)
        {
            return $"{ps.FirstName} {ps.LastName} ({ps.BirthDate}) is a {pf.Name}";
        }
    }
}