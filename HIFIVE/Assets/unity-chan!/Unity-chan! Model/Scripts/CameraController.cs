using UnityEngine;
using System.Collections;

namespace UnityChan
{
	enum MouseButtonDown
	{
		MBD_LEFT = 0,
		MBD_RIGHT,
		MBD_MIDDLE,
	};

	public class CameraController : MonoBehaviour
	{
		[SerializeField]
		private Vector3 focus = Vector3.zero;
		[SerializeField]
		private GameObject focusObj = null;

		public bool showInstWindow = true;

		private Vector3 oldPos;

		void setupFocusObject(string name)
		{
			GameObject obj = this.focusObj = new GameObject(name);
			obj.transform.position = this.focus;
			obj.transform.LookAt(this.transform.position);

			return;
		}

		void Start ()
		{
			if (this.focusObj == null)
				this.setupFocusObject("CameraFocusObject");

			Transform trans = this.transform;
			transform.parent = this.focusObj.transform;

			trans.LookAt(this.focus);

			return;
		}
	
		void cameraTranslate(Vector3 vec)
		{
			Transform focusTrans = this.focusObj.transform;

			vec.x *= -1;

			focusTrans.Translate(Vector3.right * vec.x);
			focusTrans.Translate(Vector3.up * vec.y);

			this.focus = focusTrans.position;

			return;
		}

		public void cameraRotate(Vector3 eulerAngle)
		{
			//Use Quaternion to prevent rotation flips on XY plane
			Quaternion q = Quaternion.identity;
 
			Transform focusTrans = this.focusObj.transform;
			focusTrans.localEulerAngles = focusTrans.localEulerAngles + eulerAngle;

			//Change this.transform.LookAt(this.focus) to q.SetLookRotation(this.focus)
			q.SetLookRotation (this.focus) ;

			return;
		}
	}
}