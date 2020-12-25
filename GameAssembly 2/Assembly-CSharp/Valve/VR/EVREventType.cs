﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public enum EVREventType // TypeDefIndex: 8237
	{
		VREvent_None = 0,
		VREvent_TrackedDeviceActivated = 100,
		VREvent_TrackedDeviceDeactivated = 101,
		VREvent_TrackedDeviceUpdated = 102,
		VREvent_TrackedDeviceUserInteractionStarted = 103,
		VREvent_TrackedDeviceUserInteractionEnded = 104,
		VREvent_IpdChanged = 105,
		VREvent_EnterStandbyMode = 106,
		VREvent_LeaveStandbyMode = 107,
		VREvent_TrackedDeviceRoleChanged = 108,
		VREvent_WatchdogWakeUpRequested = 109,
		VREvent_LensDistortionChanged = 110,
		VREvent_PropertyChanged = 111,
		VREvent_ButtonPress = 200,
		VREvent_ButtonUnpress = 201,
		VREvent_ButtonTouch = 202,
		VREvent_ButtonUntouch = 203,
		VREvent_MouseMove = 300,
		VREvent_MouseButtonDown = 301,
		VREvent_MouseButtonUp = 302,
		VREvent_FocusEnter = 303,
		VREvent_FocusLeave = 304,
		VREvent_Scroll = 305,
		VREvent_TouchPadMove = 306,
		VREvent_OverlayFocusChanged = 307,
		VREvent_InputFocusCaptured = 400,
		VREvent_InputFocusReleased = 401,
		VREvent_SceneFocusLost = 402,
		VREvent_SceneFocusGained = 403,
		VREvent_SceneApplicationChanged = 404,
		VREvent_SceneFocusChanged = 405,
		VREvent_InputFocusChanged = 406,
		VREvent_SceneApplicationSecondaryRenderingStarted = 407,
		VREvent_HideRenderModels = 410,
		VREvent_ShowRenderModels = 411,
		VREvent_OverlayShown = 500,
		VREvent_OverlayHidden = 501,
		VREvent_DashboardActivated = 502,
		VREvent_DashboardDeactivated = 503,
		VREvent_DashboardThumbSelected = 504,
		VREvent_DashboardRequested = 505,
		VREvent_ResetDashboard = 506,
		VREvent_RenderToast = 507,
		VREvent_ImageLoaded = 508,
		VREvent_ShowKeyboard = 509,
		VREvent_HideKeyboard = 510,
		VREvent_OverlayGamepadFocusGained = 511,
		VREvent_OverlayGamepadFocusLost = 512,
		VREvent_OverlaySharedTextureChanged = 513,
		VREvent_DashboardGuideButtonDown = 514,
		VREvent_DashboardGuideButtonUp = 515,
		VREvent_ScreenshotTriggered = 516,
		VREvent_ImageFailed = 517,
		VREvent_DashboardOverlayCreated = 518,
		VREvent_RequestScreenshot = 520,
		VREvent_ScreenshotTaken = 521,
		VREvent_ScreenshotFailed = 522,
		VREvent_SubmitScreenshotToDashboard = 523,
		VREvent_ScreenshotProgressToDashboard = 524,
		VREvent_PrimaryDashboardDeviceChanged = 525,
		VREvent_Notification_Shown = 600,
		VREvent_Notification_Hidden = 601,
		VREvent_Notification_BeginInteraction = 602,
		VREvent_Notification_Destroyed = 603,
		VREvent_Quit = 700,
		VREvent_ProcessQuit = 701,
		VREvent_QuitAborted_UserPrompt = 702,
		VREvent_QuitAcknowledged = 703,
		VREvent_DriverRequestedQuit = 704,
		VREvent_ChaperoneDataHasChanged = 800,
		VREvent_ChaperoneUniverseHasChanged = 801,
		VREvent_ChaperoneTempDataHasChanged = 802,
		VREvent_ChaperoneSettingsHaveChanged = 803,
		VREvent_SeatedZeroPoseReset = 804,
		VREvent_AudioSettingsHaveChanged = 820,
		VREvent_BackgroundSettingHasChanged = 850,
		VREvent_CameraSettingsHaveChanged = 851,
		VREvent_ReprojectionSettingHasChanged = 852,
		VREvent_ModelSkinSettingsHaveChanged = 853,
		VREvent_EnvironmentSettingsHaveChanged = 854,
		VREvent_PowerSettingsHaveChanged = 855,
		VREvent_EnableHomeAppSettingsHaveChanged = 856,
		VREvent_StatusUpdate = 900,
		VREvent_MCImageUpdated = 1000,
		VREvent_FirmwareUpdateStarted = 1100,
		VREvent_FirmwareUpdateFinished = 1101,
		VREvent_KeyboardClosed = 1200,
		VREvent_KeyboardCharInput = 1201,
		VREvent_KeyboardDone = 1202,
		VREvent_ApplicationTransitionStarted = 1300,
		VREvent_ApplicationTransitionAborted = 1301,
		VREvent_ApplicationTransitionNewAppStarted = 1302,
		VREvent_ApplicationListUpdated = 1303,
		VREvent_ApplicationMimeTypeLoad = 1304,
		VREvent_ApplicationTransitionNewAppLaunchComplete = 1305,
		VREvent_ProcessConnected = 1306,
		VREvent_ProcessDisconnected = 1307,
		VREvent_Compositor_MirrorWindowShown = 1400,
		VREvent_Compositor_MirrorWindowHidden = 1401,
		VREvent_Compositor_ChaperoneBoundsShown = 1410,
		VREvent_Compositor_ChaperoneBoundsHidden = 1411,
		VREvent_TrackedCamera_StartVideoStream = 1500,
		VREvent_TrackedCamera_StopVideoStream = 1501,
		VREvent_TrackedCamera_PauseVideoStream = 1502,
		VREvent_TrackedCamera_ResumeVideoStream = 1503,
		VREvent_TrackedCamera_EditingSurface = 1550,
		VREvent_PerformanceTest_EnableCapture = 1600,
		VREvent_PerformanceTest_DisableCapture = 1601,
		VREvent_PerformanceTest_FidelityLevel = 1602,
		VREvent_MessageOverlay_Closed = 1650,
		VREvent_VendorSpecific_Reserved_Start = 10000,
		VREvent_VendorSpecific_Reserved_End = 19999
	}
}
