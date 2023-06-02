namespace Torres_de_hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.OfType<Control>().Where(ctr => ctr is Button).ToList().ForEach(ctr =>
            {
                ctr.MouseDown += Ctr_MouseDown;
                ctr.MouseUp += Ctr_MouseUp;
                ctr.MouseMove += Ctr_MouseMove;
            });
        }
        bool down = false;
        Point inicial;
        int torre1X = 37, torre2X = 336, torre3X = 637;

        //ubicaciones de cubos torre 1
        Point torre1Pos4 = new Point(37, 374);
        Point torre1Pos3 = new Point(37, 317);
        Point torre1Pos2 = new Point(37, 260);
        Point torre1Pos1 = new Point(37, 203);

        //ubicaciones cubos torre 2
        Point torre2Pos4 = new Point(336, 374);
        Point torre2Pos3 = new Point(336, 317);
        Point torre2Pos2 = new Point(336, 260);
        Point torre2Pos1 = new Point(336, 203);

        //ubicaciones cubos torre 3
        Point torre3Pos4 = new Point(637, 374);
        Point torre3Pos3 = new Point(637, 317);
        Point torre3Pos2 = new Point(637, 260);
        Point torre3Pos1 = new Point(637, 203);


        private void Ctr_MouseMove(object? sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;
            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;

            }
        }

        private void Ctr_MouseUp(object? sender, MouseEventArgs e)
        {
            down = false;
            MessageBox.Show("hola");

            acomodar();
        }

        private void acomodar()
        {
            
            if (cubo1.Location.X == torre2X)
            {
                MessageBox.Show("son similareeeees");
                cubo1.Location = torre2Pos4;
            }
        }

        private void Ctr_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = true;
                inicial = e.Location;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //ubicaciones de cubos torre 1
            Point torre1Pos4 = new Point(37, 374);
            Point torre1Pos3 = new Point(37, 317);
            Point torre1Pos2 = new Point(37, 260);
            Point torre1Pos1 = new Point(37, 203);

            //ubicaciones cubos torre 2
            Point torre2Pos4 = new Point(336, 374);
            Point torre2Pos3 = new Point(336, 317);
            Point torre2Pos2 = new Point(336, 260);
            Point torre2Pos1 = new Point(336, 203);

            //ubicaciones cubos torre 3
            Point torre3Pos4 = new Point(637, 374);
            Point torre3Pos3 = new Point(637, 317);
            Point torre3Pos2 = new Point(637, 260);
            Point torre3Pos1 = new Point(637, 203);

            /*if (ubicacionCubo1 != torre1Pos1)
            {
                MessageBox.Show("coinciden");
                
            }*/

            MessageBox.Show("ubicacion 1 " + torre1Pos1);
            //MessageBox.Show("ubicacion 2 " + ubicacionCubo2);
            //MessageBox.Show("ubicacion 3 " + ubicacionCubo3);
            //MessageBox.Show("ubicacion 4 " + ubicacionCubo4);
        }
    }
}