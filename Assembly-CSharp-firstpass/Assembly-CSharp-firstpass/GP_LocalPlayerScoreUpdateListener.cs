using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200004B RID: 75
public class GP_LocalPlayerScoreUpdateListener : Object
{
	// Token: 0x0600063C RID: 1596 RVA: 0x0002C538 File Offset: 0x0002A738
	// Note: this type is marked as 'beforefieldinit'.
	static GP_LocalPlayerScoreUpdateListener()
	{
		Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_LocalPlayerScoreUpdateListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr);
		GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__RequestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, "_RequestId");
		GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__leaderboardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, "_leaderboardId");
		GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__ErrorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, "_ErrorData");
		GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr_Scores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, "Scores");
		GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, 100664056);
		GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_ReportScoreUpdate_Public_Void_GPScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, 100664057);
		GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_ReportScoreUpdateFail_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, 100664058);
		GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_get_RequestId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, 100664059);
		GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_DispatchUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr, 100664060);
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x0002C61C File Offset: 0x0002A81C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166481, XrefRangeEnd = 166488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_LocalPlayerScoreUpdateListener(int requestId, string leaderboardId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_LocalPlayerScoreUpdateListener>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref requestId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0002C678 File Offset: 0x0002A878
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166488, XrefRangeEnd = 166493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportScoreUpdate(GPScore score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_ReportScoreUpdate_Public_Void_GPScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x0002C6BC File Offset: 0x0002A8BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166493, XrefRangeEnd = 166504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportScoreUpdateFail(string errorData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_ReportScoreUpdateFail_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06000640 RID: 1600 RVA: 0x0002C700 File Offset: 0x0002A900
	public unsafe int RequestId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_get_RequestId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0002C73C File Offset: 0x0002A93C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 166531, RefRangeEnd = 166536, XrefRangeStart = 166504, XrefRangeEnd = 166531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_LocalPlayerScoreUpdateListener.NativeMethodInfoPtr_DispatchUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x0000486C File Offset: 0x00002A6C
	public GP_LocalPlayerScoreUpdateListener(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000643 RID: 1603 RVA: 0x0002C770 File Offset: 0x0002A970
	// (set) Token: 0x06000644 RID: 1604 RVA: 0x00004875 File Offset: 0x00002A75
	public unsafe int _RequestId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__RequestId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__RequestId)) = value;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000645 RID: 1605 RVA: 0x0002C798 File Offset: 0x0002A998
	// (set) Token: 0x06000646 RID: 1606 RVA: 0x00004890 File Offset: 0x00002A90
	public unsafe string _leaderboardId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__leaderboardId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__leaderboardId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
	// (set) Token: 0x06000648 RID: 1608 RVA: 0x000048AF File Offset: 0x00002AAF
	public unsafe string _ErrorData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__ErrorData);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr__ErrorData), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
	// (set) Token: 0x0600064A RID: 1610 RVA: 0x000048CE File Offset: 0x00002ACE
	public unsafe List<GPScore> Scores
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr_Scores);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GPScore>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_LocalPlayerScoreUpdateListener.NativeFieldInfoPtr_Scores), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000522 RID: 1314
	private static readonly IntPtr NativeFieldInfoPtr__RequestId;

	// Token: 0x04000523 RID: 1315
	private static readonly IntPtr NativeFieldInfoPtr__leaderboardId;

	// Token: 0x04000524 RID: 1316
	private static readonly IntPtr NativeFieldInfoPtr__ErrorData;

	// Token: 0x04000525 RID: 1317
	private static readonly IntPtr NativeFieldInfoPtr_Scores;

	// Token: 0x04000526 RID: 1318
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

	// Token: 0x04000527 RID: 1319
	private static readonly IntPtr NativeMethodInfoPtr_ReportScoreUpdate_Public_Void_GPScore_0;

	// Token: 0x04000528 RID: 1320
	private static readonly IntPtr NativeMethodInfoPtr_ReportScoreUpdateFail_Public_Void_String_0;

	// Token: 0x04000529 RID: 1321
	private static readonly IntPtr NativeMethodInfoPtr_get_RequestId_Public_get_Int32_0;

	// Token: 0x0400052A RID: 1322
	private static readonly IntPtr NativeMethodInfoPtr_DispatchUpdate_Private_Void_0;
}
