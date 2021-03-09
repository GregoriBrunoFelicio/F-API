namespace F_API.Controllers

open Microsoft.AspNetCore.Mvc
open ClientService

[<ApiController>]
[<Route("[controller]")>]
type ClientsController () =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        ClientService.getClients

    [<HttpPost>]
    member _.Post(client) =
        ClientService.addClient client

    [<HttpDelete>]
    member _.Delete(id) =
        ClientService.delete id
