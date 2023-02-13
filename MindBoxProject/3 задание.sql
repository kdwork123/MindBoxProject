SELECT Products.name, Category.name
FROM Products LEFT OUTER JOIN  Category ON Products.id=Category.productId 
ORDER BY Products.name;