module Resources

  open Model

  (* MEDIA *)
  let res1: Video   = ("./videos/welcome-video.mp4", 7)
  let res2connect   = Image "./img/connect.png"
  let res3relion    = Image "./img/relion.png"
  let res4routific  = Image "./img/routific.png"

  (* TITLES *)
  let mediaPageTitle1 = "Tools: The Simple Feast Delivery App"
  let mediaPageTitle2 = "Connect with Fellow Drivers"
  let mediaPageTitle3 = "Tools: Introduction to the Relion App for Shift Planning"

  (* SUBTITLES *)
  let mediaPageSubtitle1 = "
  When you are out on your ride you will be using our customers application for navigation.
  These applications vary in the way they look, however, they have the same functionality.
  In this video we give you an introduction to the different customer applications that we use.
  "

  let mediaPageSubtitle2 = "
  Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium,
  totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et
  quasi architecto beatae vitae dicta sunt explicabo.
  "

  let mediaPageSubtitle3 = "
  Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,
  sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.
  Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur?
  "

  (* CONTENTs *)
  let mediaPageContent1 = """# The Three Applications
  
  Here at *Chainge* we use the following three applications (until further are added).

  * Simple Feast Delivery Application
  * Aarstiderne Delivery Application
  * Økologi A/S Application.

  Please download these applications to your mobile phone in the App Store (see resources link below).

  If you become sick it is important that you fill out the illness form and contact either Thore or Jakub.
  Dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy 
  text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.
  It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.
  It was popularised in the 1960s with

  # Resources

  * [Link to Simple Feast Delivery Application]()
  * [Link to Aarstiderne Delivery Application]()
  * [Link to Økologi A/S Application]()
  * [Link to Illness Form]()
  """

  let mediaPageContent2 = "# Hello"

  let tagSocial = "Social"
  let tagLearningTool = "Learning Tools"
  let tagNewBiker = "For New Bikers"

  let doc1 : Document = {
    Id = 1
    Title = mediaPageTitle1;
    Subtitle = mediaPageSubtitle1;
    Content = mediaPageContent1;
    Media = res2connect;
    Tag = tagSocial;
  }
  
  let doc2 : Document = {
    Id = 2
    Title = mediaPageTitle2;
    Subtitle = mediaPageSubtitle2;
    Content = mediaPageContent1;
    Media = res3relion;
    Tag = tagLearningTool;
  }
  
  let doc3 : Document = {
    Id = 3
    Title = mediaPageTitle3;
    Subtitle = mediaPageSubtitle3;
    Content = mediaPageContent1;
    Media = res4routific;
    Tag = tagNewBiker;
  }