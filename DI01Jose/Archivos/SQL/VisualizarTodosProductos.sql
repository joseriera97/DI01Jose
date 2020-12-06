
alter procedure dbo.Products_GetByCategory
	@Category nvarchar(50),
	@PageInicial int,
	@PageFinally int

as
begin
	if @Category = '*'
		--Select Para obtener todos los productos disponibles 
		Select
		Production.Product.ProductID,
		Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description,
		Production.Product.Name, Production.Product.ProductNumber,Production.Product.Color,Production.Product.ListPrice,Production.Product.Size,
		Production.Product.ProductLine,Production.Product.Class,Production.Product.Style,
		Production.ProductCategory.Name AS [Product Category],
		Production.ProductSubcategory.Name AS [Product Subcategory]
		FROM
		Production.Product
		INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
		INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
		INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
		INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
		INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
		WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL AND Production.ProductCategory.Name IS NOT NULL
	
	else if @Category = 'paginar'
				--Select Para obtener todos los productos disponibles y utilizando Limit para paginar.
		Select
		Production.Product.ProductID,
		Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description,
		Production.Product.Name, Production.Product.ProductNumber,Production.Product.Color,Production.Product.ListPrice,Production.Product.Size,
		Production.Product.ProductLine,Production.Product.Class,Production.Product.Style,
		Production.ProductCategory.Name AS [Product Category],
		Production.ProductSubcategory.Name AS [Product Subcategory]
		FROM
		Production.Product
		INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
		INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
		INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
		INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
		INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
		WHERE 
		Product.ProductModelID IS NOT NULL 
		AND Production.ProductCategory.Name IS NOT NULL AND 
		ProductModelProductDescriptionCulture.CultureID = 'en' 
		ORDER BY Production.Product.ProductID DESC
		--LIMIT @PageInicial OFFSET @PageFinally
	else
		--Select Para obtener todos los productos de una Categoria especifica 
		Select
		Production.Product.ProductID,
		Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description,
		Production.Product.Name, Production.Product.ProductNumber,Production.Product.Color,Production.Product.ListPrice,Production.Product.Size,
		Production.Product.ProductLine,Production.Product.Class,Production.Product.Style,
		Production.ProductCategory.Name AS [Product Category],
		Production.ProductSubcategory.Name AS [Product Subcategory]
		FROM
		Production.Product
		INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
		INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
		INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
		INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
		INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
		WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL AND Production.ProductCategory.Name = @Category

end
