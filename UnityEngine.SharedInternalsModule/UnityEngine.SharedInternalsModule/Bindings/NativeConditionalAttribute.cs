using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000009 RID: 9
	public class NativeConditionalAttribute : Attribute
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002D04 File Offset: 0x00000F04
		// Note: this type is marked as 'beforefieldinit'.
		static NativeConditionalAttribute()
		{
			Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeConditionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr);
			NativeConditionalAttribute.NativeFieldInfoPtr__Condition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, "<Condition>k__BackingField");
			NativeConditionalAttribute.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, "<Enabled>k__BackingField");
			NativeConditionalAttribute.NativeMethodInfoPtr_set_Condition_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663308);
			NativeConditionalAttribute.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663309);
			NativeConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr, 100663310);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000227D File Offset: 0x0000047D
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002D98 File Offset: 0x00000F98
		public unsafe string Condition
		{
			get
			{
				return this._Condition_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr_set_Condition_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000229F File Offset: 0x0000049F
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002DDC File Offset: 0x00000FDC
		public unsafe bool Enabled
		{
			get
			{
				return this._Enabled_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E1C File Offset: 0x0000101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58908, XrefRangeEnd = 58909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeConditionalAttribute(string condition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeConditionalAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000223A File Offset: 0x0000043A
		public NativeConditionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002243 File Offset: 0x00000443
		public unsafe string _Condition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Condition_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Condition_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002E90 File Offset: 0x00001090
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002262 File Offset: 0x00000462
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeConditionalAttribute.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002285 File Offset: 0x00000485
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002292 File Offset: 0x00000492
		public string StubReturnStatement
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__Condition_k__BackingField;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_Condition_Public_set_Void_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
