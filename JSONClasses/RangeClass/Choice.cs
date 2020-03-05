﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Choice : IPattern
    {
        private readonly IPattern[] patterns;
        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new Match(text, false);
            }

            IMatch match = new Match(text, true);
            foreach (IPattern pattern in patterns)
            {
                match = pattern.Match(text);
                if (match.Success())
                {
                    return match;
                }
            }

            return match;
        }
    }
}
