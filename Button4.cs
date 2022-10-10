using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpielBuch
{
    public class Button4
    {
        private Button b2;
        private Button b3;
        private Button b4;
        private Label lab1;
    

        public Button4(Button b2, Button b3, Button b4, Label lab1)
        {
            B2 = b2;
            B3 = b3;
            B4 = b4;
            Lab1 = lab1;
        }

        public Button B2 { get => b2; set => b2 = value; }
        public Button B3 { get => b3; set => b3 = value; }
        public Button B4 { get => b4; set => b4 = value; }
        public Label Lab1 { get => lab1; set => lab1 = value; }

        void liegenBleiben()
        {
            
        }
    }
}
