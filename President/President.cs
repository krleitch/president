using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace President
{
    public partial class President : Form
    {

        private Pile pile;
        private DiscardPile discardPile;
        private List<Player> players;

        public President()
        {
            InitializeComponent();
            //Change so that runGame is run from a start button
            runGame();
        }

        private void runGame()
        {
            // Will change to get number of piles from GUI field
            pile = new Pile(1);
            players = new List<Player>();
            discardPile = new DiscardPile();
            players.Add(new Human("Robert"));
            players.Add(new Human("Bobert"));
            players.Add(new Human("Cobert"));
            players.Add(new Human("Dobert"));
            players.Add(new Human("Fobert"));

            //Distributes cards to players then sorts
            while (pile.length() / players.Count() > 0)
            {
                foreach (Player player in players)
                {
                    player.handAddCard(pile.pop());
                }
            }
            foreach (Player player in players)
            {
                player.handSort();
                // Debug
                Console.WriteLine(player.name);
                Console.WriteLine(player.handToString());
            }

            while (true)
            {
                foreach(Player p in players){
                    while (discardPile.push(p.TurnStart())) ;
                    // Need to discuss this more
                }
                //Add logic to break and check for winners
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
