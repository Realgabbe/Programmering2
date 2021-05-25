using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace Flappy_Bird_slutprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer(); //Skapar en DispatcherTimer vid namnet gameTimer.

        double score;
        int gravity = 8;
        bool gameOver;
        Rect flappyBirdHitBox;

        /// <summary>
        /// Den här koden körs när programmet startas. 
        /// Den initializerar komponenter.
        /// Den kör MainEventTimer varje gång som gameTimers tick uppdateras.
        /// Den sätter intervallet som gameTimers tick ska uppdateras till 20 millisekunder.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();

        }

        /// <summary>
        /// Denna metod gör så att text versionen av Score doublen innehåller texten "Score: " + värdet av Score doublen.
        /// Denna metod skapar även en hitbox, dvs ett kollisionsområde i form av en rect (Rectangle) för flappyBird bilden och lägger den ovanpå flappyBird bilden.
        /// Denna metod justerar även positionen av flappyBird bildne beroende på värdet av gravity inten och dess nuvarande position.
        /// Denna metoden definerar även de ävre och lägre gränserna för hur högt respektive hur lågt flappyBird bilden får åka innan EndGame metoden körs.
        /// Denna metod justerar även positionen för alla bilder i MyCanvas som har någon av tagsen "obs1", "obs2" eller "obs3" med 5 pixlar mot vänster ifrån dess nuvarande situation.
        /// Om det nya värdet av positionen för en bild som har någon av tagsen "obs1" "obs2" eller "obs3" är under -100 så positioneras dessa bilder vid 800 pixlar ifrån vänsterkanten samt så läggs 0.5 poäng till på värdet av Score doublen.
        /// Metoden skapar även en hitbox, dvs kollisionsområde om en bild har taggen "obs1", "obs2" eller "obs3".
        /// Om detta kollisionsområde korsas med kollisionsområdet för flappyBird bilden så körs metoden EndGame.
        /// Om en String har taggen "cloud" så kommer dess position att flyttas två pixlar till vänster från dess nuvarande position varje gång koden körs.
        /// Och om en string med taggen "cloud" passerar värdet av -250 ifrån vänster alltså, 250 pixlar längre till vänster än den definerade vänstra startpunkten för skärmen så flyttas den till positonen x, 550.
        /// </summary>
        /// <param name="sender">Källan för händelsen är att canvasen MyCanvas.</param>
        /// <param name="e">Det som händer är att Dispatchertimern gameTimer tickar.</param>
        private void MainEventTimer(object sender, EventArgs e)
        {
            txtScore.Content = "Score: " + score;

            flappyBirdHitBox = new Rect(Canvas.GetLeft(flappyBird), Canvas.GetTop(flappyBird), flappyBird.Width, flappyBird.Height);

            Canvas.SetTop(flappyBird, Canvas.GetTop(flappyBird) + gravity);

            if(Canvas.GetTop(flappyBird) < -10 || Canvas.GetTop(flappyBird) > 458)
            {
                EndGame();
            }

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1" || (string)x.Tag == "obs2" || (string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < - 100)
                    {
                        Canvas.SetLeft(x, 800);

                        score +=.5;
                    }

                    Rect pipeHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);
                    
                    if (flappyBirdHitBox.IntersectsWith(pipeHitBox))
                    {
                        EndGame(); 
                    }
                }

                if((string)x.Tag == "cloud")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) -2);

                    if(Canvas.GetLeft(x) < -250)
                    {
                        Canvas.SetLeft(x, 550);
                    }
                }
            }

        }

        /// <summary>
        /// Om knappen "Space" är nedtryckt så renderas flappyBird bilden på ett annorlunda sätt samt att inten gravity sätts till värdet -8.
        /// Om knappen R trycks ned samtidigt som booleanen gameOver är sann så körs metoden StartGame.
        /// </summary>
        /// <param name="sender">Källan för händelsen är canvasen MyCanvas</param>
        /// <param name="e">Den faktiskta händelsen som sker revolverar runt Space knappen & R knappen</param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Space)
            {
                flappyBird.RenderTransform = new RotateTransform(-20, flappyBird.Width / 2, flappyBird.Height / 2);
                gravity = -8;
            }

            if (e.Key == Key.R &&  gameOver == true)
            {
                StartGame();
            }

        }

        /// <summary>
        /// Om en knapp går från att vara nedtryckt till att vara uppe så sätts inten gravity till värdet 8.
        /// </summary>
        /// <param name="sender">Källan för händelsen är canvasen MyCanvas</param>
        /// <param name="e">Den faktiskta händelsen som sker är att en knapp, vilken som helst, går från att vara nedtryckt till att inte vara det.</param>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            flappyBird.RenderTransform = new RotateTransform(5, flappyBird.Width / 2, flappyBird.Height / 2);
            gravity = 8;
        }

        /// <summary>
        /// Denna metod sätter startpositionerna för alla variabler av taggen Image. 
        /// Denna metod sätter även booleanen gameOver till att bli falsk och den startar dispatcherTimern gameTimer.
        /// Metoden nollställer även poängräkningen.
        /// </summary>
        private void StartGame()
        {

            MyCanvas.Focus();

            int temp = 300;

            score = 0;

            gameOver = false;

            Canvas.SetTop(flappyBird, 240);

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if((string)x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                if ((string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                if ((string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }

                if ((string)x.Tag == "cloud")
                {
                    Canvas.SetLeft(x, 300 + temp);
                    temp = 800;
                }

            }

            gameTimer.Start();
            
        }
        
        
        /// <summary>
        /// Denna metod stoppar dispatchertimern gameTimer samt sätter booleanen gameOver till att bli sann.
        /// Denna metoden lägger även till texten " Game over !! Press R to try again" till text versionen av Score doublen vilket är poängräknaren som visas i spelet.
        /// </summary>
        private void EndGame()
        { 
            gameTimer.Stop();
            gameOver = true;
            txtScore.Content += " Game Over !! Press R to try again";
        }

    }

}
