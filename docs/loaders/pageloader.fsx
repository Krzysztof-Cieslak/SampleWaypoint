#r "../_lib/Fornax.Core.dll"


type Shortcut = {
    title: string
    link: string
    icon: string
}
`
let loader (projectRoot: string) (siteContet: SiteContents) =
    siteContet.Add({title = "Home"; link = "http://kcieslak.io/SampleWaypoint"; icon = "fas fa-home"})
    siteContet.Add({title = "GitHub repo"; link = "https://github.com/Krzysztof-Cieslak/SampleWaypoint"; icon = "fab fa-github"})
    siteContet