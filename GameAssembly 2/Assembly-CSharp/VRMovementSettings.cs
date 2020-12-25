﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using VRTK;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class VRMovementSettings : MonoBehaviour // TypeDefIndex: 7210
{
	// Fields
	private PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x18
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Player player; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_SlideObjectControlAction smoothLocomotion; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_HeightAdjustTeleport teleportLocomotion; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_Pointer leftControllerPointer; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_StraightPointerRenderer leftControllerRenderer; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_StraightPointerRenderer rightControllerRenderer; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_CustomRaycast teleportRaycast; // 0x50
	private LayerMask u091Du0921u091Bu0924u0922u091Cu091Du0927u0924u0926u091D; // 0x58
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LayerMask teleportMask; // 0x5C
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_RotateObjectControlAction smoothRotation; // 0x60
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_SnapRotateObjectControlAction snapRotation; // 0x68
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_TouchpadControl leftControllerTouchpadControl; // 0x70
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_BodyPhysics bodyPhysics; // 0x78
	public Animator u0921u0925u091Du091Cu091Au091Cu091Bu0925u0921u0920u0923; // 0x80
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_ControllerEvents leftControllerEvents; // 0x88
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_InteractGrab leftControllerGrab; // 0x90
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_InteractGrab rightControllerGrab; // 0x98
	public VRTeleportGrab u0924u091Cu091Fu0927u091Cu0923u0929u091Eu091Eu0922u091B; // 0xA0
	public VRTeleportGrab u091Du0926u0922u091Du0922u091Cu0928u0927u0926u091Bu0929; // 0xA8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private VRTK_UIPointer leftControllerUIPointer; // 0xB0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform leftControllerGrabModel; // 0xB8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform rightControllerGrabModel; // 0xC0
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform leftController; // 0xC8
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform rightController; // 0xD0

	// Constructors
	public VRMovementSettings() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	private void u091Fu0926u0925u091Fu0923u0924u091Cu0924u0926u0924u091F() {} // 0x000000018117BB40-0x000000018117BEA0
	private void u0927u091Eu0921u0920u0927u0928u0926u091Bu091Du0925u091B() {} // 0x000000018117DCD0-0x000000018117DD30
	private void u0928u0929u0927u0926u0929u0920u091Du091Eu0929u0924u091E() {} // 0x000000018117EE90-0x000000018117EFD0
	private float u0923u0925u091Au0929u091Au0929u0927u0927u0921u091Au091D(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117D1F0-0x000000018117D2F0
	public void u091Eu0928u091Fu091Fu0920u0928u0926u0922u0923u0925u0921(bool u0924u091Au091Bu0923u091Cu0925u0928u0924u0925u091Fu0929) {} // 0x000000018117B9F0-0x000000018117BA70
	private float u0924u0924u091Bu0926u0920u0927u0924u0923u0927u0925u0921(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117D730-0x000000018117D830
	private void Start() {} // 0x0000000181179B50-0x0000000181179C30
	private void u0923u091Eu091Bu091Bu0922u091Du091Eu091Du091Bu0926u091E() {} // 0x000000018117CE90-0x000000018117CF90
	public void InMenuOrJournal(bool u0924u091Au091Bu0923u091Cu0925u0928u0924u0925u091Fu0929) {} // 0x0000000181179AD0-0x0000000181179B50
	private void u091Bu091Au0925u0921u0925u0924u0922u091Cu0924u0926u091C() {} // 0x000000018117A3D0-0x000000018117A440
	private void u0929u0924u091Eu091Au0925u0925u091Au091Fu091Eu0926u091D() {} // 0x000000018117F340-0x000000018117F460
	private void u0925u091Fu0924u0924u0926u0926u0924u0921u091Au091Cu0920() {} // 0x000000018117D890-0x000000018117D9B0
	private void u0924u091Au0922u0924u0928u091Cu091Du0922u0924u0926u091B() {} // 0x000000018117D500-0x000000018117D630
	private void u091Bu0925u091Eu0920u091Bu091Du091Du0927u0924u0922u0924() {} // 0x000000018117A960-0x000000018117AA80
	private void u091Cu0921u0926u0922u0925u0920u0920u0927u091Eu0929u091C() {} // 0x000000018117ACA0-0x000000018117ADD0
	private float u0920u091Du0925u091Eu0920u0925u0929u091Eu0925u091Bu091D(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117C100-0x000000018117C200
	private void u091Cu0922u0925u091Bu091Du0921u091Cu091Fu091Au091Au091D() {} // 0x000000018117ADD0-0x000000018117AEB0
	private float u091Au0920u0921u0927u0922u091Du0924u0920u0925u0922u0923(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x0000000181179E30-0x0000000181179F30
	private void u091Eu0920u0923u091Cu0921u091Cu0925u091Eu091Eu091Eu0922() {} // 0x000000018117B7F0-0x000000018117B8D0
	private void u0923u0925u091Eu0926u0929u091Bu091Fu0924u0923u0923u091B() {} // 0x000000018117D2F0-0x000000018117D410
	private void u0923u091Cu091Eu0923u0929u091Bu091Bu0920u091Au091Bu091A() {} // 0x000000018117CD90-0x000000018117CE90
	private void u0924u091Cu091Eu0927u091Du091Au0928u091Au091Au0924u091E() {} // 0x000000018117D630-0x000000018117D730
	private void u0929u0926u091Bu0926u0929u091Du0928u091Eu0922u0927u0928() {} // 0x000000018117F460-0x000000018117F6C0
	public void u091Eu091Au0927u0923u091Au0924u0921u091Du0925u091Du0927(bool u0924u091Au091Bu0923u091Cu0925u0928u0924u0925u091Fu0929) {} // 0x000000018117B5F0-0x000000018117B670
	private void u0928u0922u0920u0928u0925u0927u091Cu0929u091Fu0920u0927() {} // 0x000000018117EDB0-0x000000018117EE90
	private float u0923u091Fu0924u0921u091Eu0927u0922u091Eu091Eu091Bu091D(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117CF90-0x000000018117D090
	public void u0922u091Eu0929u0922u0929u091Eu0925u091Cu0923u091Eu0921(bool u0924u091Au091Bu0923u091Cu0925u0928u0924u0925u091Fu0929) {} // 0x000000018117C9B0-0x000000018117CA30
	private void u0926u091Fu0922u091Du0924u091Du091Au0924u0928u091Cu0928() {} // 0x000000018117DA70-0x000000018117DCD0
	private void u091Bu091Fu0921u0925u0925u0925u0921u091Cu0928u0925u091A() {} // 0x000000018117A8F0-0x000000018117A960
	private float u0920u0920u091Du091Bu0925u091Eu0925u0929u0923u0925u0920(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117C200-0x000000018117C2F0
	private void u091Au091Eu091Fu0925u091Eu0922u0920u091Bu0920u0923u091A() {} // 0x0000000181179D60-0x0000000181179E30
	private void u0920u0929u0927u0926u0927u0922u0929u091Cu091Cu091Eu0922() {} // 0x000000018117C700-0x000000018117C880
	private void u091Du091Cu091Cu0928u0921u0921u0926u0924u091Cu091Cu0929() {} // 0x000000018117AEB0-0x000000018117B110
	private void u0927u0925u0921u091Au091Fu091Au0923u0929u091Bu091Fu0924() {} // 0x000000018117E9D0-0x000000018117EB10
	private void u091Du0925u0922u091Au0927u091Au091Bu091Cu0926u0923u0926() {} // 0x000000018117B3A0-0x000000018117B520
	private void u0920u0923u0926u0926u091Fu091Bu091Fu0920u0924u0929u0924() {} // 0x000000018117C2F0-0x000000018117C400
	private void u091Bu091Bu0923u091Bu091Fu0924u0924u0929u0927u0929u091A() {} // 0x000000018117A440-0x000000018117A540
	private void u0923u0921u091Eu0924u0924u091Bu091Au0920u091Eu091Cu0923() {} // 0x000000018117D090-0x000000018117D0F0
	private void u0922u0922u0920u0921u091Au091Fu0925u0920u0929u0927u0925() {} // 0x000000018117CB40-0x000000018117CD90
	private void u0927u0920u091Bu0927u091Du091Bu091Fu0925u0920u091Cu091A() {} // 0x000000018117E780-0x000000018117E9D0
	private void u091Cu0920u0929u0921u0922u0922u0921u0925u091Bu0926u091F() {} // 0x000000018117AB80-0x000000018117ACA0
	private void u091Eu0928u091Eu0929u091Eu0928u091Du091Fu0926u0926u0927() {} // 0x000000018117B8D0-0x000000018117B9F0
	public void u0927u091Eu0927u091Au091Eu0928u091Eu0929u091Bu0927u0927() {} // 0x000000018117DD30-0x000000018117E240
	private void u0923u0929u091Du0924u0926u0927u0921u0928u0921u0926u091F() {} // 0x000000018117D410-0x000000018117D480
	private void u091Eu0928u0920u0927u0925u0929u0920u0922u091Cu0929u091B() {} // 0x000000018117BA70-0x000000018117BAD0
	private void u091Au0921u0922u091Cu091Au0921u0923u0926u091Eu0923u0927() {} // 0x0000000181179F30-0x000000018117A290
	private void u091Du091Du0924u0926u091Cu0929u0920u0925u0923u091Fu0926() {} // 0x000000018117B110-0x000000018117B280
	private void u0925u0926u091Eu0922u0920u0923u0928u0922u0924u0923u0927() {} // 0x000000018117D9B0-0x000000018117DA70
	private void u091Eu091Eu091Cu0927u091Au091Du0925u091Eu0923u0927u0920() {} // 0x000000018117B670-0x000000018117B730
	private void u091Du0924u0920u0926u091Cu0926u0923u091Eu0924u091Du0928() {} // 0x000000018117B280-0x000000018117B3A0
	private void u091Bu0927u0922u0921u091Eu091Bu0925u0929u091Eu0929u091F() {} // 0x000000018117AA80-0x000000018117AB80
	public void u0923u0929u0921u0921u0921u091Du0926u0927u0923u0928u0927(bool u0924u091Au091Bu0923u091Cu0925u0928u0924u0925u091Fu0929) {} // 0x000000018117D480-0x000000018117D500
	private float u0923u0923u0929u0922u091Bu0924u091Cu0920u0926u091Fu0925(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117D0F0-0x000000018117D1F0
	private void Update() {} // 0x000000018117F6C0-0x000000018117F7D0
	private void u0922u091Fu0920u0924u0923u0929u091Au0927u091Fu0923u0927() {} // 0x000000018117CA30-0x000000018117CB40
	public void u091Bu091Du091Cu0926u0925u0923u0923u091Cu0923u0927u091C() {} // 0x000000018117A540-0x000000018117A8F0
	private void u091Du0929u091Cu0925u0921u0929u091Eu0924u0926u0929u091F() {} // 0x000000018117B520-0x000000018117B5F0
	public void ApplySettings() {} // 0x0000000181179830-0x0000000181179A70
	private void u0920u091Cu0926u091Au0929u0924u0922u0920u0920u091Cu091D() {} // 0x000000018117C0A0-0x000000018117C100
	private void u091Fu0927u091Au091Fu091Au0924u0925u091Cu0927u091Eu0924() {} // 0x000000018117BEA0-0x000000018117BFA0
	private void Awake() {} // 0x0000000181179A70-0x0000000181179AD0
	private void u0920u0925u091Eu091Eu091Bu0920u091Bu0921u0926u091Bu091C() {} // 0x000000018117C600-0x000000018117C700
	private void u0929u091Du091Cu091Du091Du0921u0926u091Fu091Fu091Fu0927() {} // 0x000000018117EFD0-0x000000018117F100
	private void u0921u0929u091Eu0925u0925u091Au0925u0927u091Fu091Fu091F() {} // 0x000000018117C880-0x000000018117C9B0
	private void u091Au0923u091Cu0928u0929u0929u091Eu0924u0926u0924u0928() {} // 0x000000018117A290-0x000000018117A3D0
	private void u091Au091Du0920u0921u0928u0928u0929u0923u0923u0921u091F() {} // 0x0000000181179C30-0x0000000181179D60
	private void u0920u0924u0924u0922u0922u091Fu0929u0928u091Du091Cu0929() {} // 0x000000018117C520-0x000000018117C600
	public void u0928u091Bu0923u0927u0921u0923u091Cu091Cu0926u091Du0929() {} // 0x000000018117EB10-0x000000018117EDB0
	private void u091Eu091Eu0927u0925u091Au0928u091Au091Cu091Du0929u091E() {} // 0x000000018117B730-0x000000018117B7F0
	public void u0927u091Fu0926u0922u0928u091Au091Du0922u0929u0920u0928() {} // 0x000000018117E240-0x000000018117E780
	private void u0924u0928u0926u091Bu091Du091Cu0922u091Bu0926u0922u0920() {} // 0x000000018117D830-0x000000018117D890
	private void u0929u0922u0921u0927u0926u0927u091Bu091Cu0928u0927u091C() {} // 0x000000018117F200-0x000000018117F340
	private void u091Fu0923u0921u0927u091Au0924u0923u091Eu091Bu0925u0927() {} // 0x000000018117BAD0-0x000000018117BB40
	private void u0920u091Cu091Bu0926u0920u0923u0927u091Bu091Du0925u091E() {} // 0x000000018117BFA0-0x000000018117C0A0
	private void u0920u0924u0920u0926u0926u0920u0923u091Fu0929u091Du091F() {} // 0x000000018117C400-0x000000018117C520
	private float u0929u091Fu0927u0923u091Eu091Eu0928u0925u0920u0925u0925(float u0929u0926u091Cu091Du0922u0921u0928u0928u0929u0925u091F) => default; // 0x000000018117F100-0x000000018117F200
}
