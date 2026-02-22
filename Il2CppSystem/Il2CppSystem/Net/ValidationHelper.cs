using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000CE RID: 206
	public static class ValidationHelper : Object
	{
		// Token: 0x06000BF4 RID: 3060 RVA: 0x0003D5AC File Offset: 0x0003B7AC
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationHelper()
		{
			Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ValidationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr);
			ValidationHelper.NativeFieldInfoPtr_EmptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "EmptyArray");
			ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidMethodChars");
			ValidationHelper.NativeFieldInfoPtr_InvalidParamChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidParamChars");
			ValidationHelper.NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100664982);
			ValidationHelper.NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100664983);
			ValidationHelper.NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100664984);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0003D654 File Offset: 0x0003B854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46037, RefRangeEnd = 46039, XrefRangeStart = 46037, XrefRangeEnd = 46037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeStringNull(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0003D690 File Offset: 0x0003B890
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 46039, RefRangeEnd = 46275, XrefRangeStart = 46039, XrefRangeEnd = 46039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlankString(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46275, RefRangeEnd = 46276, XrefRangeStart = 46275, XrefRangeEnd = 46275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateTcpPort(int port)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref port;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00006B74 File Offset: 0x00004D74
		public ValidationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0003D714 File Offset: 0x0003B914
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00006B7D File Offset: 0x00004D7D
		public unsafe static Il2CppStringArray EmptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_EmptyArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_EmptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0003D73C File Offset: 0x0003B93C
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00006B8F File Offset: 0x00004D8F
		public unsafe static Il2CppStructArray<char> InvalidMethodChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0003D764 File Offset: 0x0003B964
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00006BA1 File Offset: 0x00004DA1
		public unsafe static Il2CppStructArray<char> InvalidParamChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_InvalidParamChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_InvalidParamChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_EmptyArray;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_InvalidMethodChars;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_InvalidParamChars;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0;
	}
}
