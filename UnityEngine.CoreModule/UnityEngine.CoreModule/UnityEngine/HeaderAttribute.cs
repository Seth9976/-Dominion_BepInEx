using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000092 RID: 146
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x0003F734 File Offset: 0x0003D934
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderAttribute()
		{
			Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HeaderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr);
			HeaderAttribute.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr, "header");
			HeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr, 100664260);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0003F78C File Offset: 0x0003D98C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00009A61 File Offset: 0x00007C61
		public HeaderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0003F7D8 File Offset: 0x0003D9D8
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00009A6A File Offset: 0x00007C6A
		public unsafe string header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderAttribute.NativeFieldInfoPtr_header);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderAttribute.NativeFieldInfoPtr_header), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
