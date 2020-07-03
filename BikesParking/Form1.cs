using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BikeParkingLib;


namespace BikesParking
{
    public partial class Form1 : Form
    {
        bool dec = false, adddec = false;

        readonly DataTable bikesTable = new DataTable();
        readonly ReaderData Reader;
        readonly List<BikeParkingData> bikes = new List<BikeParkingData>();
        public Form1()
        {
            InitializeComponent();
            Reader = new ReaderData();
            bikes = Reader.Bikesarr;
            FillGrid();

        }

        private void FillGrid()
        {
            bikesTable.Columns.Add("ID", typeof(int));
            bikesTable.Columns.Add("Name", typeof(string));
            bikesTable.Columns.Add("Address", typeof(string));
            bikesTable.Columns.Add("District", typeof(string));
            bikesTable.Columns.Add("Capacity", typeof(int));
            bikesTable.Columns.Add("AdmArea", typeof(string));
            bikesTable.Columns.Add("OperationOrganizationPhone", typeof(string));
            bikesTable.Columns.Add("global_id", typeof(double));
            for (int i = 0; i < bikes.Count; i++)
            {
                bikesTable.Rows.Add(bikes[i].Id, bikes[i].Name, bikes[i].Address, bikes[i].District,
                    bikes[i].Capacity, bikes[i].AdmArea, bikes[i].OperationOrganizationPhone, bikes[i].Global_id);
            }
            dataGrid.DataSource = bikesTable;
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
            var selRow = from bike in bikes
                         where bike.Id == int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString())
                         select bike;
            foreach (var item in selRow)
            {
                Map map = new Map(item.Latitude_WGS84, item.Longitude_WGS84);
                map.ShowDialog();
            }
        }

        private void SortById_button_Click(object sender, EventArgs e)
        {
            if (!dec)
            {
                bikesTable.DefaultView.Sort = "ID desc";
                dec = true;
            }
            else
            {
                bikesTable.DefaultView.Sort = "ID";
                dec = false;
            }
            dataGrid.DataSource = bikesTable;

        }

        private void SortById_button_MouseEnter(object sender, EventArgs e)
        {
            SortById_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            SortById_button.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }

        private void SortById_button_MouseLeave(object sender, EventArgs e)
        {
            SortById_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            SortById_button.ForeColor = System.Drawing.Color.White;
        }

        private void SortByAddrbutton1_MouseEnter(object sender, EventArgs e)
        {
            SortByAddrbutton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 126, 49);
            SortByAddrbutton1.ForeColor = System.Drawing.Color.FromArgb(229, 126, 49);
        }

        private void SortByAddrbutton1_MouseLeave(object sender, EventArgs e)
        {
            SortByAddrbutton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            SortByAddrbutton1.ForeColor = System.Drawing.Color.White;
        }

        private void searchtextBox1_TextChanged(object sender, EventArgs e)
        {
            // dataGrid.DataSource = bikesTable.Select($"ID ={searchtextBox1.Text} ");
            // dataGrid.Refresh();
        }

        private void SortByAddrbutton1_Click(object sender, EventArgs e)
        {
            if (!adddec)
            {
                bikesTable.DefaultView.Sort = "Address desc";
                adddec = true;
            }
            else
            {
                bikesTable.DefaultView.Sort = "Address";
                adddec = false;
            }
            dataGrid.DataSource = bikesTable;
        }
    }
}
