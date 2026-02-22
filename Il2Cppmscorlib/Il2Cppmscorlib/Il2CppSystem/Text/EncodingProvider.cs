using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200016E RID: 366
	public class EncodingProvider : Object
	{
		// Token: 0x0600190A RID: 6410 RVA: 0x00092910 File Offset: 0x00090B10
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingProvider()
		{
			Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr);
			EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_InternalSyncObject");
			EncodingProvider.NativeFieldInfoPtr_s_providers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_providers");
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667481);
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667482);
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667483);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667484);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667485);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667486);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x000929E0 File Offset: 0x00090BE0
		[CallerCount(0)]
		public unsafe virtual Encoding GetEncoding(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00092A3C File Offset: 0x00090C3C
		[CallerCount(0)]
		public unsafe virtual Encoding GetEncoding(int codepage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00092A94 File Offset: 0x00090C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311560, XrefRangeEnd = 311562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoderFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoderFallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00092B10 File Offset: 0x00090D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311562, XrefRangeEnd = 311572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00092B50 File Offset: 0x00090D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311572, XrefRangeEnd = 311582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(string encodingName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encodingName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00092B94 File Offset: 0x00090D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311582, XrefRangeEnd = 311592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00008BC7 File Offset: 0x00006DC7
		public EncodingProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00092BF8 File Offset: 0x00090DF8
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00008BD0 File Offset: 0x00006DD0
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00092C20 File Offset: 0x00090E20
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x00008BE2 File Offset: 0x00006DE2
		public unsafe static Il2CppReferenceArray<EncodingProvider> s_providers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingProvider.NativeFieldInfoPtr_s_providers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EncodingProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingProvider.NativeFieldInfoPtr_s_providers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_s_providers;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;
	}
}
