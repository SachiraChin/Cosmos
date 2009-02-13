﻿using System;
using Cosmos.Compiler.Builder;

namespace CosmosBoot {
	class Program {
		#region Cosmos Builder logic
		// Most users wont touch this. This will call the Cosmos Build tool
		[STAThread]
		static void Main(string[] args) {
            BuildUI.Run();
        }
		#endregion

		// Main entry point of the kernel
		public static void Init() {
            var xBoot = new Cosmos.Sys.Boot();
            xBoot.Execute();

            Console.WriteLine("Congratulations! You just booted C# code.");
            Console.WriteLine("Edit Program.cs to create your own Operating System.");
            Console.WriteLine("Press a key to shutdown...");
            Console.Read();
            Cosmos.Sys.Deboot.ShutDown();
		}
	}
}