using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200000A RID: 10
public class GADBannerIdFactory : Object
{
	// Token: 0x060000CE RID: 206 RVA: 0x00019E00 File Offset: 0x00018000
	// Note: this type is marked as 'beforefieldinit'.
	static GADBannerIdFactory()
	{
		Il2CppClassPointerStore<GADBannerIdFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GADBannerIdFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GADBannerIdFactory>.NativeClassPtr);
		GADBannerIdFactory.NativeFieldInfoPtr__nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GADBannerIdFactory>.NativeClassPtr, "_nextId");
		GADBannerIdFactory.NativeMethodInfoPtr_get_nextId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GADBannerIdFactory>.NativeClassPtr, 100663433);
		GADBannerIdFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GADBannerIdFactory>.NativeClassPtr, 100663434);
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000CF RID: 207 RVA: 0x00019E6C File Offset: 0x0001806C
	public unsafe static int nextId
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160678, RefRangeEnd = 160681, XrefRangeStart = 160673, XrefRangeEnd = 160678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GADBannerIdFactory.NativeMethodInfoPtr_get_nextId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00019E9C File Offset: 0x0001809C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GADBannerIdFactory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GADBannerIdFactory>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GADBannerIdFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000023BB File Offset: 0x000005BB
	public GADBannerIdFactory(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00019ED8 File Offset: 0x000180D8
	// (set) Token: 0x060000D3 RID: 211 RVA: 0x000023C4 File Offset: 0x000005C4
	public unsafe static int _nextId
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(GADBannerIdFactory.NativeFieldInfoPtr__nextId, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GADBannerIdFactory.NativeFieldInfoPtr__nextId, (void*)(&value));
		}
	}

	// Token: 0x040000B3 RID: 179
	private static readonly IntPtr NativeFieldInfoPtr__nextId;

	// Token: 0x040000B4 RID: 180
	private static readonly IntPtr NativeMethodInfoPtr_get_nextId_Public_Static_get_Int32_0;

	// Token: 0x040000B5 RID: 181
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
