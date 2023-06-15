namespace SepararColorRGB;

public partial class Form1 : Form {

    public Form1() {
        InitializeComponent();

        //cada que el boton se pulsa, se genera el evento
        btn.Click += new EventHandler(btn_Click);

    }

    private void btn_Click(object? sender, EventArgs e) {
        
        //si se abre el cuadro de dialogo para buscar la imagen, se hacen las operaciones
        if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            RGB();
        else
            MessageBox.Show("Por favor seleccione una imagen");
        
    }

    public void RGB () {
        string imgPath = openFileDialog1.FileName;  
        originalPicBox.SizeMode = PictureBoxSizeMode.StretchImage; //hace que la imagen tenga el mismo tamaño que el picturebox
        originalPicBox.Image = Image.FromFile(imgPath); //cargar las imagenes a los picturebox

        Bitmap bmp = new Bitmap(imgPath); //leer imagen original
            
        //matriz de pixeles para los colores
        Bitmap bmpRed = new Bitmap(bmp);
        Bitmap bmpGreen = new Bitmap(bmp);
        Bitmap bmpBlue = new Bitmap(bmp);

        //Color
        Color p;

        //almacenar los valores del color
        int alpha;
        int red;
        int green;
        int blue;
            
        //hace que la imagen tenga el mismo tamaño que el picturebox
        redPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
        greenPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
        bluePicBox.SizeMode = PictureBoxSizeMode.StretchImage;

        //obtener la dimension de la imagen original
        int width = bmp.Width;
        int height = bmp.Height;

        //obtener colores
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                //obtener el valor del pixel
                p = bmp.GetPixel(j, i);

                alpha = p.A;
                red = p.R;
                green = p.G;
                blue = p.B;

                //enviar el pixel rojo de la imagen a la matriz
                bmpRed.SetPixel(j, i, Color.FromArgb(alpha, red, 0, 0));

                //verde
                bmpGreen.SetPixel(j, i, Color.FromArgb(alpha, 0, green, 0));

                //azul
                bmpBlue.SetPixel(j, i, Color.FromArgb(alpha, 0, 0, blue));

                //Combina los colores del RGB, alpha es para la transparencia
                //de la imagen
                //prueba.SetPixel(j, i, Color.FromArgb(alpha, red, 0, blue));
            }
        }

        //se envia la matriz con los pixeles a cada picturebox
        redPicBox.Image = bmpRed;
        greenPicBox.Image = bmpGreen;
        bluePicBox.Image = bmpBlue;
    }
}
