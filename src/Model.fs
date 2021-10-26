module Model 

type Url = string

type Markdown = string

type VideoLength = int

type Video = (Url * VideoLength)

type MediaResource =
| Video of Video
| Image of Url

type Color = string

type Tag = string

type DocumentId = int

type Document = 
    { Id: DocumentId
      Title: string
      Subtitle: string 
      Content: Markdown 
      Media: MediaResource
      Tag: Tag }