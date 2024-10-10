using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace rtos_unity.management
{
    /// <summary>
    /// The manager used to lay out tasks graphically.
    /// </summary>
    public class LayoutManager : MonoBehaviour
    {
        #region SINGLETON

        /// <summary>
        /// A static singleton reference to the layout manager.
        /// </summary>
        public static LayoutManager Instance;

        #endregion

        private void Awake()
        {
            /* Singleton assignment */
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            Instance = this;
        }
    }
}


