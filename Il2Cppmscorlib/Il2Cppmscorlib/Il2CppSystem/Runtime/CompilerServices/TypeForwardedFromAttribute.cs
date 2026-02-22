using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000425 RID: 1061
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		// Token: 0x06004216 RID: 16918 RVA: 0x00130B70 File Offset: 0x0012ED70
		// Note: this type is marked as 'beforefieldinit'.
		static TypeForwardedFromAttribute()
		{
			Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TypeForwardedFromAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr);
			TypeForwardedFromAttribute.NativeFieldInfoPtr_assemblyFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, "assemblyFullName");
			TypeForwardedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, 100672917);
			TypeForwardedFromAttribute.NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, 100672918);
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x00130BDC File Offset: 0x0012EDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357103, XrefRangeEnd = 357105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeForwardedFromAttribute(string assemblyFullName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyFullName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeForwardedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x00130C28 File Offset: 0x0012EE28
		public unsafe string AssemblyFullName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeForwardedFromAttribute.NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x00019332 File Offset: 0x00017532
		public TypeForwardedFromAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x00130C60 File Offset: 0x0012EE60
		// (set) Token: 0x0600421B RID: 16923 RVA: 0x0001933B File Offset: 0x0001753B
		public unsafe string assemblyFullName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeForwardedFromAttribute.NativeFieldInfoPtr_assemblyFullName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeForwardedFromAttribute.NativeFieldInfoPtr_assemblyFullName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeFieldInfoPtr_assemblyFullName;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0;
	}
}
