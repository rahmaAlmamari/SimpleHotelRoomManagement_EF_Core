namespace SimpleHotelRoomManagement_EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to create new object of HotelDbContext ...
            using HotelDbContext context = new HotelDbContext();
            //to make sure that DB created ...
            context.Database.EnsureCreated();
        }
    }
}
