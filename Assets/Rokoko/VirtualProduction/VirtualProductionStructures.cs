using System.Collections.Generic;
using UnityEngine;

namespace Rokoko.VirtualProduction
{
    [System.Serializable]
    public class VirtualProductionFrame
    {
        public int version;
        public Prop[] props;
        public Tracker[] trackers;
    }

    [System.Serializable]
    public class Prop
    {
        public string name;
        public string id;
        public Vector3 position;
        public Quaternion rotation;
        public bool isLive;
        public PropProfile profile;
    }


    [System.Serializable]
    public enum VrPropType
    {
        NORMAL = 0,
        CAMERA = 1,
        STICK = 2
    }

    [System.Serializable]
    public class PropProfile
    {
        public string name;
        public string uuid;

        public Vector3 dimensions;

        public Vector3 color;
        public ReferencePoint trackerOffset;
        public ReferencePoint pivot;
        public List<RadiusReferencePoint> grips;

        public VrPropType propType;
    }

    [System.Serializable]
    public struct ReferencePoint
    {
        public Vector3 position;
        public Vector3 rotation;
    }

    [System.Serializable]
    public struct RadiusReferencePoint
    {
        public float radius;
        public Vector3 position;
        public Vector3 rotation;
    }

    [System.Serializable]
    public enum ETrackingResult
    {
        Uninitialized = 1,
        Calibrating_InProgress = 100,
        Calibrating_OutOfRange = 101,
        Running_OK = 200,
        Running_OutOfRange = 201,
    }


    [System.Serializable]
    public enum VRTrackerType
    {
        INVALID = -1,
        HEAD = 0,
        TRACKER = 1,
        CONTROLLER = 2,
        BASESTATION = 3
    }

    [System.Serializable]
    public class Tracker
    {
        public string name;
        public string connectionId;
        public Vector3 position;
        public Quaternion rotation;
        public bool isLive;

        public ETrackingResult trackingResult;
        public VRTrackerType trackerType;
        public string RenderModelName;
        public float battery;
    }
}