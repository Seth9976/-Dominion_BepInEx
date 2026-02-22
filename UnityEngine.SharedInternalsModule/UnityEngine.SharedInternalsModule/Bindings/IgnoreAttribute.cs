using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001A RID: 26
	public class IgnoreAttribute : Attribute
	{
		// Token: 0x060000AA RID: 170 RVA: 0x0000425C File Offset: 0x0000245C
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoreAttribute()
		{
			Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "IgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr);
			IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, "<DoesNotContributeToSize>k__BackingField");
			IgnoreAttribute.NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, 100663351);
			IgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, 100663352);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002651 File Offset: 0x00000851
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000042C8 File Offset: 0x000024C8
		public unsafe bool DoesNotContributeToSize
		{
			get
			{
				return this._DoesNotContributeToSize_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreAttribute.NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004308 File Offset: 0x00002508
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000262D File Offset: 0x0000082D
		public IgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00004344 File Offset: 0x00002544
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002636 File Offset: 0x00000836
		public unsafe bool _DoesNotContributeToSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField)) = value;
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
