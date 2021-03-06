﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace CoffeApp.Data
{
    public class User
    {
        public User()
        {

        }
        /// <summary>
        /// The user's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The user's email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's name.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// URL to the user's IDP photo.
        /// </summary>
        public BitmapImage PhotoUrl { get; set; }
    }
}
