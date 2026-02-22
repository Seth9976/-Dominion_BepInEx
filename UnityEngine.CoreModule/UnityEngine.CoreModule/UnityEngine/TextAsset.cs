using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace UnityEngine
{
	// Token: 0x020000C1 RID: 193
	public class TextAsset : Object
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x00045880 File Offset: 0x00043A80
		// Note: this type is marked as 'beforefieldinit'.
		static TextAsset()
		{
			Il2CppClassPointerStore<TextAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAsset>.NativeClassPtr);
			TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664468);
			TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664469);
			TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664470);
			TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100664471);
			TextAsset.GetPreviewBytesDelegateField = IL2CPP.ResolveICall<TextAsset.GetPreviewBytesDelegate>("UnityEngine.TextAsset::GetPreviewBytes");
			TextAsset.Internal_CreateInstanceDelegateField = IL2CPP.ResolveICall<TextAsset.Internal_CreateInstanceDelegate>("UnityEngine.TextAsset::Internal_CreateInstance");
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x00045920 File Offset: 0x00043B20
		public unsafe Il2CppStructArray<byte> bytes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72587, RefRangeEnd = 72588, XrefRangeStart = 72585, XrefRangeEnd = 72587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x00045960 File Offset: 0x00043B60
		public unsafe string text
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 72591, RefRangeEnd = 72596, XrefRangeStart = 72588, XrefRangeEnd = 72591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00045998 File Offset: 0x00043B98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 72591, RefRangeEnd = 72596, XrefRangeStart = 72591, XrefRangeEnd = 72596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000459DC File Offset: 0x00043BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72613, RefRangeEnd = 72615, XrefRangeStart = 72596, XrefRangeEnd = 72613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0000A556 File Offset: 0x00008756
		public TextAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00045A18 File Offset: 0x00043C18
		public Il2CppStructArray<byte> GetPreviewBytes(int maxByteCount)
		{
			IntPtr intPtr = TextAsset.GetPreviewBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), maxByteCount);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0000A55F File Offset: 0x0000875F
		public static void Internal_CreateInstance(TextAsset self, string text)
		{
			TextAsset.Internal_CreateInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(text));
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00045A48 File Offset: 0x00043C48
		public string GetPreview(int maxChars)
		{
			return TextAsset.DecodeString(this.GetPreviewBytes(maxChars * 4));
		}

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly TextAsset.GetPreviewBytesDelegate GetPreviewBytesDelegateField;

		// Token: 0x04000CE0 RID: 3296
		private static readonly TextAsset.Internal_CreateInstanceDelegate Internal_CreateInstanceDelegateField;

		// Token: 0x020007A8 RID: 1960
		public static class EncodingUtility : Object
		{
			// Token: 0x06002CEF RID: 11503 RVA: 0x000153BA File Offset: 0x000135BA
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingUtility()
			{
				Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, "EncodingUtility");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "encodingLookup");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "targetEncoding");
			}

			// Token: 0x06002CF0 RID: 11504 RVA: 0x000153F8 File Offset: 0x000135F8
			public EncodingUtility(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x0006C760 File Offset: 0x0006A960
			// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x00015401 File Offset: 0x00013601
			public unsafe static Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>> encodingLookup
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x0006C788 File Offset: 0x0006A988
			// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00015413 File Offset: 0x00013613
			public unsafe static Encoding targetEncoding
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CA0 RID: 7328
			private static readonly IntPtr NativeFieldInfoPtr_encodingLookup;

			// Token: 0x04001CA1 RID: 7329
			private static readonly IntPtr NativeFieldInfoPtr_targetEncoding;
		}

		// Token: 0x020007A9 RID: 1961
		public enum CreateOptions
		{
			// Token: 0x04001CA3 RID: 7331
			None,
			// Token: 0x04001CA4 RID: 7332
			CreateNativeObject
		}

		// Token: 0x020007AA RID: 1962
		// (Invoke) Token: 0x06002CF6 RID: 11510
		private delegate IntPtr GetPreviewBytesDelegate(IntPtr @this, int maxByteCount);

		// Token: 0x020007AB RID: 1963
		// (Invoke) Token: 0x06002CF8 RID: 11512
		private delegate void Internal_CreateInstanceDelegate(IntPtr self, IntPtr text);
	}
}
