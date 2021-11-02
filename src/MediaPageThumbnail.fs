module MediaPageThumbnail

open Feliz
open Feliz.Bulma

open Model

  type State = 
    { Document: Document }

  type Msg =
    | DocumentLinkClicked of DocumentId

  let init document =
    { Document = document }

  let update (msg: Msg) (state: State) =
    match msg with
    | DocumentLinkClicked _ -> state

  let render (state: State) (dispatch: Msg -> unit) =
    Bulma.columns [
      columns.isGapless
      columns.isVCentered
      
      prop.style [
        style.borderBottom (1, borderStyle.solid, color.lightGray)
        style.marginBottom 0
        style.paddingBottom 0
      ]
      prop.children [
      Bulma.column [
        prop.style [
          style.margin 30
        ]
        prop.children [
          Bulma.content [
            prop.children [
              Bulma.tag [
                prop.style [
                  style.backgroundColor (state.Document.Tag |> snd)
                  style.color "#FFF"
                ]
                Bulma.tag.isMedium
                prop.text (state.Document.Tag |> fst)
              ]
              Html.h3 state.Document.Title
              Html.p state.Document.Subtitle
              Bulma.button.button [
                color.isSuccess
                Bulma.button.isInverted
                prop.children [
                    Bulma.icon [ Html.i [ prop.className "fas fa-play" ] ]
                    Html.p "Read or watch"
                ]
                prop.onClick (fun _ -> dispatch (DocumentLinkClicked state.Document.Id))
              ]
            ]
          ]
        ]

      ]
      Bulma.column [
        column.is4
        
        prop.children [
          match state.Document.Media with
          | Video (url, _) -> 
              Html.video [
                  prop.src url
                  prop.type' "video/mp4"
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
    ]