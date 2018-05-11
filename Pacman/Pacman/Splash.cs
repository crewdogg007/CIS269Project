using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pacman
{
  public partial class Splash : Form
  {
    public Splash()
    {
      InitializeComponent();
      pictureBox1.Image = Image.FromFile("../../images/splash1.gif");
    }
  }
}
