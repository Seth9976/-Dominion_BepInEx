using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000066 RID: 102
public class GP_RTM_ReliableMessageDeliveredResult : GP_RTM_Result
{
	// Token: 0x060007E3 RID: 2019 RVA: 0x000320EC File Offset: 0x000302EC
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RTM_ReliableMessageDeliveredResult()
	{
		Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RTM_ReliableMessageDeliveredResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr);
		GP_RTM_ReliableMessageDeliveredResult.NativeFieldInfoPtr__MessageTokenId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr, "_MessageTokenId");
		GP_RTM_ReliableMessageDeliveredResult.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr, "_Data");
		GP_RTM_ReliableMessageDeliveredResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr, 100664254);
		GP_RTM_ReliableMessageDeliveredResult.NativeMethodInfoPtr_get_MessageTokenId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr, 100664255);
		GP_RTM_ReliableMessageDeliveredResult.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr, 100664256);
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00032180 File Offset: 0x00030380
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 168657, RefRangeEnd = 168659, XrefRangeStart = 168656, XrefRangeEnd = 168657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RTM_ReliableMessageDeliveredResult(string status, string roomId, int messageTokedId, Il2CppStructArray<byte> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RTM_ReliableMessageDeliveredResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roomId);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageTokedId;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageDeliveredResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00032200 File Offset: 0x00030400
	public unsafe int MessageTokenId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageDeliveredResult.NativeMethodInfoPtr_get_MessageTokenId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0003223C File Offset: 0x0003043C
	public unsafe Il2CppStructArray<byte> Data
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageDeliveredResult.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x000052BF File Offset: 0x000034BF
	public GP_RTM_ReliableMessageDeliveredResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0003227C File Offset: 0x0003047C
	// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000052C8 File Offset: 0x000034C8
	public unsafe int _MessageTokenId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageDeliveredResult.NativeFieldInfoPtr__MessageTokenId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageDeliveredResult.NativeFieldInfoPtr__MessageTokenId)) = value;
		}
	}

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x060007EA RID: 2026 RVA: 0x000322A4 File Offset: 0x000304A4
	// (set) Token: 0x060007EB RID: 2027 RVA: 0x000052E3 File Offset: 0x000034E3
	public unsafe Il2CppStructArray<byte> _Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageDeliveredResult.NativeFieldInfoPtr__Data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageDeliveredResult.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000668 RID: 1640
	private static readonly IntPtr NativeFieldInfoPtr__MessageTokenId;

	// Token: 0x04000669 RID: 1641
	private static readonly IntPtr NativeFieldInfoPtr__Data;

	// Token: 0x0400066A RID: 1642
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Il2CppStructArray_1_Byte_0;

	// Token: 0x0400066B RID: 1643
	private static readonly IntPtr NativeMethodInfoPtr_get_MessageTokenId_Public_get_Int32_0;

	// Token: 0x0400066C RID: 1644
	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;
}
