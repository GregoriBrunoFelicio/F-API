module ClientService
open Context
open Table

let getClients = 
    Context.getContext.Clients

let addClient client =
    let table = getClients
    let data = client :: getClients.Data
    saveTable { table with Data = data}
