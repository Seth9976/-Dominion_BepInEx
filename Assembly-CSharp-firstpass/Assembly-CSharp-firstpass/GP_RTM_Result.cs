using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000069 RID: 105
public class GP_RTM_Result : Object
{
	// Token: 0x06000802 RID: 2050 RVA: 0x0003274C File Offset: 0x0003094C
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RTM_Result()
	{
		Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RTM_Result");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr);
		GP_RTM_Result.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr, "_status");
		GP_RTM_Result.NativeFieldInfoPtr__roomId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr, "_roomId");
		GP_RTM_Result.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr, 100664265);
		GP_RTM_Result.NativeMethodInfoPtr_get_status_Public_get_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr, 100664266);
		GP_RTM_Result.NativeMethodInfoPtr_get_roomId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr, 100664267);
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x000327E0 File Offset: 0x000309E0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 168674, RefRangeEnd = 168677, XrefRangeStart = 168669, XrefRangeEnd = 168674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RTM_Result(string r_status, string r_roomId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RTM_Result>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(r_status);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(r_roomId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Result.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06000804 RID: 2052 RVA: 0x00032840 File Offset: 0x00030A40
	public unsafe GP_GamesStatusCodes status
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Result.NativeMethodInfoPtr_get_status_Public_get_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06000805 RID: 2053 RVA: 0x0003287C File Offset: 0x00030A7C
	public unsafe string roomId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Result.NativeMethodInfoPtr_get_roomId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x000053A3 File Offset: 0x000035A3
	public GP_RTM_Result(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06000807 RID: 2055 RVA: 0x000328B4 File Offset: 0x00030AB4
	// (set) Token: 0x06000808 RID: 2056 RVA: 0x000053AC File Offset: 0x000035AC
	public unsafe GP_GamesStatusCodes _status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Result.NativeFieldInfoPtr__status);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Result.NativeFieldInfoPtr__status)) = value;
		}
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06000809 RID: 2057 RVA: 0x000328DC File Offset: 0x00030ADC
	// (set) Token: 0x0600080A RID: 2058 RVA: 0x000053C7 File Offset: 0x000035C7
	public unsafe string _roomId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Result.NativeFieldInfoPtr__roomId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Result.NativeFieldInfoPtr__roomId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400067A RID: 1658
	private static readonly IntPtr NativeFieldInfoPtr__status;

	// Token: 0x0400067B RID: 1659
	private static readonly IntPtr NativeFieldInfoPtr__roomId;

	// Token: 0x0400067C RID: 1660
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x0400067D RID: 1661
	private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_GP_GamesStatusCodes_0;

	// Token: 0x0400067E RID: 1662
	private static readonly IntPtr NativeMethodInfoPtr_get_roomId_Public_get_String_0;
}
