using PluginBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TestAppWithPlugins
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (args.Length == 1 && args[0] == "/d") {
					Console.WriteLine("Waiting for any key...");
					Console.ReadLine();
				}

				string[] pluginPaths = new string[]
				{
					// Paths for Plugins to load from
				};

				IEnumerable<ICommand> commands = pluginPaths.SelectMany(pluginPath =>
				{
					Assembly pluginAssembly = LoadPlugin(pluginPath);
					return CreateCommands(pluginAssembly);
				});

				if (args.Length == 0)
				{
					Console.WriteLine("Commands: ");
					// Output commands
				}
				else
				{
					foreach (string commandName in args)
					{
						Console.WriteLine($"-- {commandName} --");

						// Execute Command with name passed as argument

						Console.WriteLine();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}