using UnityEngine;
using System.Collections;
using System;

namespace UnityEngine.UI
{
	public class LoopScrollPrefabSource : PrefabSourceBehaviour
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


    public abstract class PrefabSourceBehaviour : MonoBehaviour, IPrefabSource
    {
        public abstract GameObject GetObject();

        public abstract void ReturnObject(GameObject obj);
    }

}
