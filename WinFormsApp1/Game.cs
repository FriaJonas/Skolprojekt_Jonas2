using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Game : Form
    {
        System.Windows.Forms.Timer GameTimer { get; set; } = new System.Windows.Forms.Timer();

        //Heltal som ska hålla reda på poängen
        int p1Points = 0;
        int p2Points = 0;

        //Strängar som ska hålla reda på namnen.... i förlängningen ska vi kunna byta!
        string p1Name = "Spelare 1";
        string p2Name = "Spelare 2";

        //heltal som håller reda på hur stor förflyttningen i pixlar / punkter ska ske över skärmen vid varje uppdatering.
        int speed = 15; //Pixlar som objekten ska röra sig..

        //Heltal som håller reda på riktning X och Y för spelare 1
        int p1XSpeed = 0;
        int p1YSpeed = 0;

        //Heltal som håller reda på riktningen för spelare 2
        int p2XSpeed = 0; 
        int p2YSpeed = 0;

        //Heltal 1 el. 2 vem som har datten 
        int playerTurn=1; //Vid startup blir det 2.an som har datten och 1an kan jaga bollar!
        
        public Game()
        {
            InitializeComponent();
            GameTimer.Tick += new EventHandler(GameUpdate);

            GameTimer.Interval = 100;
            GameTimer.Start();
            lblPlayer1.Text = p1Name;
            lblPlayer2.Text = p2Name;
            ResetGame();
            //SetStyle(ControlStyles.SupportsTransparentBackColor,true);
        }

        private void ResetGame()
        {
            SetPlayerStartPosition();
            SetPlayerTurn();
            p1Points = 0;
            p2Points = 0;
            RandomBallPosition();
        }

        private void RandomBallPosition()
        {
            Random r = new Random();
            Ball.Left= r.Next(100, 800);
            Ball.Top = r.Next(100, 550);
        }

        private void SetPlayerTurn()
        {
            if (playerTurn == 1)
            {
                //Om spelare 1 hade datten - så får nu spelare 2 det
                playerTurn = 2;

                //Vi byter färger på spelarnamnen så att vi vet vem som har datten
                lblPlayer1.ForeColor = System.Drawing.Color.White;
                lblPlayer2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                //Annars får spelare 1 datten.
                playerTurn = 1;
                //vi byter lite färger igen
                lblPlayer1.ForeColor = System.Drawing.Color.Red;
                lblPlayer2.ForeColor = System.Drawing.Color.White;
            }
        }
        private void SetPlayerStartPosition()
        {
            //Sätter kordinaterna för spelare 1 (pixlar från toppen och vänster)
            Player1.Left = 30;
            Player1.Top = 100;
            
            //För spelare 2
            Player2.Left = 830;
            Player2.Top = 100;

            //Sätter även hastigheterna till 0
            p1XSpeed = 0;
            p1YSpeed = 0;

            //Heltal som håller reda på riktningen för spelare 2
            p2XSpeed = 0;
            p2YSpeed = 0;
        }

        private void GameUpdate(Object myObject, EventArgs myEventArgs)
        {
            //Uppdatera spelare 1
            Player1.Top += p1YSpeed;
            Player1.Left += p1XSpeed;

            //Uppdatera spelare 2
            Player2.Top += p2YSpeed;
            Player2.Left += p2XSpeed;

            //Om spelarna rör varandra
            if (Player1.Bounds.IntersectsWith(Player2.Bounds))
            {
                //Nu ska datten gå över till den andra
                SetPlayerTurn();

                //Vi anropar funktionen som återställer positionerna vid krock
                SetPlayerStartPosition();
            }
            if (Player1.Bounds.IntersectsWith(Ball.Bounds))
            {
                //Om spelare 1 rör vid bollen
                if(playerTurn != 1)
                {
                    //Om spelare 1 inte har datten så får vi poäng!!
                    p1Points += 1;
                    
                }
                else
                {
                    //Annars får vi minuspoäng!!!
                    p1Points -= 1;
                }

                //Skriver ut poängen för spelare 1
                lblPlayer1Points.Text = p1Points.ToString();

                //Anropar funktionen för att slumpa ny position för bollen
                RandomBallPosition();
            }
            if (Player2.Bounds.IntersectsWith(Ball.Bounds))
            {
                //Om spelare 1 rör vid bollen
                if (playerTurn != 2)
                {
                    //Om spelare 1 inte har datten så får vi poäng!!
                    p2Points += 1;

                }
                else
                {
                    //Annars får vi minuspoäng!!!
                    p2Points -= 1;
                }

                //Skriver ut poängen för spelare 2
                lblPlayer2Points.Text = p2Points.ToString();

                //Anropar funktionen för att slumpa ny position för bollen
                RandomBallPosition();
            }
            //Till sist kollar vi om ngn vunnit
            CheckWinner();
        }

        private void CheckWinner()
        {
            if (p1Points == 5)
            {
                //Börjar med att stoppa timern så att spelet inte fortsätter loopa
                GameTimer.Stop();
                MessageBox.Show("Grattis spelare " + p1Name + " - du vann!!");
                
            }
            else if (p2Points == 5)
            {
                //Börjar med att stoppa timern så att spelet inte fortsätter loopa
                GameTimer.Stop();
                MessageBox.Show("Grattis spelare " + p2Name + " - du vann!!");
                
            }
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            //kollar spelare 1
            
            if(e.KeyCode == Keys.A )
            {
                p1XSpeed = -speed;
                p1YSpeed = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                p1XSpeed = speed;
                p1YSpeed = 0;
            }
            else if (e.KeyCode == Keys.W)
            {
                p1YSpeed = -speed;
                p1XSpeed = 0;
            }
            else if (e.KeyCode == Keys.Z)
            {
                p1YSpeed = speed;
                p1XSpeed = 0;
            }

            //vi kollar även spelare 2.s tangenter
            if (e.KeyCode == Keys.J)
            {
                p2XSpeed = -speed;
                p2YSpeed = 0;
            }
            else if (e.KeyCode == Keys.K)
            {
                p2XSpeed = speed;
                p2YSpeed = 0;
            }
            else if (e.KeyCode == Keys.I)
            {
                p2YSpeed = -speed;
                p2XSpeed = 0;
            }
            else if (e.KeyCode == Keys.M)
            {
                p2YSpeed = speed;
                p2XSpeed = 0;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
