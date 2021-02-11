﻿using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight = null; //TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Day {Monday, Tuesday, Wednesday, Thursday, Friday/*Fill out the days of the week*/ };

    }
}
