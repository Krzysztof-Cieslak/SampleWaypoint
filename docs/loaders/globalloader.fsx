#r "../_lib/Fornax.Core.dll"

type SiteInfo = {
    title: string
    description: string
    theme_variant: string option
    root_url: string
}

let config = {
    title = "SampleWaypoint"
    description = "Description of SampleWaypoint project"
    theme_variant = Some "blue"
    root_url =
      #if WATCH
        "http://localhost:8080/"
      #else
        "http://kcieslak.io/SampleWaypoint"
      #endif
}

let loader (projectRoot: string) (siteContet: SiteContents) =
    siteContet.Add(config)

    siteContet
