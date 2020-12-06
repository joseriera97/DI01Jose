using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI01Jose
{
    public partial class DetailsProduct : Form
    {
        public DetailsProduct()
        {
            InitializeComponent();
        }
        public DetailsProduct(Product product)
        {
            InitializeComponent();
            //ID del Producto Oculto para que el usuario no lo pueda visualizar
            productIDTextBox.Text = product.ProductID.ToString();//Int
            productModelTextBox.Text = product.ProductModel;
            productNameTextBox.Text = product.Name;
            descriptionProductTextBox.Text = product.Description;
            priceTextBox.Text = product.ListPrice.ToString();//Decimal
            productCategoryComboBox.Text = product.ProductCategory;
            productSubCategoryComboBox.Text = product.ProductSubcategory;
        }

        private void DetailsProduct_Load(object sender, EventArgs e)
        {
        }
        private void habilitarText() 
        {
            //Considero que el Model y el Name no se deben modificar , Name es como una PK no se repite su contenido.
            productModelTextBox.Enabled = false;
            productNameTextBox.Enabled = false;

            descriptionProductTextBox.Enabled = true;
            priceTextBox.Enabled = true;
            productCategoryComboBox.Enabled = true;
            productSubCategoryComboBox.Enabled = true;
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            //Pasar a modo Edicion. 
            //Se habilitan los elementos.
            habilitarText();
            //Deshabilitar el boton edicion.
            editProductButton.Enabled = false;
            //Habilitamos la vision de los botones de Confirmar y Cancelar.
            confirmButton.Visible = true;
            cancelButton.Visible = true;

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Cuando se realiza click en confirmar la edición.
            //Para llegar a la entrega se ha reducido la cantidad de ediciones.
            //A Descripcion y Precio. Ya que realizaremos control de lo introducido en precio-

            //Recogemos los valores necesarios.
            int ProductID = int.Parse(productIDTextBox.Text);
            string Descripcion = descriptionProductTextBox.Text;
            decimal precio = decimal.Parse(priceTextBox.Text);

            //Preparar el acceso a la bbdd
            DataAccess db = new DataAccess();
            //Obtenemos un Producto
             db.UpdateProductForProductID(ProductID ,Descripcion , precio);
            


        }
    }
}
