SELECT DISTINCT p.Name AS 'Имя продукта', COALESCE(c.Name, 'Без категории') AS 'Имя категории'
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id