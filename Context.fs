module Context
open Model
open Table

type Context = {
    Clients: Table<Client>
    Products: Table<Product>
    Purchases: Table<Purchase>
}

let initialClients = 
    [
        {
            Id = 1
            Name = "Mano"
            LastName = "Brown"
            Age = 56
            Email = "mano.brown@hotmail.com"
            Telephone = "4563-8892"
            Address = "Alameda sempre verde"
        } 
    ]

let initialProducts = 
    [
        {
            Id = 1
            Name = "Pão"
            Description = "No céu tem pão?"
            Price = 3.50
        }
    ]

let initialPurchases = 
    [
       {
           Id = 1 
           ClientId = 1
           Amount = 4.0
       } 
    ]

let getContext baseDirectory =
    let context = {
      Clients = createTableToApplication
                        baseDirectory
                        "/Clients.json"
                        initialClients

      Products = createTableToApplication
                        baseDirectory
                        "/Products.json"
                        initialProducts
      
      Purchases = createTableToApplication
                        baseDirectory
                        "/Purchases.json"
                        initialPurchases
    }
    context


