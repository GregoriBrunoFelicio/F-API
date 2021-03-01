module Configurations

open Microsoft.Extensions.Configuration
open System.IO

let constructor = new ConfigurationBuilder()
let directoryContructor = constructor.SetBasePath(Directory.GetCurrentDirectory())
let jsonFile = directoryContructor.AddJsonFile("appsettings.json")
let configuration = jsonFile.Build()

let getConfiguration (configurationName:string) = 
       configuration.[configurationName]

let tableDirectory = getConfiguration "TableDirectory"
