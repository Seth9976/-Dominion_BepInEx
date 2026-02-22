using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B3 RID: 1203
	[Serializable]
	public sealed class ConditionalAttribute : Attribute
	{
		// Token: 0x06004727 RID: 18215 RVA: 0x00147708 File Offset: 0x00145908
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalAttribute()
		{
			Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "ConditionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr);
			ConditionalAttribute.NativeFieldInfoPtr_m_conditionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr, "m_conditionString");
			ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr, 100673866);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x00147760 File Offset: 0x00145960
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalAttribute(string conditionString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(conditionString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0001AD17 File Offset: 0x00018F17
		public ConditionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x001477AC File Offset: 0x001459AC
		// (set) Token: 0x0600472B RID: 18219 RVA: 0x0001AD20 File Offset: 0x00018F20
		public unsafe string m_conditionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalAttribute.NativeFieldInfoPtr_m_conditionString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalAttribute.NativeFieldInfoPtr_m_conditionString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeFieldInfoPtr_m_conditionString;

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
