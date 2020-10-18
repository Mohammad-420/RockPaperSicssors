using System;
namespace RockPaperScissors{
    class Program {
        static void Main(string[] args){
            string inputPlayer,inputCPU;
            int randomInt;
            
            bool playAgain = true;

            while(playAgain){

                int scorePlayer = 0;
                int scoreCPU = 0;

                while(scorePlayer < 3 && scoreCPU < 3){

                    Console.Write("Choose between Rock,Paper and Scissors: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1,4);

                    switch(randomInt){
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer choose "+inputCPU);
                            if(inputPlayer == "ROCK"){
                                Console.WriteLine("Draw!!\n\n");
                            }else if(inputPlayer == "PAPER"){
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }else if(inputPlayer == "SCISSORS"){
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer choose "+inputCPU);
                            if(inputPlayer == "ROCK"){
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }else if (inputPlayer == "PAPER"){
                                Console.WriteLine("Draw!!\n\n");
                            }else if(inputPlayer == "SCISSORS"){
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer choose "+inputCPU);
                            if(inputPlayer == "ROCK"){
                                Console.WriteLine("Player Wins!!\n\n");
                                scorePlayer++;
                            }else if(inputPlayer == "PAPER"){
                                Console.WriteLine("CPU Wins!!\n\n");
                                scoreCPU++;
                            }else if(inputPlayer == "SCISSORS"){
                                Console.WriteLine("Draw!!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("invalid choose");
                            break;
                    }

                    Console.WriteLine("\n\nScores:\tPlayer:\t{0}\tCPU:\t{1}",scorePlayer,scoreCPU);
                }

                if(scorePlayer == 3){
                    Console.WriteLine("Player Won!");
                }else if (scoreCPU == 3){
                    Console.WriteLine("CPU Won!");
                }

                Console.WriteLine("Do you want to play again ? (y/n) ");
                string loop = Console.ReadLine();
                if(loop == "y"){
                    playAgain = true;
                } else if (loop == "n"){
                    playAgain = false;
                }
            }
        }
    }
}