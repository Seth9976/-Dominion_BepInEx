using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000DB RID: 219
public class AndroidSocialGate : MonoBehaviour
{
	// Token: 0x06000FBC RID: 4028 RVA: 0x0004E804 File Offset: 0x0004CA04
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidSocialGate()
	{
		Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidSocialGate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr);
		AndroidSocialGate.NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, "_Instance");
		AndroidSocialGate.NativeFieldInfoPtr_OnShareIntentCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, "OnShareIntentCallback");
		AndroidSocialGate.NativeFieldInfoPtr_s_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, "s_message");
		AndroidSocialGate.NativeFieldInfoPtr_s_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, "s_caption");
		AndroidSocialGate.NativeMethodInfoPtr_add_OnShareIntentCallback_Public_Static_add_Void_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665252);
		AndroidSocialGate.NativeMethodInfoPtr_remove_OnShareIntentCallback_Public_Static_rem_Void_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665253);
		AndroidSocialGate.NativeMethodInfoPtr_StartGooglePlusShare_Public_Static_Void_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665254);
		AndroidSocialGate.NativeMethodInfoPtr_StartVideoPickerAndShareIntent_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665255);
		AndroidSocialGate.NativeMethodInfoPtr_OnVideoPickedHandler_Private_Static_Void_AndroidVideoPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665256);
		AndroidSocialGate.NativeMethodInfoPtr_StartVideoShareIntent_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665257);
		AndroidSocialGate.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665258);
		AndroidSocialGate.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665259);
		AndroidSocialGate.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_Il2CppReferenceArray_1_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665260);
		AndroidSocialGate.NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_Il2CppReferenceArray_1_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665261);
		AndroidSocialGate.NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665262);
		AndroidSocialGate.NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665263);
		AndroidSocialGate.NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665264);
		AndroidSocialGate.NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665265);
		AndroidSocialGate.NativeMethodInfoPtr_ShareTwitterGif_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665266);
		AndroidSocialGate.NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665267);
		AndroidSocialGate.NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665268);
		AndroidSocialGate.NativeMethodInfoPtr_CheckAndCreateInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665269);
		AndroidSocialGate.NativeMethodInfoPtr_ShareCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665270);
		AndroidSocialGate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, 100665271);
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x0004EA14 File Offset: 0x0004CC14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180495, RefRangeEnd = 180496, XrefRangeStart = 180484, XrefRangeEnd = 180495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnShareIntentCallback(Action<bool, string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_add_OnShareIntentCallback_Public_Static_add_Void_Action_2_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x0004EA4C File Offset: 0x0004CC4C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180507, RefRangeEnd = 180508, XrefRangeStart = 180496, XrefRangeEnd = 180507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnShareIntentCallback(Action<bool, string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_remove_OnShareIntentCallback_Public_Static_rem_Void_Action_2_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x0004EA84 File Offset: 0x0004CC84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180525, RefRangeEnd = 180526, XrefRangeStart = 180508, XrefRangeEnd = 180525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartGooglePlusShare(string text, Texture2D texture = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartGooglePlusShare_Public_Static_Void_String_Texture2D_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x0004EACC File Offset: 0x0004CCCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180526, XrefRangeEnd = 180550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartVideoPickerAndShareIntent(string message, string caption)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(caption);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartVideoPickerAndShareIntent_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x0004EB14 File Offset: 0x0004CD14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180550, XrefRangeEnd = 180578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnVideoPickedHandler(AndroidVideoPickResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_OnVideoPickedHandler_Private_Static_Void_AndroidVideoPickResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0004EB4C File Offset: 0x0004CD4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180578, XrefRangeEnd = 180585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartVideoShareIntent(string videoFilePath, string message, string caption)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(videoFilePath);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(caption);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartVideoShareIntent_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x0004EBA8 File Offset: 0x0004CDA8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180592, RefRangeEnd = 180594, XrefRangeStart = 180585, XrefRangeEnd = 180592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntent(string caption, string message, string packageNamePattern = "")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageNamePattern);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x0004EC04 File Offset: 0x0004CE04
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 180615, RefRangeEnd = 180620, XrefRangeStart = 180594, XrefRangeEnd = 180615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntent(string caption, string message, Texture2D texture, string packageNamePattern = "")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageNamePattern);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x0004EC70 File Offset: 0x0004CE70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180620, XrefRangeEnd = 180629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntent(string caption, string message, Il2CppReferenceArray<Texture2D> textures, string packageNamePattern = "")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textures);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageNamePattern);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_Il2CppReferenceArray_1_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x0004ECDC File Offset: 0x0004CEDC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180658, RefRangeEnd = 180659, XrefRangeStart = 180629, XrefRangeEnd = 180658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntentWithSubject(string caption, string message, string subject, Il2CppReferenceArray<Texture2D> textures, string packageNamePattern = "")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textures);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageNamePattern);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_Il2CppReferenceArray_1_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x0004ED5C File Offset: 0x0004CF5C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180664, RefRangeEnd = 180665, XrefRangeStart = 180659, XrefRangeEnd = 180664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntentWithSubject(string caption, string message, string subject, string packageNamePattern = "")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageNamePattern);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180665, XrefRangeEnd = 180680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartShareIntentWithSubject(string caption, string message, string subject, Texture2D texture, string packageNamePattern = "")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageNamePattern);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x0004EE48 File Offset: 0x0004D048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180680, XrefRangeEnd = 180706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMail(string caption, string message, string subject, string recipients, Il2CppReferenceArray<Texture2D> textures)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(recipients);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textures);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_Il2CppReferenceArray_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0004EEC8 File Offset: 0x0004D0C8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180727, RefRangeEnd = 180729, XrefRangeStart = 180706, XrefRangeEnd = 180727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMail(string caption, string message, string subject, string recipients, Texture2D texture = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subject);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(recipients);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_Texture2D_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x0004EF48 File Offset: 0x0004D148
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180729, XrefRangeEnd = 180730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShareTwitterGif(string gifPath, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(gifPath);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_ShareTwitterGif_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x0004EF90 File Offset: 0x0004D190
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180744, RefRangeEnd = 180745, XrefRangeStart = 180730, XrefRangeEnd = 180744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendTextMessage(string body, string recepient)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(body);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(recepient);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x0004EFD8 File Offset: 0x0004D1D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180768, RefRangeEnd = 180769, XrefRangeStart = 180745, XrefRangeEnd = 180768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendTextMessage(string body, List<string> recipients)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(body);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipients);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_List_1_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x0004F020 File Offset: 0x0004D220
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 180808, RefRangeEnd = 180818, XrefRangeStart = 180769, XrefRangeEnd = 180808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckAndCreateInstance()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_CheckAndCreateInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x0004F048 File Offset: 0x0004D248
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180818, XrefRangeEnd = 180844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShareCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr_ShareCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x0004F08C File Offset: 0x0004D28C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidSocialGate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x00007EB3 File Offset: 0x000060B3
	public AndroidSocialGate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0004F0C8 File Offset: 0x0004D2C8
	// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00007EBC File Offset: 0x000060BC
	public unsafe static AndroidSocialGate _Instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidSocialGate.NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidSocialGate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidSocialGate.NativeFieldInfoPtr__Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0004F0F0 File Offset: 0x0004D2F0
	// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00007ECE File Offset: 0x000060CE
	public unsafe static Action<bool, string> OnShareIntentCallback
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidSocialGate.NativeFieldInfoPtr_OnShareIntentCallback, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidSocialGate.NativeFieldInfoPtr_OnShareIntentCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0004F118 File Offset: 0x0004D318
	// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00007EE0 File Offset: 0x000060E0
	public unsafe static string s_message
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidSocialGate.NativeFieldInfoPtr_s_message, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidSocialGate.NativeFieldInfoPtr_s_message, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0004F138 File Offset: 0x0004D338
	// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00007EF2 File Offset: 0x000060F2
	public unsafe static string s_caption
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidSocialGate.NativeFieldInfoPtr_s_caption, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidSocialGate.NativeFieldInfoPtr_s_caption, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000C78 RID: 3192
	private static readonly IntPtr NativeFieldInfoPtr__Instance;

	// Token: 0x04000C79 RID: 3193
	private static readonly IntPtr NativeFieldInfoPtr_OnShareIntentCallback;

	// Token: 0x04000C7A RID: 3194
	private static readonly IntPtr NativeFieldInfoPtr_s_message;

	// Token: 0x04000C7B RID: 3195
	private static readonly IntPtr NativeFieldInfoPtr_s_caption;

	// Token: 0x04000C7C RID: 3196
	private static readonly IntPtr NativeMethodInfoPtr_add_OnShareIntentCallback_Public_Static_add_Void_Action_2_Boolean_String_0;

	// Token: 0x04000C7D RID: 3197
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnShareIntentCallback_Public_Static_rem_Void_Action_2_Boolean_String_0;

	// Token: 0x04000C7E RID: 3198
	private static readonly IntPtr NativeMethodInfoPtr_StartGooglePlusShare_Public_Static_Void_String_Texture2D_0;

	// Token: 0x04000C7F RID: 3199
	private static readonly IntPtr NativeMethodInfoPtr_StartVideoPickerAndShareIntent_Public_Static_Void_String_String_0;

	// Token: 0x04000C80 RID: 3200
	private static readonly IntPtr NativeMethodInfoPtr_OnVideoPickedHandler_Private_Static_Void_AndroidVideoPickResult_0;

	// Token: 0x04000C81 RID: 3201
	private static readonly IntPtr NativeMethodInfoPtr_StartVideoShareIntent_Public_Static_Void_String_String_String_0;

	// Token: 0x04000C82 RID: 3202
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_String_0;

	// Token: 0x04000C83 RID: 3203
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_Texture2D_String_0;

	// Token: 0x04000C84 RID: 3204
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntent_Public_Static_Void_String_String_Il2CppReferenceArray_1_Texture2D_String_0;

	// Token: 0x04000C85 RID: 3205
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_Il2CppReferenceArray_1_Texture2D_String_0;

	// Token: 0x04000C86 RID: 3206
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000C87 RID: 3207
	private static readonly IntPtr NativeMethodInfoPtr_StartShareIntentWithSubject_Public_Static_Void_String_String_String_Texture2D_String_0;

	// Token: 0x04000C88 RID: 3208
	private static readonly IntPtr NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_Il2CppReferenceArray_1_Texture2D_0;

	// Token: 0x04000C89 RID: 3209
	private static readonly IntPtr NativeMethodInfoPtr_SendMail_Public_Static_Void_String_String_String_String_Texture2D_0;

	// Token: 0x04000C8A RID: 3210
	private static readonly IntPtr NativeMethodInfoPtr_ShareTwitterGif_Public_Static_Void_String_String_0;

	// Token: 0x04000C8B RID: 3211
	private static readonly IntPtr NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_String_0;

	// Token: 0x04000C8C RID: 3212
	private static readonly IntPtr NativeMethodInfoPtr_SendTextMessage_Public_Static_Void_String_List_1_String_0;

	// Token: 0x04000C8D RID: 3213
	private static readonly IntPtr NativeMethodInfoPtr_CheckAndCreateInstance_Private_Static_Void_0;

	// Token: 0x04000C8E RID: 3214
	private static readonly IntPtr NativeMethodInfoPtr_ShareCallback_Private_Void_String_0;

	// Token: 0x04000C8F RID: 3215
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000393 RID: 915
	[ObfuscatedName("AndroidSocialGate+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x000DF5E0 File Offset: 0x000DD7E0
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidSocialGate.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidSocialGate>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidSocialGate.__c>.NativeClassPtr);
			AndroidSocialGate.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSocialGate.__c>.NativeClassPtr, "<>9");
			AndroidSocialGate.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate.__c>.NativeClassPtr, 100670221);
			AndroidSocialGate.__c.NativeMethodInfoPtr___cctor_b__24_0_Internal_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSocialGate.__c>.NativeClassPtr, 100670222);
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x000DF648 File Offset: 0x000DD848
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidSocialGate.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x000DF684 File Offset: 0x000DD884
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__24_0(bool <p0>, string <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSocialGate.__c.NativeMethodInfoPtr___cctor_b__24_0_Internal_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x000151D9 File Offset: 0x000133D9
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x000DF6D4 File Offset: 0x000DD8D4
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x000151E2 File Offset: 0x000133E2
		public unsafe static AndroidSocialGate.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidSocialGate.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidSocialGate.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidSocialGate.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__24_0_Internal_Void_Boolean_String_0;
	}
}
