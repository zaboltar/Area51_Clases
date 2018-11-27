using UnityEngine;

namespace EntityData.StructLib {

    [System.Serializable]
    public struct CharTransformData {
        public Vector3 position;
        public Quaternion rotation;
    }

    [System.Serializable]
    public struct TargetData
    {
        public Transform target;
        public Vector3 focusDistance;
        public Vector3 followDistance;
        public float minFollowSpeed;

        public void SetFromVariables(Transform target, Vector3 focus, Vector3 follow, float minSpeed) {
            this.target = target;
            focusDistance = focus;
            followDistance = follow;
            minFollowSpeed = minSpeed;
        }



    }

	public struct GroundData {
        public Collider collider;
        public float incNormalized;

        public GroundData (Collider collider, float incNormalized) {
            this.collider = collider;
            this.incNormalized = incNormalized;
        }
    }

}