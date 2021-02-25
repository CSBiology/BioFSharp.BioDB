#r "netstandard.dll"
#r "nuget: System.Net.Http, 4.3.4"
#r "nuget: Newtonsoft.JSON, 12.0.3"
#r "nuget: SwaggerProvider, 0.12.0"
#r "nuget: BioFSharp.BioDB, 0.0.1-beta"

open BioFSharp.BioDB

FaToolDb.Queries.getOntologyterms FaToolDb.MapManOntology "AT3G12580"

let mouse = EbiAPI.UniProteinDB.getProteinSeqFeature "Q64446" |> Async.RunSynchronously



