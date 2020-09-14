
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Conta_Apparizioni_Parola{
    class Program{
        static void Main(string[] args){
            try{
                string text = File.ReadAllText("testo.txt");
                string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string searchword;
                int count=0;
                Console.WriteLine("Inserisci una parola o una lettera, ti dirò quante volte appare nel testo:");
                searchword = Console.ReadLine();
                Console.WriteLine("\n" + "Testo:" + "\n");
                for(int i=0; i<source.Length; i++){
                    Console.Write(source[i] + " ");
                    if (searchword == source[i]) count++;
                }
                Console.WriteLine("\n" + "\n" + "La ricerca ha rilevato " + count + " apparizioni di: " + searchword);
            }
            catch (Exception e){
                string risposta;
                Console.WriteLine("Il file non può essere letto:");
                Console.WriteLine(e.Message);
                Console.WriteLine("Se il file non è stato trovato, vuole crearlo lei adesso? si / no");
                do{
                    risposta = Console.ReadLine();
                } while (risposta.Length != 2 || risposta != "si" && risposta != "no");
                if (risposta == "si"){
                    using (StreamWriter file = new StreamWriter("testo.txt")){}
                }
            }
            Console.WriteLine("Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
    }
}
