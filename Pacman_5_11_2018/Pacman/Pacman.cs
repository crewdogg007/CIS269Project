/*Team member: Duy Nguyen & Peter J Moore
 * Project: Pacman game
 * Description:
 * - Add the magic dot to the game.
 * - Change the point to 10 points ,instead of 5 points for normal dot, when the Pacman eat the magic dot.
 * - Add more ghost to the game, the new black ghost.
 * - Play the sound when the Pacman die.
 * - Change the splash page to Animation page.
 * - Change UI for Main page.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Pacman
{
  class Pacman : Sprite
  {
    public Image pacmanUp = Image.FromFile("../../images/pacmanUp.gif");
    public Image pacmanDown = Image.FromFile("../../images/pacmanDown.gif");
    public Image pacmanRight = Image.FromFile("../../images/pacmanRight.gif");
    public Image pacmanLeft = Image.FromFile("../../images/pacmanLeft.gif");
  }
}
