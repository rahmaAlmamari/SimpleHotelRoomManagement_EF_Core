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
                        //to get the guest details from the user ...
                        string name = Validation.StringValidation("guest name");
                        string email = Validation.EmailValidation("guest email");
                        int phoneNumber = Validation.UserPhoneNumberValidation();
                        //to create new guest object ...
                        Guest guest = new Guest();
                        guest.GuestName = name;
                        guest.GuestEmail = email;
                        guest.GuestPhoneNumber = phoneNumber.ToString();
                        //to add the guest to the database ...
                        GuestService.AddGuest(guest);
                        Console.WriteLine("Guest added successfully.");
                        Additional.HoldScreen();
                        break;
                    case '3':
                        //to list all available rooms ...
                        RoomService.GetAllRooms().ForEach(r =>
                        {
                            if (r.IsAvailable)
                            {
                                Console.WriteLine($"Room Number: {r.RoomNumber}, Daily Price: {r.RoomDailyPrice}");
                            }
                        });
                        //to list all guests ...
                        GuestService.GetAllGuests().ForEach(g =>
                        {
                            Console.WriteLine($"Guest ID: {g.GuestId}, Name: {g.GuestName}");
                        });
                        //to get the booking details from the user ...
                        int roomNumber = Validation.IntValidation("room number");
                        int guestId = Validation.IntValidation("guest ID");
                        DateTime checkInDate = Validation.DateTimeValidation("check-in date");
                        DateTime checkOutDate = Validation.DateTimeValidation("check-out date");
                        //to get the room object by room number ...
                        Room selectedRoom = RoomService.GetRoomByNumber(roomNumber);
                        //to get the guest object by guest ID ...
                        Guest selectedGuest = GuestService.GetGuestById(guestId);
                        //to add the booking to the database ...
                        if (selectedRoom != null && selectedGuest != null)
                        {
                            BookingService.AddBooking(selectedGuest, selectedRoom, checkInDate, checkOutDate, selectedRoom.RoomDailyPrice);
                            Console.WriteLine("Booking added successfully.");
                            Additional.HoldScreen();
                        }
                        else
                        {
                            Console.WriteLine("Invalid room number or guest ID.");
                            Additional.HoldScreen();
                        }
                        break;
                    case '4':
                        //to list all guests ...
                        GuestService.GetAllGuests().ForEach(g =>
                        {
                            Console.WriteLine($"Guest ID: {g.GuestId}, Name: {g.GuestName}");
                        });
                        //to get the guest ID for rating ...
                        int guestIdForRating = Validation.IntValidation("guest ID for rating");
                        //to list all guest room bookings ...
                        BookingService.GetBookingsByGuestId(guestIdForRating).ForEach(b =>
                        {
                            Console.WriteLine($"Booking ID: {b.BookingId}, Room Number: {b.RoomNumber}");
                        });
                        //to get the room ID for rating ...
                        int roomIdForRating = Validation.IntValidation("room ID for rating");
                        //to get the rating value from the user ...
                        int ratingScore = Validation.IntValidation("rating score (1-5)");
                        //to get the rating comment from the user ...
                        string ratingComment = Validation.StringValidation("rating comment");
                        //to create new rating object ...
                        Rating rating = new Rating();
                        rating.GuestId = guestIdForRating;
                        rating.RoomNumber = roomIdForRating;
                        rating.Score = ratingScore;
                        rating.Comment = ratingComment;
                        rating.RatingDate = DateTime.Now;
                        //to get the room object by room number ...
                        Room roomForRating = RoomService.GetRoomByNumber(roomIdForRating);
                        //to get the guest object by guest ID ...
                        Guest guestForRating = GuestService.GetGuestById(guestIdForRating);
                        rating.room = roomForRating; // Set the room navigation property
                        rating.guest = guestForRating; // Set the guest navigation property
                        //to add the rating to the database ...
                        ratingServices.AddRating(rating);
                        break;
                    case '5':
                        //to show all rooms ...
                        RoomService.GetAllRooms().ForEach(r =>
                        {
                            Console.WriteLine($"Room Number: {r.RoomNumber}, Daily Price: {r.RoomDailyPrice}, Available: {r.IsAvailable}");
                        });
                        break;
                    case '6':
                        //to show all guests ...
                        GuestService.GetAllGuests().ForEach(g =>
                        {
                            Console.WriteLine($"Guest ID: {g.GuestId}, Name: {g.GuestName}, Email: {g.GuestEmail}, Phone: {g.GuestPhoneNumber}");
                        });
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
