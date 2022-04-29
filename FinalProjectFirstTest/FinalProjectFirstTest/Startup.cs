using FinalProjectFirstTest.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectFirstTest
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
			services.AddControllersWithViews();
			//
			services.AddSession();
			services.AddDbContext<FinalProjectDbContext>(opt => 
			{
				//opt.UseSqlServer(Configuration.GetConnectionString("FinalProjectTest"));
				opt.UseSqlServer(Configuration.GetConnectionString("TFM104Go_Camping"));
			});
			// 加cookie
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(opt =>
			{
				opt.LoginPath = new PathString("/Login_Register/LoginRegister");

			}).AddFacebook(opt =>
			{
				opt.AppId = "1077243449672588";
				opt.AppSecret = "02a8dd9f0001b321518d44662a985c1f";
			}).AddGoogle(opt =>
			{
				opt.ClientId = "257467857848-vo6c2b5n7dvrrjuspvm6m1chqurjm5gl.apps.googleusercontent.com";
				opt.ClientSecret = "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";
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			
			app.UseAuthentication();//驗證
			app.UseAuthorization(); //授權
			//加入session
			app.UseSession();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Buyer}/{action=Index}/{id?}");
			});
		}
	}
}
