using SimpleHotelRoomManagement_EF_Core.Repositries;
using SimpleHotelRoomManagement_EF_Core.Services;

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

            //to create new object of GuestRepositry ...
            IGuestRepositry GuestObject = new GuestRepositry(context);
            //to create new object of GestServices ...
            IGestServices GuestService = new GestServices(GuestObject);

            //to create new object of RoomRepositry ...
            IRoomRepositry RoomObject = new RoomRepositry(context);
            //to create new object of RoomServices ...
            IRoomServices RoomService = new RoomServices(RoomObject);
        }
    }
}
