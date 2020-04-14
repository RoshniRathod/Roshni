namespace DAL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MediStockContext context)
        {
            context.Database.EnsureCreated();

            // Seed any required data here
            // TODO: Find that which data can be inserted when database is created and seed that data here
        }
    }
}
