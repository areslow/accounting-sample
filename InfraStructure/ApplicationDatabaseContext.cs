using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure
{
    public class ApplicationDatabaseContext: IdentityDbContext<ApplicationUser> 
    {
        public ApplicationDatabaseContext(DbContextOptions options):
            base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<Account> accounts { get; set; }
        public DbSet<AccountDetail> accountsDetails { get; set; }
        public DbSet<AccountingDocument> accountsDocuments { get; set; }
        public DbSet<AccountingDocumentDetail> accountingDocumentDetails { get; set; }
        public DbSet<InvoiceDetail> invoiceDetails { get; set; }
        public DbSet<InvoiceHeader> invoiceHeaders { get; set; }
        public DbSet<InvoicePayment> invoicePayments { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductGroup> productGroups { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Account>()
            //    .HasMany(a => a.Details)
            //    .WithOne(ad => ad.Account)
            //    .HasForeignKey(ad => ad.AccountId)
            //    .HasPrincipalKey(a => a.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            ////account and payment
            //builder.Entity<Account>()
            //    .HasMany(a => a.Credits) // credits is a list of payment object
            //    .WithOne(c => c.Creditor)
            //    .HasForeignKey(c => c.CreditorId)
            //    .HasPrincipalKey(a => a.Id)
            //    .OnDelete(DeleteBehavior.NoAction);
            //builder.Entity<Account>()
            //    .HasMany(a => a.Debts) // Debts is a list of payment object
            //    .WithOne(c => c.Debtor)
            //    .HasForeignKey(c => c.DebtorId)
            //    .HasPrincipalKey(a => a.Id)
            //    .OnDelete(DeleteBehavior.NoAction);


            //// relation between accounts table and invoices table
            //builder.Entity<Account>()
            //    .HasMany(a => a.CreditInvoices)
            //    .WithOne(c => c.Creditor)
            //    .HasForeignKey(c => c.CreditorId)
            //    .HasPrincipalKey(a => a.Id)
            //    .OnDelete(DeleteBehavior.NoAction);
            //builder.Entity<Account>()
            //    .HasMany(a => a.DebtInvoices)
            //    .WithOne(c => c.Debtor)
            //    .HasForeignKey(c => c.DebtorId)
            //    .HasPrincipalKey(a => a.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            //// invoice header and details
            //builder.Entity<InvoiceHeader>()
            //    .HasMany(ih => ih.Details)
            //    .WithOne(id => id.InvoiceHeader)
            //    .HasForeignKey(id => id.InvoiceHeaderId)
            //    .HasPrincipalKey(ih => ih.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            //// product group and product
            //builder.Entity<ProductGroup>()
            //    .HasMany(pg => pg.Products)
            //    .WithOne(p => p.Group)
            //    .HasForeignKey(p => p.GroupId)
            //    .HasPrincipalKey(pg => pg.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            ////product and invoice detail
            //builder.Entity<Product>()
            //    .HasMany(p => p.InvoiceDetails)
            //    .WithOne(id => id.Product)
            //    .HasForeignKey(id => id.ProductId)
            //    .HasPrincipalKey (p => p.Id)
            //    .OnDelete (DeleteBehavior.NoAction);

            //// invoice header and invoice payment 
            //builder.Entity<InvoiceHeader>()
            //    .HasMany(ih => ih.InvoicePayments)
            //    .WithOne(ip => ip.InvoiceHeader)
            //    .HasForeignKey(ip => ip.InvoiceHeaderId)
            //    .HasPrincipalKey(ih => ih.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            //// invoice payment and payment
            //builder.Entity<Payment>()
            //    .HasOne(py => py.InvoicePayment)
            //    .WithOne(ip => ip.Payment)
            //    .HasForeignKey<InvoicePayment>(ip => ip.PaymentId)
            //    .HasPrincipalKey<Payment>(py => py.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            ////account and accounting doc details
            //builder.Entity<Account>()
            //    .HasMany(a => a.AccountingDocDetails)
            //    .WithOne(add => add.Account)
            //    .HasForeignKey(add => add.AccountId)
            //    .HasPrincipalKey(a => a.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            //// accounting doc and accounting doc details
            //builder.Entity<AccountingDocument>()
            //    .HasMany(ad => ad.DocumentDetails)
            //    .WithOne(add => add.Document)
            //    .HasForeignKey(add => add.AccountingDocumentId)
            //    .HasPrincipalKey(ad => ad.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            //// application user and payment
            //builder.Entity<ApplicationUser>()
            //    .HasMany(u => u.Payments)
            //    .WithOne(py => py.Registrar)
            //    .HasForeignKey(py => py.RegisterarId)
            //    .HasPrincipalKey(u => u.Id)
            //    .OnDelete(DeleteBehavior.NoAction);

            //// application user and invoice header
            //builder.Entity<ApplicationUser>()
            //    .HasMany(u => u.Invoices)
            //    .WithOne(i => i.Registerar)
            //    .HasForeignKey(i => i.RegisterarId)
            //    .HasPrincipalKey(u => u.Id)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}