using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200002D RID: 45
public class GP_AppInvite : Object
{
	// Token: 0x06000469 RID: 1129 RVA: 0x00025838 File Offset: 0x00023A38
	// Note: this type is marked as 'beforefieldinit'.
	static GP_AppInvite()
	{
		Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_AppInvite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr);
		GP_AppInvite.NativeFieldInfoPtr__Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, "_Id");
		GP_AppInvite.NativeFieldInfoPtr__DeepLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, "_DeepLink");
		GP_AppInvite.NativeFieldInfoPtr__IsOpenedFromPlayStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, "_IsOpenedFromPlayStore");
		GP_AppInvite.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, 100663800);
		GP_AppInvite.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, 100663801);
		GP_AppInvite.NativeMethodInfoPtr_get_DeepLink_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, 100663802);
		GP_AppInvite.NativeMethodInfoPtr_get_IsOpenedFromPlayStore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr, 100663803);
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x000258F4 File Offset: 0x00023AF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163705, XrefRangeEnd = 163709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_AppInvite(string id, string link = "", bool isOpenedFromPlatStore = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AppInvite>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(link);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpenedFromPlatStore;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvite.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x0600046B RID: 1131 RVA: 0x00025960 File Offset: 0x00023B60
	public unsafe string Id
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvite.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x0600046C RID: 1132 RVA: 0x00025998 File Offset: 0x00023B98
	public unsafe string DeepLink
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvite.NativeMethodInfoPtr_get_DeepLink_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x0600046D RID: 1133 RVA: 0x000259D0 File Offset: 0x00023BD0
	public unsafe bool IsOpenedFromPlayStore
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvite.NativeMethodInfoPtr_get_IsOpenedFromPlayStore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00003E72 File Offset: 0x00002072
	public GP_AppInvite(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x0600046F RID: 1135 RVA: 0x00025A0C File Offset: 0x00023C0C
	// (set) Token: 0x06000470 RID: 1136 RVA: 0x00003E7B File Offset: 0x0000207B
	public unsafe string _Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInvite.NativeFieldInfoPtr__Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInvite.NativeFieldInfoPtr__Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x00025A34 File Offset: 0x00023C34
	// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003E9A File Offset: 0x0000209A
	public unsafe string _DeepLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInvite.NativeFieldInfoPtr__DeepLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInvite.NativeFieldInfoPtr__DeepLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000473 RID: 1139 RVA: 0x00025A5C File Offset: 0x00023C5C
	// (set) Token: 0x06000474 RID: 1140 RVA: 0x00003EB9 File Offset: 0x000020B9
	public unsafe bool _IsOpenedFromPlayStore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInvite.NativeFieldInfoPtr__IsOpenedFromPlayStore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AppInvite.NativeFieldInfoPtr__IsOpenedFromPlayStore)) = value;
		}
	}

	// Token: 0x0400034D RID: 845
	private static readonly IntPtr NativeFieldInfoPtr__Id;

	// Token: 0x0400034E RID: 846
	private static readonly IntPtr NativeFieldInfoPtr__DeepLink;

	// Token: 0x0400034F RID: 847
	private static readonly IntPtr NativeFieldInfoPtr__IsOpenedFromPlayStore;

	// Token: 0x04000350 RID: 848
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;

	// Token: 0x04000351 RID: 849
	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

	// Token: 0x04000352 RID: 850
	private static readonly IntPtr NativeMethodInfoPtr_get_DeepLink_Public_get_String_0;

	// Token: 0x04000353 RID: 851
	private static readonly IntPtr NativeMethodInfoPtr_get_IsOpenedFromPlayStore_Public_get_Boolean_0;
}
