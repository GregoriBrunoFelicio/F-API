namespace F_API.Controllers

open Microsoft.AspNetCore.Mvc
open Context

[<ApiController>]
[<Route("clients")>]
type ClientsController () =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        Context.getContext(@"C:/temp").Clients.Data
