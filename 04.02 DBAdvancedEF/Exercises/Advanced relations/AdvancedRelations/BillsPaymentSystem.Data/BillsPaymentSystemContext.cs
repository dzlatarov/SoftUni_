﻿using System;
using BillsPaymentSystem.Data.EntityConfiguration;
using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BillsPaymentSystem.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public BillsPaymentSystemContext()
        {

        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(Config.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new BankAccountConfig());
        }
    }
}
