using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{
	[System.Serializable]
	public class LoopScrollPrefabSource : MonoBehaviour, IPrefabSource
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
			
		public virtual GameObject GetObject()
		{
			return ResourceManager.Instance.GetObjectFromPool(prefabName);
		}

        public virtual void ReturnObject(GameObject obj)
        {
            ResourceManager.Instance.ReturnObjectToPool(obj);
        }
	}
}
