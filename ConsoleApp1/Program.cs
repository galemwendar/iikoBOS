
using iiko_it_getversion_API;
using System.Diagnostics;
using System;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using ClassLibrary1_test;
using System.Runtime.InteropServices;

namespace ikoitgetversion
{
   
    class Programm
    {

        static void Main(string[] args)
        {


            //while (true)
            //{

            //    try
            //    {
            //        Server server = new Server();

            //        string sURL;
            //        Console.WriteLine("введите адрес сервера (адрес:порт, если локальный):");
            //        string adress = Console.ReadLine();
            //        if (!adress.Contains("/resto"))
            //        { adress = adress + "/resto"; }


            //        bool res = Uri.IsWellFormedUriString(adress, UriKind.Absolute);
            //        if (res == false)
            //        {
            //            Console.WriteLine("ERROR: URL адрес " + adress + " не верный. Используй URL формата" +
            //                                  " https://exmple.iiko.it или https://exmple.iiko.it/resto ");
            //        }
            //        sURL = adress + "/get_server_info.jsp?encoding=UTF-8";
            //        UrlService urlService = new UrlService();

            //        var serverProperties = urlService.GetServerProperties(sURL);
            //        Console.WriteLine("ServerVersion: {0}\nServerState: {1}\nEdition {2}",
            //             serverProperties.Version, serverProperties.ServerState, serverProperties.Edition);


            //        //Здесь перезаписываем backclient.config

            //        string roamingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //        string backclientconfig = "";
            //        if (serverProperties.Edition == "chain")
            //        {
            //            backclientconfig = roamingpath + @"\iiko\Chain\Default\config.xml";
            //        }
            //        else
            //        {
            //            backclientconfig = roamingpath + @"\iiko\Rms\Default\config\backclient.config.xml";
            //        }

            //        XElement userList = XElement.Load(backclientconfig);
            //        foreach (XElement el in userList.Elements())
            //        {
            //            if (el.Name == "ServersList")
            //            {
            //                el.Remove();
            //            }
            //        }

            //        var uriparser = new Uri(adress);
            //        var content = new XElement("ServersList",
            //                                    new XElement("ServerName", serverProperties.ServerName),
            //                                    new XElement("Version", serverProperties.Version),
            //                                    new XElement("ComputerName", serverProperties.computerName),
            //                                    new XElement("Protocol", uriparser.Scheme),
            //                                    new XElement("ServerAddr", uriparser.Host),
            //                                    new XElement("ServerSubUrl", uriparser.PathAndQuery),
            //                                    new XElement("Port", uriparser.Port.ToString()),
            //                                    new XElement("IsPresent", serverProperties.isPresent)
            //                                    );

            //        userList.Element("serverChooserIsOpened").AddBeforeSelf(content);

            //        userList.Save(backclientconfig);



            //        //Здесь мы находим и запускаем бэк
            //        Console.WriteLine("Укажите путь для папки с бэками");
            //        var rootDir = Console.ReadLine();
            //        string versionName = serverProperties.Version.Remove(8, 2);
            //        string edition = "*Office*";

            //        if (serverProperties.Edition == "chain")
            //        {
            //            edition = "*Chain*Office*";
            //        }
            //        else
            //        {
            //            edition = "*Office*";
            //        }

            //        string searchPattern = edition + versionName;
            //        Console.WriteLine("Ищу в " + rootDir + " где " + searchPattern);


            //        var directories = Directory.EnumerateDirectories(rootDir, searchPattern, SearchOption.AllDirectories);
            //        try
            //        {
            //            foreach (var directory in directories)
            //            {
            //                if (directory.Contains("Chain") && serverProperties.Edition != "chain")
            //                {
            //                    Console.WriteLine(directory + " пропускаем");
            //                    continue;
            //                }
            //                else if (!(File.Exists(directory + @"\BackOffice.exe")))
            //                {
            //                    Console.WriteLine(directory + " пропускаем");
            //                    continue;
            //                }

            //                else
            //                {
            //                    using (Process myProcess = new Process())
            //                    {
            //                        myProcess.StartInfo.UseShellExecute = false;
            //                        myProcess.StartInfo.FileName = directory + @"\BackOffice.exe";
            //                        myProcess.StartInfo.CreateNoWindow = true;
            //                        myProcess.Start();
            //                    }
            //                }
            //            }
            //        }


            //        catch (Exception e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }

            //    }


            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("ERROR: {0},{1}", ex.Message, ex.GetType().Name);
            //    }



        }
        }

    }






