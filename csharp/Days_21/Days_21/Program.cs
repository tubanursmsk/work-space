﻿using System;
using Days_21.utils;

namespace Days_21
{
    class Program
    {
        static void Main(string[] args)
        {
            FileControl fileControl = new FileControl();
            fileControl.WriteToFile("Yeni satır");
        }
    }
}