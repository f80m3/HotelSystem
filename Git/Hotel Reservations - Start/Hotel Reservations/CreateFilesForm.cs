using HotelSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservations
{
    public partial class CreateFilesForm : Form
    {
        private HotelsDataProvider _hotelsDataProvider = new HotelsDataProvider();
        private readonly string saveDir;

        public CreateFilesForm()
        {
            InitializeComponent();
            int index = Application.ExecutablePath.LastIndexOf("\\");
            saveDir = Application.ExecutablePath.Substring(0, index) + @"\..\..\";
        }      

        private void createHotelsxmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hotels = _hotelsDataProvider.GetHotels();
            var result = XmlSerializer.Serialize(hotels, saveDir + "hotels.xml");
            if (!result.Succeded) MessageBox.Show("Ooops! Something Happened: " + result.Reason);
            lblStatus.Text = "Last Action: Create Hotels";
        }

        private void createRoominventoryxmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventory = _hotelsDataProvider.GetRoomsInventory();
            var result = XmlSerializer.Serialize(inventory, saveDir + "roominventory.xml");
            if (!result.Succeded) MessageBox.Show("Ooops! Something Happened: " + result.Reason);
            lblStatus.Text = "Last Action: Create Rooms Inventory";
        }

        private void displayHotelsxmlsFileInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
        }

        private void displayRoominventoryxmlFileInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roominventory.xml";
            frm.ShowDialog();
        }

        private void loadHotelFileButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowHtmlHotelsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
