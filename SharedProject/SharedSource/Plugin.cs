using System.Runtime.CompilerServices;
using Barotrauma;
using HarmonyLib;

[assembly: IgnoresAccessChecksTo("Barotrauma")]
[assembly: IgnoresAccessChecksTo("DedicatedServer")]
[assembly: IgnoresAccessChecksTo("BarotraumaCore")]

namespace ShitTest
{
    public partial class Plugin : IAssemblyPlugin
    {
        public static Plugin Instance = null!;
        public const string Name = "Shit Test";
        public const string ShortName = "SHIT";
        public const string Id = "shit.test";
        readonly Harmony harmony = new(Id);
        #if DEBUG
        public const bool Debug = true;
        #else
        public const bool Debug = false;
        #endif
        
        public void Initialize()
        {
#if SERVER
            InitializeServer();
#elif CLIENT
            InitializeClient();
#endif
        }

        public void OnLoadCompleted()
        {
            // After all plugins have loaded
            // Put code that interacts with other plugins here.
        }

        public void PreInitPatching()
        {
            // Not yet supported: Called during the Barotrauma startup phase before vanilla content is loaded.
        }

        public void Dispose()
        {
            // Cleanup your plugin!
            throw new NotImplementedException();
        }
    }
}
