module Model

type Client = {
    Id:int
    Name:string
    LastName:string
    Age:int
    Email:string
    Telephone:string
    Address:string
}

type Product = {
    Id:int
    Name:string
    Description:string
    Price:double
}

type Purchase = {
    Id:int
    ClientId:int
    Amount:double
}

type PurchaseItem = {
    ProductId: int
    Quantity: int
    Amount:double
}
