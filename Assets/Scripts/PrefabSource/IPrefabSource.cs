/******************************************************************************** 
** Copyright(c) 2016  All Rights Reserved. 
** auth： JunC
** date： 2017/7/29 
** desc： 获取格子对象的接口
** Ver : V1.0.0 
*********************************************************************************/

namespace UnityEngine.UI
{
    public interface IPrefabSource
    {
        /// <summary>
        /// 获取格子对象
        /// </summary>
        /// <returns></returns>
        GameObject GetObject();

        /// <summary>
        /// 返回格子对象
        /// </summary>
        /// <param name="obj"></param>
        void ReturnObject(GameObject obj);
    }

    public abstract class PrefabSourceBehaviour : MonoBehaviour, IPrefabSource
    {
        public abstract GameObject GetObject();

        public abstract void ReturnObject(GameObject obj);
    }
}