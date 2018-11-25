namespace SpbDotNet_SC_Errors
{
    public class Worker
    {
        public static int GetCountsSum(TrackedEntity a, UnTrackedEntity b)
        {
            return a.Count + b.Count;
        }
    }
}