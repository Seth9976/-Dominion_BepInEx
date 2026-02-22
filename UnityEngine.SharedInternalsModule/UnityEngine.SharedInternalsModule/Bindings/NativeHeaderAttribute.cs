using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000A RID: 10
	public class NativeHeaderAttribute : Attribute
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002EB8 File Offset: 0x000010B8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeHeaderAttribute()
		{
			Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeHeaderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr);
			NativeHeaderAttribute.NativeFieldInfoPtr__Header_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr, "<Header>k__BackingField");
			NativeHeaderAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr, 100663311);
			NativeHeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr, 100663312);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000022CF File Offset: 0x000004CF
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002F24 File Offset: 0x00001124
		public unsafe virtual string Header
		{
			get
			{
				return this._Header_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeHeaderAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002F68 File Offset: 0x00001168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58909, XrefRangeEnd = 58913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeHeaderAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeHeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000022A7 File Offset: 0x000004A7
		public NativeHeaderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002FB4 File Offset: 0x000011B4
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000022B0 File Offset: 0x000004B0
		public unsafe string _Header_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeHeaderAttribute.NativeFieldInfoPtr__Header_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeHeaderAttribute.NativeFieldInfoPtr__Header_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__Header_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
