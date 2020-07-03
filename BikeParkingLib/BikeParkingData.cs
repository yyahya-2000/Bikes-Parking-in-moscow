
namespace BikeParkingLib
{
    public class BikeParkingData
    {
        string address;
        double latitude_WGS84;
        int global_id;
        Coordinate coordinate;
        double longitude_WGS84;
        string operationOrganizationPhone;
        string name;
        string admArea;
        int capacity;
        int id;
        string district;

        public string Address { get => address; set => address = value; }
        public double Latitude_WGS84 { get => latitude_WGS84; set => latitude_WGS84 = value; }
        public int Global_id { get => global_id; set => global_id = value; }
        public Coordinate Coordinate { get => coordinate; set => coordinate = value; }
        public double Longitude_WGS84 { get => longitude_WGS84; set => longitude_WGS84 = value; }
        public string OperationOrganizationPhone { get => operationOrganizationPhone; set => operationOrganizationPhone = value; }
        public string Name { get => name; set => name = value; }
        public string AdmArea { get => admArea; set => admArea = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Id { get => id; set => id = value; }
        public string District { get => district; set => district = value; }
    }
}
