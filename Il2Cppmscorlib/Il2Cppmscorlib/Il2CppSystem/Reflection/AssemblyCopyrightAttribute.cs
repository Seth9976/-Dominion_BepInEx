using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018D RID: 397
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x0009D89C File Offset: 0x0009BA9C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyCopyrightAttribute()
		{
			Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyCopyrightAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr);
			AssemblyCopyrightAttribute.NativeFieldInfoPtr_m_copyright = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr, "m_copyright");
			AssemblyCopyrightAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr, 100667899);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0009D8F4 File Offset: 0x0009BAF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyCopyrightAttribute(string copyright)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(copyright);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyCopyrightAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000096C7 File Offset: 0x000078C7
		public AssemblyCopyrightAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0009D940 File Offset: 0x0009BB40
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x000096D0 File Offset: 0x000078D0
		public unsafe string m_copyright
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCopyrightAttribute.NativeFieldInfoPtr_m_copyright);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCopyrightAttribute.NativeFieldInfoPtr_m_copyright), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_m_copyright;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
