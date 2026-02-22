using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041E RID: 1054
	[Serializable]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		// Token: 0x060041DA RID: 16858 RVA: 0x0012FE74 File Offset: 0x0012E074
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeCompatibilityAttribute()
		{
			Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeCompatibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr);
			RuntimeCompatibilityAttribute.NativeFieldInfoPtr_m_wrapNonExceptionThrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, "m_wrapNonExceptionThrows");
			RuntimeCompatibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, 100672881);
			RuntimeCompatibilityAttribute.NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, 100672882);
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x0012FEE0 File Offset: 0x0012E0E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeCompatibilityAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeCompatibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010E2 RID: 4322
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x0012FF1C File Offset: 0x0012E11C
		public unsafe bool WrapNonExceptionThrows
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeCompatibilityAttribute.NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0001919C File Offset: 0x0001739C
		public RuntimeCompatibilityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x0012FF5C File Offset: 0x0012E15C
		// (set) Token: 0x060041DF RID: 16863 RVA: 0x000191A5 File Offset: 0x000173A5
		public unsafe bool m_wrapNonExceptionThrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeCompatibilityAttribute.NativeFieldInfoPtr_m_wrapNonExceptionThrows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeCompatibilityAttribute.NativeFieldInfoPtr_m_wrapNonExceptionThrows)) = value;
			}
		}

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeFieldInfoPtr_m_wrapNonExceptionThrows;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0;
	}
}
