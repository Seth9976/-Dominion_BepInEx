using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x02000011 RID: 17
	public class CFString : CFObject
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x000131E4 File Offset: 0x000113E4
		// Note: this type is marked as 'beforefieldinit'.
		static CFString()
		{
			Il2CppClassPointerStore<CFString>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFString>.NativeClassPtr);
			CFString.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFString>.NativeClassPtr, "str");
			CFString.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663453);
			CFString.NativeMethodInfoPtr_CFStringCreateWithCharacters_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663454);
			CFString.NativeMethodInfoPtr_Create_Public_Static_CFString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663455);
			CFString.NativeMethodInfoPtr_CFStringGetLength_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663456);
			CFString.NativeMethodInfoPtr_CFStringGetCharactersPtr_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663457);
			CFString.NativeMethodInfoPtr_CFStringGetCharacters_Private_Static_IntPtr_IntPtr_CFRange_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663458);
			CFString.NativeMethodInfoPtr_AsString_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663459);
			CFString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFString>.NativeClassPtr, 100663460);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000132C8 File Offset: 0x000114C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32388, RefRangeEnd = 32390, XrefRangeStart = 32388, XrefRangeEnd = 32390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFString(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00013320 File Offset: 0x00011520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32421, XrefRangeEnd = 32423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr_CFStringCreateWithCharacters_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0001337C File Offset: 0x0001157C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32434, RefRangeEnd = 32436, XrefRangeStart = 32423, XrefRangeEnd = 32434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFString Create(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr_Create_Public_Static_CFString_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFString>(intPtr3) : null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000133C0 File Offset: 0x000115C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32436, XrefRangeEnd = 32438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFStringGetLength(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr_CFStringGetLength_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00013400 File Offset: 0x00011600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32438, XrefRangeEnd = 32440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFStringGetCharactersPtr(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr_CFStringGetCharactersPtr_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00013440 File Offset: 0x00011640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32440, XrefRangeEnd = 32442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr_CFStringGetCharacters_Private_Static_IntPtr_IntPtr_CFRange_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0001349C File Offset: 0x0001169C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 32465, RefRangeEnd = 32469, XrefRangeStart = 32442, XrefRangeEnd = 32465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AsString(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFString.NativeMethodInfoPtr_AsString_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000134D4 File Offset: 0x000116D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32469, XrefRangeEnd = 32470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CFString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000023E5 File Offset: 0x000005E5
		public CFString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00013518 File Offset: 0x00011718
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000023EE File Offset: 0x000005EE
		public unsafe string str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFString.NativeFieldInfoPtr_str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFString.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_str;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_CFStringCreateWithCharacters_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CFString_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_CFStringGetLength_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_CFStringGetCharactersPtr_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_CFStringGetCharacters_Private_Static_IntPtr_IntPtr_CFRange_IntPtr_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Static_String_IntPtr_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
