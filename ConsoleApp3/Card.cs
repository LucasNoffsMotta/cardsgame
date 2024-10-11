using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    internal class Card
    {
        public int suitValue;
        public string suitName;
        public int numberValue;
        public string numberName;

        public Card(string csuit, int cnumber)
        {
            suitName = csuit;
            setSuit(csuit);
            numberValue = cnumber;
            setNumberName();
        }



        private void setSuit(string csuit)
        {
            switch (csuit)
            {
                case "Espadas":
                    suitValue = 1;
                    break;

                case "Copas":
                    suitValue = 2;
                    break;

                case "Ouros":
                    suitValue = 3;
                    break;

                case "Paus":
                    suitValue = 4;
                    break;

                default:
                    suitValue = 1;
                    break;
            }
        }

        private void setNumberName()
        {

            if (numberValue >= 2 && numberValue <= 10)
            {
                numberName = Convert.ToString(numberValue);                    
            }
            else
            {
                switch(numberValue)
                {
                    case 11:
                        numberName = "Valete";
                        break;
                    case 12:
                        numberName = "Dama";
                        break;
                    case 13:
                        numberName = "Rei";
                        break;
                    case 14:
                        numberName = "As";
                        break;
                }
            }
        }


        public void prettyPrint()
        {
            Console.WriteLine("Card: " + numberName);
            Console.WriteLine("Naipe: " + suitName);
            
            
        }


    }
}
