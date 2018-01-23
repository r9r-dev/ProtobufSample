using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Topshelf;


/*
 * Service gRPC
 * Service débuggable en console (F5 classique)
 * Pour installer le service : Server.exe install
 * Pour désinstaller le service : Server.exe uninstall
 * Plus d'infos : https://topshelf.readthedocs.io/en/latest/overview/commandline.html
 * Plus d'infos sur Protobuf : https://developers.google.com/protocol-buffers/
 */


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = HostFactory.Run(x =>
            {
                x.Service<ServerService>(s =>
                {
                    s.ConstructUsing(name=> new ServerService());
                    s.WhenStarted(svc => svc.Start());
                    s.WhenStopped(svc => svc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Sample gRPC Service");
                x.SetDisplayName("gRPC Service example");
                x.SetServiceName("gRPCSampleService");
            });

            var exitCode = (int) Convert.ChangeType(rc, rc.GetTypeCode());
            Environment.ExitCode = exitCode;}
    }
}
