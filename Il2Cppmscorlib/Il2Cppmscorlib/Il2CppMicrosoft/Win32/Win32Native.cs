using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000049 RID: 73
	public static class Win32Native : Object
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00035224 File Offset: 0x00033424
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Native()
		{
			Il2CppClassPointerStore<Win32Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Win32Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Native>.NativeClassPtr);
			Win32Native.NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663986);
			Win32Native.NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663987);
			Win32Native.NativeMethodInfoPtr_GetCurrentProcessId_Internal_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663988);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00035290 File Offset: 0x00033490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265955, RefRangeEnd = 265957, XrefRangeStart = 265949, XrefRangeEnd = 265955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(int hr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000352C8 File Offset: 0x000334C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265957, RefRangeEnd = 265963, XrefRangeStart = 265957, XrefRangeEnd = 265957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MakeHRFromErrorCode(int errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00035308 File Offset: 0x00033508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265966, RefRangeEnd = 265968, XrefRangeStart = 265963, XrefRangeEnd = 265966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetCurrentProcessId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_GetCurrentProcessId_Internal_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003D93 File Offset: 0x00001F93
		public Win32Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProcessId_Internal_Static_UInt32_0;

		// Token: 0x0200054B RID: 1355
		public class WIN32_FIND_DATA : Object
		{
			// Token: 0x06004E3F RID: 20031 RVA: 0x00160B38 File Offset: 0x0015ED38
			// Note: this type is marked as 'beforefieldinit'.
			static WIN32_FIND_DATA()
			{
				Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, "WIN32_FIND_DATA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr);
				Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr, "dwFileAttributes");
				Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_cFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr, "cFileName");
				Win32Native.WIN32_FIND_DATA.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr, 100663989);
			}

			// Token: 0x06004E40 RID: 20032 RVA: 0x00160BA0 File Offset: 0x0015EDA0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WIN32_FIND_DATA()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.WIN32_FIND_DATA.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E41 RID: 20033 RVA: 0x0001DA3C File Offset: 0x0001BC3C
			public WIN32_FIND_DATA(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013ED RID: 5101
			// (get) Token: 0x06004E42 RID: 20034 RVA: 0x00160BDC File Offset: 0x0015EDDC
			// (set) Token: 0x06004E43 RID: 20035 RVA: 0x0001DA45 File Offset: 0x0001BC45
			public unsafe int dwFileAttributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes)) = value;
				}
			}

			// Token: 0x170013EE RID: 5102
			// (get) Token: 0x06004E44 RID: 20036 RVA: 0x00160C04 File Offset: 0x0015EE04
			// (set) Token: 0x06004E45 RID: 20037 RVA: 0x0001DA60 File Offset: 0x0001BC60
			public unsafe string cFileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_cFileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_cFileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003F29 RID: 16169
			private static readonly IntPtr NativeFieldInfoPtr_dwFileAttributes;

			// Token: 0x04003F2A RID: 16170
			private static readonly IntPtr NativeFieldInfoPtr_cFileName;

			// Token: 0x04003F2B RID: 16171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
