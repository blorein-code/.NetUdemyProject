﻿using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceColletion)
        {
            serviceColletion.AddDbContext<ProgrammersBlogContext>();
            serviceColletion.AddScoped<IUnitOfWork,UnitOfWork>();
            serviceColletion.AddScoped<ICategoryService, CategoryManager>();
            serviceColletion.AddScoped<IArticleService, ArticleManager>();
            return serviceColletion;
        }
    }
}
