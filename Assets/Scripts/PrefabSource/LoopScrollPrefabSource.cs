using UnityEngine;
using System.Collections;
using System;

namespace UnityEngine.UI
{
	public class LoopScrollPrefabSource : LoopPrefabSourceBehaviour
    {
        [SerializeField]
		public string prefabName;

        [SerializeField]
        public int poolSize = 5;

		public void Awake()
		{
            InitPool();
        }

		public virtual void InitPool()
		{
			ResourceManager.Instance.InitPool(prefabName, poolSize);
		}
			
		public override GameObject GetObject()
		{
			return ResourceManager.Instance.GetObjectFromPool(prefabName);
		}

        public override void ReturnObject(GameObject obj)
        {
            ResourceManager.Instance.ReturnObjectToPool(obj);
        }
	}


 

}
