using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000087 RID: 135
	[Serializable]
	public sealed class CLSCompliantAttribute : Attribute
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x00047C3C File Offset: 0x00045E3C
		// Note: this type is marked as 'beforefieldinit'.
		static CLSCompliantAttribute()
		{
			Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CLSCompliantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr);
			CLSCompliantAttribute.NativeFieldInfoPtr_m_compliant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, "m_compliant");
			CLSCompliantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, 100664638);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00047C94 File Offset: 0x00045E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278039, XrefRangeEnd = 278040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CLSCompliantAttribute(bool isCompliant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCompliant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CLSCompliantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0000481E File Offset: 0x00002A1E
		public CLSCompliantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00047CDC File Offset: 0x00045EDC
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x00004827 File Offset: 0x00002A27
		public unsafe bool m_compliant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CLSCompliantAttribute.NativeFieldInfoPtr_m_compliant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CLSCompliantAttribute.NativeFieldInfoPtr_m_compliant)) = value;
			}
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_m_compliant;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
