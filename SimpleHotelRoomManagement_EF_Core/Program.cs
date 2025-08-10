using SimpleHotelRoomManagement_EF_Core.Repositries;
using SimpleHotelRoomManagement_EF_Core.Services;
using SimpleHotelRoomManagement_EF_Core.Helper;
using SimpleHotelRoomManagement_EF_Core.Models;

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

            //to create new object of BookingRepositry ...
            IBookingRepositry BookingObject = new BookingRepositry(context);
            //to create new object of BookingServices ...
            IBookingServices BookingService = new BookingServices(BookingObject);

            //to create new object of PatingRepositry ...
            IRatingRepositry ratingRepositry = new RatingRepositry(context);
            //to create new object of RatingServices ...
            IRatingServices ratingServices = new RatingServices(ratingRepositry);

            //to create the program menu ...
            bool exit = true;
            Additional.WelcomeMessage("CodeLine Hotel");
            do
            {
                char choice;
                Console.Clear();
                Console.WriteLine("1. Add room");
                Console.WriteLine("2. Add guest");
                Console.WriteLine("3. Add booking");
                Console.WriteLine("4. Add rating");
                Console.WriteLine("5. Show all rooms");
                Console.WriteLine("6. Show all guests");
                Console.WriteLine("7. Show all bookings");
                Console.WriteLine("8. Show all ratings");
                Console.WriteLine("0. Exit");
                choice = Validation.CharValidation("your choice");
                switch (choice) 
                {
                    case '1':
                        //to get the room details from the user ...
                        double price = Validation.DoubleValidation("room daily price");
                        //to create new room object ...
                        Room room = new Room();
                        room.RoomDailyPrice = price;
                        //to add the room to the database ...
                        RoomService.AddRoom(room);
                        Console.WriteLine("Room added successfully.");
                        Additional.HoldScreen();
                        break;
                    case '2':
                        
                        break;
                    case '3':
                        
                        break;
                    case '4':
                        
                        break;
                    case '5':
                        
                        break;
                    case '6':
                        
                        break;
                    case '7':
                        
                        break;
                    case '8':
                        
                        break;
                    case '0':
                        exit = false;
                        Console.WriteLine("Thank you for using our system. Goodbye!");
                        Additional.HoldScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        Additional.HoldScreen();
                        break;
                }


            } while (exit);
        }
    }
}
