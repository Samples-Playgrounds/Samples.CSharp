using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using CSnakes.Runtime;

IHostBuilder builder = Host.CreateDefaultBuilder(args)
                                .ConfigureServices
                                    (
                                        services =>
                                        {
                                            // Path to your Python modules
                                            string home = Path.Join
                                                (
                                                    Environment.CurrentDirectory, 
                                                    ".",
                                                    "docling"
                                                );
                                            string venv = Path.Join(home, ".venv");

                                            services
                                                .WithPython()
                                                .WithHome(home)
                                                .WithVirtualEnvironment(venv)
                                                // Download Python 3.12 and store it locally
                                                .FromRedistributable("3.13")
                                                // Add these methods to configure
                                                //      virtual environment and
                                                //      install packages from requirements.txt
                                                .WithPipInstaller()
                                                ;
                                        }
                                    );

IHost app = builder.Build();

IPythonEnvironment python_environment = app.Services.GetRequiredService<IPythonEnvironment>();

RunQuickDemo(python_environment);

static
    string
                                        RunQuickDemo
                                        (
                                            IPythonEnvironment python_environment
                                        )
{
    string source =
        // "/Volumes/FAT_VERB/learning/topics/security/threat-modelling/effectivethreatinvestigationforsocanalysts.pdf"
        "/Users/moljac/Downloads/a.pdf"
        // "https://arxiv.org/pdf/2408.09869"  
        //"/Volumes/FAT_VERB/learning/topics/security/threat-modelling/threatmodeling.pdf"
        ;

    string result = python_environment.Convert().CovertDocling(source);

    return result;
}