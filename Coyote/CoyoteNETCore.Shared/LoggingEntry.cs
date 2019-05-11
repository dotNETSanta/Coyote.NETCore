﻿using System;

namespace CoyoteNETCore.Shared
{
    public class LoggingEntry
    {
        private LoggingEntry()
        {

        }

        public LoggingEntry(LoggingType type, DateTime occuredAt, User user, bool succeeded, string IPv4, string platformInfo)
        {
            Type = type;
            OccuredAt = occuredAt;
            User = user;
            Succeeded = succeeded;
            IPv4 = IPv4;
            PlatformInfo = platformInfo;
        }

        public int Id { get; }

        public LoggingType Type { get; }

        public DateTime OccuredAt { get; } = DateTime.Now;

        public User User { get;  }

        public bool Succeeded { get; }

        public string IPv4 { get;}

        public string PlatformInfo { get; }
    }
}