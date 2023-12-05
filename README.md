# HRTask

## Ответ на вторую задачу:
```sql
SELECT 
    p.ProductName,
    COALESCE(c.CategoryName, 'Без категории') AS CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategory pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName;
