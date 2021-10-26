module MediaPage

open Feliz
open Feliz.Bulma

open Model

  type State = 
    { Document: Document }

  type Msg =
    | BackButtonTapped

  let init document =
    { Document = document }

  let update (msg: Msg) (state: State) =
    match msg with
    | BackButtonTapped -> state

  let render (state: State) (dispatch: Msg -> unit) =
    Html.div [
        Bulma.columns [
            prop.className "media-page-header-gradient"
            prop.children [
                Bulma.column [ ]
                Bulma.column [
                    text.hasTextCentered
                    column.isTwoThirds
                    prop.children [
                        Html.div [
                            text.hasTextCentered
                            prop.children [
                                Bulma.image [
                                    prop.className "is-inline-block"
                                    text.hasTextCentered
                                    prop.style [
                                        style.width 200
                                        style.height 200
                                        style.paddingTop 70
                                    ]
                                    prop.children [
                                        Html.img [
                                            prop.src "/graphics/logo.png"
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        Bulma.title [
                            Html.p [
                                color.hasTextLight
                                prop.text state.Document.Title
                            ]
                        ]
                        
                        Html.p [
                            color.hasTextGreyLight
                            prop.text state.Document.Subtitle
                        ]

                        Bulma.button.button [
                            color.isSuccess
                            Bulma.button.isOutlined
                            prop.children [
                                Bulma.icon [ Html.i [ prop.className "fas fa-arrow-left" ] ]
                                Html.p "Back"
                            ]
                            prop.style [
                                style.margin 50
                            ]
                            prop.onClick (fun _ -> dispatch BackButtonTapped)
                        ]

                        Bulma.columns [
                            Bulma.column []
                            Bulma.column [
                                column.is8
                                prop.children [
                                    Bulma.box [
                                        match state.Document.Media with
                                        | Video (url, _) -> 
                                            Html.video [
                                                prop.src url
                                                prop.type' "video/mp4"
                                                prop.controls true
                                            ]
                                        | Image url ->
                                            Bulma.image [
                                                image.isSquare
                                                prop.children [
                                                    Html.img [
                                                        prop.src url
                                                    ]
                                                ]
                                            ]   
                                    ]
                                ]
                            ]
                            Bulma.column []
                        ]
                    ]
                ]
                Bulma.column [ ]
            ]
        ]

        Bulma.columns [
            prop.style [
                style.paddingTop 50
                style.paddingBottom 50
            ]
            prop.children [
                Bulma.column []
                Bulma.column [
                    column.isTwoThirds
                    prop.children [
                        Bulma.content [
                            App.Components.MarkdownDiv(state.Document.Content)
                        ]
                    ]
                ]
                Bulma.column []
            ]
        ]
    ]