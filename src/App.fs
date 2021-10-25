module App

open Feliz
open App
open Fable.Core.JsInterop
open Elmish
open Elmish.React
open Feliz.Bulma
open Model
open MediaPage
open Resources
open MediaPageThumbnail

importSideEffects "./styles/global.scss"
importSideEffects "./styles/all.min.js"

type State =
    { Documents: Document list;
      MediaPage: MediaPage.State
    }

type Msg =
    | MediaPageMsg of MediaPage.Msg
    | MediaPageThumbnailMsg of MediaPageThumbnail.Msg

let init() =
    { Documents = [Resources.doc1; Resources.doc2; Resources.doc3];
      MediaPage = { Document = doc1 }
    }

let update (msg: Msg) (state: State): State =
    match msg with
    | MediaPageMsg _ -> state
    | MediaPageThumbnailMsg _ -> state


let render state dispatch =
    Html.div [
        prop.children [
            for document in state.Documents 
                -> MediaPageThumbnail.render ({Document = document}) (MediaPageThumbnailMsg >> dispatch)
        ]
    ]

Program.mkSimple init update render
|> Program.withReactSynchronous "trainge-app"
|> Program.run