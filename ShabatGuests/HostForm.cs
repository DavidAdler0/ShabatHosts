using ShabatHosts.DAL;
using System.Data;

namespace ShabatGuests
{
    public partial class HostForm : Form
    {

        public HostForm(DBContext dBContext)
        {

            InitializeComponent();
            Load(dBContext);
        }

        public void Load(DBContext db)
        {
            DataTable result = new DataTable();
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            result = db.ExecuteQuery(query, null);
            foreach (DataRow dr in result.Rows)
            {
                CategorylistView.Items.Add(dr["CategoryName"].ToString());
            }


        }

    }
}
