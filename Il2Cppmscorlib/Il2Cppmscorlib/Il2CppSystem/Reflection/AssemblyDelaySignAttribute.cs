using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000198 RID: 408
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x0009E160 File Offset: 0x0009C360
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDelaySignAttribute()
		{
			Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDelaySignAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr);
			AssemblyDelaySignAttribute.NativeFieldInfoPtr_m_delaySign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, "m_delaySign");
			AssemblyDelaySignAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, 100667910);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0009E1B8 File Offset: 0x0009C3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316822, XrefRangeEnd = 316823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDelaySignAttribute(bool delaySign)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delaySign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDelaySignAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0000987F File Offset: 0x00007A7F
		public AssemblyDelaySignAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0009E200 File Offset: 0x0009C400
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x00009888 File Offset: 0x00007A88
		public unsafe bool m_delaySign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDelaySignAttribute.NativeFieldInfoPtr_m_delaySign);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDelaySignAttribute.NativeFieldInfoPtr_m_delaySign)) = value;
			}
		}

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeFieldInfoPtr_m_delaySign;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
