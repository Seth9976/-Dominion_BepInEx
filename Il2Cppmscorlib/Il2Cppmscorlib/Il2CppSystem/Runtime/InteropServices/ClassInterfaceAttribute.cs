using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000440 RID: 1088
	public sealed class ClassInterfaceAttribute : Attribute
	{
		// Token: 0x060042A1 RID: 17057 RVA: 0x00132584 File Offset: 0x00130784
		// Note: this type is marked as 'beforefieldinit'.
		static ClassInterfaceAttribute()
		{
			Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ClassInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr);
			ClassInterfaceAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr, "_val");
			ClassInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr, 100672965);
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x001325DC File Offset: 0x001307DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classInterfaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000197E6 File Offset: 0x000179E6
		public ClassInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x00132624 File Offset: 0x00130824
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x000197EF File Offset: 0x000179EF
		public unsafe ClassInterfaceType _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassInterfaceAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassInterfaceAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04003623 RID: 13859
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04003624 RID: 13860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0;
	}
}
