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
open FrontPageHeader

importSideEffects "./styles/global.scss"
importSideEffects "./styles/all.min.js"

type ShownPage =
    | MediaPage
    | FrontPage

type State =
    { Documents: Document list;
      MediaPageState: MediaPage.State;
      ShownPage: ShownPage
    }

type Msg =
    | MediaPageMsg of MediaPage.Msg
    | MediaPageThumbnailMsg of MediaPageThumbnail.Msg
    | FrontPageHeaderMsg of FrontPageHeader.Msg

let init() =
    { Documents = [Resources.doc1; Resources.doc2; Resources.doc3];
      MediaPageState = { Document = doc1 };
      ShownPage = FrontPage
    }

let update (msg: Msg) (state: State): State =
    
    match msg with
    | MediaPageMsg msg ->
        match msg with
        | BackButtonTapped -> { state with ShownPage = FrontPage }
    
    | MediaPageThumbnailMsg msg ->
        match msg with
        | DocumentLinkClicked id ->
            let documentToShow = List.find (fun d -> d.Id = id) state.Documents
            { state with MediaPageState = { Document = documentToShow }; ShownPage = MediaPage }

    | FrontPageHeaderMsg _ -> state


let fphState: FrontPageHeader.State =  {
    Title = "Welcome to Trainge – Chainge's knowledgebase"; 
    Subtitle = "Watch the introduction video"; 
    Video = Resources.welcomeVideo
}

let renderMediaPageThumbnails state dispatch =
    Html.div [
        prop.style [
            style.paddingTop 12
        ]
        prop.children [
        for document in state.Documents ->
            (MediaPageThumbnail.render ({Document = document}) (MediaPageThumbnailMsg >> dispatch))
        ]
    ]

let render state dispatch =
    match state.ShownPage with 
    | FrontPage -> 
        Html.div [
            prop.children [
                FrontPageHeader.render fphState (FrontPageHeaderMsg >> dispatch)
                renderMediaPageThumbnails state dispatch
            ]
        ]
    | MediaPage ->
        Html.div [
            MediaPage.render state.MediaPageState (MediaPageMsg >> dispatch)
        ]

Program.mkSimple init update render
|> Program.withReactSynchronous "trainge-app"
|> Program.run