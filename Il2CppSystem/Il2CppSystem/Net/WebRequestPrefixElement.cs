using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D0 RID: 208
	public class WebRequestPrefixElement : Object
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x0003D8DC File Offset: 0x0003BADC
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestPrefixElement()
		{
			Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestPrefixElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr);
			WebRequestPrefixElement.NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "Prefix");
			WebRequestPrefixElement.NativeFieldInfoPtr_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creator");
			WebRequestPrefixElement.NativeFieldInfoPtr_creatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creatorType");
			WebRequestPrefixElement.NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100664990);
			WebRequestPrefixElement.NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100664991);
			WebRequestPrefixElement.NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100664992);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0003D984 File Offset: 0x0003BB84
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
		public unsafe IWebRequestCreate Creator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 46346, RefRangeEnd = 46347, XrefRangeStart = 46326, XrefRangeEnd = 46346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0003DA08 File Offset: 0x0003BC08
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestPrefixElement(string P, IWebRequestCreate C)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(P);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(C);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestPrefixElement.NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00006BBC File Offset: 0x00004DBC
		public WebRequestPrefixElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0003DA68 File Offset: 0x0003BC68
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00006BC5 File Offset: 0x00004DC5
		public unsafe string Prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_Prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_Prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003DA90 File Offset: 0x0003BC90
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00006BE4 File Offset: 0x00004DE4
		public unsafe IWebRequestCreate creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003DAC0 File Offset: 0x0003BCC0
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00006C03 File Offset: 0x00004E03
		public unsafe Type creatorType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creatorType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestPrefixElement.NativeFieldInfoPtr_creatorType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_Prefix;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_creator;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeFieldInfoPtr_creatorType;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0;
	}
}
