using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000068 RID: 104
public class GP_RTM_ReliableMessageSentResult : GP_RTM_Result
{
	// Token: 0x060007F9 RID: 2041 RVA: 0x00032564 File Offset: 0x00030764
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RTM_ReliableMessageSentResult()
	{
		Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RTM_ReliableMessageSentResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr);
		GP_RTM_ReliableMessageSentResult.NativeFieldInfoPtr__MessageTokenId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr, "_MessageTokenId");
		GP_RTM_ReliableMessageSentResult.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr, "_Data");
		GP_RTM_ReliableMessageSentResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr, 100664262);
		GP_RTM_ReliableMessageSentResult.NativeMethodInfoPtr_get_MessageTokenId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr, 100664263);
		GP_RTM_ReliableMessageSentResult.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr, 100664264);
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x000325F8 File Offset: 0x000307F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 168657, RefRangeEnd = 168659, XrefRangeStart = 168657, XrefRangeEnd = 168659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RTM_ReliableMessageSentResult(string status, string roomId, int messageTokedId, Il2CppStructArray<byte> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RTM_ReliableMessageSentResult>.NativeClassPtr))
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageSentResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x060007FB RID: 2043 RVA: 0x00032678 File Offset: 0x00030878
	public unsafe int MessageTokenId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageSentResult.NativeMethodInfoPtr_get_MessageTokenId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x060007FC RID: 2044 RVA: 0x000326B4 File Offset: 0x000308B4
	public unsafe Il2CppStructArray<byte> Data
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageSentResult.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00005360 File Offset: 0x00003560
	public GP_RTM_ReliableMessageSentResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x060007FE RID: 2046 RVA: 0x000326F4 File Offset: 0x000308F4
	// (set) Token: 0x060007FF RID: 2047 RVA: 0x00005369 File Offset: 0x00003569
	public unsafe int _MessageTokenId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageSentResult.NativeFieldInfoPtr__MessageTokenId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageSentResult.NativeFieldInfoPtr__MessageTokenId)) = value;
		}
	}

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x06000800 RID: 2048 RVA: 0x0003271C File Offset: 0x0003091C
	// (set) Token: 0x06000801 RID: 2049 RVA: 0x00005384 File Offset: 0x00003584
	public unsafe Il2CppStructArray<byte> _Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageSentResult.NativeFieldInfoPtr__Data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageSentResult.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000675 RID: 1653
	private static readonly IntPtr NativeFieldInfoPtr__MessageTokenId;

	// Token: 0x04000676 RID: 1654
	private static readonly IntPtr NativeFieldInfoPtr__Data;

	// Token: 0x04000677 RID: 1655
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Il2CppStructArray_1_Byte_0;

	// Token: 0x04000678 RID: 1656
	private static readonly IntPtr NativeMethodInfoPtr_get_MessageTokenId_Public_get_Int32_0;

	// Token: 0x04000679 RID: 1657
	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;
}
