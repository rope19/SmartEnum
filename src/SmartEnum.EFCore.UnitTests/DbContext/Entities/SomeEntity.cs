﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartEnum.EFCore.UnitTests.DbContext.Entities
{
    public class SomeEntity
    {
        public int Id { get; set; }

        public Weekday Weekday { get; set; }
    }
}