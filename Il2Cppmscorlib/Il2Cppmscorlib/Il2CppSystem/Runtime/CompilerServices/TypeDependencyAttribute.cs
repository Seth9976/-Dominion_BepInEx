using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000433 RID: 1075
	public sealed class TypeDependencyAttribute : Attribute
	{
		// Token: 0x06004255 RID: 16981 RVA: 0x00131624 File Offset: 0x0012F824
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDependencyAttribute()
		{
			Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TypeDependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr);
			TypeDependencyAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr, "typeName");
			TypeDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr, 100672938);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0013167C File Offset: 0x0012F87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357110, XrefRangeEnd = 357111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeDependencyAttribute(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0001956D File Offset: 0x0001776D
		public TypeDependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x001316C8 File Offset: 0x0012F8C8
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x00019576 File Offset: 0x00017776
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDependencyAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDependencyAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
