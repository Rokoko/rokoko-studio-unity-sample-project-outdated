<h2 align="center"> Rokoko Studio - Sample project for Unity</h1>

[Rokoko Studio](https://www.rokoko.com/en/products/studio) is A powerful and intuitive software for recording, visualizing and exporting motion capture.

This sample project for Unity contains necessary means to get you started with your application.

---

## Getting Started

To learn more about how to use Virtual Production in Rokoko Studio, read our guide [here](https://rokoko.atlassian.net/servicedesk/customer/kb/view/861208607)

## Documentation

#### Virtual production


Example scene: Assets/Scenes/RokokovirtualProductionExample/vp_setup

Components: 

- Virtual Production Receiver (Assets/Rokoko/VirtualProduction/VirtualProductionReceiver.cs)

Allows to access virtual production data, which includes tracker and prop information from studio.

| Parameter  | Description |
| ------------- | ------------- |
| Port  | The port number at which Studio is forwarding Virtual Production data. The default value is 14045.  |
| Virtual Production Data  | This value is read-only and displays information about the trackers and props received by the receiver.  |

- Virtual Production Prop (Assets/Rokoko/VirtualProduction/VirtualProductionProp.cs)

Uses the latest prop information to control a GameObject

| Parameter  | Description |
| ------------- | ------------- |
| Prop Name  | The friendly name of the prop as defined in Studio.  |

- Virtual Production Tracker (Assets/Rokoko/VirtualProduction/VirtualProductionTracker.cs)

Uses the latest tracker information to control a GameObject

| Parameter  | Description |
| ------------- | ------------- |
| Tracker Id  | The ID of the tracker, e.g. "1" or "2".  |
| Follow Live Tracker  | Whether to follow a live tracker in Studio or one from playback.  |

- Virtual Production Trackers  (Assets/Rokoko/VirtualProduction/VirtualProductionTrackers.cs)

Helper component that is used to visualize the trackers in 3D space.

| Parameter  | Description |
| ------------- | ------------- |
| Tracker Mesh  | A mesh that will be used to visualize the tracker.  |
| Tracker Material  | The material that will be used to render the tracker.  |

Virtual production data format

The structures representing the format can be found in the Assets/Rokoko/VirtualProduction/VirtualProductionStructures.cs.
Studio sends virtual production data in json format. An example of a virtual production data frame looks like below:
```json
{
  "version": 1,
  "props": [
    {
      "name": "Camera-1",
      "id": "43e83f03-41fd-4849-89f1-c334a0a0a100",
      "position": {
        "x": 0,
        "y": 1,
        "z": -1
      },
      "rotation": {
        "x": 0,
        "y": 0,
        "z": 0,
        "w": 1
      },
      "isLive": true,
      "profile": {
        "name": "Camera",
        "uuid": "camera-1",
        "dimensions": {
          "x": 0.24,
          "y": 0.18,
          "z": 0.04
        },
        "color": {
          "x": 0.8980392,
          "y": 0.5647059,
          "z": 0.254902
        },
        "trackerOffset": {
          "position": {
            "x": -0.06,
            "y": 0.1,
            "z": 0
          },
          "rotation": {
            "x": -90,
            "y": 0,
            "z": 0
          }
        },
        "pivot": {
          "position": {
            "x": 0,
            "y": 0,
            "z": 0.02
          },
          "rotation": {
            "x": 0,
            "y": 0,
            "z": 0
          }
        },
        "grips": [],
        "propType": 1
      }
    },
    ...
  ],
  "trackers": [
    {
      "name": "2",
      "connectionId": "",
      "position": {
        "x": -1.866039,
        "y": 2.214238,
        "z": 0.976444244
      },
      "rotation": {
        "x": 0.119269691,
        "y": 0.864182353,
        "z": -0.302122056,
        "w": 0.384299219
      },
      "isLive": false,
      "trackingResult": 200,
      "trackerType": 3,
      "RenderModelName": null,
      "battery": 1
    },
    ...
  ]
}
```


## Issues

File a bug in [GitHub Issues](https://github.com/RokokoElectronics/studio-unity-sample-project/issues)

## License

Copyright (c) Rokoko Electronics ApS. All rights reserved.

Licensed under the [GNU GPLv3](https://github.com/RokokoElectronics/rokoko-studio-unity-sample-project/blob/master/LICENSE.md) License.
