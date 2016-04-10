using UnityEngine;
using System.Collections;

// クラス名が被っているといけないので、namespaceで囲む
namespace TAK_CameraController
{

	public class CameraController : MonoBehaviour
	{
		void Update()
		{
			Vector3 acceleration = Input.acceleration;

			if (Input.GetKey(KeyCode.RightArrow)) {
				Transform trans = this.transform;
				trans.Rotate (Vector3.up, 1);
			}
			if (Input.GetKey(KeyCode.LeftArrow)) {
				Transform trans = this.transform;
				trans.Rotate (Vector3.up, -1);
			}
			if (Input.GetKey(KeyCode.UpArrow)) {
				Transform trans = this.transform;
				trans.Rotate (Vector3.left, 1);
			}
			if (Input.GetKey(KeyCode.DownArrow)) {
				Transform trans = this.transform;
				trans.Rotate (Vector3.left, -1);
			}
		}
	}
}