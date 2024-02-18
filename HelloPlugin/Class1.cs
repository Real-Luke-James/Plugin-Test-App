using PluginBase;
using System;

namespace HelloPlugin
{
	public class HelloCommand : ICommand
	{
		public string Name { get => "hello"; }
		public string Description { get => "Displays Hello Message."; }

		public int Execute()
		{
			Console.WriteLine("Hello !!!");
			return 0;
		}
	}
}