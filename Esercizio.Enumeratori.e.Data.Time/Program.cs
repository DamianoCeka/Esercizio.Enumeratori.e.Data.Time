using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Esercizio.Enumeratori.e.Data.Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
            FindOrCreate(@"C:\Users\39327\Desktop\Banca");
            CreateSubDirectory(@"C:\Users\39327\Desktop\Banca\Clientela");           

            const String path = @"C:\Users\39327\Desktop";
            CLiente Cliente1 = new CLiente("Damiano", 23, "CKEFSAGSAG");
            CLiente Cliente2 = new CLiente("MIchele", 34, "VARSGSBGQW22");
            CLiente Cliente3 = new CLiente("Giulio", 19, "12D123FVVAS");

            Bank Unicredit = new Bank("Unicredit", path);
            Bank Hype = new Bank(" Hype", path);

            Unicredit.AddNewClient(Cliente1);
            Unicredit.AddNewClient(Cliente2);
            Unicredit.AddNewClient(Cliente3);

            Hype.AddNewClient(Cliente1);
            Hype.AddNewClient(Cliente2);
            Hype.AddNewClient(Cliente3);          

        }

        public class CLiente
        {
           public Saldo _saldo;
           public string _nome;
           public int _eta;
           public string _codicefiscale;
            

            public CLiente (string Nome, int Eta, string Codicefiscale)
            {
                _nome = Nome;
                _eta = Eta;
                _codicefiscale = Codicefiscale;
                
            }   
        }
         public class Saldo 
        {
            public CLiente CLiente;
            public decimal EURO = 0.00M;
            public decimal BTC = 0.00M;
             
            public Saldo(CLiente _cLiente)
            {
                CLiente = _cLiente;
                
            }
            public string GetClientName()
            {
                return CLiente._nome;
            }

        }
        public class Bank
        {
            List<CLiente> _cLiente = new List<CLiente>();
            public string _nome;
            string _path;

            public Bank(string nome, string path)
            {
                _nome = nome;
                _path = path;
                CreateFolder(Path.Combine(_path, _nome));
            }
            public void AddNewClient(CLiente CLiente)
            {               
                CreateFolder(CLiente._codicefiscale);
                _cLiente.Add(CLiente);
            }
            public void CreateFolder(string FolderName)
            {                
               
            }
        }
       
        static void FindOrCreate(String path)
        {
            DirectoryInfo info = new DirectoryInfo(path);

            if (info.Exists)
            {
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.Name);
                Console.WriteLine(info.Parent);
            }
            else
            {
                info.Create();
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.Name);
                Console.WriteLine(info.Parent);
            }
        }
        static void CreateSubDirectory(String path)
        {
            DirectoryInfo info = new DirectoryInfo(path);

            if (info.Exists)
            {
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.Name);
                Console.WriteLine(info.Parent);
            }
            else
            {
                info.Create();
                
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.Name);
                Console.WriteLine(info.Parent);
            }
        }
       
        
        
    }
}
