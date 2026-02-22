using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x0200001C RID: 28
	public class UsedByNativeCodeAttribute : Attribute
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000043A8 File Offset: 0x000025A8
		// Note: this type is marked as 'beforefieldinit'.
		static UsedByNativeCodeAttribute()
		{
			Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Scripting", "UsedByNativeCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr);
			UsedByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr, "<Name>k__BackingField");
			UsedByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr, 100663354);
			UsedByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr, 100663355);
			UsedByNativeCodeAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr, 100663356);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004428 File Offset: 0x00002628
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsedByNativeCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004464 File Offset: 0x00002664
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsedByNativeCodeAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedByNativeCodeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000026C3 File Offset: 0x000008C3
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000044B0 File Offset: 0x000026B0
		public unsafe string Name
		{
			get
			{
				return this._Name_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedByNativeCodeAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000269B File Offset: 0x0000089B
		public UsedByNativeCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000044F4 File Offset: 0x000026F4
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000026A4 File Offset: 0x000008A4
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
	}
}
