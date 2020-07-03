using System.Collections.Generic;
using System.Xml.Linq;

namespace BikeParkingLib
{
    public class ReaderData
    {
        static readonly string path = "../../media/bikesParking.xml";
        List<BikeParkingData> bikesarr = new List<BikeParkingData>();
        public ReaderData()
        {
            GetData();
        }

        public List<BikeParkingData> Bikesarr { get => bikesarr; set => bikesarr = value; }

        private void GetData()
        {

            XDocument doc1 = XDocument.Load(path);
            XElement root = doc1.Element("catalog");
            IEnumerable<XElement> bikes = root.Elements();
            foreach (XElement bike in bikes)
            {
                BikeParkingData temp = new BikeParkingData();
                temp.Address = bike.Element("Address").Value.ToString();
                temp.Latitude_WGS84 = double.Parse(bike.Element("Latitude_WGS84").Value);
                temp.Global_id = int.Parse(bike.Element("global_id").Value.ToString());
                double[] tempar = new double[2];
                int i = 0;
                foreach (XElement coord in bike.Element("geoData").Elements("coordinates"))
                {
                    tempar[i++] = double.Parse(coord.Value.ToString());
                }
                temp.Coordinate = new Coordinate(tempar[0], tempar[1]);
                temp.Longitude_WGS84 = double.Parse(bike.Element("Longitude_WGS84").Value.ToString());
                temp.OperationOrganizationPhone = bike.Element("ObjectOperOrgPhone").Element("OperationOrganizationPhone").Value.ToString();
                temp.Name = bike.Element("Name").Value.ToString();
                temp.AdmArea = bike.Element("AdmArea").Value.ToString();
                temp.Capacity = int.Parse(bike.Element("Capacity").Value.ToString());
                temp.Id = int.Parse(bike.Element("ID").Value.ToString());
                temp.District = bike.Element("District").Value.ToString();
                Bikesarr.Add(temp);
            }

        }
    }
}
