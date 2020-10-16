﻿using PW.Domain.IRepository;
using PW.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PW.ApplicationContracts.Interfaces;
using PW.Application;

namespace PW.Infrastructure.EFCore
{
    public class Bootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionstring)
        {
            services.AddTransient<ICourseApplication, CourseApplication>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<IFileApplication, FileApplication>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IMessageApplication, MessageApplication>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProfessorApplication, ProfessorApplication>();
            services.AddTransient<IProfessorRepository, ProfessorRepository>();
            services.AddTransient<IResumeApplication, ResumeApplication>();
            services.AddTransient<IResumeRepository, ResumeRepository>();
            services.AddTransient<ITestimonialApplication, TestimonialApplication>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddDbContext<EMContext>(options => options.UseSqlServer(connectionstring));

        }
    }
}
