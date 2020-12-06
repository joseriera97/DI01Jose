using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI01Jose
{
    public partial class mainForm : Form
    {
        int productsForPage;
        int numberOfPages; //Total Products / productsForPage +1
        int currentPage = 0;
        List<Product> productos = new List<Product>();
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void CargarDatosAllProducts(string Categoria) 
        {
            try
            {
                //Preparar el acceso a la bbdd
                DataAccess db = new DataAccess();
                //Este contenido se guarda en la lista de productos.
                productos = db.GetProducts(Categoria);
            }
            catch (Exception)
            {

                throw;
            }

        }
        //Este es el primero en ejecutar-se durante la paginación.
        //Se resetea los valores y deshabilitamos el boton para volver atras.
        private void UpdateBinding()
        {
            //Cuando enviamos * significa obtener todos los tipos de productos de cualquier Categoria.
            CargarDatosAllProducts("*");
            productListListView.Clear();
            //Actualizar la información de el ListView con lo que tenemos en el List de Productos.
            foreach (Product producto in productos)
            {
                productListListView.Items.Add(producto.ProductID.ToString(), producto.ToString(),0); 
            }
            //UpdateProductsListViewProcedure();
            int totalProducts = productos.Count();
            allCategoryLabel.Text = totalProducts + " Products found";
            numberOfPages = totalProducts / int.Parse(filmsForPageComboBox.Text) + 1;
            currentPage = 0;
            backPageButton.Enabled = false;
            nextPageButton.Enabled = true;
            actualPageLabel.Text = (currentPage + 1) + " of " + numberOfPages + " pages";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Dar el primer valor por defecto 20
            productsForPage = int.Parse(filmsForPageComboBox.Text);/*
            productListListView.Scrollable = true;
            productListListView.View = View.Details;
            ColumnHeader columnHeader = new ColumnHeader();
            columnHeader.Text = "";
            columnHeader.Name = "col1";
            productListListView.Columns.Add(columnHeader);
            columnHeader.Width = productListListView.Width - 50;
            productListListView.HeaderStyle = ColumnHeaderStyle.None;*/

            UpdateBinding();

        }



        private void productsCategoryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {//Switch para comprobar cual item de TabPage ha sido seleccionado.
            switch (productsCategoryTabControl.SelectedTab.Text)
            {
                case "All":
                    CargarDatosAllProducts("*");
                    //UpdateProductsListViewProcedure();
                    break;
                case "Bikes":
                    CargarDatosAllProducts("Bikes");
                    bikesListView.Clear();
                    //Actualizar la información de Bikes
                    foreach (Product producto in productos)
                    {
                        bikesListView.Items.Add(producto.ProductID.ToString(),producto.ToString(),0);
                    }
                    bikesLabel.Text = productos.Count() + " Products found";
                    //Obtener las subcategorias de Bikes.
                    break;
                case "Components":
                    CargarDatosAllProducts("Components");
                    componentsListView.Clear();
                    //Actualizar la información de Components
                    foreach (Product producto in productos)
                    {
                        componentsListView.Items.Add(producto.ProductID.ToString(), producto.ToString(),0);
                    }
                    componentLabel.Text = productos.Count() + " Products found";
                    break;
                case "Clothing":
                    CargarDatosAllProducts("Clothing");
                    clothingListView.Clear();
                    //Actualizar Clothing
                    foreach (Product producto in productos)
                    {
                        clothingListView.Items.Add(producto.ProductID.ToString(), producto.ToString(),0);
                    }
                    clothingLabel.Text = productos.Count() + " Products found";
                    break;
                case "Accessories":
                    CargarDatosAllProducts("Accessories");
                    accessoriesListView.Clear();
                    //Actualizar la información de Accessories
                    foreach (Product producto in productos)
                    {
                        accessoriesListView.Items.Add(producto.ProductID.ToString(), producto.ToString(),0);
                    }
                    accessoriesLabel.Text = productos.Count() + " Products found";
                    break;
            }

        }


        //Se realiza cuando se da click a el button FIND
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string buscarNombre = searchTextBox.Text;
                if (buscarNombre != " ")
                {
                    //Preparar el acceso a la bbdd
                    DataAccess db = new DataAccess();
                    
                    //Este contenido se guarda en la lista de productos.
                    productos = db.GetProductForName(buscarNombre);
                    productListListView.Items.Add(buscarNombre);
                    productListListView.Clear();
                    //Actualizar la información de el ListView con lo que tenemos en el List de Productos.
                    foreach (Product producto in productos)
                    {
                        productListListView.Items.Add(producto.ProductID.ToString(), producto.ToString(), 0);
                    }
                    allCategoryLabel.Text = productos.Count() + " Products found";
                    int totalProducts = productos.Count();
                    allCategoryLabel.Text = totalProducts + " Products found";
                    numberOfPages = totalProducts / int.Parse(filmsForPageComboBox.Text) + 1;
                    actualPageLabel.Text = (currentPage + 1) + " of " + numberOfPages + " pages";

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Cuando realizamos doble click sobre un producto de la lista
        private void productListListView_DoubleClick(object sender, EventArgs e)
        {
            //Con esto obtenemos el ID que esta como Name. El texto es el String
            int ProductID = int.Parse(productListListView.SelectedItems[0].Name);

            //Preparar el acceso a la bbdd
            DataAccess db = new DataAccess();
            //Obtenemos un Producto
            Product product  = db.GetProductForProductID(ProductID);

            //Preparamos el Dialog  para abrir el Details Products
            DetailsProduct detailsProduct = new DetailsProduct(product);
            detailsProduct.ShowDialog();

        }
        //--------------------------------------------------------------------------
        //Pagination
        //Para realizar la paginación en el inicial.
        private void UpdateProductsListView() 
        {
            actualPageLabel.Text = (currentPage + 1) + " of " + numberOfPages + " pages";

            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorkMysql"].ConnectionString;
            int inicio = currentPage * productsForPage;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sql = $"Select Production.Product.ProductID,Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description " +
                                    $" FROM " +
                                    $" Production.Product " +
                                    $" INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                                    $" INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                                    $" INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                    $" WHERE " +
                                    $" Product.ProductModelID IS NOT NULL " +
                                    $" AND Production.ProductCategory.Name IS NOT NULL AND " +
                                    $" ProductModelProductDescriptionCulture.CultureID = 'en' " +
                                    $" ORDER BY  Production.Product.ProductID DESC" +
                                    $" Limit {inicio}, {productsForPage}";
                    List<Product> products = new List<Product>();
                    products = connection.Query<Product>(sql).ToList();
                    productListListView.Items.Clear();
                    foreach (Product product in products)
                    {
                        productListListView.Items.Add(product.ProductID.ToString(), product.ToString(), 0);
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("No se ha podido conectar directamente, parte de la Paginación.");

                throw;
            }

        }
        private void UpdateProductsListViewProcedure()
        {
            actualPageLabel.Text = (currentPage + 1) + " of " + numberOfPages + " pages";

            int inicio = currentPage * productsForPage;
            try
            {
                try
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWork")))
                    {
                        List<Product> products = connection.Query<Product>("dbo.Products_GetListPerPagination @PageInicial @PageFinally", new { PageInicial = inicio , PageFinally = productsForPage }).ToList();
                        productListListView.Items.Clear();
                        foreach (Product product in products)
                        {
                            productListListView.Items.Add(product.ProductID.ToString(), product.ToString(), 0);
                        }

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Problemas con la Obtención de Producto por Nombre de Producto");

                    throw;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("No se ha podido conectar directamente, parte de la Paginación.");

                throw;
            }

        }


        private void backPageButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            if (currentPage == 0) 
            {
                //Estamos en la pagina inicial.
                backPageButton.Enabled = false;
            }
            nextPageButton.Enabled = true;
            //UpdateProductsListViewProcedure();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            currentPage++;
            if (currentPage == numberOfPages - 1)
            {
                //Deshabilitamos pasar a la siguiente pagina. Pork ya supera la lista de productos.
                nextPageButton.Enabled = false;

            }
            backPageButton.Enabled = true;
            //UpdateProductsListViewProcedure();

        }
    }
}
