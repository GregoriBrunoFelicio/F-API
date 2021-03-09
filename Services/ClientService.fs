module ClientService
open Context
open Table
open Model

let getClients = 
    Context.getContext.Clients

let addClient client =
    let table = getClients
    let data = client :: getClients.Data
    saveTable { table with Data = data}



let rec deleteById id alreadyTraveled (clients:Client list) =
             match clients with
             | head :: tail when head.Id =  id -> alreadyTraveled@tail
             | head :: tail -> deleteById id (head::alreadyTraveled) tail
             | [] -> alreadyTraveled


let delete id = 
    let table = getClients
    let data = deleteById id [] table.Data
    saveTable { table with Data = data}


let rec findClientById id (clients:Client list) =
              match clients with
              | head::tail when head.Id = id -> Some head
              | head::tail -> findClientById id tail
              | [] -> None

