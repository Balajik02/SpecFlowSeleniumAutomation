using System;
using System.Diagnostics;

namespace AutomationCore.CommandRunner
{
    public static class CommandRunner
    {
        public static void RunCommand(string[] args)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";

                // Use the provided arguments
                process.StartInfo.Arguments = $"/c {args}";

                // Enable redirection of standard output and error
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                // Start the process
                process.Start();

                // Read the output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                // Display the output and error
                Console.WriteLine("Output:");
                Console.WriteLine(output);

                if (!string.IsNullOrWhiteSpace(error))
                {
                    Console.WriteLine("Error:");
                    Console.WriteLine(error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}