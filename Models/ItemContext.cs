﻿using Microsoft.EntityFrameworkCore;

namespace Assignment1.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ItemId = 1,
                    ProductName = "PlayStation 5",
                    ProductDescription = "Sony next-gen gaming console",
                    MinimumBidAmount = 1000,
                    AuctionStartDate = DateTime.Now,
                    AuctionEndDate = new DateTime(2023, 03, 23),
                    ItemCondition = "New",
                    Category = "Electronics",
                    ImageUrl = "https://i5.walmartimages.com/asr/fd596ed4-bf03-4ecb-a3b0-7a9c0067df83.bb8f535c7677cebdd4010741c6476d3a.png?odnHeight=612&odnWidth=612&odnBg=FFFFFF"
                },
                new Item
                {
                    ItemId = 2,
                    ProductName = "Jordan 1 Lost and Found",
                    ProductDescription = "2022 Sneaker of the Year",
                    MinimumBidAmount = 5000,
                    AuctionStartDate = DateTime.Now,
                    AuctionEndDate = new DateTime(2023, 03, 23),
                    ItemCondition = "Used",
                    Category = "Shoes",
                    ImageUrl = "https://solesavy.com/wp-content/uploads/2022/08/Air-Jordan-1-Lost-and-Found-DZ5485-612-Release-Date.jpeg"
                }
            );
        }
    }
}
