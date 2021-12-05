using System.Windows.Forms;

namespace TriviaGameShow
{
    public partial class frmGameBoard : Form
    {
        public frmGameBoard()
        {
            InitializeComponent();

            foreach (Control c in pnlColumns.Controls )
            {
                //if (c.Name.StartsWith("lblTitle") || c.Name.StartsWith("lblQuestion"))
                //{
                //}
            }

        }
    }
}
