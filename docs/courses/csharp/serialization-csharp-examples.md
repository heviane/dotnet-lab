# Exemplos Serialização e Deserialização

Classe base para os exemplos:

```csharp
    public class Sale
    {


        public Sale(int id, string product, decimal price, DateTime saleDate)
        {
            Id = id;
            Product = product;
            Price = price;
            SaleDate = saleDate;
        }

        public int Id { get; set; }
        [JsonProperty("name_product")] // atributos (Podemos atribuir metadados para classes e propriedades)
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
    }
```

## Exemplo 1: Serialização

```csharp
// Criação de objetos para serialização
DateTime now = DateTime.Now; // ISO 8601 (Padroniza a representação de datas entre sistemas)

Sale sale1 = new Sale(1, "Tennis", 125.00M, now);
Sale sale2 = new Sale(2, "Boots", 199.00M, now);

// Serialização de um objeto
string serialized = JsonConvert.SerializeObject(sale1, Formatting.Indented);

Console.WriteLine(serialized);
File.WriteAllText("sale.json", serialized);

// Serialização de uma Coleção
List<Sale> sales = new List<Sale>();
sales.Add(sale1);
sales.Add(sale2);

string salesJson = JsonConvert.SerializeObject(sales, Formatting.Indented);

Console.WriteLine(salesJson);
File.WriteAllText("sales.json", salesJson);
```

## Exemplo 2: Deserialização

Exemplo: Deserialização de um objeto

```csharp
string serializedSale = File.ReadAllText("sale.json");
Sale? sale = JsonConvert.DeserializeObject<Sale>(serializedSale);

if (sale is not null)
{
    Console.WriteLine($"ID: {sale.Id}, Product: {sale.Product}, Price: {sale.Price}, Date: {sale.SaleDate.ToString("dd/MM/yyyy HH:mm")}");
}
```

Exemplo: Deserialização de uma Lista de Objetos

```csharp
    string serializedSale = File.ReadAllText("sales.json");
    List<Sale>? salesList = JsonConvert.DeserializeObject<List<Sale>>(serializedSale);

    if (salesList is not null)
    {
        foreach (Sale sale in salesList)
        {
            Console.WriteLine($"ID: {sale.Id}, Product: {sale.Product}, Price: {sale.Price}, Date: {sale.SaleDate.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
```

> Os nomes dos campos devem ser iguais, ou seja, os campos dentro do arquivo json devem ser iguais aos atributos da classe, caso contrário ele não consegue fazer a correspondência, e assim o campo no objeto ficará sem valor.

## Arquivos JSON

Exemplo com um objeto:

```json
{
  "Id": 1,
  "name_product": "Sapato",
  "Price": 99.00,
  "SaleDate": "2025-09-13T15:53:24.831049-03:00"
}
```

Exemplo com uma lista de objetos:

```json
[
  {
    "Id": 1,
    "name_product": "Tennis",
    "Price": 125.00,
    "SaleDate": "2025-09-13T15:53:24.831049-03:00"
  },
  {
    "Id": 2,
    "name_product": "Boots",
    "Price": 199.00,
    "SaleDate": "2025-09-13T15:53:24.831049-03:00"
  }
]
```
