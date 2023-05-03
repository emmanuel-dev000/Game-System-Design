# GAME SYSTEM DESIGN


### STARTUP CLASS
- The starting point of the game.
- Always inside the Startup Scene.
- Startup will initialize the game.

### GAME EVENTS
- Game will use the Observer Pattern.
- Classes will uses the EventHandler and EventArgs.

For example:
Sudden "No Internet Connection" popup event.

### UI
- UI is a prefab inside its own scene.
- UI is edited in inspector.
- UI is loaded as scene additive.
- UI is unloaded as scene after showing its hiding animation.
- UI is MonoBehaviour.

For example:
UI Menu is inside UI Menu Scene.

### SCENES
- Loading of a scene means deleting all the gameObjects inside the previous one, and loading the new one.
- Don't use Singleton to avoid memory leaks with events.
- Don't use DontDestroyOnLoad(gameObject) to avoid memory leaks.

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
