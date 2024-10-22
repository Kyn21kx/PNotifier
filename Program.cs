using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace PNotifier;

class Program {

	static async Task Main(string[] args){
		if (!OperatingSystem.IsWindows()) {
			Console.Error.WriteLine("PNotifier is currently only available for Windows!");
			return;
		}
		if (args.Length < 1 ) {
			Console.Error.WriteLine("Not enough arguments given to execute a process and notify!");
			return;
		}
		//Handle the args as the process string from idx > 1
		StringBuilder cmdBuilder = new StringBuilder();
		for (int i = 0; i < args.Length; i++)
		{
			cmdBuilder.Append(args[i]);
			cmdBuilder.Append(' ');
		}
		string cmd = "cmd.exe";
		
		Process pInfo = Process.Start(cmd, "/c " + cmdBuilder.ToString());
		await pInfo.WaitForExitAsync();
		Console.Beep(523, 450); // C
		Console.Beep(587, 150); // D
		Console.Beep(659, 300); // E
		Console.Beep(698, 300); // F
		Console.Beep(783, 600); // G
	}
}


