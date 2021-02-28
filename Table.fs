
module Table
open Wrappers
open Operators

type Table<'e> = {
    File: string
    Data: 'e list
}

let saveTable table =
        Json.serialize table.Data
        |> File.save table.File
        table

let loadTable<'e> file =
    let data = File.read file
               |> Json.deserialize<'e list> 
    {
     File = file
     Data = data
    }

let initializeTable  file initialData =
    let table = {
         File = file
         Data = initialData
    }
    saveTable table

let createTableToApplication<'e> baseDirectory file initialData = 
    let completedFile = baseDirectory ^ file
    let fileExists = File.exist completedFile
    match fileExists with
    | true -> loadTable<'e> completedFile
    | false -> initializeTable completedFile initialData


