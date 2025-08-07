﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Helper
{
    public static class Additional
    {
        //1. To hoad the screen ...
        public static void HoldScreen()
        {
            Console.WriteLine("Press (Enter Kay) to continue");
            Console.ReadLine();
        }
        //2. To check of the string contains something other than letters like number and empty space(this methos return true or false)....
        public static bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }
        //3. WelcomeMessage method ...
        public static void WelcomeMessage(string message)
        {
            Console.WriteLine($"Welcome to Codeline {message} System\nWe hope you have a pleasant time using our services " +
                              "(^0^)");
            HoldScreen();//to hold the screen ...
        }

    }
}
