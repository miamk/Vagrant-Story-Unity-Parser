﻿using UnityEngine;

namespace VS.Entity
{
    public class ARMRoom : MonoBehaviour
    {
        public uint zoneNumber;
        public uint mapNumber;
        [SerializeField]
        public VSDoor[] doors;

        public ARMRoom()
        {

        }
    }
}