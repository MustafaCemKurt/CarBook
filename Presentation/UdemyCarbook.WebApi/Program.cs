using UdemyCarbook.Application.Features.CQRS.Handlers.AboutHandlers;
using UdemyCarbook.Application.Features.CQRS.Handlers.BannerHandlers;
using UdemyCarbook.Application.Features.CQRS.Handlers.BrandHandlers;
using UdemyCarbook.Application.Features.CQRS.Handlers.CarHandlers;
using UdemyCarbook.Application.Features.CQRS.Handlers.CategoryHandlers;
using UdemyCarbook.Application.Features.CQRS.Handlers.ContactHandlers;
using UdemyCarbook.Application.Interfaces;
using UdemyCarbook.Application.Interfaces.CarInterfaces;
using UdemyCarbook.Application.Services;
using UdemyCarbook.Persistance.Context;
using UdemyCarbook.Persistance.Repositories;
using UdemyCarbook.Persistance.Repositories.CarRepositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddScoped<CarBookContext>();
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));

        builder.Services.AddScoped<GetAboutQueryHandler>();
        builder.Services.AddScoped<GetAboutByIdQueryHandler>();
        builder.Services.AddScoped<CreateAboutCommandHandler>();
        builder.Services.AddScoped<UpdateAboutCommandHandler>();
        builder.Services.AddScoped<RemoveAboutCommandHandler>();


        builder.Services.AddScoped<GetBannerQueryHandler>();
        builder.Services.AddScoped<GetBannerByIdQueryHandler>();
        builder.Services.AddScoped<CreateBannerCommandHandler>();
        builder.Services.AddScoped<RemoveBannerCommandHandler>();
        builder.Services.AddScoped<UpdateBannerCommandHandler>();

        builder.Services.AddScoped<GetBrandQueryHandler>();
        builder.Services.AddScoped<GetBrandByIdQueryHandler>();
        builder.Services.AddScoped<CreateBrandCommandHandler>();
        builder.Services.AddScoped<UpdateBrandCommandHandler>();
        builder.Services.AddScoped<RemoveBrandCommandHandler>();

        builder.Services.AddScoped<GetCarQueryHandler>();
        builder.Services.AddScoped<GetCarByIdQueryHandler>();
        builder.Services.AddScoped<CreateCarCommandHandler>();
        builder.Services.AddScoped<UpdateCarCommandHandler>();
        builder.Services.AddScoped<RemoveCarCommandHandler>();
        builder.Services.AddScoped<GetCarWithBrandQueryHandler>();

        builder.Services.AddScoped<GetCategoryQueryHandler>();
        builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
        builder.Services.AddScoped<CreateCategoryCommandHandler>();
        builder.Services.AddScoped<UpdateCategoryCommandHandler>();
        builder.Services.AddScoped<RemoveCategoryCommandHandler>();

        builder.Services.AddScoped<GetContactQueryHandler>();
        builder.Services.AddScoped<GetContactByIdQueryHandler>();
        builder.Services.AddScoped<CreateContactCommandHandler>();
        builder.Services.AddScoped<UpdateContactCommandHandler>();
        builder.Services.AddScoped<RemoveContactCommandHandler>();

        builder.Services.AddApplicationService(builder.Configuration);


        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}