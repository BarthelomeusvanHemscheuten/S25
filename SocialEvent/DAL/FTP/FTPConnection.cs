﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.FTP
{
    public class FTPConnection
    {
        private string webserver = @"ftp://192.168.20.18/";
        private string username = "Administrator";
        private string password = "Welkom10!";
        public FTPConnection()
        { }

        /// <summary>
        /// Methode om files te uploaden.
        /// Houd er rekening mee dat deze methode exceptions kan geven als:
        /// <para>- Je niet verbonden bent met de infralab VPN.</para>
        /// <para>- De FTP server of router uit staat.</para>
        /// <para>- De netwerkfolder nog niet bestaat.</para>
        /// </summary>
        /// <param name="uploadFromPath">Path van het bestand op de gebruikerscomputer. Bv: @"C:\testfile.txt" </param>
        /// <param name="uploadToPath">Path waar je het geupload wil hebben op de server. Bv: @"users\thomasj10\files\testfile.txt"</param>
        public void UploadFile(string uploadFromPath, string uploadToPath)
        {
            //Geef aan waar we de file naar willen uploaden. De FTP server + in welke subfolder
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://192.168.20.18/" + uploadToPath);

            //Aangeven dat we een file willen uploaden
            request.Method = WebRequestMethods.Ftp.UploadFile;

            //Inloggen op de FTP server. (Onveilig. Demo only!!)
            request.Credentials = new NetworkCredential("Administrator", "Welkom10!");

            try
            {
                //Lokaal bestand uitlezen
                byte[] fileContents = File.ReadAllBytes(uploadFromPath);
                request.ContentLength = fileContents.Length;

                //Bestand wegschrijven naar de server
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                //Response opvangen en in de console zetten
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);
                response.Close();
            }
            catch (WebException e)
            {
                string status = ((FtpWebResponse)e.Response).StatusDescription;
                Console.WriteLine(status);
            }
        }

        /// <summary>
        /// Methode om files te downloaden.
        /// Houd er rekening mee dat deze methode exceptions kan geven als:
        /// <para>- Je niet verbonden bent met de infralab VPN</para>
        /// <para>- De FTP server of router uit staat.</para>
        /// <para>- Het opgegeven netwerk pad niet gevonden kan worden.</para>
        /// <para>- Er geen schrijftoegang is tot het download pad</para>
        /// </summary>
        /// <param name="downloadFromPath">Path van het bestand op de FTP server. Bv: @"users\thomasj10\files\testfile.txt" </param>
        /// <param name="downloadToPath">Path waar het bestand naar opgeslagen moet worden. Bv: @"C:\testfile.txt" </param>
        public void DownloadFileToFolder(string downloadFromPath, string downloadToPath)
        {
            //Geeft aan waar we de file vanaf willen downloaden. De FTP server + welke subfolder  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(webserver + downloadFromPath);

            //Aangeven dat we een file willen downloaden
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            //Inloggen op de FTP server. (Onveilig. Demo only!!)
            request.Credentials = new NetworkCredential(username, password);

            try
            {
                //Response opvangen en in een stream zetten
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                //Opgevangen stream kopieëren naar een lokaal bestand.
                Stream fileStream = File.Create(downloadToPath);
                responseStream.CopyTo(fileStream);
                fileStream.Close();

                //Response status weergeven in console
                Console.WriteLine("Download Complete, status {0}", response.StatusDescription);
                response.Close();
            }
            catch (WebException e)
            {
                string status = ((FtpWebResponse)e.Response).StatusDescription;
                Console.WriteLine(status);
            }
        }

        /// <summary>
        /// Methode om image objecten te krijgen
        /// Houd er rekening mee dat deze methode exceptions kan geven als:
        /// <para>- Je niet verbonden bent met de infralab VPN</para>
        /// <para>- De FTP server of router uit staat.</para>
        /// <para>- Het opgegeven netwerk pad niet gevonden kan worden.</para>
        /// <para>- Het opgegeven bestand geen image is.</para>
        /// </summary>
        /// <param name="downloadFromPath">Path van het bestand op de FTP server. Bv: @"users\thomasj10\files\testfile.txt" </param>
        public Image GetImageFromFTP(string downloadFromPath)
        {
            //Geeft aan waar we de file vanaf willen downloaden. De FTP server + welke subfolder  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(webserver + downloadFromPath);

            //Aangeven dat we een file willen downloaden
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            //Inloggen op de FTP server. (Onveilig. Demo only!!)
            request.Credentials = new NetworkCredential(username, password);

            //Response opvangen en in een stream zetten
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //Opgevangen stream kopieëren naar een lokaal bestand.
            Image output = DAL.Properties.Resources._1024px_No_image_available_svg;
            try
            {
                output = Bitmap.FromStream(responseStream);
            }
            catch
            {
                Console.WriteLine("Data is no image");
            }

            //Response status weergeven in console
            Console.WriteLine("Download Complete, status {0}", response.StatusDescription);
            response.Close();

            return output;
        }

        private bool DirectoryExists(string directory)
        {
            bool directoryExists;

            var request = (FtpWebRequest)WebRequest.Create(@"ftp://192.168.20.18/" + directory + "/");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential("Administrator", "Welkom10!");

            try
            {
                using (request.GetResponse())
                {
                    directoryExists = true;
                }
            }
            catch (WebException)
            {
                directoryExists = false;
            }

            return directoryExists;
        }

        public void CreateDirectoryIfNotExists(string directory)
        {
            if (!DirectoryExists(directory))
            {
                //Geeft aan waar we de file vanaf willen downloaden. De FTP server + welke subfolder  
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://192.168.20.18/" + directory + "/");

                //Aangeven dat we een map willen aanmaken
                request.Method = WebRequestMethods.Ftp.MakeDirectory;

                //Inloggen op de FTP server. (Onveilig. Demo only!!)
                request.Credentials = new NetworkCredential("Administrator", "Welkom10!");

                try
                {
                    //Response opvangen en in een stream zetten
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                    //Response status weergeven in console
                    Console.WriteLine("Download Complete, status {0}", response.StatusDescription);
                    response.Close();
                }
                catch (WebException e)
                {
                    string status = ((FtpWebResponse)e.Response).StatusDescription;
                    Console.WriteLine(status);
                }
            }
        }

    }
}
