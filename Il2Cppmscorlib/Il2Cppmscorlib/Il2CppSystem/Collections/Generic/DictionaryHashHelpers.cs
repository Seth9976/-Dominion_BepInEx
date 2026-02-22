using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000492 RID: 1170
	public class DictionaryHashHelpers : Object
	{
		// Token: 0x06004630 RID: 17968 RVA: 0x00141C04 File Offset: 0x0013FE04
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryHashHelpers()
		{
			Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryHashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr);
			DictionaryHashHelpers.NativeFieldInfoPtr__SerializationInfoTable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr, "<SerializationInfoTable>k__BackingField");
			DictionaryHashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryHashHelpers>.NativeClassPtr, 100673695);
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x00141C5C File Offset: 0x0013FE5C
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363749, XrefRangeEnd = 363753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryHashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x0001AB12 File Offset: 0x00018D12
		public DictionaryHashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x00141C90 File Offset: 0x0013FE90
		// (set) Token: 0x06004634 RID: 17972 RVA: 0x0001AB1B File Offset: 0x00018D1B
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> _SerializationInfoTable_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DictionaryHashHelpers.NativeFieldInfoPtr__SerializationInfoTable_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DictionaryHashHelpers.NativeFieldInfoPtr__SerializationInfoTable_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400390F RID: 14607
		private static readonly IntPtr NativeFieldInfoPtr__SerializationInfoTable_k__BackingField;

		// Token: 0x04003910 RID: 14608
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0;
	}
}
