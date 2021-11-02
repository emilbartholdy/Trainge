module Resources

  open Model

  (* MEDIA *)
  let welcomeVideo: Video   = ("./videos/welcome-video.mp4", 7)
  let connectImg   = Image "./img/connect.png"
  let relionImg    = Image "./img/relion.png"
  let routificImg  = Image "./img/routific.png"

  (* TITLES *)
  let title1 = "Introduction to Relion app: Shift planning"
  let title2 = "Introduction to Routific app: Route planning"
  let title3 = "Connect with Fellow Drivers"

  (* SUBTITLES *)
  let subtitle1 = 
    """
    You will use the app called Relion for scheduling shifts and plan your work days.
    You need to register your work hours in the app after each shift.
    If you are planning on going on vacation then you need to contact your supervisor
    to get it approved and mark it in the app. 
    """

  let subtitle2 =
    """
    You will use the app called Relion for scheduling shifts and plan your work days.
    You need to register your work hours in the app after each shift.
    If you are planning on going on vacation then you need to contact your supervisor
    to get it approved and mark it in the app. 
    """

  let subtitle3 =
    """
    You will use the app called Relion for scheduling shifts and plan your work days.
    You need to register your work hours in the app after each shift.
    If you are planning on going on vacation then you need to contact your supervisor
    to get it approved and mark it in the app. 
    """

  (* CONTENTS *)
  let content1 = 
    """
# Operire auxiliaria

## Incunabula fortis omnes horruit aura

Lorem markdownum servaturis manus accipiunt oculis musta *fugit pervenientia
magis* tu tamen ita maduerunt. Magnum nec Egeriae inde sermone volenti si
timidi; vicit est calcare insula quondam nimia facientia atque ignarum te
deriguisse. Laetaque tinguit semine crepitantibus cursu.

- Medios tuta verso
- Videt illa tellus
- Aequora thracius antiquus doloris
- Te tecta et petit tenebrisque tellus ulciscitur
- Petitve longe et gravis ore Vesta neque

## Aristis oculos tuum ad meas silvis

Mentibus genus legi qui caelo dixerat. Bello ut tremens insula incustoditae
creatus tutum scopulos [et](http://cepitpericli.net/intervoluitque.php) lumina
tela quod est, antiquarum? Terrae nam dedere non dies legati quibus, inposita
ictibus fluctus lustrabere parenti oculos! Exanimesque quarto quid, vocabula in
secum Cadmeida surrexere metuendus Atlantis nubibus.

- Iniere certaminis proicit cupioque cursu
- Cacumine est Iasone tersere
- Per pocula quaesita haeserat caluere centum tellus
- Purpureusque perque adnuit opus
  
    """
  
  let resources1 = 
    """
# Resources

- [Download Relion on the App Store](https://apps.apple.com/us/app/relion/id1500773464#?platform=iphone)
- [Download Relion on the Play Store](https://play.google.com/store/apps/details?id=com.relion.android&hl=da)
    """
      
  let resources2 =
    """
# Resources

- [Download Routific on the App Store](https://apps.apple.com/us/app/routific-driver/id1502763779)
- [Download Routific on the Play Store](https://play.google.com/store/apps/details?id=com.routific.driverapp&hl=da)
    """

  let resources3 =
    """
# Resources

- [Download WhatsApp on the App Store](https://apps.apple.com/us/app/whatsapp-messenger/id310633997)
- [Download WhatsApp on the Play Store](https://play.google.com/store/apps/details?id=com.whatsapp&hl=da&gl=US)
    """

  let mediaPageContent2 = "# Hello"

  let tagSocial: Tag = ("Social", "#96C254")
  let tagTool: Tag = ("Tools", "#8D51F6")

  let doc1 : Document = {
    Id = 1
    Title = title1;
    Subtitle = subtitle1;
    Content = (content1 + resources1);
    Media = relionImg;
    Tag = tagTool;
  }
  
  let doc2 : Document = {
    Id = 2
    Title = title2;
    Subtitle = subtitle2;
    Content = (content1 + resources2);
    Media = routificImg;
    Tag = tagTool;
  }
  
  let doc3 : Document = {
    Id = 3
    Title = title3;
    Subtitle = subtitle3;
    Content = (content1 + resources3);
    Media = connectImg;
    Tag = tagSocial;
  }