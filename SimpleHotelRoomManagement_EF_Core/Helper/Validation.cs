﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core.Helper
{
    public static class Validation
    {
        //1. CharValidation method ...
        public static char CharValidation(string message)
        {
            bool CharFlag;//to handle user char error input ...
            char CharInput = '0';
            do
            {
                try
                {
                    CharFlag = false;
                    Console.WriteLine($"Enter your {message}:");
                    CharInput = char.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Your {message} not accepted due to: " + e.Message);
                    CharFlag = true;
                }

            } while (CharFlag);

            //to return tne char input ...
            return CharInput;
        }

        //2. StringNamingValidation method ...
        public static string StringNamingValidation(string message)
        {
            bool StringNamingFlag;//to handle user StringNaming error input ...
            string StringNamingInput = "null";
            do
            {
                StringNamingFlag = false;
                Console.WriteLine($"Enter your {message}:");
                StringNamingInput = Console.ReadLine();
                //to check if StringNamingInput has number or not ...
                bool check_StringNaming = Additional.IsAlpha(StringNamingInput);
                if (check_StringNaming == false)
                {
                    Console.WriteLine($"{message} can not contains number and con not be null ..." +
                                      "please prass enter key to try again");
                    Additional.HoldScreen();//just to hold a second ...
                    StringNamingFlag = true;
                }

            } while (StringNamingFlag);

            //to return tne char input ...
            return StringNamingInput;
        }
        //3. StringValidation method ...
        public static string StringValidation(string message)
        {
            bool StringFlag;//to handle user StringNaming error input ...
            string StringInput = "null";
            do
            {
                StringFlag = false;
                Console.WriteLine($"Enter your {message}:");
                StringInput = Console.ReadLine();
                // Check if StringInput null or empty
                if (string.IsNullOrWhiteSpace(StringInput))
                {
                    Console.WriteLine($"{message} cannot be empty.");
                    Additional.HoldScreen();//just to hoad second ...
                    StringFlag = true;
                }

            } while (StringFlag);

            //to return tne char input ...
            return StringInput;
        }
        //4. DoubleValidation method ...
        public static double DoubleValidation(string message)
        {
            bool DoubleFlag;//to handle user StringNaming error input ...
            double DoubleInput = 0;
            do
            {
                DoubleFlag = false;
                try
                {
                    Console.WriteLine($"Enter your {message}:");
                    DoubleInput = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{message} not accepted due to " + e.Message);
                    Console.WriteLine("please prass enter key to try again");
                    Additional.HoldScreen();//just to hold a second ...
                    DoubleFlag = true;
                }

            } while (DoubleFlag);
            //to return tne char input ...
            return DoubleInput;
        }
        //5. IntValidation method ...
        public static int IntValidation(string message)
        {
            bool IntFlag;//to handle user StringNaming error input ...
            int IntInput = 0;
            do
            {
                IntFlag = false;
                try
                {
                    Console.WriteLine($"Enter {message}:");
                    IntInput = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{message} not accepted due to " + e.Message);
                    Additional.HoldScreen();//just to hold a second ...
                    IntFlag = true;
                }

            } while (IntFlag);
            //to return tne char input ...
            return IntInput;
        }
        //6. DateTimeValidation method ...
        public static DateTime DateTimeValidation(string message)
        {
            bool DateTimeFlag; // to handle user DateTime error input
            DateTime DateTimeInput = DateTime.Now;

            do
            {
                DateTimeFlag = false;
                try
                {
                    Console.WriteLine($"Enter your {message} (format: MM/dd/yyyy):");
                    DateTimeInput = DateTime.Parse(Console.ReadLine());

                    //// Check if the date is in the future or today
                    //if (DateTimeInput.Date > DateTime.Now.Date)
                    //{
                    //    Console.WriteLine($"{message} should be a date valid.");
                    //    HoldScreen(); // just to hold a second
                    //    DateTimeFlag = true; // ask user again
                    //}
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{message} not accepted due to: " + e.Message);
                    Additional.HoldScreen(); // just to hold a second
                    DateTimeFlag = true; // ask user again
                }
            } while (DateTimeFlag);

            return DateTimeInput; // Return the validated input
        }
        //7. DateOnlyValidation method ...
        public static DateOnly DateOnlyValidation(string message)
        {
            bool DateTimeFlag; // to handle user DateTime error input
            DateOnly DateTimeInput = DateOnly.FromDateTime(DateTime.Now);

            do
            {
                DateTimeFlag = false;
                try
                {
                    Console.WriteLine($"Enter your {message} (format: MM/dd/yyyy):");
                    DateTimeInput = DateOnly.Parse(Console.ReadLine());

                    //// Check if the date is in the future or today
                    //if (DateTimeInput.Date > DateTime.Now.Date)
                    //{
                    //    Console.WriteLine($"{message} should be a date valid.");
                    //    HoldScreen(); // just to hold a second
                    //    DateTimeFlag = true; // ask user again
                    //}
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{message} not accepted due to: " + e.Message);
                    Additional.HoldScreen(); // just to hold a second
                    DateTimeFlag = true; // ask user again
                }
            } while (DateTimeFlag);

            return DateTimeInput; // Return the validated input
        }
        //8. To read password from the user and validate it ...
        public static string ReadPassword(string message)
        {
            //StringBuilder -> to improve performance when building strings character by character.
            //password -> to store the password input from the user ...
            StringBuilder password = new StringBuilder();
            //ConsoleKeyInfo -> is a structure that stores information
            //about a key press: the key, character, and modifiers (like Shift or Ctrl).
            ConsoleKeyInfo key;

            //To show message to the user to enter password ...
            Console.WriteLine($"Enter your {message} (press Enter when done):");
            do
            {
                //(intercept: true) -> reads a key press without showing it on the screen.
                key = Console.ReadKey(intercept: true);
                //To checks if the user pressed the Backspace key and remove it if so 
                //from the password and delete * from the console.
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password.Remove(password.Length - 1, 1);
                    Console.Write("\b \b");
                }
                //This filters out non-printable characters, like Ctrl or Alt.
                //If the key is normal characters (letters, digits, etc.)
                //it will enter the (if) and add the key to the password
                else if (!char.IsControl(key.KeyChar))
                {
                    password.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            //The loop continues until the user presses Enter.
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password.ToString();
        }
        //9. To hashed Password ...
        public static string HashPasswordPBKDF2(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            // RNGCryptoServiceProvider -> is used to generate a cryptographically strong random number.
            {
                byte[] salt = new byte[16];//to get a random value that makes each hash unique.
                // GetBytes -> fills the specified array with a cryptographically strong random sequence of values.
                rng.GetBytes(salt);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);//to creates a secure hash using the PBKDF2 algorithm.
                byte[] hash = pbkdf2.GetBytes(20);//to gets the first 20 bytes (160 bits) of the hash.

                byte[] hashBytes = new byte[36];//to creates a final array to store salt + hash.
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                //to Copies salt (first 16 bytes) and hash (next 20 bytes) into one array.

                return Convert.ToBase64String(hashBytes);
                //to converts the whole 36-byte array to a Base64 string so
                //it can be stored in a database or file easily.
            }
        }
        //HashPasswordPBKDF2 -> this method hashes the user’s password securely using the
        //PBKDF2 algorithm with a random salt, and returns the result as a Base64 string.
        //what is salt -> a random value added to a password before hashing it.
        //It’s used to make each password hash unique, even if two users have the same password.

        //10. Verify password by comparing hashes
        public static bool VerifyPasswordPBKDF2(string password, string savedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(savedHash);
            //to converts the stored string back into the original 36-byte array
            //(16 bytes salt + 20 bytes hash).

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);//to extracts the first 16 bytes (the salt).

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            //to recreates the hash for the input password using the same salt and iteration count.
            byte[] hash = pbkdf2.GetBytes(20);//to gets the expected hash (20 bytes).

            for (int i = 0; i < 20; i++)//to compares each byte of the newly generated
                                        //hash with the one stored after the salt.
            {
                if (hashBytes[i + 16] != hash[i])//to check if any byte is different
                                                 //the password is incorrect.
                    return false;
            }
            return true;//If all bytes match, the password is correct.
        }
        //VerifyPasswordPBKDF2 -> this method verifies a user’s password by:
        // 1. Extracting the original salt from the stored hash
        // 2. Re-hashing the input password using the same salt
        // 3. Comparing both hashes

        //11. Check if the Password unique or not ...
        public static bool PasswordIsUnique(string password, List<string> list)
        {
            bool IsUnique = true;//it is unique (not exsit in the system) ...
            //to check if password is exist or not (password should be unique) ...
            foreach (var storedHashpassword in list)
            {
                //to call VerifyPasswordPBKDF2 which will hash the password and
                //compare it with the stored hash password ...
                if (VerifyPasswordPBKDF2(password, storedHashpassword))
                {
                    Console.WriteLine("Password is exist in the system.");
                    Additional.HoldScreen();//just to hoad second ...
                    IsUnique = false;
                    return false; // Match found
                }
            }
            return IsUnique; // No match
        }

        //12. IsValidEmail method to check if email in the right format or not ...
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Basic but solid regex for general email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        //13. EmailValidation method to validate user email input ...
        public static string EmailValidation(string message)
        {
            bool emailFlag;//to handle user email error input ...
            string emailInput = "null";
            do
            {
                emailFlag = false;
                Console.WriteLine($"Enter your {message}:");
                emailInput = Console.ReadLine();
                //to check if emailInput is valid or not ...
                if (!IsValidEmail(emailInput))
                {
                    Console.WriteLine($"{message} is not valid, please try again.");
                    //Additional.HoldScreen();//just to hold a second ...
                    emailFlag = true;
                }
            } while (emailFlag);
            //to return tne char input ...
            return emailInput;
        }
    }
}
