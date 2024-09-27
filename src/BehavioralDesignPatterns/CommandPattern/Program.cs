

using CommandPattern;
using CommandPattern.Command;

Light light = new Light("Living Room Light");
Door door = new Door("Front Door");
Tv tv = new Tv("LG Tv");

SmartHomeMobileApplication smartHomeMobileApplication = new SmartHomeMobileApplication();
SmartHomeShortcut smartHomeShortcut = new SmartHomeShortcut();


smartHomeMobileApplication.Execute(new TurnLightOnCommand(light));
smartHomeMobileApplication.Execute(new TurnTvOffCommand(tv));
smartHomeMobileApplication.Execute(new UnlockDoorCommand(door));

smartHomeShortcut.SetCommand("Turn On Light", new TurnLightOnCommand(light));
smartHomeShortcut.SetCommand("Turn Off Tv", new TurnTvOffCommand(tv));
smartHomeShortcut.SetCommand("Unlock Door", new UnlockDoorCommand(door));

smartHomeShortcut.OpenShortcut("Turn On Light");
smartHomeShortcut.OpenShortcut("Turn Off Tv");
smartHomeShortcut.OpenShortcut("Unlock Door");