﻿using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BIGBACK.Configurations.Entities
{
    public class ComplaintSeed : IEntityTypeConfiguration<Complaint>
    {
        public void Configure(EntityTypeBuilder<Complaint> builder)
        {
            builder.HasData(
                new Complaint
                {
                    Id = 1,
                    OrderId = 1,
                    StaffId = 1,
                    RiderId = 1,
                    ComplaintDesc = "Late delivery",
                    ComplaintStatus = "Open",
                    ComplaintDateTime = DateTime.Now,
                    
                   
                },
                new Complaint
                {
                   Id = 2,
                   OrderId = 2,
                   StaffId = 2,
                   RiderId = 2,
                   ComplaintDesc = "Damaged item",
                   ComplaintStatus = "Resolved",
                   ComplaintDateTime = DateTime.Now,
                   
                }
              );
           

        }
    }
}
