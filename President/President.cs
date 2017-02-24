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
        private List<Player> players;

        public President()
        {
            InitializeComponent();
            pile = new Pile(1);
            players = new List<Player>();
            players.Add(new Human("Robert"));
            players.Add(new Human("Bobert"));
            players.Add(new Human("Cobert"));
            players.Add(new Human("Dobert"));
            players.Add(new Human("Fobert"));

            //Console.WriteLine(pile.ToString());
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
                Console.WriteLine(player.name);
                Console.WriteLine(player.handToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
