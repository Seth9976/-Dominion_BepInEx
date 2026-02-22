using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000056 RID: 86
public class GP_ParticipantResult : Object
{
	// Token: 0x060006C3 RID: 1731 RVA: 0x0002E174 File Offset: 0x0002C374
	// Note: this type is marked as 'beforefieldinit'.
	static GP_ParticipantResult()
	{
		Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_ParticipantResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr);
		GP_ParticipantResult.NativeFieldInfoPtr__Placing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, "_Placing");
		GP_ParticipantResult.NativeFieldInfoPtr__Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, "_Result");
		GP_ParticipantResult.NativeFieldInfoPtr__VersionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, "_VersionCode");
		GP_ParticipantResult.NativeFieldInfoPtr__ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, "_ParticipantId");
		GP_ParticipantResult.NativeMethodInfoPtr__ctor_Public_Void_String_GP_TBM_ParticipantResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664113);
		GP_ParticipantResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_GP_TBM_ParticipantResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664114);
		GP_ParticipantResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664115);
		GP_ParticipantResult.NativeMethodInfoPtr_get_Placing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664116);
		GP_ParticipantResult.NativeMethodInfoPtr_get_Result_Public_get_GP_TBM_ParticipantResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664117);
		GP_ParticipantResult.NativeMethodInfoPtr_get_VersionCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664118);
		GP_ParticipantResult.NativeMethodInfoPtr_get_ParticipantId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr, 100664119);
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x0002E280 File Offset: 0x0002C480
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166697, XrefRangeEnd = 166698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_ParticipantResult(string participantId, GP_TBM_ParticipantResult result, int placing)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(participantId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref placing;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr__ctor_Public_Void_String_GP_TBM_ParticipantResult_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166698, XrefRangeEnd = 166699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_ParticipantResult(int versionCode, string participantId, GP_TBM_ParticipantResult result, int placing)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref versionCode;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(participantId);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref placing;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_GP_TBM_ParticipantResult_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0002E360 File Offset: 0x0002C560
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166699, XrefRangeEnd = 166706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_ParticipantResult(Il2CppStringArray data, int index)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_ParticipantResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0002E3BC File Offset: 0x0002C5BC
	public unsafe int Placing
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr_get_Placing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
	public unsafe GP_TBM_ParticipantResult Result
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr_get_Result_Public_get_GP_TBM_ParticipantResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0002E434 File Offset: 0x0002C634
	public unsafe int VersionCode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr_get_VersionCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x060006CA RID: 1738 RVA: 0x0002E470 File Offset: 0x0002C670
	public unsafe string ParticipantId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ParticipantResult.NativeMethodInfoPtr_get_ParticipantId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00004C0B File Offset: 0x00002E0B
	public GP_ParticipantResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x060006CC RID: 1740 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
	// (set) Token: 0x060006CD RID: 1741 RVA: 0x00004C14 File Offset: 0x00002E14
	public unsafe int _Placing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__Placing);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__Placing)) = value;
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x060006CE RID: 1742 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
	// (set) Token: 0x060006CF RID: 1743 RVA: 0x00004C2F File Offset: 0x00002E2F
	public unsafe GP_TBM_ParticipantResult _Result
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__Result);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__Result)) = value;
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0002E4F8 File Offset: 0x0002C6F8
	// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00004C4A File Offset: 0x00002E4A
	public unsafe int _VersionCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__VersionCode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__VersionCode)) = value;
		}
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0002E520 File Offset: 0x0002C720
	// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00004C65 File Offset: 0x00002E65
	public unsafe string _ParticipantId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__ParticipantId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ParticipantResult.NativeFieldInfoPtr__ParticipantId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000577 RID: 1399
	private static readonly IntPtr NativeFieldInfoPtr__Placing;

	// Token: 0x04000578 RID: 1400
	private static readonly IntPtr NativeFieldInfoPtr__Result;

	// Token: 0x04000579 RID: 1401
	private static readonly IntPtr NativeFieldInfoPtr__VersionCode;

	// Token: 0x0400057A RID: 1402
	private static readonly IntPtr NativeFieldInfoPtr__ParticipantId;

	// Token: 0x0400057B RID: 1403
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_GP_TBM_ParticipantResult_Int32_0;

	// Token: 0x0400057C RID: 1404
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_GP_TBM_ParticipantResult_Int32_0;

	// Token: 0x0400057D RID: 1405
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Int32_0;

	// Token: 0x0400057E RID: 1406
	private static readonly IntPtr NativeMethodInfoPtr_get_Placing_Public_get_Int32_0;

	// Token: 0x0400057F RID: 1407
	private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_GP_TBM_ParticipantResult_0;

	// Token: 0x04000580 RID: 1408
	private static readonly IntPtr NativeMethodInfoPtr_get_VersionCode_Public_get_Int32_0;

	// Token: 0x04000581 RID: 1409
	private static readonly IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_String_0;
}
