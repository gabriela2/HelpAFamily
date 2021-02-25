using System.Text;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpAFamily
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public Startup(IConfiguration configuration)
		{
			this.Configuration = configuration;
		}


		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
			{
				builder.AllowAnyOrigin()
					   .AllowAnyMethod()
					   .AllowAnyHeader();
			}));

			// for LOOP services.AddControllers();

			services.AddControllers().AddNewtonsoftJson(options =>
			{
				options.SerializerSettings.ContractResolver = new DefaultContractResolver();
				options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			});


			// Register the Swagger generator, defining 1 or more Swagger documents
			services.AddSwaggerGen();

			services.AddDbContext<DataContext>(
				sql => sql.UseSqlServer(@"Server=.\; Database=HelpAFamily; Trusted_Connection=true;")
				);

			DbContextOptionsBuilder<DataContext> ob = new DbContextOptionsBuilder<DataContext>();
			ob.UseSqlServer(@"Server=.\; Database=HelpAFamily; Trusted_Connection=true;");
			DataContext.DefaultOptions = ob.Options;
			new DataContext(DataContext.DefaultOptions).Database.EnsureCreated();
			services.AddScoped<DataContext>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();


			app.UseCors("MyPolicy");
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();



			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
				//c.RoutePrefix = string.Empty;
			});


			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
