using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using System.Drawing.Text;

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
            //MessageBox.Show("hola");
            acomodarEnY();
        }

        private void acomodarEnY()//cambiar el cubo.Location de todos los ifs
        {
            var torre1PosX = (1,50);// 37
            var torre2PosX = (300,370);// 336
            var torre3PosX = (600, 670);// 637


            //acomodar cubo 1
            if (cubo1.Location.X >= torre1PosX.Item1 && cubo1.Location.X <= torre1PosX.Item2)
            {
                //MessageBox.Show("son similareeeees
                acomodarEnXCubo1(1);
            }

            if (cubo1.Location.X >= torre2PosX.Item1 && cubo1.Location.X <= torre2PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                //cubo1.Location = torre2Pos4;
                acomodarEnXCubo1(2);
            }

            if (cubo1.Location.X >= torre3PosX.Item1 && cubo1.Location.X <= torre3PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                //cubo1.Location = torre3Pos4;
                acomodarEnXCubo1(3);
            }
            //no mover lo de arriba
            //acomodar cubo 2
            if (cubo2.Location.X >= torre1PosX.Item1 && cubo2.Location.X <= torre1PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                acomodarEnXCubo2(1);
            }

            if (cubo2.Location.X >= torre2PosX.Item1 && cubo2.Location.X <= torre2PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                acomodarEnXCubo2(2);
            }

            if (cubo2.Location.X >= torre3PosX.Item1 && cubo2.Location.X <= torre3PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                acomodarEnXCubo2(3);
            }

            //acomodar cubo 3
            if (cubo3.Location.X >= torre1PosX.Item1 && cubo3.Location.X <= torre1PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                //cubo3.Location = torre1Pos1;
            }

            if (cubo3.Location.X >= torre2PosX.Item1 && cubo3.Location.X <= torre2PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                //cubo3.Location = torre2Pos4;
            }

            if (cubo3.Location.X >= torre3PosX.Item1 && cubo3.Location.X <= torre3PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                //cubo3.Location = torre3Pos4;
            }

            //acomodar cubo 4
            if (cubo4.Location.X >= torre1PosX.Item1 && cubo4.Location.X <= torre1PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                acomodarEnXCubo4(4);
            }

            if (cubo4.Location.X >= torre2PosX.Item1 && cubo4.Location.X <= torre2PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                acomodarEnXCubo4(2);
            }

            if (cubo4.Location.X >= torre3PosX.Item1 && cubo4.Location.X <= torre3PosX.Item2)
            {
                //MessageBox.Show("son similareeeees");
                acomodarEnXCubo4(3);
            }
        }
        private void acomodarEnXCubo1(int torre) {//c4>>c3>>c2>>c1
            //condiciones cubo 1
            //cubo1 solo verificar que no halla nada debajo de el en las torres para asi ponerse o si hay algo ponerse ahi sin restriccion
            switch (torre)
            {
                case 1:
                    if (cubo2.Location == torre1Pos4 || cubo3.Location == torre1Pos4 || cubo4.Location == torre1Pos4)
                    {

                        if (cubo2.Location == torre1Pos3 || cubo3.Location == torre1Pos3 || cubo4.Location == torre1Pos3)
                        {
                            if (cubo2.Location == torre1Pos2 || cubo3.Location == torre1Pos2 || cubo4.Location == torre1Pos2)
                            {
                                cubo1.Location = torre1Pos1;
                            }
                            else
                            {
                                cubo1.Location = torre1Pos2;
                            }
                        }
                        else
                        {
                            cubo1.Location = torre1Pos3;
                        }
                    }
                    else { 
                        cubo1.Location = torre1Pos4;
                    }

                    break;
                case 2:
                    if (cubo2.Location == torre2Pos4 || cubo3.Location == torre2Pos4 || cubo4.Location == torre2Pos4)
                    {

                        if (cubo2.Location == torre2Pos3 || cubo3.Location == torre2Pos3 || cubo4.Location == torre2Pos3)
                        {
                            if (cubo2.Location == torre2Pos2 || cubo3.Location == torre2Pos2 || cubo4.Location == torre2Pos2)
                            {
                                cubo1.Location = torre2Pos1;
                            }
                            else
                            {
                                cubo1.Location = torre2Pos2;
                            }
                        }
                        else
                        {
                            cubo1.Location = torre2Pos3;
                        }
                    }
                    else
                    {
                        cubo1.Location = torre2Pos4;
                    }

                break;
                case 3:
                    if (cubo2.Location == torre3Pos4 || cubo3.Location == torre3Pos4 || cubo4.Location == torre3Pos4)
                    {

                        if (cubo2.Location == torre3Pos3 || cubo3.Location == torre3Pos3 || cubo4.Location == torre3Pos3)
                        {
                            if (cubo2.Location == torre3Pos2 || cubo3.Location == torre3Pos2 || cubo4.Location == torre3Pos2)
                            {
                                cubo1.Location = torre3Pos1;
                            }
                            else
                            {
                                cubo1.Location = torre3Pos2;
                            }


                        }
                        else
                        {
                            cubo1.Location = torre3Pos3;
                        }
                    }
                    else
                    {
                        cubo1.Location = torre3Pos4;
                    }

                    break;

            }
            //Point torre1Pos4 = new Point(37, 374);
            //Point torre1Pos3 = new Point(37, 317);
            //Point torre1Pos2 = new Point(37, 260);
            //Point torre1Pos1 = new Point(37, 203);
        }

        private void acomodarEnXCubo2(int torre)
        {
            switch(torre) {//recuerda que no puede estar este cubo arriba del 1
                case 1://falta validacion cubo 1

                    if (cubo1.Location == torre1Pos4) {
                        MessageBox.Show("error 2 torre 1");
                        break;
                    } else if (cubo1.Location == torre1Pos3 && cubo2.Location == torre1Pos4) {
                        MessageBox.Show("error 2 torre 1");
                        break;
                    }else if (cubo1.Location == torre1Pos2)
                    {
                        MessageBox.Show("error 2 torre 1 pos 2");
                        break;
                    }

                    if (cubo3.Location == torre1Pos4 || cubo4.Location == torre1Pos4)
                    {

                        if (cubo3.Location == torre1Pos3 || cubo4.Location == torre1Pos3)//cubo4 ya no sube aqui
                        {
                                cubo2.Location = torre1Pos2;
                        }
                        else
                        {
                            cubo2.Location = torre1Pos3;
                        }
                    }
                    else
                    {
                        cubo2.Location = torre1Pos4;
                    }

                    break;
                case 2:
                    if (cubo1.Location == torre2Pos4)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre2Pos3)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre2Pos2)
                    {
                        MessageBox.Show("error");
                        break;
                    }

                    if (cubo3.Location == torre2Pos4 || cubo4.Location == torre2Pos4)
                    {

                        if (cubo3.Location == torre2Pos3 || cubo4.Location == torre2Pos3)//cubo4 ya no sube aqui
                        {
                            cubo2.Location = torre2Pos2;
                        }
                        else
                        {
                            cubo2.Location = torre2Pos3;
                        }
                    }
                    else
                    {
                        cubo2.Location = torre2Pos4;
                    }
                    break;
                case 3:
                    if (cubo1.Location == torre3Pos4)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre3Pos3)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre3Pos2)
                    {
                        MessageBox.Show("error");
                        break;
                    }

                    if (cubo3.Location == torre3Pos4 || cubo4.Location == torre3Pos4)
                    {

                        if (cubo3.Location == torre3Pos3 || cubo4.Location == torre3Pos3)//cubo4 ya no sube aqui
                        {
                            cubo2.Location = torre3Pos2;
                        }
                        else
                        {
                            cubo2.Location = torre3Pos3;
                        }
                    }
                    else
                    {
                        cubo2.Location = torre3Pos4;
                    }
                    break;
            }
        }

        private void acomodarEnXCubo3(int torre)
        {
            switch (torre)
            {//recuerda que no puede estar este cubo arriba del 1
                case 1://falta validacion cubo 1

                    if (cubo1.Location == torre1Pos4)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre1Pos3)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre1Pos2)
                    {
                        MessageBox.Show("error");
                        break;
                    }

                    if (cubo3.Location == torre1Pos4 || cubo4.Location == torre1Pos4)
                    {

                        if (cubo3.Location == torre1Pos3 || cubo4.Location == torre1Pos3)//cubo4 ya no sube aqui
                        {
                            cubo2.Location = torre1Pos2;
                        }
                        else
                        {
                            cubo2.Location = torre1Pos3;
                        }
                    }
                    else
                    {
                        cubo2.Location = torre1Pos4;
                    }

                    break;
                case 2:
                    if (cubo1.Location == torre2Pos4)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre2Pos3)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre2Pos2)
                    {
                        MessageBox.Show("error");
                        break;
                    }

                    if (cubo3.Location == torre2Pos4 || cubo4.Location == torre2Pos4)
                    {

                        if (cubo3.Location == torre2Pos3 || cubo4.Location == torre2Pos3)//cubo4 ya no sube aqui
                        {
                            cubo2.Location = torre2Pos2;
                        }
                        else
                        {
                            cubo2.Location = torre2Pos3;
                        }
                    }
                    else
                    {
                        cubo2.Location = torre2Pos4;
                    }
                    break;
                case 3:
                    if (cubo1.Location == torre3Pos4)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre3Pos3)
                    {
                        MessageBox.Show("error");
                        break;
                    }
                    else if (cubo1.Location == torre3Pos2)
                    {
                        MessageBox.Show("error");
                        break;
                    }

                    if (cubo3.Location == torre3Pos4 || cubo4.Location == torre3Pos4)
                    {

                        if (cubo3.Location == torre3Pos3 || cubo4.Location == torre3Pos3)//cubo4 ya no sube aqui
                        {
                            cubo2.Location = torre3Pos2;
                        }
                        else
                        {
                            cubo2.Location = torre3Pos3;
                        }
                    }
                    else
                    {
                        cubo2.Location = torre3Pos4;
                    }
                    break;
            }
        }

        private void acomodarEnXCubo4(int torre)
        {
            switch (torre)
            {//recuerda que no puede estar este cubo arriba del 1
                case 1://falta validacion cubo 1

                    if (cubo1.Location == torre1Pos4 || cubo2.Location == torre1Pos4 || cubo3.Location == torre1Pos4)
                    {
                        MessageBox.Show("error 4");
                        break;
                    }
                    else
                    {
                        cubo4.Location = torre1Pos4;
                    }

                    break;
                case 2:
                    if (cubo1.Location == torre2Pos4 || cubo2.Location == torre2Pos4 || cubo3.Location == torre2Pos4)
                    {
                        MessageBox.Show("error 4");
                        break;
                    }
                    else
                    {
                        cubo4.Location = torre2Pos4;
                    }
                    break;
                case 3:
                    if (cubo1.Location == torre3Pos4 || cubo2.Location == torre3Pos4 || cubo3.Location == torre3Pos4)
                    {
                        MessageBox.Show("error 4");
                        break;
                    }
                    else
                    {
                        cubo4.Location = torre3Pos4;
                    }
                    break;
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