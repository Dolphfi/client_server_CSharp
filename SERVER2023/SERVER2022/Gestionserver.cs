using System;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInterface;
using System.Threading.Tasks;

namespace SERVER2023
{
    public class Gestionserver
    {
        TcpChannel channel = null;
        public void Demarer()
        {

            channel = new TcpChannel(1070);
            try
            {
                ChannelServices.RegisterChannel(channel);
            }
            catch (Exception ex)
            {
            }
        }
        public void Arreter()
        {
            try
            {
                ChannelServices.UnregisterChannel(channel);
            }
            catch (Exception ex)
            {
            }
        }

        public void Serveur()
        {
            try
            {
                Demarer();
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.CtrlUtilisateur), "IUtilisateur", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlCompte), "ICompte", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.Ctrlclient), "IClient", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.Ctrlemploye), "IEmploye", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlDepot), "IDepot", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlRetrait), "IRetrait", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlTransfert), "ITransfert", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlStatistique), "IStatistique", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlDashboard), "IDashboard", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(SERVER2023.application.ControlPayroll), "IPayroll", WellKnownObjectMode.Singleton);

            }

            catch (Exception ex)
            {

            }
        }
    }
}
