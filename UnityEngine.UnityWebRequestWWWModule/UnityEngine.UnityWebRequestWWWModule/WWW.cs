using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine.Networking;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class WWW : CustomYieldInstruction
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D8 File Offset: 0x000002D8
		// Note: this type is marked as 'beforefieldinit'.
		static WWW()
		{
			Il2CppClassPointerStore<WWW>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestWWWModule.dll", "UnityEngine", "WWW");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWW>.NativeClassPtr);
			WWW.NativeFieldInfoPtr__uwr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWW>.NativeClassPtr, "_uwr");
			WWW.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663297);
			WWW.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663298);
			WWW.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663299);
			WWW.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663300);
			WWW.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663301);
			WWW.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663302);
			WWW.NativeMethodInfoPtr_get_error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663303);
			WWW.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663304);
			WWW.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663305);
			WWW.NativeMethodInfoPtr_CreateTextureFromDownloadedData_Private_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663306);
			WWW.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663307);
			WWW.NativeMethodInfoPtr_get_url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663308);
			WWW.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663309);
			WWW.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663310);
			WWW.NativeMethodInfoPtr_WaitUntilDoneIfPossible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWW>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002248 File Offset: 0x00000448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131683, RefRangeEnd = 131685, XrefRangeStart = 131681, XrefRangeEnd = 131683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeURL(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002284 File Offset: 0x00000484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131685, XrefRangeEnd = 131686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeURL(string s, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000022D4 File Offset: 0x000004D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131690, RefRangeEnd = 131692, XrefRangeStart = 131686, XrefRangeEnd = 131690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WWW(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWW>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002320 File Offset: 0x00000520
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131697, RefRangeEnd = 131701, XrefRangeStart = 131692, XrefRangeEnd = 131697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WWW(string url, WWWForm form)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWW>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(form);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002380 File Offset: 0x00000580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131742, RefRangeEnd = 131745, XrefRangeStart = 131701, XrefRangeEnd = 131742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WWW(string url, Il2CppStructArray<byte> postData, Dictionary<string, string> headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWW>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000023F0 File Offset: 0x000005F0
		public unsafe Il2CppStructArray<byte> bytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131745, XrefRangeEnd = 131752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002430 File Offset: 0x00000630
		public unsafe string error
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 131764, RefRangeEnd = 131780, XrefRangeStart = 131752, XrefRangeEnd = 131764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_get_error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002468 File Offset: 0x00000668
		public unsafe bool isDone
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131782, RefRangeEnd = 131784, XrefRangeStart = 131780, XrefRangeEnd = 131782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000024A4 File Offset: 0x000006A4
		public unsafe string text
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 131790, RefRangeEnd = 131799, XrefRangeStart = 131784, XrefRangeEnd = 131790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024DC File Offset: 0x000006DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131799, XrefRangeEnd = 131808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D CreateTextureFromDownloadedData(bool markNonReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markNonReadable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_CreateTextureFromDownloadedData_Private_Texture2D_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002528 File Offset: 0x00000728
		public unsafe Texture2D texture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131817, RefRangeEnd = 131819, XrefRangeStart = 131808, XrefRangeEnd = 131817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002568 File Offset: 0x00000768
		public unsafe string url
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131819, XrefRangeEnd = 131821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_get_url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000025A0 File Offset: 0x000007A0
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WWW.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000025E8 File Offset: 0x000007E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131821, XrefRangeEnd = 131822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000261C File Offset: 0x0000081C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131833, RefRangeEnd = 131837, XrefRangeStart = 131822, XrefRangeEnd = 131833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitUntilDoneIfPossible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWW.NativeMethodInfoPtr_WaitUntilDoneIfPossible_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		public WWW(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe UnityWebRequest _uwr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWW.NativeFieldInfoPtr__uwr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWW.NativeFieldInfoPtr__uwr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002688 File Offset: 0x00000888
		public static string UnEscapeURL(string s)
		{
			return WWW.UnEscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026A8 File Offset: 0x000008A8
		public static string UnEscapeURL(string s, Encoding e)
		{
			return UnityWebRequest.UnEscapeURL(s, e);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026C4 File Offset: 0x000008C4
		public static WWW LoadFromCacheOrDownload(string url, int version)
		{
			return WWW.LoadFromCacheOrDownload(url, version, 0U);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002078 File Offset: 0x00000278
		public static WWW LoadFromCacheOrDownload(string url, int version, uint crc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002085 File Offset: 0x00000285
		public AssetBundle assetBundle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000026E0 File Offset: 0x000008E0
		public Object audioClip
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000026F4 File Offset: 0x000008F4
		public Object movie
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002708 File Offset: 0x00000908
		public int size
		{
			get
			{
				return this.bytesDownloaded;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002720 File Offset: 0x00000920
		public int bytesDownloaded
		{
			get
			{
				return (int)this._uwr.downloadedBytes;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002740 File Offset: 0x00000940
		public float progress
		{
			get
			{
				float num = this._uwr.downloadProgress;
				bool flag = num < 0f;
				if (flag)
				{
					num = 0f;
				}
				return num;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002092 File Offset: 0x00000292
		public Dictionary<string, string> responseHeaders
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002774 File Offset: 0x00000974
		public string data
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000278C File Offset: 0x0000098C
		public Texture2D textureNonReadable
		{
			get
			{
				return this.CreateTextureFromDownloadedData(true);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000027A8 File Offset: 0x000009A8
		public void LoadImageIntoTexture(Texture2D texture)
		{
			bool flag = !this.WaitUntilDoneIfPossible();
			if (!flag)
			{
				bool flag2 = this._uwr.result == UnityWebRequest.Result.ConnectionError;
				if (flag2)
				{
					Debug.LogError("Cannot load image: download failed");
				}
				else
				{
					DownloadHandler downloadHandler = this._uwr.downloadHandler;
					bool flag3 = downloadHandler == null;
					if (flag3)
					{
						Debug.LogError("Cannot load image: internal error");
					}
					else
					{
						texture.LoadImage(downloadHandler.data, false);
					}
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000209F File Offset: 0x0000029F
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000020AC File Offset: 0x000002AC
		public ThreadPriority threadPriority
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002818 File Offset: 0x00000A18
		public float uploadProgress
		{
			get
			{
				float num = this._uwr.uploadProgress;
				bool flag = num < 0f;
				if (flag)
				{
					num = 0f;
				}
				return num;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000284C File Offset: 0x00000A4C
		public Object GetAudioClipInternal(bool threeD, bool stream, bool compressed, AudioType audioType)
		{
			return WebRequestWWW.InternalCreateAudioClipUsingDH(this._uwr.downloadHandler, this._uwr.url, stream, compressed, audioType);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002880 File Offset: 0x00000A80
		public AudioClip GetAudioClip()
		{
			return this.GetAudioClip(true, false, AudioType.UNKNOWN);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000289C File Offset: 0x00000A9C
		public AudioClip GetAudioClip(bool threeD)
		{
			return this.GetAudioClip(threeD, false, AudioType.UNKNOWN);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000028B8 File Offset: 0x00000AB8
		public AudioClip GetAudioClip(bool threeD, bool stream)
		{
			return this.GetAudioClip(threeD, stream, AudioType.UNKNOWN);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000028D4 File Offset: 0x00000AD4
		public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType)
		{
			return this.GetAudioClipInternal(threeD, stream, false, audioType).Cast<AudioClip>();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000028F8 File Offset: 0x00000AF8
		public AudioClip GetAudioClipCompressed()
		{
			return this.GetAudioClipCompressed(false, AudioType.UNKNOWN);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002914 File Offset: 0x00000B14
		public AudioClip GetAudioClipCompressed(bool threeD)
		{
			return this.GetAudioClipCompressed(threeD, AudioType.UNKNOWN);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002930 File Offset: 0x00000B30
		public AudioClip GetAudioClipCompressed(bool threeD, AudioType audioType)
		{
			return this.GetAudioClipInternal(threeD, false, true, audioType).Cast<AudioClip>();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020B9 File Offset: 0x000002B9
		public MovieTexture GetMovieTexture()
		{
			throw new Exception("MovieTexture has been removed from Unity. Use VideoPlayer instead.");
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr__uwr;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_EscapeURL_Public_Static_String_String_Encoding_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Dictionary_2_String_String_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Public_get_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextureFromDownloadedData_Private_Texture2D_Boolean_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_url_Public_get_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilDoneIfPossible_Private_Boolean_0;
	}
}
