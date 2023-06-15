namespace SepararColorRGB;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 800); //tamaño de la ventana
        this.Text = "Separar RGB de una imagen";
        this.StartPosition = FormStartPosition.CenterScreen; //centrar la ventana

        InstanciaObjetos();

        //se le asigna un nombre a la caja
        originalPicBox.Name = "originalPicBox";
        redPicBox.Name = "resultPicBox";
        greenPicBox.Name = "greenPicBox";
        bluePicBox.Name = "bluePicBox";
        btn.Name = "btn";

        btn.Text = "Buscar";

        DiseñoComponentes();
        

        //se establece el lugar en donde aparecera
        originalPicBox.Location = new System.Drawing.Point(30,20);
        redPicBox.Location = new System.Drawing.Point(420, 20);
        greenPicBox.Location = new System.Drawing.Point(30, 380);
        bluePicBox.Location = new System.Drawing.Point(420, 380);
        btn.Location = new System.Drawing.Point(360, 750);

        //checkRed.Location = new System.Drawing.Point(30, 400);
        //checkGreen.Location = new System.Drawing.Point(90, 400);
        //checkBlue.Location = new System.Drawing.Point(150, 400);


        //se añade al frame
        this.Controls.Add(originalPicBox);
        this.Controls.Add(redPicBox);
        this.Controls.Add(greenPicBox);
        this.Controls.Add(bluePicBox);
        this.Controls.Add(btn);
        /*this.Controls.Add(checkRed);
        this.Controls.Add(checkGreen);
        this.Controls.Add(checkBlue);*/

        //
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
    }

    private void InstanciaObjetos () {
        originalPicBox = new PictureBox();
        redPicBox = new PictureBox();
        greenPicBox = new PictureBox();
        bluePicBox = new PictureBox();
        btn = new Button();
    }

    private void DiseñoComponentes () {
        originalPicBox.Size = new System.Drawing.Size(350,350);
        originalPicBox.BorderStyle = BorderStyle.FixedSingle;

        redPicBox.Size = new System.Drawing.Size(350,350);
        redPicBox.BorderStyle = BorderStyle.FixedSingle;

        greenPicBox.Size = new System.Drawing.Size(350,350);
        greenPicBox.BorderStyle = BorderStyle.FixedSingle;

        bluePicBox.Size = new System.Drawing.Size(350,350);
        bluePicBox.BorderStyle = BorderStyle.FixedSingle;
    }

    


    private PictureBox originalPicBox;
    private PictureBox redPicBox;
    private PictureBox greenPicBox;
    private PictureBox bluePicBox;
    private Button btn;
    private OpenFileDialog openFileDialog1;

    #endregion
}
