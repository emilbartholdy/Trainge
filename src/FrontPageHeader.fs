module FrontPageHeader

open Feliz
open Feliz.Bulma
open Model

type State = 
  { Title: string
    Subtitle: string
    Video: Video }

type Msg =
  | None

let init title subtitle video =
  { Title = title;
    Subtitle = subtitle;
    Video = video
  }

let update (msg: Msg) (state: State) =
  match msg with
  | None -> state

let render (state: State) (dispatch: Msg -> unit) =
  Html.div [
      Bulma.columns [
          prop.className "front-page-header-gradient"
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
                      
                      Bulma.block [
                          Bulma.title [
                              Html.p [
                                  prop.text state.Title
                              ]
                          ]
                      ]
                      
                      Bulma.subtitle [
                          Html.p [
                              color.hasTextGrey
                              prop.text state.Subtitle
                          ]
                      ]

                      Bulma.columns [
                          prop.style [
                              style.marginBottom 100
                          ]
                          prop.children [
                              Bulma.column []
                              Bulma.column [
                                  column.is8
                                  prop.children [
                                      Bulma.box [
                                        let (url, _) = state.Video
                                        Html.video [
                                            prop.src url
                                            prop.type' "video/mp4"
                                            prop.controls true
                                        ]
                                      ]
                                  ]
                              ]
                              Bulma.column []
                          ]
                      ]
                  ]
              ]
              Bulma.column [ ]
          ]
      ]
  ]