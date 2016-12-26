using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kanonji.Stash {

	public class Placeholder : IEnumerable<Vector3> {

		private Vector3 basePopsition;
		private Index3D numInEdge;
		private float spacing;

		private int index;

		public Placeholder(Vector3 _basePopsition, Vector3 _numInEdge, float _spacing) {
			basePopsition = _basePopsition;
			numInEdge = new Index3D(_numInEdge);
			spacing = _spacing;
		}

		public IEnumerator<Vector3> GetEnumerator() {
			index = 0;
			int total = GetTotalNum();
			while (index < total) {
				index++;
				var index3d = GetIndex3D(index);
				yield return index3d * spacing;
			}
		}

		protected Vector3 GetIndex3D(int index) {
			index--;
			int z = index / (numInEdge.x * numInEdge.y);
			int remainder = index % (numInEdge.x * numInEdge.y);
			int y = remainder / numInEdge.x;
			int x = remainder % numInEdge.x;
			return new Vector3(x, y, z);
		}

		protected int GetTotalNum() {
			return (int)(numInEdge.x * numInEdge.y * numInEdge.z);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}
	}
}