using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PracticTeh.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace PracticTeh
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
            // ��������� ������ ����������� �� ����� ������������
            string connection = Configuration.GetConnectionString("DefaultConnection");       //�����
            // ���������� ��������� MobileContext � �������� ������� � ����������
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connection));
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            //������������� ��������� �����������
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseMiddleware<RoutingMiddleware>();
        }
    }
}
