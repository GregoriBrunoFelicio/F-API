namespace Wrappers

open Newtonsoft.Json

module Json =
    let serialize object = 
        JsonConvert.SerializeObject(object)

    let deserialize<'a> json = 
        JsonConvert.DeserializeObject<'a>(json)



module File =
   open System.IO   

   let save directory content = 
        File.WriteAllText(directory, content)

   let read directory =
        File.ReadAllText(directory)

   let exist directory = 
        File.Exists(directory)  
