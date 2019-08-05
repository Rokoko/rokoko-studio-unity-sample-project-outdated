using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rokoko.VirtualProduction
{
    public class Face : MonoBehaviour
    {
        public string faceId = "";

        [SerializeField] private SkinnedMeshRenderer _faceSkin;
        [SerializeField] private FaceBlendshapeMap _blendshapeMapping;
        private List<string> blendshapeNames;
        private void Reset()
        {
            if (!_faceSkin) _faceSkin = GetComponent<SkinnedMeshRenderer>();
            var blendshapes = GetBlendShapeNames();
            foreach (var blendshape in blendshapes)
            {
                if (blendshape.Contains("eyeBlinkLeft"))
                {
                    _blendshapeMapping.eyeBlinkLeft = blendshape;
                } else if (blendshape.Contains("eyeLookDownLeft")) {
                    _blendshapeMapping.eyeLookDownLeft = blendshape;
                } else if (blendshape.Contains("eyeLookInLeft")) {
                    _blendshapeMapping.eyeLookInLeft = blendshape;
                } else if (blendshape.Contains("eyeLookOutLeft")) {
                    _blendshapeMapping.eyeLookOutLeft = blendshape;
                } else if (blendshape.Contains("eyeLookUpLeft")) {
                    _blendshapeMapping.eyeLookUpLeft = blendshape;
                } else if (blendshape.Contains("eyeSquintLeft")) {
                    _blendshapeMapping.eyeSquintLeft = blendshape;
                } else if (blendshape.Contains("eyeWideLeft")) {
                    _blendshapeMapping.eyeWideLeft = blendshape;
                } else if (blendshape.Contains("eyeBlinkRight")) {
                    _blendshapeMapping.eyeBlinkRight = blendshape;
                } else if (blendshape.Contains("eyeLookDownRight")) {
                    _blendshapeMapping.eyeLookDownRight = blendshape;
                } else if (blendshape.Contains("eyeLookInRight")) {
                    _blendshapeMapping.eyeLookInRight = blendshape;
                } else if (blendshape.Contains("eyeLookOutRight")) {
                    _blendshapeMapping.eyeLookOutRight = blendshape;
                } else if (blendshape.Contains("eyeLookUpRight")) {
                    _blendshapeMapping.eyeLookUpRight = blendshape;
                } else if (blendshape.Contains("eyeSquintRight")) {
                    _blendshapeMapping.eyeSquintRight = blendshape;
                } else if (blendshape.Contains("eyeWideRight")) {
                    _blendshapeMapping.eyeWideRight = blendshape;
                } else if (blendshape.Contains("jawForward")) {
                    _blendshapeMapping.jawForward = blendshape;
                } else if (blendshape.Contains("jawLeft")) {
                    _blendshapeMapping.jawLeft = blendshape;
                } else if (blendshape.Contains("jawRight")) {
                    _blendshapeMapping.jawRight = blendshape;
                } else if (blendshape.Contains("jawOpen")) {
                    _blendshapeMapping.jawOpen = blendshape;
                } else if (blendshape.Contains("mouthClose")) {
                    _blendshapeMapping.mouthClose = blendshape;
                } else if (blendshape.Contains("mouthFunnel")) {
                    _blendshapeMapping.mouthFunnel = blendshape;
                } else if (blendshape.Contains("mouthPucker")) {
                    _blendshapeMapping.mouthPucker = blendshape;
                } else if (blendshape.Contains("mouthLeft")) {
                    _blendshapeMapping.mouthLeft = blendshape;
                } else if (blendshape.Contains("mouthRight")) {
                    _blendshapeMapping.mouthRight = blendshape;
                } else if (blendshape.Contains("mouthSmileLeft")) {
                    _blendshapeMapping.mouthSmileLeft = blendshape;
                } else if (blendshape.Contains("mouthSmileRight")) {
                    _blendshapeMapping.mouthSmileRight = blendshape;
                } else if (blendshape.Contains("mouthFrownLeft")) {
                    _blendshapeMapping.mouthFrownLeft = blendshape;
                } else if (blendshape.Contains("mouthFrownRight")) {
                    _blendshapeMapping.mouthFrownRight = blendshape;
                } else if (blendshape.Contains("mouthDimpleLeft")) {
                    _blendshapeMapping.mouthDimpleLeft = blendshape;
                } else if (blendshape.Contains("mouthDimpleRight")) {
                    _blendshapeMapping.mouthDimpleRight = blendshape;
                } else if (blendshape.Contains("mouthStretchLeft")) {
                    _blendshapeMapping.mouthStretchLeft = blendshape;
                } else if (blendshape.Contains("mouthStretchRight")) {
                    _blendshapeMapping.mouthStretchRight = blendshape;
                } else if (blendshape.Contains("mouthRollLower")) {
                    _blendshapeMapping.mouthRollLower = blendshape;
                } else if (blendshape.Contains("mouthRollUpper")) {
                    _blendshapeMapping.mouthRollUpper = blendshape;
                } else if (blendshape.Contains("mouthShrugLower")) {
                    _blendshapeMapping.mouthShrugLower = blendshape;
                } else if (blendshape.Contains("mouthShrugUpper")) {
                    _blendshapeMapping.mouthShrugUpper = blendshape;
                } else if (blendshape.Contains("mouthPressLeft")) {
                    _blendshapeMapping.mouthPressLeft = blendshape;
                } else if (blendshape.Contains("mouthPressRight")) {
                    _blendshapeMapping.mouthPressRight = blendshape;
                } else if (blendshape.Contains("mouthLowerDownLeft")) {
                    _blendshapeMapping.mouthLowerDownLeft = blendshape;
                } else if (blendshape.Contains("mouthLowerDownRight")) {
                    _blendshapeMapping.mouthLowerDownRight = blendshape;
                } else if (blendshape.Contains("mouthUpperUpLeft")) {
                    _blendshapeMapping.mouthUpperUpLeft = blendshape;
                } else if (blendshape.Contains("mouthUpperUpRight")) {
                    _blendshapeMapping.mouthUpperUpRight = blendshape;
                } else if (blendshape.Contains("browDownLeft")) {
                    _blendshapeMapping.browDownLeft = blendshape;
                } else if (blendshape.Contains("browDownRight")) {
                    _blendshapeMapping.browDownRight = blendshape;
                } else if (blendshape.Contains("browInnerUp")) {
                    _blendshapeMapping.browInnerUp = blendshape;
                } else if (blendshape.Contains("browOuterUpLeft")) {
                    _blendshapeMapping.browOuterUpLeft = blendshape;
                } else if (blendshape.Contains("browOuterUpRight")) {
                    _blendshapeMapping.browOuterUpRight = blendshape;
                } else if (blendshape.Contains("cheekPuff")) {
                    _blendshapeMapping.cheekPuff = blendshape;
                } else if (blendshape.Contains("cheekSquintLeft")) {
                    _blendshapeMapping.cheekSquintLeft = blendshape;
                } else if (blendshape.Contains("cheekSquintRight")) {
                    _blendshapeMapping.cheekSquintRight = blendshape;
                } else if (blendshape.Contains("noseSneerLeft")) {
                    _blendshapeMapping.noseSneerLeft = blendshape;
                } else if (blendshape.Contains("noseSneerRight")) {
                    _blendshapeMapping.noseSneerRight = blendshape;
                } else if (blendshape.Contains("tongueOut")) {
                    _blendshapeMapping.tongueOut = blendshape;
                }
            }
        }

        private void Start()
        {
            blendshapeNames = new List<string>();
            blendshapeNames.AddRange(GetBlendShapeNames());
        }

        private void Update()
        {
            foreach (var face in VirtualProductionReceiver.Instance.VirtualProductionData.faces)
            {
                if (face.faceId == faceId)
                {
                    ApplyFace(face);
                    break;
                }
            }
        }

        private void ApplyFace(FaceData face)
        {
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeBlinkLeft), face.eyeBlinkLeft);
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookDownLeft), face.eyeLookDownLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookInLeft), face.eyeLookInLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookOutLeft), face.eyeLookOutLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookUpLeft), face.eyeLookUpLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeSquintLeft), face.eyeSquintLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeWideLeft), face.eyeWideLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeBlinkRight), face.eyeBlinkRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookDownRight), face.eyeLookDownRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookInRight), face.eyeLookInRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookOutRight), face.eyeLookOutRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeLookUpRight), face.eyeLookUpRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeSquintRight), face.eyeSquintRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.eyeWideRight), face.eyeWideRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.jawForward), face.jawForward);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.jawLeft), face.jawLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.jawRight), face.jawRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.jawOpen), face.jawOpen);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthClose), face.mouthClose);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthFunnel), face.mouthFunnel);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthPucker), face.mouthPucker);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthLeft), face.mouthLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthRight), face.mouthRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthSmileLeft), face.mouthSmileLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthSmileRight), face.mouthSmileRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthFrownLeft), face.mouthFrownLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthFrownRight), face.mouthFrownRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthDimpleLeft), face.mouthDimpleLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthDimpleRight), face.mouthDimpleRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthStretchLeft), face.mouthStretchLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthStretchRight), face.mouthStretchRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthRollLower), face.mouthRollLower);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthRollUpper), face.mouthRollUpper);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthShrugLower), face.mouthShrugLower);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthShrugUpper), face.mouthShrugUpper);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthPressLeft), face.mouthPressLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthPressRight), face.mouthPressRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthLowerDownLeft), face.mouthLowerDownLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthLowerDownRight), face.mouthLowerDownRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthUpperUpLeft), face.mouthUpperUpLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.mouthUpperUpRight), face.mouthUpperUpRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.browDownLeft), face.browDownLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.browDownRight), face.browDownRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.browInnerUp), face.browInnerUp);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.browOuterUpLeft), face.browOuterUpLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.browOuterUpRight), face.browOuterUpRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.cheekPuff), face.cheekPuff);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.cheekSquintLeft), face.cheekSquintLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.cheekSquintRight), face.cheekSquintRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.noseSneerLeft), face.noseSneerLeft);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.noseSneerRight), face.noseSneerRight);    
            _faceSkin.SetBlendShapeWeight(blendshapeNames.IndexOf(_blendshapeMapping.tongueOut), face.tongueOut);    
        }

        public string[] GetBlendShapeNames()
        {
            Mesh m = _faceSkin.sharedMesh;
            string[] arr;
            arr = new string [m.blendShapeCount];
            for (int i = 0; i < m.blendShapeCount; i++)
            {
                string s = m.GetBlendShapeName(i);
                arr[i] = s;
            }

            return arr;
        }

        [System.Serializable]
        public struct FaceBlendshapeMap
        {
            public string eyeBlinkLeft; // 4
            public string eyeLookDownLeft; // 4
            public string eyeLookInLeft; // 4
            public string eyeLookOutLeft; // 4
            public string eyeLookUpLeft;
            public string eyeSquintLeft;
            public string eyeWideLeft;
            public string eyeBlinkRight;
            public string eyeLookDownRight;
            public string eyeLookInRight;
            public string eyeLookOutRight;
            public string eyeLookUpRight;
            public string eyeSquintRight;
            public string eyeWideRight;
            public string jawForward;
            public string jawLeft;
            public string jawRight;
            public string jawOpen;
            public string mouthClose;
            public string mouthFunnel;
            public string mouthPucker;
            public string mouthLeft;
            public string mouthRight;
            public string mouthSmileLeft;
            public string mouthSmileRight;
            public string mouthFrownLeft;
            public string mouthFrownRight;
            public string mouthDimpleLeft;
            public string mouthDimpleRight;
            public string mouthStretchLeft;
            public string mouthStretchRight;
            public string mouthRollLower;
            public string mouthRollUpper;
            public string mouthShrugLower;
            public string mouthShrugUpper;
            public string mouthPressLeft;
            public string mouthPressRight;
            public string mouthLowerDownLeft;
            public string mouthLowerDownRight;
            public string mouthUpperUpLeft;
            public string mouthUpperUpRight;
            public string browDownLeft;
            public string browDownRight;
            public string browInnerUp;
            public string browOuterUpLeft;
            public string browOuterUpRight;
            public string cheekPuff;
            public string cheekSquintLeft;
            public string cheekSquintRight;
            public string noseSneerLeft;
            public string noseSneerRight;
            public string tongueOut;
        }
    }
}