using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200002E RID: 46
public class GP_AppInviteBuilder : Object
{
	// Token: 0x06000475 RID: 1141 RVA: 0x00025A84 File Offset: 0x00023C84
	// Note: this type is marked as 'beforefieldinit'.
	static GP_AppInviteBuilder()
	{
		Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_AppInviteBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr);
		GP_AppInviteBuilder.NativeFieldInfoPtr__Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, "_Id");
		GP_AppInviteBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663804);
		GP_AppInviteBuilder.NativeMethodInfoPtr_SetMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663805);
		GP_AppInviteBuilder.NativeMethodInfoPtr_SetDeepLink_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663806);
		GP_AppInviteBuilder.NativeMethodInfoPtr_SetCallToActionText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663807);
		GP_AppInviteBuilder.NativeMethodInfoPtr_SetGoogleAnalyticsTrackingId_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663808);
		GP_AppInviteBuilder.NativeMethodInfoPtr_SetAndroidMinimumVersionCode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663809);
		GP_AppInviteBuilder.NativeMethodInfoPtr_SetAdditionalReferralParameters_Public_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663810);
		GP_AppInviteBuilder.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr, 100663811);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00025B68 File Offset: 0x00023D68
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163712, RefRangeEnd = 163714, XrefRangeStart = 163709, XrefRangeEnd = 163712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_AppInviteBuilder(string title)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AppInviteBuilder>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00025BB4 File Offset: 0x00023DB4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163715, RefRangeEnd = 163717, XrefRangeStart = 163714, XrefRangeEnd = 163715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMessage(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_SetMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00025BF8 File Offset: 0x00023DF8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163718, RefRangeEnd = 163720, XrefRangeStart = 163717, XrefRangeEnd = 163718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDeepLink(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_SetDeepLink_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00025C3C File Offset: 0x00023E3C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163721, RefRangeEnd = 163723, XrefRangeStart = 163720, XrefRangeEnd = 163721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCallToActionText(string actionText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_SetCallToActionText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00025C80 File Offset: 0x00023E80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163723, XrefRangeEnd = 163724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoogleAnalyticsTrackingId(string trackingId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackingId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_SetGoogleAnalyticsTrackingId_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00025CC4 File Offset: 0x00023EC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163724, XrefRangeEnd = 163725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAndroidMinimumVersionCode(int versionCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref versionCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_SetAndroidMinimumVersionCode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00025D04 File Offset: 0x00023F04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163725, XrefRangeEnd = 163764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAdditionalReferralParameters(Dictionary<string, string> referralParameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(referralParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_SetAdditionalReferralParameters_Public_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x0600047D RID: 1149 RVA: 0x00025D48 File Offset: 0x00023F48
	public unsafe int Id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInviteBuilder.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00003ED4 File Offset: 0x000020D4
	public GP_AppInviteBuilder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x0600047F RID: 1151 RVA: 0x00025D84 File Offset: 0x00023F84
	// (set) Token: 0x06000480 RID: 1152 RVA: 0x00003EDD File Offset: 0x000020DD
	public unsafe int _Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInviteBuilder.NativeFieldInfoPtr__Id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInviteBuilder.NativeFieldInfoPtr__Id)) = value;
		}
	}

	// Token: 0x04000354 RID: 852
	private static readonly IntPtr NativeFieldInfoPtr__Id;

	// Token: 0x04000355 RID: 853
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000356 RID: 854
	private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_String_0;

	// Token: 0x04000357 RID: 855
	private static readonly IntPtr NativeMethodInfoPtr_SetDeepLink_Public_Void_String_0;

	// Token: 0x04000358 RID: 856
	private static readonly IntPtr NativeMethodInfoPtr_SetCallToActionText_Public_Void_String_0;

	// Token: 0x04000359 RID: 857
	private static readonly IntPtr NativeMethodInfoPtr_SetGoogleAnalyticsTrackingId_Public_Void_String_0;

	// Token: 0x0400035A RID: 858
	private static readonly IntPtr NativeMethodInfoPtr_SetAndroidMinimumVersionCode_Public_Void_Int32_0;

	// Token: 0x0400035B RID: 859
	private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalReferralParameters_Public_Void_Dictionary_2_String_String_0;

	// Token: 0x0400035C RID: 860
	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;
}
