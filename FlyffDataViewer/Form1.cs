using FlyffDataViewer.Classes;
using FlyffDataViewer.Usercontrols;

namespace FlyffDataViewer
{
    public partial class Form1 : Form
    {
        ItemsView itemsView;
        public Form1()
        {
            InitializeComponent();
            itemsView = new ItemsView();
            itemsView.Visible = true;
            panel1.Controls.Add(itemsView);
            SettingsManager.LoadSettings();
            ContentManager.LoadItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}