namespace SpielBuch
{
    public partial class Form1 : Form
    {
        public static int counter = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            label1.Text = "Georg wacht auf.";
            label2.Text = "";
            button2.Text = "eine rauchen";
            button3.Text = "nach dem Einstein suchen";
            button4.Text = "liegen bleiben";
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (counter==0)
            {
                //C1 eine rauchen
                label1.Text = "Georg steht auf dem Balkon und raucht.";
                button2.Text = "in die Ferne schauen";
                button3.Text = "sich am Hintern kratzen";
                button4.Visible = false;
                counter=200;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter==200 || counter==202)
            {
                //C2 in die Ferne schauen
                label1.Text = "Georg sieht einen McDonalds in der Ferne.";
                button2.Text = "Interessant!";
                button3.Visible = false;
                button4.Visible = false;
                counter=201;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter==201)
            {
                //C3 Interessant
                label1.Text = "Dabei spürt er, dass er Hunger hat.";
                button2.Text = "in die Küche gehen";
                button3.Text = "sich einen Lieferservice aussuchen";
                button4.Text = "in den Flur gehen";
                button3.Visible = true;
                button4.Visible = true;
                counter=250;
                label2.Text = $"Counter= {counter}";

            }else if (counter == 250)
            {
                //C4 in die Küche gehen
                label1.Text = "Die Küche ist leergeräumt.";
                button2.Text = "Einstein beschuldigen";
                button3.Text = "einen Ausweg finden";
                button4.Visible = false;
                counter=400;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter==400)
            {
                //C5 Einstein beschuldigen
                label1.Text = "Georg findet Einstein im leeren Kühlschrank.";
                button2.Text = "nach einen Lieferservice schauen";
                button3.Visible = false;
                button4.Visible = false;
                counter=500;
                label2.Text = $"Counter= {counter}";

            }
            else if (counter==500)
            {
                //C6 nach einem Lieferservice schauen
                label1.Text = "Georg bestellt beim McDonalds drei BigMacs für sich \nund einen HappyMeal für den Einstein.";
                button2.Text = "Ende!";
                button3.Visible = false;
                button4.Visible = false;
                counter=600;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter==600)
            {
                //C7 Ende
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (counter==0)
            {
                //C1 Nach dem Einstein suchen
                label1.Text = "Einstein ist nicht im Käfig.";
                button4.Text = "unter dem Bett suchen";
                button3.Text = "Nach Draussen gehen";
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = true;
                counter=100;
                label2.Text = $"Counter= {counter}";

            }
            else if (counter == 100)
            {
                //C2 nach Draussen gehen
                label1.Text = "Georg steht auf dem Balkon und raucht.";
                button2.Text = "in die Ferne schauen";
                button3.Text = "sich am Hintern kratzen";
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                counter=202;
                label2.Text = $"Counter= {counter}";
            } else if (counter == 202 || counter==200)
            {
                //C3 sich am Hintern kratzen
                label1.Text = "Dabei spürt er, dass er Hunger hat.";
                button2.Text = "in die Küche gehen";
                button3.Text = "sich einen Lieferservice aussuchen";
                button4.Text = "in den Flur gehen";
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                counter=250;
                label2.Text = $"Counter= {counter}";
            }else if (counter == 250)
            {
                //C4 sich einen Lieferservice aussuchen
                label1.Text = "Georg sieht mehrere Nachrichten auf seinem Handy.";
                button2.Text = "sich einen Lieferservice aussuchen";
                button4.Text = "sich die Nachrichten anschauen";
                button3.Visible = false;
                button2.Visible = true;
                button4.Visible = true;
                counter=500;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter==400)
            {//C4 Ausweg finden
                label1.Text = "Georg bestellt beim McDonalds drei BigMacs für sich \nund einen HappyMeal für den Einstein.";
                button2.Text = "Ende!";
                button3.Visible = false;
                button4.Visible = false;
                counter = 600;
                label2.Text = $"Counter= {counter}";
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
           
            if (counter==0)
            { 
                //C1 liegen bleiben
                label1.Text = "-Wie toll doch Firma Microsoft sei. \ndenkt sich Georg."; //??
                button2.Visible = false;
                button3.Visible = false;
                counter=600;
                label2.Text = $"Counter= {counter}";
                button4.Text = "In der Tat!";
            }
            else if (counter==600)
            {
                //C2 In der Tat!
                label1.Text = "Gratulation! \nDu hast das Spiel durchgespielt!\r\nDu bist ein toller Typ.\r\nDein Freund Bill.";
                button4.Text = "Ende!";
                counter=700;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter == 700) 
            {  
                //C3 Ende
                Thread.Sleep(3000);
                Environment.Exit(0);

            }else if (counter == 201)
            {
                //C4 unter dem Bett suchen
                label1.Text = "Dabei spürt er, dass er Hunger hat.";
                button2.Text = "in die Küche gehen";
                button3.Text = "sich einen Lieferservice aussuchen";
                button4.Text = "in den Flur gehen";
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                counter=250;
                label2.Text = $"Counter= {counter}";

            }else if (counter == 250)
            {
                //C5 geht in den Flur
                label1.Text = "-Wo ist der Einstein. \n denkt er sich.";
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button4.Text = "nach dem Einstein suchen";
                counter=300;
                label2.Text = $"Counter= {counter}";
            }
            else if (counter==300)
            {
                //C6 nach dem Einstein suchen
                label1.Text = "-Möglicherweise in der Küche?";
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button2.Text = "in die Küche gehen";
                counter=250;
                label2.Text = $"Counter= {counter}";

            }
            else if (counter==500)
            {
                label1.Text = "Die neuen Nachrichten von Ilyass.\nNeue Fotos, die er mit seinem neuen Galaxy S23 Pro Extra Ultra Max gemacht hat.";
                button2.Text = "sich einen Lieferservice aussuchen";
                button3.Visible = false;
                button2.Visible = true;
                button4.Visible = false;
                counter=500;
                label2.Text = $"Counter= {counter}";
            }

        }
    }
}