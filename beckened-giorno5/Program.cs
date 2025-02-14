using System;
using beckened_giorno5.Models;


            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("BENVENUTO NEL CALCOLATORE DELL'IMPOSTA DA VERSARE");
               
                // Richiesta dei dati del contribuente
                Console.Write("Inserisci il Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Inserisci il Cognome: ");
                string cognome = Console.ReadLine();

                DateTime dataDiNascita;
                while (true)
                {
                    Console.Write("Inserisci la Data di Nascita (gg/mm/yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out dataDiNascita))
                    {
                        break;
                    }
                    Console.WriteLine("Data non valida. Riprova.");
                }

                char sesso;
                while (true)
                {
                    Console.Write("Inserisci il Sesso (M/F): ");
                    if (char.TryParse(Console.ReadLine().ToUpper(), out sesso) && (sesso == 'M' || sesso == 'F'))
                    {
                        break;
                    }
                    Console.WriteLine("Sesso non valido. Inserire M o F.");
                }

                Console.Write("Inserisci il Codice Fiscale: ");
                string codiceFiscale = Console.ReadLine();

                Console.Write("Inserisci il Comune di Residenza: ");
                string comuneResidenza = Console.ReadLine();

                decimal redditoAnnuale;
                while (true)
                {
                    Console.Write("Inserisci il Reddito Annuale (esempio: 17850,50): ");
                    if (decimal.TryParse(Console.ReadLine(), out redditoAnnuale) && redditoAnnuale >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Reddito non valido. Riprova.");
                }

                Contribuente contribuente = new Contribuente(nome, cognome, dataDiNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

               
                Console.Clear()
                Console.WriteLine("\nCALCOLO DELL'IMPOSTA DA VERSARE:\n");
                Console.WriteLine(contribuente);

               
                
                Console.Write("\nVuoi calcolare l'imposta per un altro contribuente? (S/N): ");

                string risposta = Console.ReadLine().ToUpper();

                if (risposta != "S")
                {
                    break; // Esci dal ciclo se la risposta non è "S"
                }
            }

            Console.WriteLine("\nGrazie per aver utilizzato il calcolatore. Arrivederci!");
      

