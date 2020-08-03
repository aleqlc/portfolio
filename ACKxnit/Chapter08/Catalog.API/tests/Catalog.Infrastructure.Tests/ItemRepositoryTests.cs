﻿using Catalog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Catalog.Infrastructure.Tests
{
    public class ItemRepositoryTests
    {
        [Fact]
        public async Task should_get_data()
        {
            var options = new DbContextOptionsBuilder<CatalogContext>().UseInMemoryDatabase(databaseName: "should_get_data").Options;

            await using var context = new TestCatalogContext(options);
            context.Database.EnsureCreated();
            var sut = new ItemRepository(context);
            var result = await sut.GetAsync();

            result.ShouldNotBeNull();
            //result.ShouldBeEmpty();
            //result.ShouldNotBeEmpty();
        }
    }
}
