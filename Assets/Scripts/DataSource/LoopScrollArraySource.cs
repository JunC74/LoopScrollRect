using UnityEngine;
using System.Collections;
using System;

namespace UnityEngine.UI
{
	public class LoopScrollArraySource : LoopDataSourceBehaviour
    {
        object[] objectsToFill;

		public void SetArray(object[] objectsToFill)
        {
            this.objectsToFill = objectsToFill;
            OnDataUpdate();
        }

        public override int GetItemNum()
        {
            if (objectsToFill == null) return 0;
            else return objectsToFill.Length;
        }

        public override void ProvideData(Transform transform, int idx)
        {
            transform.SendMessage("ScrollCellContent", objectsToFill[idx]);
        }
    }
}