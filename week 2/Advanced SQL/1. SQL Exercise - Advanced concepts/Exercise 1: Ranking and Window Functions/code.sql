DROP TABLE IF EXISTS Products;
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(100),
    Price DECIMAL(10, 2)
);
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 900),
(2, 'Phone', 'Electronics', 700),
(3, 'TV', 'Electronics', 900),
(4, 'Shirt', 'Clothing', 40),
(5, 'Jeans', 'Clothing', 60),
(6, 'Jacket', 'Clothing', 60),
(7, 'Blender', 'Kitchenware', 120),
(8, 'Oven', 'Kitchenware', 200),
(9, 'Toaster', 'Kitchenware', 120);
WITH RankedProducts AS (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products
)
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RowNum,
    RankNum,
    DenseRankNum
FROM RankedProducts
WHERE RowNum <= 3
   OR RankNum <= 3
   OR DenseRankNum <= 3
ORDER BY Category, Price DESC;
