- Rain Drop Effect 2 v1.4 -
-------------------------------------------------------------------
Globe Games

-------------------------------------------------------------------
1: Introduction
-------------------------------------------------------------------
Thank you for purchasing Rain Drop Effect 2. This package contains some useful distortion effects. Before using, you can check 

"RainDropEffect2/SampleScene/SampleScene.unity"

to confirm how to use.

-------------------------------------------------------------------
2: Usage
-------------------------------------------------------------------
5 basic and useful effect prefabs are prepared for you. Please use prefabs in

"RainDropEffect2/Prefabs/"

You can D&D the prefab(s) at your scene. Descriptions of them are as follows.

- Blood Rain
  A splash of blood. It could be used for games like fps.

- from Rain1 to Rain6
  A normal rain drop effect. Note that it is not optimized for mobiles.

- from MobileRain1 to MobileRain2
  Cheap rain effects optimized for mobiles.

- Water Splash In
  A water splash (dive) effect.

- Water Splash Out 
  A water splash (leap out) effect.

- Frozen
  This is a freeze effect in cold environment.

If an effect is not playable at start, you have to call a method from your script. Like below to be described

[RainCameraController].Refresh (); // If you need
[RainCameraController].Play (); 

-------------------------------------------------------------------
3: Properties
-------------------------------------------------------------------
RainCameraController.cs is a main component you will use. It requires an orthographic camera. 
When you attach RainCameraController.cs for an arbitrary game object, the camera is automatically added.
Please refer properties of RainCameraController to customize.

3-0: (On Inspector)

- Render Queue
  Render Queue is an important order for rendering. If you are using GUI assets (such as NGUI) under RainCameraController, you can controll the queue of effects. 3000 is a default value.
- Alpha
  You can adjust whole rain alpha value under the camera.

3-1: Property

- public int CurrentDrawCall {get;}
  It returns current draw call the RainCamera issues.

- public int MaxDrawCall {get;}
  Gets the max draw call the RainCamera issues.

- public bool IsPlaying {get;}
  Gets a value indicating whether this rain drop patterns are playing.
 

3-2: Method

- public void Refresh ()
  You can call this when you want to redraw rain.

- public void Play ()
  Starts the rain increasingly.

- public void PlayOnce ()
  Starts once.

- public void Stop () 
  Stops the rain gradually.

- public void StopImmidiate ()
  Stops the rain immediately.

-------------------------------------------------------------------
4: Important
-------------------------------------------------------------------
You can optimize performance using low scale rain drop normal map.
Do not forget to adjust the resolutions too. In some case, resolutions on mobile platforms are too high.

-------------------------------------------------------------------
5: Contact
-------------------------------------------------------------------
If you have any question, please feel to cantact us.
globegames.info@gmail.com

-------------------------------------------------------------------
Copyright 2017 Globe Games. All rights reserved.