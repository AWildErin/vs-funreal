# FUnreal - Unreal Engine Extension for Visual Studio

[![version](https://img.shields.io/visual-studio-marketplace/v/fdefelici.vs-funreal?color=blue&label=latest)](https://marketplace.visualstudio.com/items?itemName=fdefelici.vs-funreal) [![install](https://img.shields.io/visual-studio-marketplace/i/fdefelici.vs-funreal?color=light-green)](https://marketplace.visualstudio.com/items?itemName=fdefelici.vs-funreal)

`FUnreal` is an extension for **Visual Studio** with the aim of improve workflow of **Unreal Engine** C++ developers.

Basically if you've got to the point where you write all your code in one file just because the hassle of adding new files to the project (here I am :raised_hand:), this extension if for you :wink:.

![FUnreal context menu example](./docs/images/intro.png)

The idea is to have an handy context menu on **Solution Explorer** view to have - *just a right-click away* - a bunch a useful operations without the need to launch an *Unreal Engine Editor* instance (as for creating plugins or common classes) or alternately working on the filesystem side (adding, renaming or deleting files) and then launching *Unreal Build Tool*.

Futhermore `FUnreal` will try to keep consistency in your project, updating UE descriptor files and sources depending on the scenario.

# Features
`FUnreal` currently supports:
* UE: 4.x and 5.x games project
* IDE: Visual Studio 2022 (aka v17.x)
* OS: Windows

and offers the following features:
* Create/Rename/Delete `files` and `folders` (even empty folders will be visibles and manageables)
* Create `C++ classes` choosing from *Unreal Common Classes*
* Create/Rename/Delete `plugins` choosing from *Unreal Plugin Templates*
* Create/Rename/Delete `modules` (for plugin modules and game modules) choosing from *Unreal Templates*
* `Invoke UBT automatically` to keep in sync UE project and VS Solution
* `Keep the consistency` of the code base, updating properly *.uproject, .uplugin, .Build.cs, .Target.cs*, module source file, and C++ include file directive, even cross modules, depenging on the operation executed (for more details read [here](./docs/DETAILS.md)).


# Activation
`FUnreal` starts automatically when detects an UE Project, even if the actual activation dependends on Visual Studio extension loading chain. So before looking for the context menu, you can be aware if `FUnreal` is loaded properly in two ways:
* A temporary notification message in **VS Status Bar**
* A dedicated Output window named **FUnreal**

![FUnreal notification](./docs/images/notify.png)

# Usage
Once active, `FUnreal` context menu is available in **Solution Explorer** view on the following items:
* `Game Project` and `.uproject` file
* `Plugin directory` and `.uplugin` file
* `Module directory` and `.Build.cs` file (for both plugin modules and game modules)
* Any `folder` or `file` within a Module directory

After executing the selected operation, `FUnreal` will run **Unreal Build Tool**, so you should receive at end the usual VS dialog advising that the project has been modified externally and need to be reloaded.

---Dove trovare FUnreal menu

That's it! Enjoy :+1:

# Changelog
History of changes [here](./docs/CHANGELOG.md).