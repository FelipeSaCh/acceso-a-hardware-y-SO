using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using WUApiLib;
using Microsoft.Win32;
using System.Diagnostics;

namespace libreria
{
    public class Componentes
    {
        
        public static string SerialNumber(string lnNroSerie)
        {
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject objeto in buscador.Get())
            {
                if (objeto["SerialNumber"] != null)
                {
                    lnNroSerie = objeto["SerialNumber"].ToString();
                    return lnNroSerie;
                }
            }
            return null;
        }
        public static string Diskunits()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            string Disk = "";
            foreach (DriveInfo drive in drives)
            {               
                Disk += ($"drive {drive.Name}\n "+$"Tipo: {drive.DriveType}\n "+$"Espacio libre: {(drive.AvailableFreeSpace) / 1073741824 + " GB"}\n");
                
            }
            return Disk;
        }

        public static string NumberProcessors()
        {
            return ($"Numero de procesadores: {Environment.ProcessorCount}");
        }

        public static string Ram()
        {
            ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            foreach (ManagementObject Mobject in Search.Get())
            {
                double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));
                return ($"RAM Utilizable: {(Ram_Bytes) / 1073741824} GB");
            }
            return null;
        }

        public static string NIT()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            string redes = "";
            foreach (NetworkInterface adapter in interfaces)
            {
                redes += ($"Name: {adapter.Name}\n "+$"Descripcion: {adapter.Description}\n "+$"Tipo de interfaz: {adapter.NetworkInterfaceType}\n "+$"Estado operacional: {adapter.OperationalStatus}\n "+"--------\n");
            }

            return redes;
        }

        public static string MacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                return nic.GetPhysicalAddress().ToString();
            }
            return "null";
        }

        public static string Patches()
        {
            var updateSession = new UpdateSession();
            var updateSearcher = updateSession.CreateUpdateSearcher();
            var count = updateSearcher.GetTotalHistoryCount();
            var history = updateSearcher.QueryHistory(0, count);
            string show = "";

            for (int i = 0; i < count; ++i)
            {
                show += (history[i].Title+"\n");
            }
            return show;
        }

        public static string ReadKey(string n1, string n2)
        {
            return Registry.GetValue(n1, n2, "Registro no encontrado.").ToString();
        }
        public static void SetKey(string n1, string n2, string n3)
        {
            Registry.SetValue(n1, n2, n3);  
        }
        public static string CreateKey(string n1, string n2, string n3)
        {
            Registry.SetValue(n1, n2, n3);
            return Registry.GetValue(n1, n2, "Registro no encontrado.").ToString();
        }
        public static void DeleteKey(string n1, string n2)
        {
            if(n2 != null)
            {
                System.IO.File.WriteAllText("sys.reg", "Windows Registry Editor Version 5.00" + "\n" + "\n" + "[" + n1 + "]" + "\n" + "\"" + n2 + "\"=-");
                System.Diagnostics.Process.Start(@"sys.reg");
            }
            else
            {
                System.IO.File.WriteAllText("sys.reg", "Windows Registry Editor Version 5.00" + "\n" + "\n" + "[-" + n1 + "]");
                System.Diagnostics.Process.Start(@"sys.reg");
            }
        }

      
    }
}
