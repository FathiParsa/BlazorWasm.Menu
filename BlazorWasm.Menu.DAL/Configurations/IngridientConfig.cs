using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorWasm.Menu.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorWasm.Menu.DAL.Configurations
{
    public class IngridientConfig : IEntityTypeConfiguration<Ingridient>
    {
        public void Configure(EntityTypeBuilder<Ingridient> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
        }
    }
}
