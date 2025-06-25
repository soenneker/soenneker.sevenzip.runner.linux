﻿using Microsoft.Extensions.DependencyInjection;
using Soenneker.SevenZip.Runner.Linux.Utils;
using Soenneker.SevenZip.Runner.Linux.Utils.Abstract;
using Soenneker.Managers.Runners.Registrars;
using Soenneker.Compression.Tar.XZ.Registrars;

namespace Soenneker.SevenZip.Runner.Linux;

/// <summary>
/// Console type startup
/// </summary>
public static class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    public static void ConfigureServices(IServiceCollection services)
    {
        services.SetupIoC();
    }

    public static IServiceCollection SetupIoC(this IServiceCollection services)
    {
        services.AddHostedService<ConsoleHostedService>()
                .AddScoped<IFileOperationsUtil, FileOperationsUtil>()
                .AddTarXZUtilAsScoped()
                .AddRunnersManagerAsScoped();

        return services;
    }
}
