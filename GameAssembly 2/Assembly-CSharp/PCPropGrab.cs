﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class PCPropGrab : MonoBehaviour // TypeDefIndex: 7196
{
	// Fields
	private float u0921u0920u0926u0924u091Fu0929u091Bu0929u0927u091Eu0924; // 0x18
	private Ray u091Bu0923u0925u0927u0925u091Fu0922u091Au0920u0922u091F; // 0x1C
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PhotonView view; // 0x38
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Player player; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PCCanvas pcCanvas; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PCFlashlight pcFlashlight; // 0x50
	public List<PhotonObjectInteract> u0926u0925u0928u0921u0921u0920u0920u0922u0924u091Du091A; // 0x58
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public int u091Au0920u0924u0925u091Bu0925u0926u0926u091Fu091Eu0929; // 0x60
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Camera playerCam; // 0x68
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private LayerMask mask; // 0x70
	[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
	public FixedJoint u0927u091Fu0925u0920u0923u0921u091Cu0925u091Fu091Bu091B; // 0x78
	public Transform u0921u0923u091Cu091Eu0924u091Du091Eu091Fu091Au0922u0920; // 0x80
	private bool u091Du0926u0925u0922u0922u0924u0925u0922u091Du0920u0926; // 0x88

	// Constructors
	public PCPropGrab() {} // 0x0000000180D9DE30-0x0000000180D9DEB0

	// Methods
	private void Update() {} // 0x0000000180D9DA30-0x0000000180D9DE30
	public void u0929u091Au0924u091Du0929u0921u091Cu0924u0927u091Bu091C(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9CCA0-0x0000000180D9CD70
	private void u0928u091Au091Au091Eu0920u0923u0925u0928u0926u0927u091D() {} // 0x0000000180D9C760-0x0000000180D9C9A0
	private void u091Fu0922u0924u091Cu0925u091Fu0927u0926u0925u091Du0924(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D95100-0x0000000180D95440
	private void u0927u091Du0925u0926u091Du091Bu0926u091Fu0928u091Bu0929() {} // 0x0000000180D9BC30-0x0000000180D9C550
	public void u0920u0929u0920u091Fu0928u0926u0928u0920u091Du091Au0925(float u0924u091Du0928u0927u0925u091Au091Du0929u0926u091Fu0927) {} // 0x0000000180D95660-0x0000000180D95750
	public void u0923u091Eu091Fu0928u0929u091Cu091Bu0923u091Eu0929u0922(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D974D0-0x0000000180D976E0
	public void OnInteract(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8EBE0-0x0000000180D8ECB0
	public void u0924u091Fu0929u091Fu0927u091Au091Au091Du0928u091Fu0920(int u0920u091Fu0926u0929u0925u0929u0927u0925u091Bu0922u0926) {} // 0x0000000180D98850-0x0000000180D99290
	private void u091Eu0927u0925u091Bu0920u0927u091Au0922u0926u0921u0922() {} // 0x0000000180D92AE0-0x0000000180D93430
	private void u091Au0928u091Au091Bu091Cu091Fu0922u091Du0925u0925u091A() {} // 0x0000000180D90230-0x0000000180D906C0
	public void u0921u0929u0925u0927u091Au091Fu091Bu0925u0921u091Du091E(float u0924u091Du0928u0927u0925u091Au091Du0929u0926u091Fu0927) {} // 0x0000000180D96730-0x0000000180D96820
	public void u091Du0920u0921u0924u091Fu0925u0925u0923u0926u0925u0927() {} // 0x0000000180D914B0-0x0000000180D91DD0
	private void u0925u0924u091Cu0927u091Bu091Bu091Du0928u0923u091Fu0924(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D99D60-0x0000000180D99F90
	public void u091Cu0920u091Eu091Bu091Eu0929u0928u0923u091Fu0923u0922(int u0920u091Fu0926u0929u0925u0929u0927u0925u091Bu0922u0926) {} // 0x0000000180D90940-0x0000000180D91390
	private void u091Fu091Cu091Fu0921u0922u0926u0922u091Fu091Du0923u0929(PhotonObjectInteract u0928u091Du091Cu0923u0924u0925u0929u091Fu0927u0925u0920) {} // 0x0000000180D93EE0-0x0000000180D945C0
	private IEnumerator u0924u091Eu091Bu0921u0921u0928u091Bu091Bu091Fu091Bu0924() => default; // 0x0000000180D987E0-0x0000000180D98850
	public void u091Fu091Cu0922u0920u0922u0926u0920u091Cu091Bu0925u0928(float u0924u091Du0928u0927u0925u091Au091Du0929u0926u091Fu0927) {} // 0x0000000180D945C0-0x0000000180D946B0
	private void u091Du0928u0922u0928u0928u0927u0921u091Bu091Fu0927u0927() {} // 0x0000000180D91E40-0x0000000180D92080
	private void u0922u0923u091Cu091Cu0928u091Fu091Au0929u091Fu091Cu091F() {} // 0x0000000180D96820-0x0000000180D97150
	// [IteratorStateMachine] // 0x00000001800FF6C0-0x00000001800FF710
	private IEnumerator u0921u091Fu0924u0924u091Bu0922u0926u0926u091Bu091Au091D() => default; // 0x0000000180D965D0-0x0000000180D96640
	public void u0929u0920u091Eu0929u0927u091Au0922u091Cu091Cu0924u0925(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9CF70-0x0000000180D9D110
	private void u0928u091Fu091Au091Du091Cu0929u091Bu091Fu0928u0927u0922() {} // 0x0000000180D9C9A0-0x0000000180D9CBE0
	public void OnInventorySwapScroll(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8ECB0-0x0000000180D8EE60
	public void PlayerDied() {} // 0x0000000180D8F440-0x0000000180D8F4B0
	public void OnPickup(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8EFA0-0x0000000180D8F1B0
	private void u0922u0925u091Du0921u091Cu091Au0924u0920u0920u0926u0925() {} // 0x0000000180D97150-0x0000000180D97210
	public void ControlSchemeChanged() {} // 0x0000000180D8CEC0-0x0000000180D8CF40
	private void u0920u0924u091Du0926u0923u0926u091Du0929u0928u0921u0920(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D95440-0x0000000180D95660
	private void u091Eu0927u091Du0929u091Bu091Fu0920u0929u0920u0926u0922(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D928C0-0x0000000180D92AE0
	public void u0925u0921u091Cu091Du0924u0925u0925u091Du091Cu091Cu0927(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D99290-0x0000000180D99430
	public void u0921u0928u091Au091Bu0926u0926u0926u091Du091Bu0929u0921(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D96640-0x0000000180D96730
	public void u0926u091Fu0921u0928u0924u0928u091Du0927u0921u091Au0927() {} // 0x0000000180D9AC30-0x0000000180D9ACA0
	private void u091Du091Fu0920u0922u0924u0922u0920u091Au0924u091Cu0924(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B, bool u0925u091Au0924u0921u0925u0923u091Du091Eu091Du0929u0921) {} // 0x0000000180D91400-0x0000000180D914B0
	public void u0921u091Eu091Cu0923u0922u0926u0922u0926u0925u091Au0928() {} // 0x0000000180D96550-0x0000000180D965D0
	private void u0925u0921u0927u0922u091Au0926u0929u0921u091Cu0927u0924() {} // 0x0000000180D99430-0x0000000180D99D60
	public void OnPrimaryUse(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8F1B0-0x0000000180D8F350
	public void u0929u091Fu091Au091Du0925u0926u0920u091Fu091Eu0925u0926(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9CE30-0x0000000180D9CF70
	public void u0926u0921u091Du091Au091Bu091Au0925u0929u091Bu0926u0926() {} // 0x0000000180D9AFE0-0x0000000180D9B060
	public void u0922u0927u091Cu091Du091Eu0922u091Cu0922u0922u0923u091D(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D97210-0x0000000180D97420
	private void u091Au091Au091Fu091Bu0927u091Fu0920u0920u091Cu091Du0927(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D8FEF0-0x0000000180D90230
	public void OnSecondaryUse(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8F350-0x0000000180D8F440
	public void u091Fu0920u0924u0923u0924u091Eu0925u091Bu0927u091Eu0929(int u0920u091Fu0926u0929u0925u0929u0927u0925u091Bu0922u0926) {} // 0x0000000180D946B0-0x0000000180D95100
	public void u091Fu091Bu0925u091Au091Au091Fu0925u0925u091Cu091Du091D() {} // 0x0000000180D93E70-0x0000000180D93EE0
	private void u0929u091Au0925u091Fu0927u0922u091Au0929u0921u091Cu0922() {} // 0x0000000180D9CD70-0x0000000180D9CE30
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void EnableOrDisableObject(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B, bool u0925u091Au0924u0921u0925u0923u091Du091Eu091Du0929u0921) {} // 0x0000000180D8E420-0x0000000180D8E4D0
	public void u0926u091Du091Au091Au0922u091Bu0926u091Au0929u0924u091A(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9A9A0-0x0000000180D9AA90
	private void u0929u0927u091Au091Du091Cu0923u0923u091Eu0926u091Fu0927() {} // 0x0000000180D9D7F0-0x0000000180D9DA30
	public void u0923u0922u0926u091Au0922u091Cu0928u0921u0922u091Du091D() {} // 0x0000000180D97880-0x0000000180D98190
	private void u0921u091Cu0921u091Eu0920u0924u0920u0920u0922u0926u091E() {} // 0x0000000180D95CD0-0x0000000180D96550
	private void u0923u0926u0921u091Eu091Bu091Cu091Au0925u091Au0920u091B() {} // 0x0000000180D98260-0x0000000180D986F0
	public void u091Bu0927u0927u091Bu0922u0927u091Fu091Eu091Fu0920u0922(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D906C0-0x0000000180D90800
	public void u0923u0923u0923u091Cu0924u091Eu0928u091Bu0926u091Fu0926(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D98190-0x0000000180D98260
	public void SwitchHand(int u0920u091Fu0926u0929u0925u0929u0927u0925u091Bu0922u0926) {} // 0x0000000180D8F4B0-0x0000000180D8FEF0
	public void u091Cu091Fu091Bu091Bu0927u091Cu091Au0920u0924u0922u0927(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D90800-0x0000000180D90940
	private void u0929u0921u091Du0929u0929u091Au0928u091Eu0924u0928u0927(PhotonObjectInteract u0928u091Du091Cu0923u0924u0925u0929u091Fu0927u0925u0920) {} // 0x0000000180D9D110-0x0000000180D9D7F0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NetworkedGrab(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D8E4D0-0x0000000180D8E800
	public void u0926u0926u091Eu0923u0926u091Cu0922u0924u0920u0922u091D(int u0920u091Fu0926u0929u0925u0929u0927u0925u091Bu0922u0926) {} // 0x0000000180D9B060-0x0000000180D9BAB0
	private void u0926u0920u091Fu091Cu0921u0920u0925u091Bu0922u0922u091F(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D9ACA0-0x0000000180D9AFE0
	public void u0924u091Au091Bu091Cu091Fu091Au0921u0928u0922u091Eu0927(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D986F0-0x0000000180D987E0
	public void u0923u0920u091Bu0926u0929u0925u0920u091Bu0925u0920u091D(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D976E0-0x0000000180D97880
	public void u0926u091Fu091Cu0929u0921u0920u091Au0929u0921u0921u0928(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9AA90-0x0000000180D9AC30
	private void u0926u0928u0920u0923u0929u0924u091Du0927u0927u0924u0920(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B, bool u0925u091Au0924u0921u0925u0923u091Du091Eu091Du0929u0921) {} // 0x0000000180D9BAB0-0x0000000180D9BB60
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void NetworkedUnGrab(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D8E800-0x0000000180D8EA30
	public void u0925u0929u0927u0927u0925u0920u0929u0927u0928u0922u091B(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D99F90-0x0000000180D9A0D0
	public void u091Du0929u091Au091Au091Bu0921u091Bu091Bu0923u0920u0921(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D92080-0x0000000180D92290
	private void OnDisable() {} // 0x0000000180D8EA30-0x0000000180D8EAF0
	public void OnDrop(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8EAF0-0x0000000180D8EBE0
	public void OnInventorySwap(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D8EE60-0x0000000180D8EFA0
	private IEnumerator u091Cu0920u0924u0921u0925u091Du091Fu091Fu0923u0929u0929() => default; // 0x0000000180D91390-0x0000000180D91400
	public void Drop(bool u0920u0920u091Eu0924u0922u0926u0929u0923u0922u0921u0927) {} // 0x0000000180D8D8A0-0x0000000180D8E420
	public void DropAllInventoryProps() {} // 0x0000000180D8CF40-0x0000000180D8D8A0
	private void u091Eu0926u0921u0926u091Du0929u091Au0922u091Du0929u0924() {} // 0x0000000180D92430-0x0000000180D928C0
	private void u0921u091Au091Du091Au0922u091Eu0927u091Du091Fu0920u091F() {} // 0x0000000180D95750-0x0000000180D95990
	private void u0921u091Au0921u091Du091Bu0924u091Cu0925u0925u0926u091F(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B) {} // 0x0000000180D95990-0x0000000180D95CD0
	public void u091Eu091Cu0924u0926u0929u0927u091Au0926u0921u0925u0928(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D92290-0x0000000180D92430
	private IEnumerator u091Du0924u091Eu091Au0920u091Au0927u091Cu0927u091Bu091C() => default; // 0x0000000180D91DD0-0x0000000180D91E40
	public void u0927u0921u091Eu0928u091Du091Bu091Cu0922u091Fu091Bu0929(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9C550-0x0000000180D9C6F0
	private IEnumerator u0927u0926u0925u0929u0927u0927u0923u091Du091Cu0926u0921() => default; // 0x0000000180D9C6F0-0x0000000180D9C760
	public void ChangeItemSpotWithFOV(float u0924u091Du0928u0927u0925u091Au091Du0929u0926u091Fu0927) {} // 0x0000000180D8CDD0-0x0000000180D8CEC0
	public void u0927u091Au091Eu091Fu0921u0928u091Bu0923u0921u091Du0929(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000180D9BB60-0x0000000180D9BC30
	private void u0923u091Au0921u091Bu091Au091Au091Au091Bu0922u0926u091A(int u0920u091Eu091Bu0928u0928u0923u0923u0929u0929u0925u091B, bool u0925u091Au0924u0921u0925u0923u091Du091Eu091Du0929u0921) {} // 0x0000000180D97420-0x0000000180D974D0
	public void u091Eu0929u0923u091Fu0921u091Cu0927u0921u0926u0929u0923(int u0920u091Fu0926u0929u0925u0929u0927u0925u091Bu0922u0926) {} // 0x0000000180D93430-0x0000000180D93E70
	private void u0928u0920u0923u091Fu091Du0923u091Cu0924u091Bu0927u0926() {} // 0x0000000180D9CBE0-0x0000000180D9CCA0
	public void u0926u091Au0923u0926u0928u0929u0924u0923u0923u091Fu0921() {} // 0x0000000180D9A0D0-0x0000000180D9A9A0
}

