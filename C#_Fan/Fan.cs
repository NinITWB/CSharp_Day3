namespace FanTask
{
    class Fan
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;

        private int speed;
        public int Speed 
        {
            get {return this.speed;}
            set 
            {
                if (value <= 1) this.speed = SLOW;
                else if (value == 2) this.speed = MEDIUM;
                else this.speed = FAST;
            }
        }

        private bool on;
        public bool On {get {return this.on;} set {this.on = value;}}

        private double radius;
        public double Radius {get {return this.radius;} set {this.radius = value;}}

        private string color;
        public string Color {get {return this.color;} set {this.color = value;}}

        public Fan()
        {
            this.speed = SLOW;
            this.on = false;
            this.radius = 5;
            this.color = "blue";
        }

        public override string ToString()
        {
            if (on) return $"fan is on (Speed: {speed}, color: {this.color}, radius: {this.radius})";
            else return $"fan is off (Color: {this.color}, radius: {this.radius})";
        }



    }
}