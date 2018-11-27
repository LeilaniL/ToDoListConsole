// using System;
// using System.Collections.Generic;
// using ToDoList.Models;

// namespace ToDoList 
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             Console.WriteLine("Welcome to the To Do List! Would you like to add an item to your list or view your list? (Add/View/End)");
//             string userResponse = Console.ReadLine();
//             if(userResponse == "Add") 
//                 {
//                     Console.WriteLine("Please enter the new item description to add to your list.");
//                     string userDescription = Console.ReadLine();
//                     Item newToDoListItem = new Item(userDescription);
//                     Main();
//                 } else if(userResponse == "View")
//                 {
//                     List<Item> showAll = Item.GetAll();
//                     for (int i=0;i<showAll.Count;i++)
//                     {
//                         Console.WriteLine(showAll[i].GetDescription());
//                     }
//                     Main();
//                 } else 
//                 {
//                     Console.WriteLine("Ok, have a nice day. Bye!");
//                 }
//         }
//     }
// }