﻿using System;
using TrackerEnabledDbContext.Common.Models;

namespace TrackerEnabledDbContext.Common.EventArgs
{
    public class AuditLogGeneratedEventArgs : System.EventArgs
    {
        public AuditLogGeneratedEventArgs(AuditLog log, object entity)
        {
            Log = log;
            Entity = entity;
        }

        public AuditLog Log { get; internal set; }

        public object Entity { get; internal set; }

        [Obsolete("Please use `SkipSavingLog` property instead.")]
        public bool SkipSaving
        {
            get { return SkipSavingLog; }
            set { SkipSavingLog = value; }
        }

        /// <summary>
        /// Skips saving of log to database.
        /// </summary>
        public bool SkipSavingLog { get; set; } = false;
    }
}
