select Products.Title, Categories.Title
from Products 
left join Products_Categories
on Products.ProductId = Products_Categories.ProductId
left join Categories
on Products_Categories.CategoryId = Categories.CategoryId
