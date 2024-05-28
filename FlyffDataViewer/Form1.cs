using FlyffDataViewer.Classes;
using FlyffDataViewer.Usercontrols;

namespace FlyffDataViewer
{
    public partial class Form1 : Form
    {
        ItemsView itemsView;
        MoversView moversView;
        public Form1()
        {
            InitializeComponent();
            itemsView = new ItemsView();
            itemsView.Visible = true;
            panel1.Controls.Add(itemsView);

            moversView = new MoversView();
            moversView.Visible = false;
            panel1.Controls.Add(moversView);

            SettingsManager.LoadSettings();
            ContentManager.LoadItems();
            ContentManager.LoadMovers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monstersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moversView.Visible = true;
            itemsView.Visible = false;
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moversView.Visible = false;
            itemsView.Visible = true;
        }
    }
}