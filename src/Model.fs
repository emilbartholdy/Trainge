module Model 

type Url = string

type Markdown = string

type VideoLength = int

type MediaResource =
| Video of Url * VideoLength
| Image of Url

type Tag = string

type DocumentId = int

type Document = 
    { Id: DocumentId
      Title: string
      Subtitle: string 
      Content: Markdown 
      Media: MediaResource
      Tag: Tag }