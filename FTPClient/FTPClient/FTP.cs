using System;
using System.Collections;
using System.Net;
using System.IO;

namespace FTPClient
{
    class FTP
    {
        private string host;
        private Client client;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private Stream ftpStream = null;
        private int bufferSize = 2048;


        public FTP(string host, Client client)
        {
            this.host = host;
            this.client = client;
        }
        
        public bool Download(string fileName)
        {
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + fileName);
                ftpRequest.Credentials = new NetworkCredential(client.GetLogin(), client.GetPassword());
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                FileStream localFileStream = new FileStream(fileName, FileMode.Create);
                byte[] byteBuffer = new byte[bufferSize];
                int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public ArrayList GetListOfFiles()
        {
            try
            {
                ArrayList al = new ArrayList();
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host);
                ftpRequest.Credentials = new NetworkCredential(client.GetLogin(), client.GetPassword());
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader ftpReader = new StreamReader(ftpStream);
                try
                {
                    while (ftpReader.Peek() != -1)
                    {
                        al.Add(ftpReader.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                return al;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}