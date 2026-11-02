using System.Runtime.CompilerServices;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        await ApiFetch();
    }

    static async Task ApiFetch()
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Read from .env file
                string baseUrl = GetEnvironmentVariableFromDotEnv("API_BASE_URL") ?? "";
                string url = baseUrl.Trim();
                if (url == "")
                    throw new Exception("API_BASE_URL not found. Check the .env file.");
                
                HttpResponseMessage response = await client.GetAsync(url);
                
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"HTTP error! Status: {response.StatusCode}");

                string json = await response.Content.ReadAsStringAsync();
                JsonDocument doc = JsonDocument.Parse(json);
                
                Console.WriteLine("First Post Title: " + doc.RootElement[0].GetProperty("title").GetString());
                
                doc.Dispose();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    
    // Code to pull straight from .env file
    static string GetEnvironmentVariableFromDotEnv(string variableName, [CallerFilePath] string sourceFile = "")
    {
        try
        {
            // Look for .env in the current directory, the "Task 3" subfolder, or any parent directory
            string? envFilePath = null;
            // Start from the working directory, the build output, and the folder holding this source file
            string?[] startDirs = { Directory.GetCurrentDirectory(), AppContext.BaseDirectory, Path.GetDirectoryName(sourceFile) };
            foreach (string? start in startDirs)
            {
                if (string.IsNullOrEmpty(start)) continue;
                DirectoryInfo? dir = new DirectoryInfo(start);
                while (dir != null && envFilePath == null)
                {
                    foreach (string candidate in new[] { Path.Combine(dir.FullName, ".env"), Path.Combine(dir.FullName, "Task 3", ".env") })
                    {
                        if (File.Exists(candidate))
                        {
                            envFilePath = candidate;
                            break;
                        }
                    }
                    dir = dir.Parent;
                }
                if (envFilePath != null) break;
            }

            if (envFilePath != null)
            {
                string[] lines = File.ReadAllLines(envFilePath);
                
                foreach (string line in lines)
                {
                    if (line.StartsWith(variableName + "="))
                    {
                        return line.Substring(variableName.Length + 1);
                    }
                }
            }
        }
        catch
        {
            // If there's any error reading the file, just return null
        }
        
        return null;
    }
}