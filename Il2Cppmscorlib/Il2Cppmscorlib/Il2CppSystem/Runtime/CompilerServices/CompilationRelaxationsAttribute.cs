using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000429 RID: 1065
	[Serializable]
	public class CompilationRelaxationsAttribute : Attribute
	{
		// Token: 0x06004221 RID: 16929 RVA: 0x00130D50 File Offset: 0x0012EF50
		// Note: this type is marked as 'beforefieldinit'.
		static CompilationRelaxationsAttribute()
		{
			Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilationRelaxationsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr);
			CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, "m_relaxations");
			CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100672920);
			CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100672921);
			CompilationRelaxationsAttribute.NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100672922);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00130DD0 File Offset: 0x0012EFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilationRelaxationsAttribute(int relaxations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relaxations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00130E18 File Offset: 0x0012F018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relaxations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x00130E60 File Offset: 0x0012F060
		public unsafe int CompilationRelaxations
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x0001937E File Offset: 0x0001757E
		public CompilationRelaxationsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x00130E9C File Offset: 0x0012F09C
		// (set) Token: 0x06004227 RID: 16935 RVA: 0x00019387 File Offset: 0x00017587
		public unsafe int m_relaxations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations)) = value;
			}
		}

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeFieldInfoPtr_m_relaxations;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0;

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0;
	}
}
