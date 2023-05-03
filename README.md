# GAME SYSTEM DESIGN

### UI
- UI is a prefab inside its own scene.
- UI is edited in inspector.
- UI is loaded as scene additive.
- UI is unloaded as scene after showing its hiding animation.
- UI is MonoBehaviour.

For example:
UI Menu is inside UI Menu Scene.

### SCRIPTABLE OBJECTS DATA
- MonoBehaviour serialized fields will be put here.
- ScriptableObjectsData will use an Editor plugin from GitHub.
- ScriptableObjectsData will not use the Unity Components.

For example:
PlayerController(the MonoBehaviour) uses PlayerControllerData (the ScriptableObject).

### VCONTAINER
- Game will use the VContainer.
- Class that uses VContainer are for UI, Audio, Networking, and Saving/Loading of Data.
- Class that are used in gameplay or other factor that is needed in gameplay will not use VContainer.
- Except MonoBehaviour, all scripts will follow VContainer – Dependency Inversion.
- MonoBehaviour UI will follow the: builder.RegisterComponent(helloScreen);
- Game will use the Constructor Injection, and nothing else.

Link:
- https://vcontainer.hadashikick.jp/resolving/gameobject-injection
- https://vcontainer.hadashikick.jp/resolving/constructor-injection
