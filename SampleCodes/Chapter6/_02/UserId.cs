﻿using System;

namespace _02
{
    public class UserId
    {
        public UserId(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("valueがnullまたは空文字です");

            Value = value;
        }

        public string Value { get; }
    }
}
