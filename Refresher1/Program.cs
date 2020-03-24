using System;


namespace BuildASynth
{
    class Program
    {
        static void Main()
        {

            /*FakeVST or Build -A- Synth Modular V.1.0. T.Scott George. Main portfolio piece in CSharp
             Building VST aka Vurtual Instrument in this case a Synthesizer.
             A user can pick different moduals for a modular Synth, Oscilators, reverbs, filters, etc.

             The choices can be stored in a text file.
             */
            string OCSs, FLTs, Revb, CHOR, DLY, GRNDLY, DIST, SEQ, CHSNM;

            //List of muduals available. Probably can be done with fewer linse of code. More work to be done on this.
            Console.WriteLine("Pick some OSCs: ");
            OCSs = Console.ReadLine();
            String Result = Console.ReadLine();

            int oscillators;

            
            bool isOscillatorsValid = false;
            while (!isOscillatorsValid)
            {
                OCSs = Console.ReadLine();
                if (!int.TryParse(OCSs, out oscillators))
                {
                    Console.WriteLine("Not a valid option, try again.");
                    continue;
                }
                if (oscillators >= 5)
                {
                    Console.WriteLine("Please choose fewer");
                    continue;
                }
                isOscillatorsValid = true;
            }

            Console.WriteLine("Pick some Filters: ");
            FLTs = Console.ReadLine();

            Console.WriteLine("Pick a Reverb: ");
            Revb = Console.ReadLine();

            Console.WriteLine("Pick a Chorus: ");
            CHOR = Console.ReadLine();

            Console.WriteLine("Pick a Delay: ");
            DLY = Console.ReadLine();

            Console.WriteLine("Pick a Garanulatr Delay: ");
            GRNDLY = Console.ReadLine();

            Console.WriteLine("Pick some Distortion: ");
            DIST = Console.ReadLine();

            Console.WriteLine("Pick a Sequencer: ");
            SEQ = Console.ReadLine();

            Console.WriteLine("Please choose a name for your new Synth!: ");
            CHSNM = Console.ReadLine();



            Console.WriteLine("Thanks! Your new synth is ready to buy! Please depost $2.2MILLION DOLLARS!");

            //This line was shortend to one line from multiple lines, mostly from memory and what seemed to make sense. This is to simply document my progress in memorizing.
            Console.WriteLine("OCS" + OCSs, "FLTs" + FLTs, "Revb" + Revb, "CHOR" + CHOR, "DLY" + DLY, "GRNDLY" + GRNDLY, "DIST" + DIST, "SEQ" + SEQ, "CHSNM" + CHSNM);

            Console.ReadLine();
        }
    }
}
