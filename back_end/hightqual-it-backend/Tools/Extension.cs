using hightqual_it_backend.Interfaces;

using hightqual_it_backend.Models;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Models.Motherboard;
using hightqual_it_backend.Repositories;
using hightqual_it_backend.Repositories.Detail;
using hightqual_it_backend.Repositories.Device;
using hightqual_it_backend.Repositories.Logistic;
using hightqual_it_backend.Repositories.Motherboard;
using hightqual_it_backend.Services;

using hightqual_it_backend.Services.Detail;
using hightqual_it_backend.Services.Device;
using hightqual_it_backend.Services.Logistic;
using hightqual_it_backend.Services.Motherboard;

using Microsoft.Extensions.DependencyInjection;





namespace hightqual_it_backend.Tools
{
    public static class Extension
    {
        public static void AddOurServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();

            services.AddScoped<IRepository<Computer>, ComputerRepository>();
            services.AddScoped<ComputerService>();

            services.AddScoped<IRepository<Os>, OsRepository>();
            services.AddScoped<OsService>();
            
            services.AddScoped<IRepository<Screen>, ScreenRepository>();
            services.AddScoped<ScreenService>();

            services.AddScoped<IRepository<Sound>, SoundRepository>();
            services.AddScoped(typeof(SoundRepository));
            services.AddScoped(typeof(SoundService));

            services.AddScoped<IRepository<Cpu>, CpuRepository>();
            services.AddScoped<CpuService>();
            
            services.AddScoped<IRepository<GraphicProduct>, GProductRepository>();
            services.AddScoped<GCardService>();

            services.AddScoped<IRepository<Memory>, MemoryRepository>();
            services.AddScoped<MemoryService>();
            
            services.AddScoped<IRepository<HardDisk>, HDiskRepository>();
            services.AddScoped<HDiskService>();

            services.AddScoped<IRepository<Mouse>, _mouseRepository>();
            services.AddScoped<MouseService>();
            
            services.AddScoped<IRepository<PowerSupply>, PowerSupplyRepository>();
            services.AddScoped<PowerSupplyService>();

            services.AddScoped<IRepository<Connector>, ConnectorRepository>();
            services.AddScoped<ConnectorService>();
            
            // Detail
            services.AddScoped<IRepository<Brand>, BrandRepository>();
            services.AddScoped(typeof(BrandService));

            services.AddScoped<IRepository<Color>, ColorRepository>();
            services.AddScoped(typeof(ColorService));

            services.AddScoped<IRepository<Commentary>, CommentaryRepository>();
            services.AddScoped(typeof(CommentaryService));

            services.AddScoped<IRepository<Category>, CategoryRepository>();
            services.AddScoped(typeof(CategoryService));

            services.AddScoped<IRepository<Image>, ImageRepository>();
            services.AddScoped(typeof(ImageService));

            // Logistic
            services.AddScoped<IRepository<Cart>, CartRepository>();
            services.AddScoped(typeof(CartRepository));
            services.AddScoped(typeof(CartService));
        }

    }
}
