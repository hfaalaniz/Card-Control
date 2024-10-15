using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Tarjeta : UserControl
    {
        Color _colorBorde = Color.FromArgb(51, 182, 121);
        int _ajusteMargen = 3;
        Image _imagenTitulo = null;
        Image _imagenCuerpo = null;
        string _lineaTitulo = "Titulo";
        string _lineaContenido = "Contenido";
        string _linea1 = "Linea 1";
        string _linea2 = "Linea 2";
        string _linea3 = "Linea 3";
        float _anchoLinea = 1;
        Font _fuenteTitulo = new Font("Yu Gothic UI", 12, FontStyle.Bold);
        Font _fuenteContenido = new Font("Yu Gothic UI", 9, FontStyle.Regular);
        Font _fuenteLinea123 = new Font("Yu Gothic UI", 10, FontStyle.Bold);
        Color _colorTitulo = Color.FromArgb(51, 182, 121);
        Color _colorContenido = Color.FromArgb(51, 182, 121);
        Color _colorLinea123 = Color.FromArgb(51, 182, 121);


        private bool iKnowDaColor = true;

        public float AnchoLinea
        {
            get { return _anchoLinea; }
            set { _anchoLinea = value; Refresh(); }
        }

        public Color ColorLinea123
        {
            get { return _colorLinea123; }
            set { _colorLinea123 = value; Refresh(); }
        }

        public Color ColorTitulo
        {
            get { return _colorTitulo; }
            set { _colorTitulo = value; Refresh(); }
        }

        public Color ColorContenido
        {
            get { return _colorContenido; }
            set { _colorContenido = value; Refresh(); }
        }

        public Font FuenteLinea123
        {
            get { return _fuenteLinea123; }
            set { _fuenteLinea123 = value; Refresh(); }
        }
        public Font FuenteTitulo
        {
            get { return _fuenteTitulo; }
            set { _fuenteTitulo = value; Refresh(); }
        }

        public Font FuenteContenido
        {
            get { return _fuenteContenido; }
            set { _fuenteContenido = value; Refresh(); }
        }

        public string LineaTitulo
        {
            get { return _lineaTitulo; }
            set { _lineaTitulo = value; Refresh(); }
        }
        public string LineaContenido
        {
            get { return _lineaContenido; }
            set { _lineaContenido = value; Refresh(); }
        }

        public string Linea1
        {
            get { return _linea1; }
            set { _linea1 = value; Refresh(); }
        }

        public string Linea2
        {
            get { return _linea2; }
            set { _linea2 = value; Refresh(); }
        }

        public string Linea3
        {
            get { return _linea3; }
            set { _linea3 = value; Refresh(); }
        }

        public Image ImagenCuerpo
        {
            get { return _imagenCuerpo; }
            set { _imagenCuerpo = value; Refresh(); }
        }
        public Image ImagenTitulo
        {
            get { return _imagenTitulo; }
            set { _imagenTitulo = value; Refresh(); }
        }
        public int AjusteMargen
        {
            get { return _ajusteMargen; }
            set { _ajusteMargen = value; Refresh(); }
        }

        public Color ColorBorde
        {
            get { return _colorBorde; }
            set { _colorBorde = value; Refresh(); }
        }

        public Tarjeta()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            // CenterTheBox(picCuerpo);
            picCuerpo.Location = new Point((pnlCuerpo.Width / 2) - (picCuerpo.Width / 2), (pnlCuerpo.Height / 4) - (picCuerpo.Height / 4));

            pnlCuerpo.Width = this.Width;
            pnlCuerpo.Height = this.Height;

            lblLinea1.Left = this.pnlCuerpo.Left + 5;
            lblLinea1.Width = this.pnlCuerpo.Width - 15;
            lblLinea1.Top = this.picCuerpo.Bottom + 5;

            lblLinea2.Left = this.pnlCuerpo.Left + 5;
            lblLinea2.Width = this.pnlCuerpo.Width - 15;
            lblLinea2.Top = this.lblLinea1.Top + this.lblLinea1.Height + 2;

            lblLinea3.Left = this.pnlCuerpo.Left + 5;
            lblLinea3.Width = this.pnlCuerpo.Width - 15;
            lblLinea3.Top = this.lblLinea2.Top + this.lblLinea2.Height + 2;
        }

        private void CenterTheBox(PictureBox picture)
        {
            picture.Size = picture.Size;
            var left = (pnlCuerpo.ClientRectangle.Width - picture.ClientRectangle.Width) / 2;
            var top = 1;  // (pnlCuerpo.ClientRectangle.Height - picture.ClientRectangle.Height) / (picture.Height / 3);
            picture.Location = new System.Drawing.Point(pnlCuerpo.ClientRectangle.Location.X + left, pnlCuerpo.ClientRectangle.Location.Y + top);
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(ColorBorde, AnchoLinea), 0, 0, this.pnlCuerpo.Width - 1, this.pnlTitulo.Height - 1);
            picTitulo.Padding = new Padding(_ajusteMargen);
            picTitulo.Image = ImagenTitulo;

            lblTitulo.Text = LineaTitulo;
            lblContenido.Text = LineaContenido;

            lblTitulo.Font = FuenteTitulo;
            lblContenido.Font = FuenteContenido;

            lblTitulo.ForeColor = ColorTitulo;
            lblContenido.ForeColor = ColorContenido;
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(ColorBorde, AnchoLinea), 0, 0, this.pnlCuerpo.Width - 1, this.pnlCuerpo.Height - 1);
            picCuerpo.Image = ImagenCuerpo;

            lblLinea1.Text = Linea1;
            lblLinea2.Text = Linea2;
            lblLinea3.Text = Linea3;

            lblLinea1.Font = FuenteLinea123;
            lblLinea2.Font = FuenteLinea123;
            lblLinea3.Font = FuenteLinea123;

            lblLinea1.ForeColor = ColorLinea123;
            lblLinea2.ForeColor = ColorLinea123;
            lblLinea3.ForeColor = ColorLinea123;
        }
    }
}
