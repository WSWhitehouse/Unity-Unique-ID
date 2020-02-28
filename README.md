# Unity Unique ID

Add this script to a GameObject to give it a unique alphanumeric identifier.

[![UniqueIDScript](https://i.gyazo.com/b6936eecfb699b6f35fa87cb1f9d2191.png)](https://gyazo.com/b6936eecfb699b6f35fa87cb1f9d2191)

## Features

- Auto-generates an ID when the script is added to a GameObject
- Only one script per GameObject, meaning each GameObject gets only ONE unique ID
- Uses system GUID generation
- Unique ID can only be accessed, it cannot be overwritten by other scripts
- Custom Editor to show the ID in the inspector, and a button to reset it if needed
- Keeps the same ID throughout play-mode and in builds

## Installing

- Download the source code or check the [releases on this repository](https://github.com/WSWhitehouse/Unity-Unique-ID/releases) for a specific Unity Package download or download the [Latest Unity Package](https://github.com/WSWhitehouse/Unity-Unique-ID/releases/latest)
  - If you downloaded the Unity Package you will need to import it. `Assets -> Import Package -> Custom Package` and select the Unity Package you just downloaded
- Put the `UniqueID.cs` script onto a GameObject
- Done! Your GameObject now has a Unique ID
