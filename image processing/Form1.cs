using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color_original, color_converted;
        int R = 0, G = 0, B = 0;

        


        private void Form1_Load(object sender, EventArgs e)
        {
            //görüntüyü okuma 
            Bitmap bmp = new Bitmap("D:\\Lenna.png");


            pB_original.Image = Image.FromFile("D:\\Lenna.png");

            txt_x1.Text = "24"; txt_x2.Text = "362"; txt_x3.Text = "17"; txt_x4.Text = "338";
            txt_y1.Text = "73"; txt_y2.Text = "55"; txt_y3.Text = "130"; txt_y4.Text = "177";
            txt_XX1.Text = "0"; txt_XX2.Text = "361"; txt_XX3.Text = "0"; txt_XX4.Text = "362";
            txt_YY1.Text = "48"; txt_YY2.Text = "44"; txt_YY3.Text = "190"; txt_YY4.Text = "190";
            textBox1.Text = "30";




        }
        void setgreyscale()
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            //x ve y ekseni alma
            int width = bmp.Width;
            int height = bmp.Height;

            //pixel rengi 
            Color p;

            //griye dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ort bulma 
                    int ort = (r + g + b) / 3;

                    //yeni değerli girme
                    bmp.SetPixel(x, y, Color.FromArgb(a, ort, ort, ort));



                }
            }

            //pb_converte yükleme
            pB_convert.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            //x ve y ekseni alma
            int width = bmp.Width;
            int height = bmp.Height;

            //pixel rengi 
            Color p;

            //griye dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ort bulma 
                    int ort = (r + g + b) / 3;

                    //yeni değerli girme
                    bmp.SetPixel(x, y, Color.FromArgb(a, ort, ort, ort));



                }
            }

            //pb_converte yükleme
            pB_convert.Image = bmp;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void rgb(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(("D:\\Lenna.png"));
            int width = bmp.Width;
            int height = bmp.Height;

            // yeşil mavi kırmızı bitmap
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //kırmızı yapma 
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //yeşil yapma
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //mavi yapma
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                    pB_convert.Image = rbmp;



                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(("D:\\Lenna.png"));
            int width = bmp.Width;
            int height = bmp.Height;

            // yeşil mavi kırmızı bitmap
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //kırmızı yapma 
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //yeşil yapma
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //mavi yapma
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                    pB_convert.Image = gbmp;

                }
            }
        }






        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(("D:\\Lenna.png"));
            int width = bmp.Width;
            int height = bmp.Height;

            // yeşil mavi kırmızı bitmap
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //kırmızı yapma 
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //yeşil yapma
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //mavi yapma
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                    pB_convert.Image = bbmp;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap nbmp = new Bitmap(("D:\\Lenna.png"));
            int width = nbmp.Width;
            int height = nbmp.Height;


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = nbmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    //negatif değeri bulma
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;


                    nbmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));


                }
            }

            pB_convert.Image = nbmp;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            //x ve y ekseni alma
            int width = bmp.Width;
            int height = bmp.Height;

            //pixel rengi 
            Color p;

            //griye dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ort bulma 
                    int ort = (r + g + b) / 3;

                    //yeni değerli girme

                    bmp.SetPixel(x, y, Color.FromArgb(a = 0, r, g, b));





                }
            }

            //pb_converte yükleme
            pB_convert.Image = bmp;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            int width = bmp.Width;
            int height = bmp.Height;



            Color c;
            int a, r, g, b;
            int anti_color;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir değer giriniz", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                anti_color = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        r = c.R + anti_color;
                        if (r > 255) r = 255;
                        g = c.R + anti_color;
                        if (g > 255) g = 255;
                        b = c.R + anti_color;
                        if (b > 255) b = 255;
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b));






                    }

                }
                pB_convert.Image = bmp;
            }
        }

        private void contrast_set_Click(object sender, EventArgs e)
        {
            Bitmap contrast_bmp = new Bitmap("D:\\Lenna.png");
            int width = contrast_bmp.Width;
            int height = contrast_bmp.Height;

            if (textBox1.Text == "")
                MessageBox.Show("Lütfen değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                double C_contrastLevel = Convert.ToInt32(textBox1.Text);
                double F_contrastFactor = (259 * (C_contrastLevel + 255)) / (255 * (259 -
                C_contrastLevel));
                for(int x = 0;x<width;x++)
                {
                    for(int y = 0;y<height;y++)
                    {
                        color_original = contrast_bmp.GetPixel(x, y);
                        R = color_original.R;
                        G = color_original.G;
                        B = color_original.B;
                        R = (int)((F_contrastFactor * (R - 128)) + 128);
                        G = (int)((F_contrastFactor * (G - 128)) + 128);
                        B = (int)((F_contrastFactor * (B - 128)) + 128);

                        //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;

                        color_converted = Color.FromArgb(R, G, B);
                        contrast_bmp.SetPixel(x, y, color_converted);

                    }
                }
                pB_convert.Image = contrast_bmp;
            }
        }

        private void contrast_stretch_Click(object sender, EventArgs e)
        {
            Bitmap contrast_bmp = new Bitmap("D:\\Lenna.png");
            int width = contrast_bmp.Width;
            int height = contrast_bmp.Height;

            textBox1.Text = "0"; textBox2.Text = "250"; textBox3.Text = "0"; textBox4.Text = "255";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Lütfen değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int X1 = Convert.ToInt16(textBox1.Text);
                int X2 = Convert.ToInt16(textBox2.Text);
                int Y1 = Convert.ToInt16(textBox3.Text);
                int Y2 = Convert.ToInt16(textBox4.Text);
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color_original = contrast_bmp.GetPixel(x, y);
                    R = color_original.R;
                    G = color_original.G;
                    B = color_original.B;
                    int gray = (R + G + B) / 3;

                    int X = gray;
                    //int Y = ((((X - X1) * Y2 - Y1)) / (X2 - X1)) + Y1;
                    //if (Y > 255) Y = 255;
                    //if (Y < 0) Y = 0;
                    //color_converted = Color.FromArgb(Y, Y, Y);
                    contrast_bmp.SetPixel(x, y, color_converted);

                }
            }

        }

        private void bugauss_filter_Click(object sender, EventArgs e)
        {
            Bitmap gauss_bmp = new Bitmap("D:\\Lenna.png");
            int width = gauss_bmp.Width;
            int height = gauss_bmp.Height;

            int SablonBoyutu = 5; //Çekirdek matrisin boyutu
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            int[] Matris = { 1, 4, 7, 4, 1, 4, 20, 33, 20, 4, 7, 33, 55, 33, 7, 4, 20, 33, 20, 4, 1, 4, 7, 4, 1 };
            int MatrisToplami = 1 + 4 + 7 + 4 + 1 + 4 + 20 + 33 + 20 + 4 + 7 + 33 + 55 + 33 + 7 + 4 + 20 + 33 + 20 + 4 + 1 + 4 + 7 + 4 + 1;
            for (x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            color_original = gauss_bmp.GetPixel(x + i, y + j);
                            toplamR = toplamR + color_original.R * Matris[k];
                            toplamG = toplamG + color_original.G * Matris[k];
                            toplamB = toplamB + color_original.B * Matris[k];
                            k++;
                        }
                        ortalamaR = toplamR / MatrisToplami;
                        ortalamaG = toplamG / MatrisToplami;
                        ortalamaB = toplamB / MatrisToplami;
                        gauss_bmp.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                    }
                }
            }
            pB_convert.Image = gauss_bmp;
        }

        private void mean_filter_Click(object sender, EventArgs e)
        {
            Bitmap mean_bmp = new Bitmap("D:\\Lenna.png");
            int width = mean_bmp.Width;
            int height = mean_bmp.Height;


            int SablonBoyutu = 5; //şablon boyutu 3 den büyük tek rakam olmalıdır(3, 5, 7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            for (x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            color_original = mean_bmp.GetPixel(x + i, y + j);
                            toplamR = toplamR + color_original.R;
                            toplamG = toplamG + color_original.G;
                            toplamB = toplamB + color_original.B;
                        }
                    }
                    ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                    ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                    ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);
                    mean_bmp.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }
            pB_convert.Image = mean_bmp;
        }

        private void Laplacian_filter_Click(object sender, EventArgs e)
        {
            Bitmap laplacian_bmp = new Bitmap("D:\\Lenna.png");
            int width = laplacian_bmp.Width -1;
            int height = laplacian_bmp.Height -1;

            Bitmap exit_bmp = new Bitmap(laplacian_bmp);

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    Color color2, color4, color5, color6, color8;
                    color2 = laplacian_bmp.GetPixel(x, y - 1);
                    color4 = laplacian_bmp.GetPixel(x - 1, y);
                    color5 = laplacian_bmp.GetPixel(x, y);
                    color6 = laplacian_bmp.GetPixel(x + 1, y);
                    color8 = laplacian_bmp.GetPixel(x, y + 1);
                    int r = (color2.R + color4.R + color5.R * (-4)) + color6.R + color8.R;
                    int g = (color2.G + color4.G + color5.G * (-4)) + color6.G + color8.G;
                    int b = (color2.B + color4.B + color5.B * (-4)) + color6.B + color8.B;

                    int avg = ((r + g + b) / 3);
                    if (avg > 255) avg = 255;
                    if (avg < 0) avg = 0;
                    exit_bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));

                }

            }
            pB_convert.Image =exit_bmp;
        }

        private void Graident_filter_Click(object sender, EventArgs e)
        {
            Bitmap gradient_bmp = new Bitmap("D:\\Lenna.png");
            int width = gradient_bmp.Width;
            int height = gradient_bmp.Height;

            Color renk;
            int r, g, b;
            int gray;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    renk = gradient_bmp.GetPixel(x, y);
                    r = Convert.ToInt32(renk.R);
                    g = Convert.ToInt32(renk.G);
                    b = Convert.ToInt32(renk.B);

                    gray = (r + g + b) / 3;
                    gradient_bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            
            int gradient;
            Color cl;
            int x1, x2, x3, x4;
            int b1, b2, b3, b4;
            x1 = -1; x2 = 1; x3 = -1; x4 = 1;
            for (int x = 1; x < width-1; x++)
            {
                for (int y = 1; y < height-1; y++)
                {
                    cl = gradient_bmp.GetPixel(x, y);
                    b1 = cl.R;
                    cl = gradient_bmp.GetPixel(x + 1, y);
                    b2 = cl.R;
                    cl = gradient_bmp.GetPixel(x, y + 1);
                    b3 = cl.R;
                    cl = gradient_bmp.GetPixel(x + 1, y + 1);
                    b4 = cl.R;
                    gradient = x1 * b1 + x2 * b2 + x3 * b3 + x4 * b4;
                    if (gradient > 255) gradient = 255;
                    if (gradient < 0) gradient = 0;
                    gradient_bmp.SetPixel(x, y, Color.FromArgb(gradient, gradient, gradient));
                }
            }
            pB_convert.Image = gradient_bmp;
        }

        private void Sobel_filter_Click(object sender, EventArgs e)
        {
            Bitmap sobel_bmp = new Bitmap("D:\\Lenna.png");
            int width = sobel_bmp.Width;
            int height = sobel_bmp.Height;

            Bitmap ExitPictureXY;
            //resim = new Bitmap(pictureBox1.Image);
            ExitPictureXY = new Bitmap(width, height);

            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = sobel_bmp.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = sobel_bmp.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;


                    int Gx = Math.Abs(-P1 + P3 - 2 * P4 + 2 * P6 - P7 + P9);
                    int Gy = Math.Abs(P1 + 2 * P2 + P3 - P7 - 2 * P8 - P9);
                    int Gxy = Gx + Gy;
                    if (Gx > 255) Gx = 255;
                    if (Gy > 255) Gy = 255;
                    if (Gxy > 255) Gxy = 255;
                    ExitPictureXY.SetPixel(x, y, Color.FromArgb(Gxy, Gxy, Gxy));
                }
            }
            pB_convert.Image = ExitPictureXY;
        }

        private void angle_rotation_Click(object sender, EventArgs e)
        {
            Bitmap angle_bmp = new Bitmap("D:\\Lenna.png");
            int width = angle_bmp.Width;
            int height = angle_bmp.Height;
            Bitmap exit_bmp = new Bitmap(width,height);

            if (textBox1.Text == "")
                MessageBox.Show("Lütfen değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int Aci = Convert.ToInt16(textBox1.Text);
                double RadyanAci = Aci * 2 * Math.PI / 360;
                double x2 = 0, y2 = 0;
                //Resim merkezini buluyor. Resim merkezi etrafında döndürecek.
                int x0 = width / 2;
                int y0 = height / 2;
                for (int x1 = 0; x1 < (width); x1++)
                {
                    for (int y1 = 0; y1 < (height); y1++)
                    {
                        color_original = angle_bmp.GetPixel(x1, y1);
                        //Döndürme Formülleri
                        x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                        y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;
                        if (x2 > 0 && x2 < width && y2 > 0 && y2 < height)
                            exit_bmp.SetPixel((int)x2, (int)y2,color_original);
                    }
                }
                pB_convert.Image = exit_bmp;
            }
        }

        private void mirroring_Click(object sender, EventArgs e)
        {

            Bitmap mirror_bmp = new Bitmap("D:\\Lenna.png");
            int width = mirror_bmp.Width;
            int height = mirror_bmp.Height;
            Bitmap exit_bmp = new Bitmap(width * 2, height);

            for (int y = 0; y < width; y++)
            {
                for (int lx = 0, rx = height * 2 - 1; lx < height; lx++, rx--)
                {
                    //get source pixel value
                    Color p = mirror_bmp.GetPixel(lx, y);

                    //set mirror pixel value
                    exit_bmp.SetPixel(lx, y, p);
                    exit_bmp.SetPixel(rx, y, p);
                }
            }
            pB_convert.Image = exit_bmp;
            pB_convert.Width = 1200;
            pB_convert.Height = 600;
            
           
        }

        private void Zooming_Click(object sender, EventArgs e)
        {
            Bitmap zoom_bmp = new Bitmap("D:\\Lenna.png");
            int width = zoom_bmp.Width;
            int height = zoom_bmp.Height;

            pB_convert.SizeMode = PictureBoxSizeMode.Normal;
            Size size = new Size(100, 100);
            Bitmap exit_bmp = new Bitmap(zoom_bmp, zoom_bmp.Width + (zoom_bmp.Width * size.Width / 100), zoom_bmp.Height + (zoom_bmp.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(exit_bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pB_convert.Image = exit_bmp;
            

        }

        private void Reversing_Click(object sender, EventArgs e)
        {
            Bitmap reverse_bmp = new Bitmap("D:\\Lenna.png");
            int width = reverse_bmp.Width;
            int height = reverse_bmp.Height;

            Bitmap exit_bmp = new Bitmap(pB_original.Image);
            exit_bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pB_convert.Image = exit_bmp;
        }

        private void Moving_Click(object sender, EventArgs e)
        {

            Bitmap move_bmp = new Bitmap("D:\\Lenna.png");
            int width = move_bmp.Width;
            int height = move_bmp.Height;

            Bitmap exit_bmp = new Bitmap(width, height);
            double x2 = 0, y2 = 0;
            //Taşıma mesafelerini atıyor.
            int Tx = 100;
            int Ty = 50;
            for (int x1 = 0; x1 < (width); x1++)
            {
                for (int y1 = 0; y1 < (height); y1++)
                {
                    color_original = move_bmp.GetPixel(x1, y1);
                    x2 = x1 + Tx;
                    y2 = y1 + Ty;
                    if (x2 > 0 && x2 < width && y2 > 0 && y2 < height)
                        exit_bmp.SetPixel((int)x2, (int)y2, color_original);
                }
            }
            pB_convert.Image = exit_bmp;
        }

        private void Removing_Click(object sender, EventArgs e)
        {
            Bitmap remove_bmp = new Bitmap("D:\\Lenna.png");
            int width = remove_bmp.Width;
            int height = remove_bmp.Height;

            Bitmap exit_bmp = new Bitmap(width, height);
            int x2 = 0, y2 = 0; //Çıkış resminin x ve y si olacak.
            int KucultmeKatsayisi = 2;
            for (int x1 = 0; x1 < width; x1 = x1 + KucultmeKatsayisi)
            {
                y2 = 0;
                for (int y1 = 0; y1 < height; y1 = y1 + KucultmeKatsayisi)
                {
                    color_original = remove_bmp.GetPixel(x1, y1);
                    color_converted = color_original;
                    exit_bmp.SetPixel(x2, y2, color_converted);
                    y2++;
                }
                x2++;
            }
            pB_convert.Image = exit_bmp;
        }

        private void Morphology_Click(object sender, EventArgs e)
        {
            Bitmap morf_bmp = new Bitmap("D:\\Lenna.png");
            int width = morf_bmp.Width;
            int height = morf_bmp.Height;

            double bit = 0;
            for (int y = 0; y < morf_bmp.Height; y++)
            {
                for (int x = 0; x < morf_bmp.Width; x++)
                {
                    bit += morf_bmp.GetPixel(x, y).GetBrightness();
                }
            }

            bit = bit / (morf_bmp.Width * morf_bmp.Height);
            bit = bit < .3 ? .3 : bit;
            bit = bit > .7 ? .7 : bit;

            for (int y = 0; y < morf_bmp.Height; y++)
            {
                for (int x = 0; x < morf_bmp.Width; x++)
                {
                    if (morf_bmp.GetPixel(x, y).GetBrightness() > bit) morf_bmp.SetPixel(x, y, Color.White);
                    else morf_bmp.SetPixel(x, y, Color.Black);
                }
            }
            pB_original.Image = morf_bmp;
            //morf_bmp.Save("D:\\Lenna_morph.png");
        }

        private void Dilation_Click(object sender, EventArgs e)
        {

            Bitmap morf_bmp = new Bitmap("D:\\Lenna.png");
            int width = morf_bmp.Width;
            int height = morf_bmp.Height;

            double bit = 0;
            for (int y = 0; y < morf_bmp.Height; y++)
            {
                for (int x = 0; x < morf_bmp.Width; x++)
                {
                    bit += morf_bmp.GetPixel(x, y).GetBrightness();
                }
            }

            bit = bit / (morf_bmp.Width * morf_bmp.Height);
            bit = bit < .3 ? .3 : bit;
            bit = bit > .7 ? .7 : bit;

            for (int y = 0; y < morf_bmp.Height; y++)
            {
                for (int x = 0; x < morf_bmp.Width; x++)
                {
                    if (morf_bmp.GetPixel(x, y).GetBrightness() > bit) morf_bmp.SetPixel(x, y, Color.White);
                    else morf_bmp.SetPixel(x, y, Color.Black);
                }
            }
            pB_original.Image = morf_bmp;

            Bitmap Dil_bmp = new Bitmap(morf_bmp);
            int dilwidth = Dil_bmp.Width;
            int dilheight = Dil_bmp.Height;

            Bitmap exit_bmp = new Bitmap(Dil_bmp);

            int x1 = 255, x2 = 255, x3 = 255;
            Color c;
            int b1, b2, b3;
            for (int y = 1; y < dilheight - 1; y++)
            {
                for (int x = 1; x < dilwidth - 1; x++)
                {
                    c = Dil_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = Dil_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = Dil_bmp.GetPixel(x + 1, y);
                    b3 = c.R;

                    if (b1 == x1 & b2 == x2 & b3 == x3)
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            pB_convert.Image = exit_bmp;
           


        }

        private void Erosion_Click(object sender, EventArgs e)
        {

            Bitmap morf_bmp = new Bitmap("D:\\Lenna.png");
            int width = morf_bmp.Width;
            int height = morf_bmp.Height;

            double bit = 0;
            for (int y = 0; y < morf_bmp.Height; y++)
            {
                for (int x = 0; x < morf_bmp.Width; x++)
                {
                    bit += morf_bmp.GetPixel(x, y).GetBrightness();
                }
            }

            bit = bit / (morf_bmp.Width * morf_bmp.Height);
            bit = bit < .3 ? .3 : bit;
            bit = bit > .7 ? .7 : bit;

            for (int y = 0; y < morf_bmp.Height; y++)
            {
                for (int x = 0; x < morf_bmp.Width; x++)
                {
                    if (morf_bmp.GetPixel(x, y).GetBrightness() > bit) morf_bmp.SetPixel(x, y, Color.White);
                    else morf_bmp.SetPixel(x, y, Color.Black);
                }
            }
            pB_original.Image = morf_bmp;

            Bitmap er_bmp = new Bitmap(morf_bmp);
            int erwidth = er_bmp.Width;
            int erheight = er_bmp.Height;
            Bitmap exit_bmp = new Bitmap(er_bmp);

            int x1 = 255, x2 = 255, x3 = 255;
            Color c;
            int b1, b2, b3;
            for (int y = 1; y < erheight - 1; y++)
            {
                for (int x = 1; x < erwidth - 1; x++)
                {
                    c = er_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = er_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = er_bmp.GetPixel(x + 1, y);
                    b3 = c.R;

                    if (b1 == x1 & b2 == x2 & b3 == x3)
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            pB_convert.Image = exit_bmp;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Bitmap er_bmp = new Bitmap("D:\\Lenna_morph.png");
            int erwidth = er_bmp.Width;
            int erheight = er_bmp.Height;
            

            Bitmap op_bmp = new Bitmap(er_bmp);
            int width = op_bmp.Width;
            int height = op_bmp.Height;
            Bitmap exit_bmp = new Bitmap(op_bmp);

            int x1 = 255, x2 = 255, x3 = 255;
            Color c;
            int b1, b2, b3;
            for (int y = 1; y < erheight - 1; y++)
            {
                for (int x = 1; x < erwidth - 1; x++)
                {
                    c = er_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = er_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = er_bmp.GetPixel(x + 1, y);
                    b3 = c.R;

                    if (b1 == x1 & b2 == x2 & b3 == x3)
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    c = op_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = op_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = op_bmp.GetPixel(x + 1, y);
                    b3 = c.R;

                    if (b1 == x1 & b2 == x2 & b3 == x3)
                    {
                        er_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        er_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    c = er_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = er_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = er_bmp.GetPixel(x + 1, y);
                    b3 = c.R;

                    if (b1 == x1 & b2 == x2 & b3 == x3)
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            pB_convert.Image = exit_bmp;



        }

        private void Close_Click(object sender, EventArgs e)
        {
            Bitmap Dil_bmp = new Bitmap("D:\\Lenna_morph.png");
            int dilwidth = Dil_bmp.Width;
            int dilheight = Dil_bmp.Height;

            Bitmap clos_bmp = new Bitmap(Dil_bmp);
            int width = clos_bmp.Width;
            int height = clos_bmp.Height;
            Bitmap exit_bmp = new Bitmap(clos_bmp);



            

            int x1 = 255, x2 = 255, x3 = 255;
            Color c;
            int b1, b2, b3;
            for (int y = 1; y < dilheight - 1; y++)
            {
                for (int x = 1; x < dilwidth - 1; x++)
                {
                    c = Dil_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = Dil_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = Dil_bmp.GetPixel(x + 1, y);
                    b3 = c.R;

                    if (b1 == x1 & b2 == x2 & b3 == x3)
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    c = clos_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = clos_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = clos_bmp.GetPixel(x + 1, y);
                    b3 = c.R;
                    if (b1 == x1 || b2 == x2 || b3 == x3)
                    {
                        Dil_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        Dil_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    c = Dil_bmp.GetPixel(x, y);
                    b1 = c.R;
                    c = Dil_bmp.GetPixel(x - 1, y);
                    b2 = c.R;
                    c = Dil_bmp.GetPixel(x + 1, y);
                    b3 = c.R;
                    if (b1 == x1 && b2 == x2 && b3 == x3)
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        exit_bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            pB_convert.Image = exit_bmp;
        }

        private void konvulisyon_Click(object sender, EventArgs e)
        {
            Bitmap kon_bmp = new Bitmap("D:\\Lenna.png");
            int width = kon_bmp.Width;
            int height = kon_bmp.Height;

            Bitmap exit_bmp = new Bitmap(kon_bmp);


            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y, i, j, toplamR, toplamG, toplamB;
            int R, G, B;
            int[] Matris = { 0, -2, 0, -2, 11, -2, 0, -2, 0 };
            int MatrisToplami = 0 + -2 + 0 + -2 + 11 + -2 + 0 + -2 + 0;
            //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek
            for (x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0;//matris içindeki elemanları sırayla okurken kullanılacak. ,
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            color_original = kon_bmp.GetPixel(x + i, y + j);
                            toplamR = toplamR + color_original.R * Matris[k];
                            toplamG = toplamG + color_original.G * Matris[k];
                            toplamB = toplamB + color_original.B * Matris[k];
                            k++;
                        }
                    }
                    R = toplamR / MatrisToplami;
                    G = toplamG / MatrisToplami;
                    B = toplamB / MatrisToplami;
                    //=========================================
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    //=========================================
                    exit_bmp.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            pB_convert.Image = exit_bmp;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Bitmap photo_bmp = new Bitmap(500, 500); 
            photo_bmp = new Bitmap(pB_convert.Image);
            pB_convert.Image = null;
            
        }

        private void median_filter_Click(object sender, EventArgs e)
        {

            Bitmap med_bmp = new Bitmap("D:\\Lenna.png");
            int width = med_bmp.Width;
            int height = med_bmp.Height;


            int SablonBoyutu = 5; //şablon boyutu 3 den büyük tek rakam olmalıdır(3, 5, 7 gibi).
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int[] R = new int[ElemanSayisi];
            int[] G = new int[ElemanSayisi];
            int[] B = new int[ElemanSayisi];
            int[] Gri = new int[ElemanSayisi];
            int x, y, i, j;
            for (x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                {
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            color_original = med_bmp.GetPixel(x + i, y + j);
                            R[k] = color_original.R;
                            G[k] = color_original.G;
                            B[k] = color_original.B;
                            Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114); //Gri ton formülü
                            k++;
                        }
                    }
                    //Gri tona göre sıralama yapıyor. Aynı anda üç rengide değiştiriyor.
                    int GeciciSayi = 0;
                    for (i = 0; i < ElemanSayisi; i++)
                    {
                        for (j = i + 1; j < ElemanSayisi; j++)
                        {
                            if (Gri[j] < Gri[i])
                            {
                                GeciciSayi = Gri[i];
                                Gri[i] = Gri[j];
                                Gri[j] = GeciciSayi;
                                GeciciSayi = R[i];
                                R[i] = R[j];
                                R[j] = GeciciSayi;
                                GeciciSayi = G[i];
                                G[i] = G[j];
                                G[j] = GeciciSayi;
                                GeciciSayi = B[i];
                                B[i] = B[j];
                                B[j] = GeciciSayi;
                            }
                        }
                    }
                    //Sıralama sonrası ortadaki değeri çıkış resminin piksel değeri olarak atıyor.
                    med_bmp.SetPixel(x, y, Color.FromArgb(R[(ElemanSayisi - 1) / 2], G[(ElemanSayisi - 1) / 2], B[(ElemanSayisi - 1) / 2]));
                }
            }
            pB_convert.Image = med_bmp;
        }

        private void hist_est_Click(object sender, EventArgs e)
        {
            Bitmap his_est_bmp = new Bitmap("D:\\Lenna.png");
            int width = his_est_bmp.Width;
            int height = his_est_bmp.Height;


            Bitmap renderedImage = new Bitmap(his_est_bmp);
            uint pixels = (uint)renderedImage.Height * (uint)renderedImage.Width;
            decimal Const = 255 / (decimal)pixels;
            int x, y, R, G, B;
            int[] HistogramRed2 = new int[256];
            int[] HistogramGreen2 = new int[256];
            int[] HistogramBlue2 = new int[256];

            for (var i = 0; i < renderedImage.Width; i++)
            {
                for (var j = 0; j < renderedImage.Height; j++)
                {
                    var piksel = renderedImage.GetPixel(i, j);

                    HistogramRed2[(int)piksel.R]++;
                    HistogramGreen2[(int)piksel.G]++;
                    HistogramBlue2[(int)piksel.B]++;
                }
            }

            int[] cdfR = HistogramRed2;
            int[] cdfG = HistogramGreen2;
            int[] cdfB = HistogramBlue2;

            for (int r = 1; r <= 255; r++)
            {
                cdfR[r] = cdfR[r] + cdfR[r - 1];
                cdfG[r] = cdfG[r] + cdfG[r - 1];
                cdfB[r] = cdfB[r] + cdfB[r - 1];
            }

            for (y = 0; y < renderedImage.Height; y++)
            {
                for (x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    R = (int)((decimal)cdfR[pixelColor.R] * Const);
                    G = (int)((decimal)cdfG[pixelColor.G] * Const);
                    B = (int)((decimal)cdfB[pixelColor.B] * Const);

                    Color newColor = Color.FromArgb(R, G, B);
                    renderedImage.SetPixel(x, y, newColor);
                }
            }
            pB_convert.Image = renderedImage;
        }

        private void perspective_Click(object sender, EventArgs e)
        {

           
            // MATRİS TERSİNİ ALMA---------------------
            double[,] MatrisTersiniAl(double[,] GirisMatrisi)
            {
                int MatrisBoyutu = Convert.ToInt16(Math.Sqrt(GirisMatrisi.Length));
                //matris boyutu içindeki eleman sayısı olduğu için kare matrisde
                //karekökü matris boyutu olur.
                double[,] CikisMatrisi = new double[MatrisBoyutu, MatrisBoyutu]; //A nın
                                                                                 //tersi alındığında bu matris içinde tutulacak
                                                                                 //--I Birim matrisin içeriğini dolduruyor
                for (int i = 0; i < MatrisBoyutu; i++)
                {
                    for (int j = 0; j < MatrisBoyutu; j++)
                    {
                        if (i == j)
                            CikisMatrisi[i, j] = 1;
                        else
                            CikisMatrisi[i, j] = 0;
                    }
                }
                //--Matris Tersini alma işlemi---------
                double d, k;
                for (int i = 0; i < MatrisBoyutu; i++)
                {
                    d = GirisMatrisi[i, i];
                    for (int j = 0; j < MatrisBoyutu; j++)
                    {
                        if (d == 0)
                        {
                            d = 0.0001; //0 bölme hata veriyordu.
                        }
                        GirisMatrisi[i, j] = GirisMatrisi[i, j] / d;
                        CikisMatrisi[i, j] = CikisMatrisi[i, j] / d;
                    }
                    for (int x = 0; x < MatrisBoyutu; x++)
                    {
                        if (x != i)
                        {
                            k = GirisMatrisi[x, i];
                            for (int j = 0; j < MatrisBoyutu; j++)
                            {
                                GirisMatrisi[x, j] = GirisMatrisi[x, j] - GirisMatrisi[i, j] * k;
                                CikisMatrisi[x, j] = CikisMatrisi[x, j] - CikisMatrisi[i, j] * k;
                            }
                        }
                    }
                }
                return CikisMatrisi;
            }

            double x1 = Convert.ToDouble(txt_x1.Text);
            double y1 = Convert.ToDouble(txt_y1.Text);
            double x2 = Convert.ToDouble(txt_x2.Text);
            double y2 = Convert.ToDouble(txt_y2.Text);
            double x3 = Convert.ToDouble(txt_x3.Text);
            double y3 = Convert.ToDouble(txt_y3.Text);
            double x4 = Convert.ToDouble(txt_x4.Text);
            double y4 = Convert.ToDouble(txt_y4.Text);
            double X1 = Convert.ToDouble(txt_XX1.Text);
            double Y1 = Convert.ToDouble(txt_YY1.Text);
            double X2 = Convert.ToDouble(txt_XX2.Text);
            double Y2 = Convert.ToDouble(txt_YY2.Text);
            double X3 = Convert.ToDouble(txt_XX3.Text);
            double Y3 = Convert.ToDouble(txt_YY3.Text);
            double X4 = Convert.ToDouble(txt_XX4.Text);
            double Y4 = Convert.ToDouble(txt_YY4.Text);
            double[,] GirisMatrisi = new double[8, 8];
            // { x1, y1, 1, 0, 0, 0, -x1 * X1, -y1 * X1 }
            GirisMatrisi[0, 0] = x1;
            GirisMatrisi[0, 1] = y1;
            GirisMatrisi[0, 2] = 1;
            GirisMatrisi[0, 3] = 0;
            GirisMatrisi[0, 4] = 0;
            GirisMatrisi[0, 5] = 0;
            GirisMatrisi[0, 6] = -x1 * X1;
            GirisMatrisi[0, 7] = -y1 * X1;
            //{ 0, 0, 0, x1, y1, 1, -x1 * Y1, -y1 * Y1 }
            GirisMatrisi[1, 0] = 0;
            GirisMatrisi[1, 1] = 0;
            GirisMatrisi[1, 2] = 0;
            GirisMatrisi[1, 3] = x1;
            GirisMatrisi[1, 4] = y1;
            GirisMatrisi[1, 5] = 1;
            GirisMatrisi[1, 6] = -x1 * Y1;
            GirisMatrisi[1, 7] = -y1 * Y1;
            //{ x2, y2, 1, 0, 0, 0, -x2 * X2, -y2 * X2 }
            GirisMatrisi[2, 0] = x2;
            GirisMatrisi[2, 1] = y2;
            GirisMatrisi[2, 2] = 1;
            GirisMatrisi[2, 3] = 0;
            GirisMatrisi[2, 4] = 0;
            GirisMatrisi[2, 5] = 0;
            GirisMatrisi[2, 6] = -x2 * X2;
            GirisMatrisi[2, 7] = -y2 * X2;
            //{ 0, 0, 0, x2, y2, 1, -x2 * Y2, -y2 * Y2 }
            GirisMatrisi[3, 0] = 0;
            GirisMatrisi[3, 1] = 0;
            GirisMatrisi[3, 2] = 0;
            GirisMatrisi[3, 3] = x2;
            GirisMatrisi[3, 4] = y2;
            GirisMatrisi[3, 5] = 1;
            GirisMatrisi[3, 6] = -x2 * Y2;
            GirisMatrisi[3, 7] = -y2 * Y2;
            //{ x3, y3, 1, 0, 0, 0, -x3 * X3, -y3 * X3 }
            GirisMatrisi[4, 0] = x3;
            GirisMatrisi[4, 1] = y3;
            GirisMatrisi[4, 2] = 1;
            GirisMatrisi[4, 3] = 0;
            GirisMatrisi[4, 4] = 0;
            GirisMatrisi[4, 5] = 0;
            GirisMatrisi[4, 6] = -x3 * X3;
            GirisMatrisi[4, 7] = -y3 * X3;
            //{ 0, 0, 0, x3, y3, 1, -x3 * Y3, -y3 * Y3 }
            GirisMatrisi[5, 0] = 0;
            GirisMatrisi[5, 1] = 0;
            GirisMatrisi[5, 2] = 0;
            GirisMatrisi[5, 3] = x3;
            GirisMatrisi[5, 4] = y3;
            GirisMatrisi[5, 5] = 1;
            GirisMatrisi[5, 6] = -x3 * Y3;
            GirisMatrisi[5, 7] = -y3 * Y3;
            //{ x4, y4, 1, 0, 0, 0, -x4 * X4, -y4 * X4 }
            GirisMatrisi[6, 0] = x4;
            GirisMatrisi[6, 1] = y4;
            GirisMatrisi[6, 2] = 1;
            GirisMatrisi[6, 3] = 0;
            GirisMatrisi[6, 4] = 0;
            GirisMatrisi[6, 5] = 0;
            GirisMatrisi[6, 6] = -x4 * X4;
            GirisMatrisi[6, 7] = -y4 * X4;
            //{ 0, 0, 0, x4, y4, 1, -x4 * Y4, -y4 * Y4 }
            GirisMatrisi[7, 0] = 0;
            GirisMatrisi[7, 1] = 0;
            GirisMatrisi[7, 2] = 0;
            GirisMatrisi[7, 3] = x4;
            GirisMatrisi[7, 4] = y4;
            GirisMatrisi[7, 5] = 1;
            GirisMatrisi[7, 6] = -x4 * Y4;
            GirisMatrisi[7, 7] = -y4 * Y4;
            //------------------------------------------------------------------
            double[,] matrisBTersi = MatrisTersiniAl(GirisMatrisi);
            //-------------------- A Dönüşüm Matrisi (3x3) -----------------
            double a00 = 0, a01 = 0, a02 = 0, a10 = 0, a11 = 0, a12 = 0, a20 = 0, a21 = 0, a22 = 0;
            a00 = matrisBTersi[0, 0] * X1 + matrisBTersi[0, 1] * Y1 + matrisBTersi[0, 2] *
            X2 + matrisBTersi[0, 3] * Y2 + matrisBTersi[0, 4] * X3 + matrisBTersi[0, 5] * Y3 +
            matrisBTersi[0, 6] * X4 + matrisBTersi[0, 7] * Y4;
            a01 = matrisBTersi[1, 0] * X1 + matrisBTersi[1, 1] * Y1 + matrisBTersi[1, 2] *
            X2 + matrisBTersi[1, 3] * Y2 + matrisBTersi[1, 4] * X3 + matrisBTersi[1, 5] * Y3 +
            matrisBTersi[1, 6] * X4 + matrisBTersi[1, 7] * Y4;
            a02 = matrisBTersi[2, 0] * X1 + matrisBTersi[2, 1] * Y1 + matrisBTersi[2, 2] *
            X2 + matrisBTersi[2, 3] * Y2 + matrisBTersi[2, 4] * X3 + matrisBTersi[2, 5] * Y3 +
            matrisBTersi[2, 6] * X4 + matrisBTersi[2, 7] * Y4;
            a10 = matrisBTersi[3, 0] * X1 + matrisBTersi[3, 1] * Y1 + matrisBTersi[3, 2] *
            X2 + matrisBTersi[3, 3] * Y2 + matrisBTersi[3, 4] * X3 + matrisBTersi[3, 5] * Y3 +
            matrisBTersi[3, 6] * X4 + matrisBTersi[3, 7] * Y4;
            a11 = matrisBTersi[4, 0] * X1 + matrisBTersi[4, 1] * Y1 + matrisBTersi[4, 2] *
            X2 + matrisBTersi[4, 3] * Y2 + matrisBTersi[4, 4] * X3 + matrisBTersi[4, 5] * Y3 +
            matrisBTersi[4, 6] * X4 + matrisBTersi[4, 7] * Y4;
            a12 = matrisBTersi[5, 0] * X1 + matrisBTersi[5, 1] * Y1 + matrisBTersi[5, 2] *
            X2 + matrisBTersi[5, 3] * Y2 + matrisBTersi[5, 4] * X3 + matrisBTersi[5, 5] * Y3 +
            matrisBTersi[5, 6] * X4 + matrisBTersi[5, 7] * Y4;
            a20 = matrisBTersi[6, 0] * X1 + matrisBTersi[6, 1] * Y1 + matrisBTersi[6, 2] *
            X2 + matrisBTersi[6, 3] * Y2 + matrisBTersi[6, 4] * X3 + matrisBTersi[6, 5] * Y3 +
            matrisBTersi[6, 6] * X4 + matrisBTersi[6, 7] * Y4;
            a21 = matrisBTersi[7, 0] * X1 + matrisBTersi[7, 1] * Y1 + matrisBTersi[7, 2] * X2 + matrisBTersi[7, 3] * Y2 + matrisBTersi[7, 4] * X3 + matrisBTersi[7, 5] * Y3 + matrisBTersi[7, 6] * X4 + matrisBTersi[7, 7] * Y4;
            a22 = 1;
            //------------------------- Perspektif düzeltme işlemi ------------------------
            PerspektifDuzelt(a00, a01, a02, a10, a11, a12, a20, a21, a22);
        }
        public void PerspektifDuzelt(double a00, double a01, double a02,
        double a10, double a11, double a12, double a20,
        double a21, double a22)
        {

            Bitmap bmp = new Bitmap("D:\\plaka2.png");
            Bitmap GirisResmi, CikisResmi;
            Color OkunanRenk;
            GirisResmi = new Bitmap(bmp);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double X, Y, z;
            for (int x = 0; x < (ResimGenisligi); x++)
            {
                for (int y = 0; y < (ResimYuksekligi); y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    z = a20 * x + a21 * y + 1;
                    X = (a00 * x + a01 * y + a02) / z;
                    Y = (a10 * x + a11 * y + a12) / z;
                    if (X > 0 && X < ResimGenisligi && Y > 0 && Y < ResimYuksekligi)
                        //Picturebox ın dışına çıkan kısımlar oluşturulmayacak.
                        CikisResmi.SetPixel((int)X, (int)Y, OkunanRenk);
                }
            }
            pB_convert.Image = CikisResmi;
        }

        private void prewitt_Click(object sender, EventArgs e)
        {
            Bitmap prewitt_bmp = new Bitmap("D:\\Lenna.png");
            int width = prewitt_bmp.Width - 1;
            int height = prewitt_bmp.Height - 1;

            Bitmap exit_bmp = new Bitmap(prewitt_bmp);

            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < width - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < height - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = prewitt_bmp.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = prewitt_bmp.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(-P1 + P3 - P4 + P6 - P7 + P9); //Dikey çizgileri Bulur
                    int Gy = Math.Abs(P1 + P2 + P3 - P7 - P8 - P9); //Yatay Çizgileri Bulur.
                    int PrewittDegeri = 0;
                    PrewittDegeri = Gx;
                    PrewittDegeri = Gy;
                    PrewittDegeri = Gx + Gy; //1. Formül
                                             //PrewittDegeri = Convert.ToInt16(Math.Sqrt(Gx * Gx + Gy * Gy)); //2.Formül
                                             //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (PrewittDegeri > 255) PrewittDegeri = 255;
                    //Eşikleme: Örnek olarak 100 değeri kullanıldı.
                    //if (PrewittDegeri > 100)
                    //PrewittDegeri = 255;
                    //else
                    //PrewittDegeri = 0;
                    exit_bmp.SetPixel(x, y, Color.FromArgb(PrewittDegeri, PrewittDegeri, PrewittDegeri));
                }
            }
            pB_convert.Image = exit_bmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            pB_original.Image = bmp;
        }

        private void parlaklik_dusur_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            int width = bmp.Width;
            int height = bmp.Height;

            Color c;
            int a, r, g, b;
            int anti_color;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir değer giriniz", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                anti_color = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        c = bmp.GetPixel(i, j);
                        r = c.R - anti_color;
                        if (r < 0) r = 0;
                        g = c.R - anti_color;
                        if (g < 0) g = 0;
                        b = c.R - anti_color;
                        if (b < 0) b = 0;
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b));






                    }

                }
                pB_convert.Image = bmp;

            }
        }

        private void therholding_Click(object sender, EventArgs e)
        {
            Bitmap thresholding_bmp = new Bitmap("D:\\Lenna.png");
            int width = thresholding_bmp.Width;
            int height = thresholding_bmp.Height;
            if (textBox1.Text == "")
                MessageBox.Show("Lütfen değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int thresholding_value = Convert.ToInt32(textBox1.Text); //Eşikleme değeri parantez içine yazılır

                for(int x =0;x<width;x++)
                {
                    for(int y =0;y<height;y++)
                    {
                        color_original = thresholding_bmp.GetPixel(x, y);

                        if (color_original.R >= thresholding_value)
                            R = 255;
                        else
                            R = 0;
                        if (color_original.G >= thresholding_value)
                            G = 255;
                        else
                            G = 0;
                        if (color_original.B >= thresholding_value)
                            B = 255;
                        else
                            B = 0;
                        color_converted = Color.FromArgb(R, G, B);
                        thresholding_bmp.SetPixel(x, y,color_converted);
                    }
                }
                pB_convert.Image = thresholding_bmp;
            }
        }

        private void histogram_draw_Click(object sender, EventArgs e)
        {
            Bitmap histogram_bmp = new Bitmap("D:\\Lenna.png");
            int width = histogram_bmp.Width;
            int height = histogram_bmp.Height;
            Color color_original;

            ArrayList DiziPiksel = new ArrayList();
            int OrtalamaRenk = 0;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color_original = histogram_bmp.GetPixel(x, y);
                    OrtalamaRenk = (int)(color_original.R + color_original.G + color_original.B) / 3;
                    DiziPiksel.Add(OrtalamaRenk);

                }
            }
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r <= 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek.
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }
            //Değerleri listbox'a ekliyor.
            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak.
            for (int k = 0; k <= 255; k++)
            {
                //listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);
                //Maksimum piksel sayısını bulmaya çalışıyor.
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }
            pB_convert.BackColor = Color.White;

            //Grafiği çiziyor.
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Blue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pB_convert.CreateGraphics();
            pB_convert.Refresh();
            int GrafikYuksekligi =histogram_bmp.Height;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi;
            double OlcekX = 1.5;
            int X_kaydirma = 10;
            for (int x = 0; x <= 255; x++)
            {
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX),
                   GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi,
               (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                //Dikey kırmızı çizgiler.
            }
        }
    }
    
}

       