using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using BackEndV1.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using BackEndV1.Domain.IRepository;
using BackEndV1.Persistence.Repository;
using BackEndV1.Domain.IService;
using BackEndV1.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DinkToPdf.Contracts;
using DinkToPdf;
using BackEndV1.Utils;
using System.IO;

namespace BackEndV1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"));

            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddDbContext<AplicationDbContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("Conexion")));
            //services - logica de negocio

            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICuestionarioService, CuestionarioService>();
            services.AddScoped<IRespuestaCuestionarioService, RespuestaCuestionarioService>();
            services.AddScoped<IEstudianteService, EstudianteService>();
            services.AddScoped<IFuncionarioService, FuncionarioService>();
            services.AddScoped<IEstablecimientoService, EstablecimientoService>();
            services.AddScoped<IRegistroService, RegistroService>();
            services.AddScoped<IProtocoloActuacionService, ProtocoloActuacionService>();
            //repository
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ICuestionarioRepository, CuestionarioRepository>();
            services.AddScoped<IRespuestaCuestionarioRepository, RespuestaCuestionarioRepository>();
            services.AddScoped<IEstudianteRepository, EstudianteRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IEstablecimientoRepository, EstablecimientoRepository>();
            services.AddScoped<IProtocoloActuacionRepository, ProtocoloActuacionRepository>();
            services.AddScoped<IRegistroRepository, RegistroRepository>();
            //cors
            services.AddCors(options => options.AddPolicy("AllowWebApp",
                                      builder => builder.AllowAnyOrigin()
                                                        .AllowAnyHeader()
                                                        .AllowAnyMethod()));

            //Agregando autentificacion

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecretKey"])),
                        ClockSkew = TimeSpan.Zero

                    });

            //paquete nugett newton que permite serializar objetos dentro de objetos. (newton softjson)
            services.AddControllers().AddNewtonsoftJson(options =>
                                   options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("AllowWebApp");
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
