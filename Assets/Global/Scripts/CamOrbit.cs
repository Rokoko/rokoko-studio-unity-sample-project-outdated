using UnityEngine;
using System.Collections;
 
[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class CamOrbit : MonoBehaviour {
 
    public Transform target;
    public float distance = 5.0f;
    public float xSpeed = 120.0f;
    public float ySpeed = 120.0f;
 
    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;
 
    public float distanceMin = .5f;
    public float distanceMax = 15f;
 
    private Rigidbody rigidbody;

		// Set camera control conditions
		private bool left_mouse_down = false;
		private bool free_to_zoom = false;
 
    float x = 0.0f;
    float y = 0.0f;
 
    // Use this for initialization
    void Start () 
    {
			Vector3 angles = transform.eulerAngles;
			x = angles.y;
			y = angles.x;

			rigidbody = GetComponent<Rigidbody>();

			// Make the rigid body not change rotation
			if (rigidbody != null)
			{
				rigidbody.freezeRotation = true;
			}
    }

		void Update () {
			if (Input.GetMouseButtonDown(1)) {
				left_mouse_down = true;
			}
			if (Input.GetMouseButtonUp(1)) {
				left_mouse_down = false;
			}
			if (Input.GetKeyDown(KeyCode.Z)) {
				free_to_zoom = true;
			}
			if (Input.GetKeyUp(KeyCode.Z)) {
				free_to_zoom = false;
			}
			if (Input.GetKeyUp(KeyCode.F)) {
				// transform.position = position;
				// transform.rotation = Quaternion.identity;
				// transform.rotation.y = -180;
				transform.rotation = Quaternion.Euler(0f, 180f, 0f);
				// transform.localPosition = Vector3.zero;
				transform.localPosition = new Vector3(0f, 1f, 4f);
			}
			if (Input.GetKeyUp(KeyCode.R)) {
				transform.rotation = Quaternion.Euler(0f, 90f, 0f);
				transform.localPosition = new Vector3(-3.3f, 1f, 0.57f);
			}
			if (Input.GetKeyUp(KeyCode.G)) {
				transform.rotation = Quaternion.Euler(0f, 180f, 0f);
				transform.localPosition = new Vector3(1.32f, 0.001f, 5.1f);
			}
		}
 
    void LateUpdate () 
    {
				
			if (target) 
			{
				x += Input.GetAxis("Mouse X") * xSpeed * distance * 0.02f;
				y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

				y = ClampAngle(y, yMinLimit, yMaxLimit);

				Quaternion rotation = Quaternion.Euler(y, x, 0);

				distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel")*5, distanceMin, distanceMax);

				RaycastHit hit;
				if (Physics.Linecast (target.position, transform.position, out hit)) 
				{
					distance -=  hit.distance;
				}
				Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
				Vector3 position = rotation * negDistance + target.position;
				if (left_mouse_down || free_to_zoom) {
					transform.rotation = rotation;
					transform.position = position;
				}
			}
    }
 
    public static float ClampAngle(float angle, float min, float max)
    {
			if (angle < -360F)
				angle += 360F;
			if (angle > 360F)
				angle -= 360F;
			return Mathf.Clamp(angle, min, max);
    }
}

// using System.Collections;
// // using System.Collections.Generic;
// using UnityEngine;

// public class CameraOrbitControl : MonoBehaviour {

// 	public Transform target;

// 	public float horizMove = 45f;
// 	public float vertMove = 15f;

// 	public void MoveHorizontal (bool left) {
// 		float dir = 1;
// 		if (!left)
// 			dir *= -1;
// 		transform.RotateAround(target.position, Vector3.up, horizMove * dir);
// 	}

// 	public void MoveVertical (bool up) {
// 		float dir = 1;
// 		if (!up)
// 			dir *= -1;
// 		transform.RotateAround(target.position, transform.TransformDirection(Vector3.right), vertMove * dir);
// 	}
// }
