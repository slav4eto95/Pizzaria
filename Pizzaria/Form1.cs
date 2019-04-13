using Pizzaria.PizzariaDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today.AddDays(1);

            txtSum.Enabled = false;
            txtClientName.Enabled = false;
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;

            string fromDate = dtpFromDate.Value.ToString();
            string toDate = dtpToDate.Value.ToString();
            DateTime from = DateTime.Parse(fromDate);
            DateTime to = DateTime.Parse(toDate);

            var sum = 0.0;
            if (txtSum.Text.ToString() != "" && txtSum.Text.ToString() != null)
                sum = double.Parse(txtSum.Text.ToString());

            string clientName = "";
            if (txtClientName.Text.ToString() != "" && txtClientName.Text.ToString() != null)
                clientName = txtClientName.Text.ToString();

            PizzariaDataSet pizzariaDataSet = new PizzariaDataSet();

            // reports
            ClientsWithoutOrdersReport clientsWithoutOrdersReport = new ClientsWithoutOrdersReport();
            ClientsWithBiggerSumReport clientsWithBiggerSumReport = new ClientsWithBiggerSumReport();
            TopTenSoldProductsReport topTenSoldProductsReport = new TopTenSoldProductsReport();
            ProductsWithMaxSumOfOrdersReport productsWithMaxSumOfOrdersReport = new ProductsWithMaxSumOfOrdersReport();
            GetAllProductsByClientReport getAllProductsByClientReport = new GetAllProductsByClientReport();
            GetAllOrdersWithBiggerSumReport getAllOrdersWithBiggerSumReport = new GetAllOrdersWithBiggerSumReport();
            GetDetailedOrderReport getDetailedOrderReport = new GetDetailedOrderReport();

            // adapters
            ClientsWithoutOrdersTableAdapter clientsWithoutOrdersAdapter = new ClientsWithoutOrdersTableAdapter();
            ClientsWithSumOfOrdersBiggerThanSpecifiedSumTableAdapter clientsWithSumAdapter = new ClientsWithSumOfOrdersBiggerThanSpecifiedSumTableAdapter();
            TopTenSoldProductsTableAdapter topTenSoldProducts = new TopTenSoldProductsTableAdapter();
            ProductsWithMaxSumOfOrdersTableAdapter productsWithMaxSum = new ProductsWithMaxSumOfOrdersTableAdapter();
            GetAllProductsByClientTableAdapter getAllProductsByClientAdapter = new GetAllProductsByClientTableAdapter();
            GetAllOrdersWithBiggerSumTableAdapter getAllOrdersWithBiggerSumAdapter = new GetAllOrdersWithBiggerSumTableAdapter();
            GetDetailedOrderTableAdapter getDetailedOrderTableAdapter = new GetDetailedOrderTableAdapter();

            int selectedIndex = cmbAllReports.SelectedIndex;

            using (PizzariaEntities db = new PizzariaEntities())
            {
                using (pizzariaDataSet)
                {
                    switch (selectedIndex)
                    {
                        case 0:
                            topTenSoldProducts.Fill(pizzariaDataSet.TopTenSoldProducts, from, to);
                            topTenSoldProductsReport.SetDataSource(pizzariaDataSet);
                            topTenSoldProductsReport.SetParameterValue("fromDate", from);
                            topTenSoldProductsReport.SetParameterValue("toDate", to);
                            crystalReportViewer1.ReportSource = topTenSoldProductsReport;
                            break;
                        case 1:
                            productsWithMaxSum.Fill(pizzariaDataSet.ProductsWithMaxSumOfOrders, from, to);
                            productsWithMaxSumOfOrdersReport.SetDataSource(pizzariaDataSet);
                            productsWithMaxSumOfOrdersReport.SetParameterValue("fromDate", from);
                            productsWithMaxSumOfOrdersReport.SetParameterValue("toDate", to);
                            crystalReportViewer1.ReportSource = productsWithMaxSumOfOrdersReport;
                            break;
                        case 2:
                            clientsWithoutOrdersAdapter.Fill(pizzariaDataSet.ClientsWithoutOrders, from, to);
                            clientsWithoutOrdersReport.SetDataSource(pizzariaDataSet);
                            clientsWithoutOrdersReport.SetParameterValue("fromDate", from);
                            clientsWithoutOrdersReport.SetParameterValue("toDate", to);
                            crystalReportViewer1.ReportSource = clientsWithoutOrdersReport;
                            break;
                        case 3:
                            clientsWithSumAdapter.Fill(pizzariaDataSet.ClientsWithSumOfOrdersBiggerThanSpecifiedSum,
                                                        from, to, Convert.ToDecimal(sum));
                            clientsWithBiggerSumReport.SetDataSource(pizzariaDataSet);
                            clientsWithBiggerSumReport.SetParameterValue("fromDate", from);
                            clientsWithBiggerSumReport.SetParameterValue("toDate", to);
                            clientsWithBiggerSumReport.SetParameterValue("sum", sum);
                            crystalReportViewer1.ReportSource = clientsWithBiggerSumReport;
                            break;
                        case 4:
                            getAllProductsByClientAdapter.Fill(pizzariaDataSet.GetAllProductsByClient, clientName);
                            getAllProductsByClientReport.SetDataSource(pizzariaDataSet);
                            getAllProductsByClientReport.SetParameterValue("ClientName", clientName);
                            crystalReportViewer1.ReportSource = getAllProductsByClientReport;
                            break;
                        case 5:
                            getAllOrdersWithBiggerSumAdapter.Fill(pizzariaDataSet.GetAllOrdersWithBiggerSum, Convert.ToDecimal(sum));
                            getAllOrdersWithBiggerSumReport.SetDataSource(pizzariaDataSet);
                            getAllOrdersWithBiggerSumReport.SetParameterValue("Sum", sum);
                            crystalReportViewer1.ReportSource = getAllOrdersWithBiggerSumReport;
                            break;
                        case 6:
                            getDetailedOrderTableAdapter.Fill(pizzariaDataSet.GetDetailedOrder);
                            getDetailedOrderReport.SetDataSource(pizzariaDataSet);
                            crystalReportViewer1.ReportSource = getDetailedOrderReport;
                            break;
                        default:
                            MessageBox.Show("Моля изберете отчет от списъка!!", "Изберете отчет", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            break;
                    }
                }
            }
        }

        private void cmbAllReports_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cmbAllReports.SelectedIndex;

            switch (index)
            {
                case 0:
                case 1:
                case 2:
                    dtpFromDate.Enabled = dtpToDate.Enabled = true;
                    txtSum.Enabled = txtClientName.Enabled = false;
                    break;
                case 3:
                    txtSum.Enabled = dtpFromDate.Enabled = dtpToDate.Enabled = true;
                    txtClientName.Enabled = false;
                    break;
                case 4:
                    txtClientName.Enabled = true;
                    txtSum.Enabled = dtpFromDate.Enabled = dtpToDate.Enabled = false;
                    break;
                case 5:
                    txtSum.Enabled = true;
                    txtClientName.Enabled = dtpFromDate.Enabled = dtpToDate.Enabled = false;
                    break;
                case 6:
                    txtSum.Enabled = txtClientName.Enabled = dtpFromDate.Enabled = dtpToDate.Enabled = false;
                    break;
            }
        }
    }
}
