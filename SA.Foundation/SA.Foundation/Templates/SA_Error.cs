using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Templates
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class SA_Error : Object
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x0000727C File Offset: 0x0000547C
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Error()
		{
			Il2CppClassPointerStore<SA_Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Templates", "SA_Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Error>.NativeClassPtr);
			SA_Error.NativeFieldInfoPtr_m_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Error>.NativeClassPtr, "m_code");
			SA_Error.NativeFieldInfoPtr_m_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Error>.NativeClassPtr, "m_message");
			SA_Error.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Error>.NativeClassPtr, 100663447);
			SA_Error.NativeMethodInfoPtr_get_Code_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Error>.NativeClassPtr, 100663448);
			SA_Error.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Error>.NativeClassPtr, 100663449);
			SA_Error.NativeMethodInfoPtr_get_FullMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Error>.NativeClassPtr, 100663450);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007324 File Offset: 0x00005524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99566, RefRangeEnd = 99567, XrefRangeStart = 99563, XrefRangeEnd = 99566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Error(int code, string message = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Error>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Error.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00007380 File Offset: 0x00005580
		public unsafe int Code
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Error.NativeMethodInfoPtr_get_Code_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000073BC File Offset: 0x000055BC
		public unsafe string Message
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Error.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000073F4 File Offset: 0x000055F4
		public unsafe string FullMessage
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 99573, RefRangeEnd = 99576, XrefRangeStart = 99567, XrefRangeEnd = 99573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Error.NativeMethodInfoPtr_get_FullMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000022F0 File Offset: 0x000004F0
		public SA_Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000742C File Offset: 0x0000562C
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000022F9 File Offset: 0x000004F9
		public unsafe int m_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Error.NativeFieldInfoPtr_m_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Error.NativeFieldInfoPtr_m_code)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00007454 File Offset: 0x00005654
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002314 File Offset: 0x00000514
		public unsafe string m_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Error.NativeFieldInfoPtr_m_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Error.NativeFieldInfoPtr_m_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_m_code;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_m_message;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_FullMessage_Public_get_String_0;
	}
}
