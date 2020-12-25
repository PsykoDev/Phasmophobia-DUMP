﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	public abstract class VRTK_ObjectControl : MonoBehaviour // TypeDefIndex: 7634
	{
		// Fields
		public VRTK_ControllerEvents u0923u0926u091Cu091Bu091Au0921u091Cu0925u0922u0925u0922; // 0x18
		public u091Bu0928u0923u0923u091Cu091Bu091Bu0926u0925u091Eu0923 u0920u0928u0927u091Du091Cu0922u0929u0925u091Bu091Du0923; // 0x20
		public bool u0929u0924u0924u0921u091Cu091Bu0925u0921u0921u0925u0920; // 0x24
		public bool u0923u0920u091Cu0924u0929u091Fu0929u0923u091Au0927u0928; // 0x25
		public GameObject u091Eu091Au0928u0925u091Du0922u0927u0920u091Bu091Cu0928; // 0x28
		protected VRTK_ControllerEvents u091Au091Fu091Cu091Fu0923u0922u091Fu0929u091Du0920u0926; // 0x40
		protected VRTK_BodyPhysics u0923u0929u0925u091Fu091Bu091Cu0927u0923u091Fu091Au0927; // 0x48
		protected VRTK_ObjectControl u091Bu0923u091Eu091Cu091Du0929u0921u0922u0929u0928u091A; // 0x50
		protected GameObject u091Cu0929u0923u091Fu0920u0928u0925u0929u091Eu0928u0929; // 0x58
		protected GameObject u0924u0928u0920u0923u091Bu0926u091Fu0925u091Du0920u0927; // 0x60
		protected Transform u091Fu0928u091Fu091Du0922u0927u091Fu0929u0927u091Au0924; // 0x68
		protected u091Bu0928u0923u0923u091Cu091Bu091Bu0926u0925u091Eu0923 u0929u091Au0921u0924u0923u091Du091Eu0929u0922u091Du0925; // 0x70
		protected Vector2 u091Cu0923u0921u0925u0927u0926u091Eu091Bu0925u0929u091B; // 0x74
		protected Vector2 u0923u091Eu0924u091Eu091Eu091Du091Du0925u091Bu0928u0920; // 0x7C
		protected bool u0926u091Du0921u0920u091Fu091Bu0922u0929u091Fu0923u0921; // 0x84
		protected bool u0923u0920u0927u0922u0924u0925u0925u0928u0927u091Bu0927; // 0x85
		protected float u091Bu091Eu0920u0929u0920u091Du091Fu0920u0928u0926u091B; // 0x88
		protected float u091Du0927u0920u091Fu091Au0929u0921u0927u091Cu091Fu0928; // 0x8C
	
		// Events
		public event u091Au091Au0921u091Bu0924u0922u091Eu0922u0926u091Au0924 u091Au0929u0926u0927u0920u091Du0927u0926u091Bu0925u0922;
		public event u091Au091Au0921u091Bu0924u0922u091Eu0922u0926u091Au0924 u0923u091Eu091Bu091Au0928u0923u091Au091Fu091Au0923u091B;
	
		// Nested types
		public enum u091Bu0928u0923u0923u091Cu091Bu091Bu0926u0925u091Eu0923 // TypeDefIndex: 7635
		{
			Headset = 0,
			LeftController = 1,
			RightController = 2,
			ControlledObject = 3
		}
	
		// Constructors
		protected VRTK_ObjectControl() {} // 0x000000018131D560-0x000000018131D580
	
		// Methods
		public virtual void OnXAxisChanged(u0925u0922u0929u0926u0925u0927u0920u091Bu0923u091Au0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018131CDA0-0x000000018131CDF0
		public virtual void OnYAxisChanged(u0925u0922u0929u0926u0925u0927u0920u091Bu0923u091Au0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x000000018131CDF0-0x000000018131CE40
		protected abstract void u0925u091Au0921u091Eu091Du0920u091Bu0926u0925u091Fu0925();
		protected abstract VRTK_ObjectControl u0922u0922u091Du0928u0925u0926u091Eu0922u0922u091Cu0928();
		protected abstract bool u091Bu0929u091Cu091Bu0925u091Au0922u0929u091Eu0929u0925();
		protected abstract void u091Du091Bu0926u091Fu091Bu091Cu091Au0921u091Eu091Cu091A(bool u091Cu091Du0928u0928u0924u0927u091Fu0922u0927u091Fu0925);
		protected virtual void Awake() {} // 0x000000018131C880-0x000000018131C8F0
		protected virtual void OnEnable() {} // 0x000000018131C9B0-0x000000018131CDA0
		protected virtual void OnDisable() {} // 0x000000018086FC50-0x000000018086FC70
		protected virtual void OnDestroy() {} // 0x000000018131C940-0x000000018131C9B0
		protected virtual void Update() {} // 0x000000018131D4D0-0x000000018131D560
		protected virtual void FixedUpdate() {} // 0x000000018131C8F0-0x000000018131C940
		protected virtual u0925u0922u0929u0926u0925u0927u0920u091Bu0923u091Au0927 u0926u091Cu091Au091Eu0926u0923u0924u091Eu091Au0928u091C(Vector3 u0926u0921u0928u0922u091Eu091Au0920u0920u091Du0922u0929, float u0929u0922u0922u0925u091Cu091Du0925u091Cu091Fu0929u0928, float u0927u091Eu091Fu091Bu091Bu091Cu0927u0927u0920u0929u091A) => default; // 0x000000018131D2B0-0x000000018131D380
		protected virtual void u0929u091Au0927u0926u0924u091Bu091Cu091Eu0925u0929u0923() {} // 0x000000018131D3D0-0x000000018131D4D0
		protected virtual void u091Fu0923u0921u0921u0924u0923u0928u0929u0928u091Cu091A() {} // 0x000000018131CEF0-0x000000018131D1A0
		protected virtual bool u091Du0925u0929u0928u091Bu0925u091Du0927u091Au0927u091C() => default; // 0x000000018131CE40-0x000000018131CEF0
		protected virtual Transform u0923u091Du091Cu091Bu0929u091Cu0924u0920u0925u091Au0925() => default; // 0x000000018131D1A0-0x000000018131D2B0
		protected virtual void u0927u0923u0920u091Bu0929u091Bu0926u0927u0924u091Fu0921() {} // 0x000000018131D380-0x000000018131D3D0
	}
}
