using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000067 RID: 103
public class GP_RTM_ReliableMessageListener : Object
{
	// Token: 0x060007EC RID: 2028 RVA: 0x000322D4 File Offset: 0x000304D4
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RTM_ReliableMessageListener()
	{
		Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RTM_ReliableMessageListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr);
		GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, "_Data");
		GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__DataTokenId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, "_DataTokenId");
		GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__ReliableMessagesCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, "_ReliableMessagesCounter");
		GP_RTM_ReliableMessageListener.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, 100664257);
		GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_ReportSentMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, 100664258);
		GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_ReportDeliveredMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, 100664259);
		GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_get_DataTokenId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, 100664260);
		GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr, 100664261);
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000323A4 File Offset: 0x000305A4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 168660, RefRangeEnd = 168662, XrefRangeStart = 168659, XrefRangeEnd = 168660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RTM_ReliableMessageListener(int dataTokenId, Il2CppStructArray<byte> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RTM_ReliableMessageListener>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dataTokenId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageListener.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00032400 File Offset: 0x00030600
	[CallerCount(0)]
	public unsafe void ReportSentMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_ReportSentMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00032434 File Offset: 0x00030634
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168662, XrefRangeEnd = 168669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportDeliveredMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_ReportDeliveredMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00032468 File Offset: 0x00030668
	public unsafe int DataTokenId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_get_DataTokenId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000324A4 File Offset: 0x000306A4
	public unsafe Il2CppStructArray<byte> Data
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_ReliableMessageListener.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00005302 File Offset: 0x00003502
	public GP_RTM_ReliableMessageListener(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x060007F3 RID: 2035 RVA: 0x000324E4 File Offset: 0x000306E4
	// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000530B File Offset: 0x0000350B
	public unsafe Il2CppStructArray<byte> _Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__Data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00032514 File Offset: 0x00030714
	// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0000532A File Offset: 0x0000352A
	public unsafe int _DataTokenId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__DataTokenId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__DataTokenId)) = value;
		}
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0003253C File Offset: 0x0003073C
	// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00005345 File Offset: 0x00003545
	public unsafe int _ReliableMessagesCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__ReliableMessagesCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_ReliableMessageListener.NativeFieldInfoPtr__ReliableMessagesCounter)) = value;
		}
	}

	// Token: 0x0400066D RID: 1645
	private static readonly IntPtr NativeFieldInfoPtr__Data;

	// Token: 0x0400066E RID: 1646
	private static readonly IntPtr NativeFieldInfoPtr__DataTokenId;

	// Token: 0x0400066F RID: 1647
	private static readonly IntPtr NativeFieldInfoPtr__ReliableMessagesCounter;

	// Token: 0x04000670 RID: 1648
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Byte_0;

	// Token: 0x04000671 RID: 1649
	private static readonly IntPtr NativeMethodInfoPtr_ReportSentMessage_Public_Void_0;

	// Token: 0x04000672 RID: 1650
	private static readonly IntPtr NativeMethodInfoPtr_ReportDeliveredMessage_Public_Void_0;

	// Token: 0x04000673 RID: 1651
	private static readonly IntPtr NativeMethodInfoPtr_get_DataTokenId_Public_get_Int32_0;

	// Token: 0x04000674 RID: 1652
	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;
}
