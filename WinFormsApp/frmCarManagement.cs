using FU.Ecommerce.DataAcess.Repository;
using FU.Ecommerce.Entities;

namespace WinFormsApp
{
    public partial class frmCarManagement : Form
    {
        public ICarRepository _carRepository;
        private BindingSource _bindingSource;
        public frmCarManagement()
        {
            InitializeComponent();
            this._carRepository = new CarRepositoy();
            this._bindingSource = new BindingSource();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            // load data tu ICarRepository
            LoadCarList();

        }
        public void LoadCarList()
        {
            // LAY TOAN BO CAR TU DATABASE
            var cars = this._carRepository.GetCars();
            _bindingSource.DataSource = cars;

            //2. load len datagriview
            dgvListCar.DataSource = null;
            dgvListCar.DataSource = _bindingSource;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // k truyen qua contructor ma dung object init
            frmUpadateAndAdd frm = new frmUpadateAndAdd
            {
                Title = "Add New Car",
                CarRepository = this._carRepository,
                UpdateOrAdd = false, // false => add new 
            };
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
            }
            //frm.Show();
        }

        private void dgvListCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //1. lays data from selected row 
            var index = dgvListCar.CurrentCell.RowIndex;
            var row = dgvListCar.Rows[index];
            Car car = GetCarFromDataGridView(row);

            frmUpadateAndAdd frm = new frmUpadateAndAdd
            {
                Title = "Update Car",
                CarRepository = this._carRepository,
                UpdateOrAdd = true, // false => add new 
                CarInfo= car,
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
            }
        }

        private Car GetCarFromDataGridView(DataGridViewRow row)
        {
            var car = new Car
            {
                CarId = int.Parse(row.Cells[0].Value.ToString()),
                CarName = row.Cells[1].Value.ToString(),
                Manufacture = row.Cells[2].Value.ToString(),
                ListPrice = decimal.Parse(row.Cells[3].Value.ToString()),
                ReleaseDate = DateTime.Parse(row.Cells[4].Value.ToString())
            };
            return car;
        }

        private void dgvListCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(sender, e);
        }
    }
}