using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000420 RID: 1056
	[Serializable]
	public class StateMachineAttribute : Attribute
	{
		// Token: 0x060041E8 RID: 16872 RVA: 0x00130190 File Offset: 0x0012E390
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineAttribute()
		{
			Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "StateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr);
			StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, "<StateMachineType>k__BackingField");
			StateMachineAttribute.NativeMethodInfoPtr_set_StateMachineType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, 100672887);
			StateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, 100672888);
		}

		// Token: 0x170010E5 RID: 4325
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x001301FC File Offset: 0x0012E3FC
		public unsafe Type StateMachineType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAttribute.NativeMethodInfoPtr_set_StateMachineType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x00130240 File Offset: 0x0012E440
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x000191E8 File Offset: 0x000173E8
		public StateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x0013028C File Offset: 0x0012E48C
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x000191F1 File Offset: 0x000173F1
		public unsafe Type _StateMachineType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeFieldInfoPtr__StateMachineType_k__BackingField;

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeMethodInfoPtr_set_StateMachineType_Private_set_Void_Type_0;

		// Token: 0x040035B8 RID: 13752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
