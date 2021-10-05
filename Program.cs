using System;
using System.Collections.Generic;
using A1.ParticleProperties;


namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParticleMovement particleMover = new ParticleMovement();

            while (true)
            {
                Console.WriteLine("Please select a magnetic field/gravitiational field option below from the option numbers below (1-4): ");

                Console.WriteLine("1. Default movement without magnetic or gravitational field");
                Console.WriteLine("2. Just a magnetic field");
                Console.WriteLine("3. Just a gravitational field");
                Console.WriteLine("4. Both a magnetic and gravitational field are present. ");

                char key = Console.ReadKey().KeyChar;

                if (key != '1' && key != '2' && key != '3' && key != '4') break;

                particleMover.MovementRange = GetMovementRange();

                switch (key)
                {
                    case '1':
                        particleMover.MovementRange = ParticleMovement.BASE_MOVEMENT;
                        particleMover.MagneticField = (int)ParticleMovement.MagneticFieldOnOff.Off;
                        particleMover.GravitationalField = (int)ParticleMovement.Gravity.Off;
                        break;

                    case '2':
                        particleMover.GravitationalField = (int)ParticleMovement.Gravity.Off;
                        particleMover.MagneticField = (int)ParticleMovement.MagneticFieldOnOff.On;
                        break;

                    case '3':
                        particleMover.MagneticField = (int)ParticleMovement.MagneticFieldOnOff.Off;
                        particleMover.GravitationalField = (int)ParticleMovement.Gravity.On;
                        break;

                    case '4':
                        particleMover.MagneticField = (int)ParticleMovement.MagneticFieldOnOff.Off;
                        particleMover.GravitationalField = (int)ParticleMovement.Gravity.On;
                        break;
                }

                Console.WriteLine($"\nParticle with a movement range of {particleMover.MovementRange} units" +
                                  $" moved a total distance of {particleMover.DistanceMoved} units.\n");
            }


            /*
            Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in Cardpicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}
            */

            static int GetMovementRange()
            {
                Random random = new Random(1);
                return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            }
        }
    }

    

    public static class SubsequenceFinder
    {
        /// <summary>
        /// Determines whether a list of integers is a subsequence of another list of integers
        /// </summary>
        /// <param name="seq">The main sequence of integers.</param>
        /// <param name="subseq">The potential subsequence.</param>
        /// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
        public static bool IsValidSubsequence(List<int> seq, List<int> subseq)
        {
            int seqId = 0;
            int subseqId = 0;

            while (seqId < seq.Count)
            {
                Console.Write($"({seq[seqId]}, {subseq[subseqId]})");
                if (seq[seqId] == subseq[subseqId])
                {
                    seqId++;
                    subseqId++;
                    if (subseqId == subseq.Count)
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine();
                    seqId -= (subseqId - 1);
                    subseqId = 0;
                }
            }
            return false;
        }
    }

}
