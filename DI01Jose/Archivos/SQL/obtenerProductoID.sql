
alter procedure dbo.Products_GetByIdProduct
	@ProductoID int
as
begin
		Select
		Production.Product.ProductID,
		Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description,
		Production.Product.Name, Production.Product.ProductNumber,Production.Product.Color,Production.Product.ListPrice,Production.Product.Size,
		Production.Product.ProductLine,Production.Product.Class,Production.Product.Style,
		Production.ProductCategory.Name AS [ProductCategory],
		Production.ProductSubcategory.Name AS [ProductSubcategory]
		FROM
		Production.Product
		INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
		INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
		INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
		INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
		INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
		WHERE Production.Product.ProductID = @ProductoID And ProductModelProductDescriptionCulture.CultureID = 'en'
		

end