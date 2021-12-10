// <copyright file="User.cs" company="Alyona">
// Copyright (c) 2021 All Rights Reserved
// </copyright>

namespace Algorithm
{
   using System;
   using System.Threading;

   public class User
   {
      public string Login { get; set; }

      public string Name { get; set; }

      public bool IsPremium { get; set; }

      public static void ShowAds()
      {
         Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
         Thread.Sleep(1000);

         Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
         Thread.Sleep(2000);

         Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
         Thread.Sleep(3000);
      }

      /// <summary>
      /// Set user data from the Console.
      /// </summary>
      public void SetUserData()
      {
         try
         {
            Console.Write("Введите ваш логин: ");
            this.Login = Console.ReadLine();
            Console.Write("Введите ваше имя: ");
            this.Name = Console.ReadLine();
            Console.Write("Есть ли у вас подписка?(да/нет): ");
            var answer = Console.ReadLine();
            if (answer == "да")
            {
               this.IsPremium = true;
            }
            else if (answer == "нет")
            {
               this.IsPremium = false;
            }
            else
            {
               throw new Exception("Введёное выражение не соответствует формату ввода");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
            System.Environment.Exit(1);
         }
      }

      public void Authorization()
      {
         this.SetUserData();
         Console.WriteLine($"Добро пожаловать, {this.Name}");
         if (!this.IsPremium)
         {
            ShowAds();
         }
      }
   }
}
