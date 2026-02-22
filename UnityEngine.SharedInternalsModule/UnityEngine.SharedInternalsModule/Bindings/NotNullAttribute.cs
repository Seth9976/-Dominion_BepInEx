using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000013 RID: 19
	public class NotNullAttribute : Attribute
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003C3C File Offset: 0x00001E3C
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullAttribute()
		{
			Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr);
			NotNullAttribute.NativeFieldInfoPtr__Exception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, "<Exception>k__BackingField");
			NotNullAttribute.NativeMethodInfoPtr_set_Exception_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663338);
			NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663339);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002519 File Offset: 0x00000719
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public unsafe string Exception
		{
			get
			{
				return this._Exception_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr_set_Exception_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003CEC File Offset: 0x00001EEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullAttribute(string exception = "ArgumentNullException")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000024F1 File Offset: 0x000006F1
		public NotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003D38 File Offset: 0x00001F38
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000024FA File Offset: 0x000006FA
		public unsafe string _Exception_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullAttribute.NativeFieldInfoPtr__Exception_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullAttribute.NativeFieldInfoPtr__Exception_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr__Exception_k__BackingField;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_set_Exception_Public_set_Void_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
