using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kanonji.Stash {

	public struct Index3D {
		public int x;
		public int y;
		public int z;

		public Index3D(int _x, int _y, int _z) {
			x = _x;
			y = _y;
			z = _z;
		}

		public Index3D(Vector3 vector3) {
			x = (int)vector3.x;
			y = (int)vector3.y;
			z = (int)vector3.z;
		}
	}
}