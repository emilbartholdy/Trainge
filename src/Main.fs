module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop
open Elmish
open Elmish.React
open Feliz.Bulma

importSideEffects "./styles/global.scss"

type State =
    { TextInput: string }

type Msg =
    | SetTextInput of string


let init() =
    { TextInput = "" }

let update (msg: Msg) (state: State): State =
    match msg with
    | SetTextInput string ->
        { state with TextInput = string }

let render state dispatch =
    Bulma.columns [
        Bulma.column [
            column.is2 // <-- note context helper here
            prop.children [
                Bulma.button.button "Click me"
            ]
        ]
        Bulma.column [
            column.is2
            prop.children [
                Html.img [
                    prop.src "/img/favicon-16x16.png"
                ]
            ]
        ]
    ]

Program.mkSimple init update render
|> Program.withReactSynchronous "feliz-app"
|> Program.run