using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200004C RID: 76
public class GP_Participant : global::Il2CppSystem.Object
{
	// Token: 0x0600064B RID: 1611 RVA: 0x0002C818 File Offset: 0x0002AA18
	// Note: this type is marked as 'beforefieldinit'.
	static GP_Participant()
	{
		Il2CppClassPointerStore<GP_Participant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_Participant");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr);
		GP_Participant.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_id");
		GP_Participant.NativeFieldInfoPtr__playerid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_playerid");
		GP_Participant.NativeFieldInfoPtr__HiResImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_HiResImageUrl");
		GP_Participant.NativeFieldInfoPtr__IconImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_IconImageUrl");
		GP_Participant.NativeFieldInfoPtr__DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_DisplayName");
		GP_Participant.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_result");
		GP_Participant.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_status");
		GP_Participant.NativeFieldInfoPtr_BigPhotoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "BigPhotoLoaded");
		GP_Participant.NativeFieldInfoPtr_SmallPhotoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "SmallPhotoLoaded");
		GP_Participant.NativeFieldInfoPtr__SmallPhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_SmallPhoto");
		GP_Participant.NativeFieldInfoPtr__BigPhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "_BigPhoto");
		GP_Participant.NativeMethodInfoPtr_add_BigPhotoLoaded_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664061);
		GP_Participant.NativeMethodInfoPtr_remove_BigPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664062);
		GP_Participant.NativeMethodInfoPtr_add_SmallPhotoLoaded_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664063);
		GP_Participant.NativeMethodInfoPtr_remove_SmallPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664064);
		GP_Participant.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664065);
		GP_Participant.NativeMethodInfoPtr_SetResult_Public_Void_GP_ParticipantResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664066);
		GP_Participant.NativeMethodInfoPtr_LoadBigPhoto_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664067);
		GP_Participant.NativeMethodInfoPtr_LoadSmallPhoto_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664068);
		GP_Participant.NativeMethodInfoPtr_get_SmallPhoto_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664069);
		GP_Participant.NativeMethodInfoPtr_get_BigPhoto_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664070);
		GP_Participant.NativeMethodInfoPtr_get_id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664071);
		GP_Participant.NativeMethodInfoPtr_get_playerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664072);
		GP_Participant.NativeMethodInfoPtr_get_HiResImageUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664073);
		GP_Participant.NativeMethodInfoPtr_get_IconImageUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664074);
		GP_Participant.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664075);
		GP_Participant.NativeMethodInfoPtr_get_Status_Public_get_GP_RTM_ParticipantStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664076);
		GP_Participant.NativeMethodInfoPtr_get_Result_Public_get_GP_ParticipantResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664077);
		GP_Participant.NativeMethodInfoPtr_HandheBigPhotoLoaed_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664078);
		GP_Participant.NativeMethodInfoPtr_HandheSmallPhotoLoaed_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, 100664079);
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0002CAA0 File Offset: 0x0002ACA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166536, XrefRangeEnd = 166540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_BigPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_add_BigPhotoLoaded_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166540, XrefRangeEnd = 166544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_BigPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_remove_BigPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0002CB28 File Offset: 0x0002AD28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166544, XrefRangeEnd = 166548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_SmallPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_add_SmallPhotoLoaded_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x0002CB6C File Offset: 0x0002AD6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166548, XrefRangeEnd = 166552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_SmallPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_remove_SmallPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166584, RefRangeEnd = 166586, XrefRangeStart = 166552, XrefRangeEnd = 166584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Participant(string uid, string playerUid, string stat, string hiResImg, string IconImg, string Name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(uid);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerUid);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stat);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hiResImg);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(IconImg);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x0002CC58 File Offset: 0x0002AE58
	[CallerCount(0)]
	public unsafe void SetResult(GP_ParticipantResult r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_SetResult_Public_Void_GP_ParticipantResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x0002CC9C File Offset: 0x0002AE9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166586, XrefRangeEnd = 166595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadBigPhoto()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_LoadBigPhoto_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x0002CCD0 File Offset: 0x0002AED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166595, XrefRangeEnd = 166604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSmallPhoto()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_LoadSmallPhoto_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000654 RID: 1620 RVA: 0x0002CD04 File Offset: 0x0002AF04
	public unsafe Texture2D SmallPhoto
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_SmallPhoto_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002CD44 File Offset: 0x0002AF44
	public unsafe Texture2D BigPhoto
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_BigPhoto_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000656 RID: 1622 RVA: 0x0002CD84 File Offset: 0x0002AF84
	public unsafe string id
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x0002CDBC File Offset: 0x0002AFBC
	public unsafe string playerId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_playerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
	public unsafe string HiResImageUrl
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_HiResImageUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002CE2C File Offset: 0x0002B02C
	public unsafe string IconImageUrl
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_IconImageUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x0002CE64 File Offset: 0x0002B064
	public unsafe string DisplayName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x0600065B RID: 1627 RVA: 0x0002CE9C File Offset: 0x0002B09C
	public unsafe GP_RTM_ParticipantStatus Status
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_Status_Public_get_GP_RTM_ParticipantStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x0600065C RID: 1628 RVA: 0x0002CED8 File Offset: 0x0002B0D8
	public unsafe GP_ParticipantResult Result
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_get_Result_Public_get_GP_ParticipantResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_ParticipantResult>(intPtr3) : null;
		}
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0002CF18 File Offset: 0x0002B118
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166604, XrefRangeEnd = 166607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandheBigPhotoLoaed(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_HandheBigPhotoLoaed_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0002CF5C File Offset: 0x0002B15C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166607, XrefRangeEnd = 166610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandheSmallPhotoLoaed(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.NativeMethodInfoPtr_HandheSmallPhotoLoaed_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x000048ED File Offset: 0x00002AED
	public GP_Participant(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
	// (set) Token: 0x06000661 RID: 1633 RVA: 0x000048F6 File Offset: 0x00002AF6
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06000662 RID: 1634 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
	// (set) Token: 0x06000663 RID: 1635 RVA: 0x00004915 File Offset: 0x00002B15
	public unsafe string _playerid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__playerid);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__playerid), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06000664 RID: 1636 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
	// (set) Token: 0x06000665 RID: 1637 RVA: 0x00004934 File Offset: 0x00002B34
	public unsafe string _HiResImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__HiResImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__HiResImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000666 RID: 1638 RVA: 0x0002D018 File Offset: 0x0002B218
	// (set) Token: 0x06000667 RID: 1639 RVA: 0x00004953 File Offset: 0x00002B53
	public unsafe string _IconImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__IconImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__IconImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000668 RID: 1640 RVA: 0x0002D040 File Offset: 0x0002B240
	// (set) Token: 0x06000669 RID: 1641 RVA: 0x00004972 File Offset: 0x00002B72
	public unsafe string _DisplayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__DisplayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002D068 File Offset: 0x0002B268
	// (set) Token: 0x0600066B RID: 1643 RVA: 0x00004991 File Offset: 0x00002B91
	public unsafe GP_ParticipantResult _result
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__result);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_ParticipantResult>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__result), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x0600066C RID: 1644 RVA: 0x0002D098 File Offset: 0x0002B298
	// (set) Token: 0x0600066D RID: 1645 RVA: 0x000049B0 File Offset: 0x00002BB0
	public unsafe GP_RTM_ParticipantStatus _status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__status);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__status)) = value;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x0600066E RID: 1646 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
	// (set) Token: 0x0600066F RID: 1647 RVA: 0x000049CB File Offset: 0x00002BCB
	public unsafe Action<Texture2D> BigPhotoLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr_BigPhotoLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr_BigPhotoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000670 RID: 1648 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
	// (set) Token: 0x06000671 RID: 1649 RVA: 0x000049EA File Offset: 0x00002BEA
	public unsafe Action<Texture2D> SmallPhotoLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr_SmallPhotoLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr_SmallPhotoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000672 RID: 1650 RVA: 0x0002D120 File Offset: 0x0002B320
	// (set) Token: 0x06000673 RID: 1651 RVA: 0x00004A09 File Offset: 0x00002C09
	public unsafe Texture2D _SmallPhoto
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__SmallPhoto);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__SmallPhoto), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000674 RID: 1652 RVA: 0x0002D150 File Offset: 0x0002B350
	// (set) Token: 0x06000675 RID: 1653 RVA: 0x00004A28 File Offset: 0x00002C28
	public unsafe Texture2D _BigPhoto
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__BigPhoto);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Participant.NativeFieldInfoPtr__BigPhoto), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400052B RID: 1323
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x0400052C RID: 1324
	private static readonly IntPtr NativeFieldInfoPtr__playerid;

	// Token: 0x0400052D RID: 1325
	private static readonly IntPtr NativeFieldInfoPtr__HiResImageUrl;

	// Token: 0x0400052E RID: 1326
	private static readonly IntPtr NativeFieldInfoPtr__IconImageUrl;

	// Token: 0x0400052F RID: 1327
	private static readonly IntPtr NativeFieldInfoPtr__DisplayName;

	// Token: 0x04000530 RID: 1328
	private static readonly IntPtr NativeFieldInfoPtr__result;

	// Token: 0x04000531 RID: 1329
	private static readonly IntPtr NativeFieldInfoPtr__status;

	// Token: 0x04000532 RID: 1330
	private static readonly IntPtr NativeFieldInfoPtr_BigPhotoLoaded;

	// Token: 0x04000533 RID: 1331
	private static readonly IntPtr NativeFieldInfoPtr_SmallPhotoLoaded;

	// Token: 0x04000534 RID: 1332
	private static readonly IntPtr NativeFieldInfoPtr__SmallPhoto;

	// Token: 0x04000535 RID: 1333
	private static readonly IntPtr NativeFieldInfoPtr__BigPhoto;

	// Token: 0x04000536 RID: 1334
	private static readonly IntPtr NativeMethodInfoPtr_add_BigPhotoLoaded_Public_add_Void_Action_1_Texture2D_0;

	// Token: 0x04000537 RID: 1335
	private static readonly IntPtr NativeMethodInfoPtr_remove_BigPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0;

	// Token: 0x04000538 RID: 1336
	private static readonly IntPtr NativeMethodInfoPtr_add_SmallPhotoLoaded_Public_add_Void_Action_1_Texture2D_0;

	// Token: 0x04000539 RID: 1337
	private static readonly IntPtr NativeMethodInfoPtr_remove_SmallPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0;

	// Token: 0x0400053A RID: 1338
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0;

	// Token: 0x0400053B RID: 1339
	private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_GP_ParticipantResult_0;

	// Token: 0x0400053C RID: 1340
	private static readonly IntPtr NativeMethodInfoPtr_LoadBigPhoto_Public_Void_0;

	// Token: 0x0400053D RID: 1341
	private static readonly IntPtr NativeMethodInfoPtr_LoadSmallPhoto_Public_Void_0;

	// Token: 0x0400053E RID: 1342
	private static readonly IntPtr NativeMethodInfoPtr_get_SmallPhoto_Public_get_Texture2D_0;

	// Token: 0x0400053F RID: 1343
	private static readonly IntPtr NativeMethodInfoPtr_get_BigPhoto_Public_get_Texture2D_0;

	// Token: 0x04000540 RID: 1344
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_String_0;

	// Token: 0x04000541 RID: 1345
	private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_String_0;

	// Token: 0x04000542 RID: 1346
	private static readonly IntPtr NativeMethodInfoPtr_get_HiResImageUrl_Public_get_String_0;

	// Token: 0x04000543 RID: 1347
	private static readonly IntPtr NativeMethodInfoPtr_get_IconImageUrl_Public_get_String_0;

	// Token: 0x04000544 RID: 1348
	private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

	// Token: 0x04000545 RID: 1349
	private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_GP_RTM_ParticipantStatus_0;

	// Token: 0x04000546 RID: 1350
	private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_GP_ParticipantResult_0;

	// Token: 0x04000547 RID: 1351
	private static readonly IntPtr NativeMethodInfoPtr_HandheBigPhotoLoaed_Private_Void_Texture2D_0;

	// Token: 0x04000548 RID: 1352
	private static readonly IntPtr NativeMethodInfoPtr_HandheSmallPhotoLoaed_Private_Void_Texture2D_0;

	// Token: 0x02000373 RID: 883
	[ObfuscatedName("GP_Participant+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060034D3 RID: 13523 RVA: 0x000DA2C4 File Offset: 0x000D84C4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GP_Participant>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr);
			GP_Participant.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr, "<>9");
			GP_Participant.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr, "<>9__15_0");
			GP_Participant.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr, "<>9__15_1");
			GP_Participant.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr, 100670022);
			GP_Participant.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr, 100670023);
			GP_Participant.__c.NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr, 100670024);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000DA368 File Offset: 0x000D8568
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_Participant.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000DA3A4 File Offset: 0x000D85A4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_0(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x000DA3E8 File Offset: 0x000D85E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_1(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Participant.__c.NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00014937 File Offset: 0x00012B37
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x000DA42C File Offset: 0x000D862C
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x00014940 File Offset: 0x00012B40
		public unsafe static GP_Participant.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GP_Participant.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_Participant.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GP_Participant.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x000DA454 File Offset: 0x000D8654
		// (set) Token: 0x060034DB RID: 13531 RVA: 0x00014952 File Offset: 0x00012B52
		public unsafe static Action<Texture2D> __9__15_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GP_Participant.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GP_Participant.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x000DA47C File Offset: 0x000D867C
		// (set) Token: 0x060034DD RID: 13533 RVA: 0x00014964 File Offset: 0x00012B64
		public unsafe static Action<Texture2D> __9__15_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GP_Participant.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GP_Participant.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_Texture2D_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_Texture2D_0;
	}
}
