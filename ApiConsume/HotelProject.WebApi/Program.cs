using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.WebApi.Mapping;
using AutoMapper;

namespace HotelProject.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddAutoMapper(typeof(AutoMapperCfg));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<HotelContext>();

            builder.Services.AddScoped<IServiceDal,EfServiceDal>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<IRoomDal, EfRoomDal>();
            builder.Services.AddScoped<IRoomService, RoomManager>();

            builder.Services.AddScoped<IAboutDal, EfAboutDal>();
            builder.Services.AddScoped<IAboutService, AboutManager>();

            builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

            builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

            builder.Services.AddScoped<IStaffDal,EfStaffDal>();
            builder.Services.AddScoped<IStaffService,StaffManager>();



            builder.Services.AddCors(opt=>
            {
                opt.AddPolicy("OtelApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            app.UseHttpsRedirection();
            app.UseCors("OtelApiCors");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}