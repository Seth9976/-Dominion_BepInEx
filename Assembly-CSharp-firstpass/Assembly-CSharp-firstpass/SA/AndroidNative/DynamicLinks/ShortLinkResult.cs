using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

namespace SA.AndroidNative.DynamicLinks
{
	// Token: 0x02000351 RID: 849
	public class ShortLinkResult : Result
	{
		// Token: 0x0600333F RID: 13119 RVA: 0x000D5800 File Offset: 0x000D3A00
		// Note: this type is marked as 'beforefieldinit'.
		static ShortLinkResult()
		{
			Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.DynamicLinks", "ShortLinkResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr);
			ShortLinkResult.NativeFieldInfoPtr_shortLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr, "shortLink");
			ShortLinkResult.NativeMethodInfoPtr__ctor_Public_Void_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr, 100669863);
			ShortLinkResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr, 100669864);
			ShortLinkResult.NativeMethodInfoPtr_get_ShortLink_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr, 100669865);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x000D5880 File Offset: 0x000D3A80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223593, RefRangeEnd = 223594, XrefRangeStart = 223590, XrefRangeEnd = 223593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortLinkResult(Error error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortLinkResult.NativeMethodInfoPtr__ctor_Public_Void_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000D58CC File Offset: 0x000D3ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223597, RefRangeEnd = 223598, XrefRangeStart = 223594, XrefRangeEnd = 223597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortLinkResult(string link)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortLinkResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(link);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortLinkResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x000D5918 File Offset: 0x000D3B18
		public unsafe string ShortLink
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortLinkResult.NativeMethodInfoPtr_get_ShortLink_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00013EDC File Offset: 0x000120DC
		public ShortLinkResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x000D5950 File Offset: 0x000D3B50
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x00013EE5 File Offset: 0x000120E5
		public unsafe string shortLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortLinkResult.NativeFieldInfoPtr_shortLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortLinkResult.NativeFieldInfoPtr_shortLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeFieldInfoPtr_shortLink;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Error_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortLink_Public_get_String_0;
	}
}
