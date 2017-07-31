using System;

namespace UnityEngine.UI
{
    public interface ILoopScrollDataSource
    {
        void ProvideData(Transform transform, int idx);

        int GetItemNum();

        event Action DataUpdate;
    }

    public abstract class LoopDataSourceBehaviour : MonoBehaviour, ILoopScrollDataSource
    {
        public event Action DataUpdate;

        /// <summary>
        /// 触发数据更新事件
        /// </summary>
        public virtual void OnDataUpdate()
        {
            if (DataUpdate != null) DataUpdate.Invoke();
        }

        public abstract int GetItemNum();

        public abstract void ProvideData(Transform transform, int idx);
    }
}