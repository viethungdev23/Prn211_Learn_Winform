using FU.Ecommerce.DataAcess.Repository;
using FU.Ecommerce.Entities;

namespace WinFormsApp
{
    public partial class frmUpadateAndAdd : Form
    {
        public ICarRepository CarRepository { get; set; }
        public string Title { get; set; }
        public bool UpdateOrAdd { get; set; }
        public Car CarInfo { get; set; }

        public frmUpadateAndAdd()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpadateAndAdd_Load(object sender, EventArgs e)
        {
            this.Text = Title;
            this.txtCarId.Enabled= false;
            if (UpdateOrAdd)
            {

            }
            else
            {

            }
            
            // add data (danh sach cac manufacture to cboManufacture
            String[] manufacture = CarRepository.GetAllManufactures().ToArray();
            this.cboManufacture.Items.AddRange(manufacture);
            this.cboManufacture.SelectedIndex= 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //1. validate toan bo thong tin tren form
            if(this.txtCarId.Text == string.Empty || this.txtName.Text == string.Empty)
            {
                MessageBox.Show("carId khong dc null...");
                this.txtCarId.Focus();
            }
            //2. collect date tu form => object
            try
            {
                Car car = new Car
                {
                    CarId = int.Parse(this.txtCarId.Text),
                    CarName = this.txtName.Text,
                    Manufacture = cboManufacture.Text,
                    ListPrice = decimal.Parse(mskTxtPrice.Text),
                    ReleaseDate = dtDateRelease.Value
                };
                //3. su dung CarRepo de goi insert vao database
                if (UpdateOrAdd)
                {
                    CarRepository.Update(car);
                }
                else
                {
                    CarRepository.Add(car);
                    this.DialogResult= DialogResult.OK;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
