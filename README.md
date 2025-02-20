# Unity With Visual Studio and Git

These are the files for Dan Vicarel's GDEX 2019 Presentation: "Supercharging Your Unity Workflow With Visual Studio and Git".
Check out the accompanying slides on [OneDrive](https://1drv.ms/p/s!Apw9vDm6ePFBgasohoUml3N47t7mig?e=EFenI9).

- Click `Clone or Download` then `Download ZIP` to get these files (or clone, if you already know some Git!)
- To make following the demos easier later, please download/install the following:
  - [Git](https://git-scm.com)
    - If already installed, just re-download so you can re-run installer and verify settings
    - Pretty much keep all defaults
    - Make sure LFS is installed
    - If on Windows, make sure you're using "Windows-style line endings"
      - I'm all about Unix-style line endings, but there are just too many programs that insert CRLF on Windows, so you might as well work with them, not against them
  - [Visual Studio Tools for Unity](https://docs.microsoft.com/en-us/visualstudio/cross-platform/visual-studio-tools-for-unity)
    - Select `Extensions > Manage Extensions` within Visual Studio
    - Search `Visual Studio Tools for Unity` under `Online`
    - Select `Download`
- If you don't already have Unity and Visual Studio installed, then try to just follow along. Both programs are large and take a long time to download/install.
- Open at least the following project folders in Unity, as it will take several minutes for assets to import and you don't want to wait for that during the talk:
    - `CardGame_NeedsDebug_Start`
    - `CardGame_AsmDef_Start`
    - `CardGame_ManagedPlugins_Start/CardGame_ManagedPlugins`
