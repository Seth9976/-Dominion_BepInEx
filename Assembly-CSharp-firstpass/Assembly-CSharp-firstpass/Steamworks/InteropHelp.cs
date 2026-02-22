using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x020002BF RID: 703
	public class InteropHelp : Object
	{
		// Token: 0x06002849 RID: 10313 RVA: 0x000AED34 File Offset: 0x000ACF34
		// Note: this type is marked as 'beforefieldinit'.
		static InteropHelp()
		{
			Il2CppClassPointerStore<InteropHelp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InteropHelp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr);
			InteropHelp.NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668449);
			InteropHelp.NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668450);
			InteropHelp.NativeMethodInfoPtr_TestIfAvailableGameServer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668451);
			InteropHelp.NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668452);
			InteropHelp.NativeMethodInfoPtr_ByteArrayToStringUTF8_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668453);
			InteropHelp.NativeMethodInfoPtr_StringToByteArrayUTF8_Public_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668454);
			InteropHelp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100668455);
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x000AEDF0 File Offset: 0x000ACFF0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestIfPlatformSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x000AEE18 File Offset: 0x000AD018
		[CallerCount(796)]
		[CachedScanResults(RefRangeStart = 207932, RefRangeEnd = 208728, XrefRangeStart = 207927, XrefRangeEnd = 207932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestIfAvailableClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000AEE40 File Offset: 0x000AD040
		[CallerCount(377)]
		[CachedScanResults(RefRangeStart = 208733, RefRangeEnd = 209110, XrefRangeStart = 208728, XrefRangeEnd = 208733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestIfAvailableGameServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_TestIfAvailableGameServer_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000AEE68 File Offset: 0x000AD068
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 209126, RefRangeEnd = 209222, XrefRangeStart = 209110, XrefRangeEnd = 209126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeUtf8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000AEEA0 File Offset: 0x000AD0A0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 209224, RefRangeEnd = 209257, XrefRangeStart = 209222, XrefRangeEnd = 209224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ByteArrayToStringUTF8(Il2CppStructArray<byte> buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_ByteArrayToStringUTF8_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x000AEEDC File Offset: 0x000AD0DC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 209261, RefRangeEnd = 209296, XrefRangeStart = 209257, XrefRangeEnd = 209261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StringToByteArrayUTF8(string str, Il2CppStructArray<byte> outArrayBuffer, int outArrayBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArrayBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outArrayBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_StringToByteArrayUTF8_Public_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000AEF34 File Offset: 0x000AD134
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteropHelp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00010485 File Offset: 0x0000E685
		public InteropHelp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_TestIfAvailableGameServer_Public_Static_Void_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_ByteArrayToStringUTF8_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_StringToByteArrayUTF8_Public_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A9 RID: 937
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x06003744 RID: 14148 RVA: 0x000E20D4 File Offset: 0x000E02D4
			// Note: this type is marked as 'beforefieldinit'.
			static UTF8StringHandle()
			{
				Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, "UTF8StringHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr);
				InteropHelp.UTF8StringHandle.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr, 100670319);
				InteropHelp.UTF8StringHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr, 100670320);
			}

			// Token: 0x06003745 RID: 14149 RVA: 0x000E2128 File Offset: 0x000E0328
			[CallerCount(313)]
			[CachedScanResults(RefRangeStart = 207535, RefRangeEnd = 207848, XrefRangeStart = 207523, XrefRangeEnd = 207535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF8StringHandle(string str)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.UTF8StringHandle.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003746 RID: 14150 RVA: 0x000E2174 File Offset: 0x000E0374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207848, XrefRangeEnd = 207852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteropHelp.UTF8StringHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003747 RID: 14151 RVA: 0x0001565F File Offset: 0x0001385F
			public UTF8StringHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400324A RID: 12874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x0400324B RID: 12875
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}

		// Token: 0x020003AA RID: 938
		public class SteamParamStringArray : Object
		{
			// Token: 0x06003748 RID: 14152 RVA: 0x000E21BC File Offset: 0x000E03BC
			// Note: this type is marked as 'beforefieldinit'.
			static SteamParamStringArray()
			{
				Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, "SteamParamStringArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr);
				InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, "m_Strings");
				InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_ptrStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, "m_ptrStrings");
				InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_pSteamParamStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, "m_pSteamParamStringArray");
				InteropHelp.SteamParamStringArray.NativeMethodInfoPtr__ctor_Public_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, 100670321);
				InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, 100670322);
				InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SteamParamStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, 100670323);
			}

			// Token: 0x06003749 RID: 14153 RVA: 0x000E2260 File Offset: 0x000E0460
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 207899, RefRangeEnd = 207910, XrefRangeStart = 207852, XrefRangeEnd = 207899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SteamParamStringArray(IList<string> strings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(strings);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.SteamParamStringArray.NativeMethodInfoPtr__ctor_Public_Void_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600374A RID: 14154 RVA: 0x000E22AC File Offset: 0x000E04AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207910, XrefRangeEnd = 207927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600374B RID: 14155 RVA: 0x000E22E8 File Offset: 0x000E04E8
			[CallerCount(0)]
			public unsafe static implicit operator IntPtr(InteropHelp.SteamParamStringArray that)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SteamParamStringArray_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600374C RID: 14156 RVA: 0x00015668 File Offset: 0x00013868
			public SteamParamStringArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x0600374D RID: 14157 RVA: 0x000E232C File Offset: 0x000E052C
			// (set) Token: 0x0600374E RID: 14158 RVA: 0x00015671 File Offset: 0x00013871
			public unsafe Il2CppStructArray<IntPtr> m_Strings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_Strings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x0600374F RID: 14159 RVA: 0x000E235C File Offset: 0x000E055C
			// (set) Token: 0x06003750 RID: 14160 RVA: 0x00015690 File Offset: 0x00013890
			public unsafe IntPtr m_ptrStrings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_ptrStrings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_ptrStrings)) = value;
				}
			}

			// Token: 0x17000D3B RID: 3387
			// (get) Token: 0x06003751 RID: 14161 RVA: 0x000E2384 File Offset: 0x000E0584
			// (set) Token: 0x06003752 RID: 14162 RVA: 0x000156AB File Offset: 0x000138AB
			public unsafe IntPtr m_pSteamParamStringArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_pSteamParamStringArray);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_pSteamParamStringArray)) = value;
				}
			}

			// Token: 0x0400324C RID: 12876
			private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

			// Token: 0x0400324D RID: 12877
			private static readonly IntPtr NativeFieldInfoPtr_m_ptrStrings;

			// Token: 0x0400324E RID: 12878
			private static readonly IntPtr NativeFieldInfoPtr_m_pSteamParamStringArray;

			// Token: 0x0400324F RID: 12879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_String_0;

			// Token: 0x04003250 RID: 12880
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04003251 RID: 12881
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SteamParamStringArray_0;
		}
	}
}
