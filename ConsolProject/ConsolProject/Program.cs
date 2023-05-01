using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Serialization;

using Microsoft.VisualBasic;
namespace ConsolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy számot");
            string amitAkar = Console.ReadLine();
            switch (amitAkar)
            {
                #region 1. Foreach
                case "1":
                    Foreach fr = new Foreach();
                    fr.Csinal();
                    break;
                #endregion
                #region 2. Do-While
                case "2":
                    DoWhile dw = new DoWhile();
                    dw.Csinal();
                    break;
                #endregion
                #region 3. Adathalmazok, osztály használata paraméterként
                case "3":
                    AdatokOsztalyok ao = new AdatokOsztalyok();
                    ao.Csinal();
                    break;
                #endregion
                #region 4. Interfész implementálása
                case "4":
                    InterfImplement im = new InterfImplement();
                    im.Kiir1();
                    break;
                #endregion
                #region 5. Generikus programozás
                case "5":
                    Generikus gener = new Generikus();

                    int[] szamok = { 1, 8, 4, 7 };
                    char[] betuk = { 's', 'm', 'n', };
                    gener.Csinal(szamok);
                    Thread.Sleep(1000);
                    gener.Csinal(betuk);
                    break;
                #endregion
                #region 6. XML olvasása és írása
                case "6":
                    XML x = new XML();
                    x.CStoXML();
                    break;
                #endregion
                #region 7. Többszálú programozás
                case "7":
                    Threading td = new Threading();
                    td.Szalak();
                    break;
                #endregion
                #region 8. Delegáltak (Action, Func)
                case "8":
                    Delegalt dg = new Delegalt();
                    dg.Csinal();
                    break;
                #endregion
            }
        }
    }
    #region Felhasznált osztályok
    public class Foreach
    {
        public void Csinal()
        {
            Console.WriteLine("Írj le egy mondatot.");
            string bemenet = Console.ReadLine();

            char[] betuk = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            foreach (char betu in betuk)
            {
                bemenet = bemenet.Replace(betu.ToString(), "");
            }
            Console.WriteLine(bemenet);
        }
    }
    public class DoWhile
    {
        public void Csinal()
        {
            bool akarja = true;
            do
            {
                Console.WriteLine("Szeretnéd folytatni?");
                string bemenetDW = Console.ReadLine();
                if (bemenetDW.Equals("igen"))
                {
                    akarja = true;
                }
                else
                    akarja = false;
            }
            while (akarja is true);
        }
    }
    public class Ember
    {
        public int Kora { get; set; }
        public string Neve { get; set; }
        public int SzuletesiDatum { get; set; }
    }
    public class AdatokOsztalyok
    {
        public void Csinal()
        {
            List<Ember> ember = new List<Ember>();
            Console.WriteLine("Hány éves vagy");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Mi a neved?");
            string b = Console.ReadLine();

            DateTime ma = DateTime.Now;
            int ev = ma.Year;
            int c = ev - a;

            ember.Add(new Ember()
            {
                Kora = a,
                Neve = b,
                SzuletesiDatum = c
            });
            Console.WriteLine($"{ember[0].Kora} éves vagy," +
                $" {ember[0].Neve} a neved és {ember[0].SzuletesiDatum}-ban/ben születtél");
            Console.Read();
        }
    }
    public interface Interfész
    {
        void Kiir1();
    }
    public class InterfImplement : Interfész
    {
        public void Kiir1()
        {
            Console.WriteLine("Implementáltam");
        }
    }
    public class Generikus
    {
        public void Csinal<T>(T[] array)
        {

            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class XML
    {
        public void CStoXML()
        {
            var ember = new Ember
            {
                Kora = 3,
                Neve = "Breki",
                SzuletesiDatum = 1998
            };

            var xml = new XmlSerializer(typeof(Ember));
            using (var writer = new StringWriter())
            {
                xml.Serialize(writer, ember);
                string szoveg = writer.ToString();
                Console.WriteLine(szoveg);
            }
        }
    }
    public class Threading
    {
        public void Szalak()
        {
            var thread = new Thread(() =>
            {
                Console.WriteLine("Töltődik...");
                var weboldal = new HttpClient();
                var link = weboldal.GetStreamAsync("https://hu.wikipedia.org/wiki/");
            });
            thread.Start();
            thread.Join();

            Console.WriteLine("Kész");
        }
    }
    public class Delegalt
    {
        public void Csinal()
        {
            Action<string> printMessage = (message) => Console.WriteLine(message);
            printMessage("Hello, world!");

            Func<int, int, int> addNumbers = (x, y) => x + y;
            int result = addNumbers(2, 3);
            Console.WriteLine(result);
        }
    }
    #endregion
}