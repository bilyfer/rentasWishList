using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();

            var _productoBL = new ProductosBL();
            var _categoriasBL = new CategoriasBL();
            var _tiposBL = new TiposBL();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _productoBL.ObtenerProductos();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _categoriasBL.ObtenerCategorias();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _tiposBL.ObtenerTipos();

            var reporte = new ReporteProductos();
            reporte.Database.Tables["Producto"].SetDataSource(bindingSource1);
            reporte.Database.Tables["Categoria"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Tipo"].SetDataSource(bindingSource3);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
