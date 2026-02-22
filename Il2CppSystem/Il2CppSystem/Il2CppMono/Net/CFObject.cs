using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net
{
	// Token: 0x0200000C RID: 12
	public class CFObject : Object
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00012810 File Offset: 0x00010A10
		// Note: this type is marked as 'beforefieldinit'.
		static CFObject()
		{
			Il2CppClassPointerStore<CFObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFObject>.NativeClassPtr);
			CFObject.NativeFieldInfoPtr__Handle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFObject>.NativeClassPtr, "<Handle>k__BackingField");
			CFObject.NativeMethodInfoPtr_dlopen_Public_Static_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663429);
			CFObject.NativeMethodInfoPtr_dlsym_Private_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663430);
			CFObject.NativeMethodInfoPtr_dlclose_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663431);
			CFObject.NativeMethodInfoPtr_GetIndirect_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663432);
			CFObject.NativeMethodInfoPtr_GetCFObjectHandle_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663433);
			CFObject.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663434);
			CFObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663435);
			CFObject.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663436);
			CFObject.NativeMethodInfoPtr_set_Handle_Private_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663437);
			CFObject.NativeMethodInfoPtr_CFRetain_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663438);
			CFObject.NativeMethodInfoPtr_Retain_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663439);
			CFObject.NativeMethodInfoPtr_CFRelease_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663440);
			CFObject.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663441);
			CFObject.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663442);
			CFObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFObject>.NativeClassPtr, 100663443);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00012980 File Offset: 0x00010B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32339, XrefRangeEnd = 32342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr dlopen(string path, int mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_dlopen_Public_Static_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000129D0 File Offset: 0x00010BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32345, RefRangeEnd = 32347, XrefRangeStart = 32342, XrefRangeEnd = 32345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr dlsym(IntPtr handle, string symbol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(symbol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_dlsym_Private_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00012A20 File Offset: 0x00010C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32347, XrefRangeEnd = 32349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void dlclose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_dlclose_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00012A54 File Offset: 0x00010C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32349, XrefRangeEnd = 32350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetIndirect(IntPtr handle, string symbol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(symbol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_GetIndirect_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00012AA4 File Offset: 0x00010CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32350, XrefRangeEnd = 32357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetCFObjectHandle(IntPtr handle, string symbol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(symbol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_GetCFObjectHandle_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00012AF4 File Offset: 0x00010CF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 32360, RefRangeEnd = 32365, XrefRangeStart = 32357, XrefRangeEnd = 32360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFObject(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00012B4C File Offset: 0x00010D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32365, XrefRangeEnd = 32368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CFObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00012B88 File Offset: 0x00010D88
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00012BC4 File Offset: 0x00010DC4
		public unsafe virtual IntPtr Handle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_set_Handle_Private_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00012C04 File Offset: 0x00010E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32368, XrefRangeEnd = 32370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFRetain(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_CFRetain_Internal_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00012C44 File Offset: 0x00010E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32370, XrefRangeEnd = 32372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Retain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_Retain_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00012C78 File Offset: 0x00010E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32372, XrefRangeEnd = 32374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CFRelease(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_CFRelease_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00012CAC File Offset: 0x00010EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32374, XrefRangeEnd = 32376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00012CE0 File Offset: 0x00010EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32376, XrefRangeEnd = 32380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CFObject.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00012D2C File Offset: 0x00010F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 32384, RefRangeEnd = 32387, XrefRangeStart = 32380, XrefRangeEnd = 32384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000237D File Offset: 0x0000057D
		public CFObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00012D60 File Offset: 0x00010F60
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002386 File Offset: 0x00000586
		public unsafe IntPtr _Handle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFObject.NativeFieldInfoPtr__Handle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFObject.NativeFieldInfoPtr__Handle_k__BackingField)) = value;
			}
		}

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr__Handle_k__BackingField;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_dlopen_Public_Static_IntPtr_String_Int32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_dlsym_Private_Static_IntPtr_IntPtr_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_dlclose_Public_Static_Void_IntPtr_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetIndirect_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetCFObjectHandle_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_IntPtr_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Private_set_Void_IntPtr_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_CFRetain_Internal_Static_IntPtr_IntPtr_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Retain_Private_Void_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_CFRelease_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
