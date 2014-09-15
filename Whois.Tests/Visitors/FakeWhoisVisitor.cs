﻿using System.Collections;
using System.Text;
using Whois.Domain;
using Whois.Interfaces;

namespace Whois.Visitors
{
    /// <summary>
    /// Fake class used for testing.
    /// </summary>
    internal class FakeWhoisVisitor : IWhoisVisitor
    {
        private readonly string fakeContent;

        public Encoding CurrentEncoding { get; private set; }

        public FakeWhoisVisitor(string content)
        {
            fakeContent = content;
        }

        public WhoisRecord Visit(WhoisRecord record)
        {
            record.Text = new ArrayList { fakeContent };

            return record;
        }
    }
}