📦 Grocery Stock API
A lightweight ASP.NET Core Web API for small grocery stores to manage product stock easily.

✅ Features
Add new grocery products with quantity and restock threshold.

Get a list of low-stock products to refill on time.

In-memory data store (no database setup required).

Simple quantity validation.

Swagger UI enabled for easy testing.

🛠️ Technologies
ASP.NET Core Web API (.NET 8)

C#

Swagger (Swashbuckle)

🔧 How to Run
Clone the repository:

bash
Copy
Edit
git clone https://github.com/e1mostafa/grocery-stock-api.git
Navigate to the project folder:

bash
Copy
Edit
cd grocery-stock-api
Run the project:

bash
Copy
Edit
dotnet run
Open Swagger UI:
Navigate to: http://localhost:<PORT>/swagger

📌 API Endpoints
➕ Add Product
POST /api/products/add

Request Body:

json
Copy
Edit
{
  "productName": "Milk",
  "quantity": 5,
  "restockThreshold": 3
}
Response: 200 OK with the saved product or 400 Bad Request if invalid.

🔍 Get Low Stock Products
GET /api/products/low-stock

Response:

json
Copy
Edit
[
  {
    "id": 1,
    "productName": "Milk",
    "quantity": 2,
    "restockThreshold": 3
  }
]
📄 Example Model
csharp
Copy
Edit
public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public int RestockThreshold { get; set; }
}
👨‍💼 Target Users
Very small grocery shops

Solo shopkeepers needing a basic stock alert system

Local businesses avoiding complex inventory systems

