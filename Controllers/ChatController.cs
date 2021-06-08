﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>
        {
            {1, "Cervezas" },
            {2, "Programación" },
            {3, "Moda" }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
