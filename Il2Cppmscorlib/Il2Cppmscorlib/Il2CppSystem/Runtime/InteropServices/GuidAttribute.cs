using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000445 RID: 1093
	public sealed class GuidAttribute : Attribute
	{
		// Token: 0x060042AE RID: 17070 RVA: 0x00132750 File Offset: 0x00130950
		// Note: this type is marked as 'beforefieldinit'.
		static GuidAttribute()
		{
			Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "GuidAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr);
			GuidAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, "_val");
			GuidAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, 100672968);
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x001327A8 File Offset: 0x001309A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuidAttribute(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x00019870 File Offset: 0x00017A70
		public GuidAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x001327F4 File Offset: 0x001309F4
		// (set) Token: 0x060042B2 RID: 17074 RVA: 0x00019879 File Offset: 0x00017A79
		public unsafe string _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuidAttribute.NativeFieldInfoPtr__val);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuidAttribute.NativeFieldInfoPtr__val), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400367C RID: 13948
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400367D RID: 13949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
