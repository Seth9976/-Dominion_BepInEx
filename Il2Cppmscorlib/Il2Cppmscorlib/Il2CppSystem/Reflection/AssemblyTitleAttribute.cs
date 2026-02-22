using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000192 RID: 402
	public sealed class AssemblyTitleAttribute : Attribute
	{
		// Token: 0x06001B79 RID: 7033 RVA: 0x0009DC98 File Offset: 0x0009BE98
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyTitleAttribute()
		{
			Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyTitleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr);
			AssemblyTitleAttribute.NativeFieldInfoPtr_m_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr, "m_title");
			AssemblyTitleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr, 100667904);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0009DCF0 File Offset: 0x0009BEF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyTitleAttribute(string title)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyTitleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0000978F File Offset: 0x0000798F
		public AssemblyTitleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0009DD3C File Offset: 0x0009BF3C
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x00009798 File Offset: 0x00007998
		public unsafe string m_title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTitleAttribute.NativeFieldInfoPtr_m_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTitleAttribute.NativeFieldInfoPtr_m_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_m_title;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
