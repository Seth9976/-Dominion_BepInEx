using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000065 RID: 101
public class GP_RTM_Network_Package : Object
{
	// Token: 0x060007DA RID: 2010 RVA: 0x00031F28 File Offset: 0x00030128
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RTM_Network_Package()
	{
		Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RTM_Network_Package");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr);
		GP_RTM_Network_Package.NativeFieldInfoPtr__playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr, "_playerId");
		GP_RTM_Network_Package.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr, "_buffer");
		GP_RTM_Network_Package.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr, 100664251);
		GP_RTM_Network_Package.NativeMethodInfoPtr_get_participantId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr, 100664252);
		GP_RTM_Network_Package.NativeMethodInfoPtr_get_buffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr, 100664253);
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00031FBC File Offset: 0x000301BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168655, RefRangeEnd = 168656, XrefRangeStart = 168643, XrefRangeEnd = 168655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RTM_Network_Package(string player, string recievedData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RTM_Network_Package>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(player);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(recievedData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Network_Package.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x060007DC RID: 2012 RVA: 0x0003201C File Offset: 0x0003021C
	public unsafe string participantId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Network_Package.NativeMethodInfoPtr_get_participantId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x060007DD RID: 2013 RVA: 0x00032054 File Offset: 0x00030254
	public unsafe Il2CppStructArray<byte> buffer
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RTM_Network_Package.NativeMethodInfoPtr_get_buffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x00005278 File Offset: 0x00003478
	public GP_RTM_Network_Package(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x060007DF RID: 2015 RVA: 0x00032094 File Offset: 0x00030294
	// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00005281 File Offset: 0x00003481
	public unsafe string _playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Network_Package.NativeFieldInfoPtr__playerId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Network_Package.NativeFieldInfoPtr__playerId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000320BC File Offset: 0x000302BC
	// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000052A0 File Offset: 0x000034A0
	public unsafe Il2CppStructArray<byte> _buffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Network_Package.NativeFieldInfoPtr__buffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RTM_Network_Package.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000663 RID: 1635
	private static readonly IntPtr NativeFieldInfoPtr__playerId;

	// Token: 0x04000664 RID: 1636
	private static readonly IntPtr NativeFieldInfoPtr__buffer;

	// Token: 0x04000665 RID: 1637
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x04000666 RID: 1638
	private static readonly IntPtr NativeMethodInfoPtr_get_participantId_Public_get_String_0;

	// Token: 0x04000667 RID: 1639
	private static readonly IntPtr NativeMethodInfoPtr_get_buffer_Public_get_Il2CppStructArray_1_Byte_0;
}
