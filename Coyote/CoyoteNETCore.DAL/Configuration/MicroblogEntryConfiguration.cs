﻿using CoyoteNETCore.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoyoteNETCore.DAL.Configuration
{
    public class MicroblogEntryConfiguration : IEntityTypeConfiguration<MicroblogEntry>
    {
        public void Configure(EntityTypeBuilder<MicroblogEntry> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Author);
            builder.HasMany(x => x.Editions);
        }
    }
}