﻿using iShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShop.Repo.EntityConfigurations
{
    public class ShippingConfigurations: IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            builder
                .Property(s => s.Charge)
                .IsRequired();

            builder
                .Property(s => s.City)
                .IsRequired();

            builder
                .Property(s => s.District)
                .IsRequired();
            builder
                .Property(s => s.Ward)
                .IsRequired();
            builder
                .Property(s => s.PhoneNumber)
                .IsRequired();

           

        }
    }
}
