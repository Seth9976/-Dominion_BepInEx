using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.AndroidNative.DynamicLinks
{
	// Token: 0x0200034E RID: 846
	public class Link : Object
	{
		// Token: 0x06003316 RID: 13078 RVA: 0x000D5024 File Offset: 0x000D3224
		// Note: this type is marked as 'beforefieldinit'.
		static Link()
		{
			Il2CppClassPointerStore<Link>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.DynamicLinks", "Link");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link>.NativeClassPtr);
			Link.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "url");
			Link.NativeFieldInfoPtr_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "domain");
			Link.NativeFieldInfoPtr_androidParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "androidParams");
			Link.NativeFieldInfoPtr_iosParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "iosParams");
			Link.NativeFieldInfoPtr_googleAnalyticsParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "googleAnalyticsParams");
			Link.NativeFieldInfoPtr_itunesAnalyticsParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "itunesAnalyticsParams");
			Link.NativeFieldInfoPtr_socialMetaTagParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link>.NativeClassPtr, "socialMetaTagParams");
			Link.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669848);
			Link.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669849);
			Link.NativeMethodInfoPtr_get_Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669850);
			Link.NativeMethodInfoPtr_get_Domain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669851);
			Link.NativeMethodInfoPtr_get_AndroidParams_Public_get_AndroidParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669852);
			Link.NativeMethodInfoPtr_get_IosParams_Public_get_IosParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669853);
			Link.NativeMethodInfoPtr_get_GoogleAnalyticsParams_Public_get_GoogleAnalyticsParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669854);
			Link.NativeMethodInfoPtr_get_ItunesAnalyticsParams_Public_get_ItunesConnectAnalyticsParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669855);
			Link.NativeMethodInfoPtr_get_SocialMetaTagParams_Public_get_SocialMetaTagParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link>.NativeClassPtr, 100669856);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000D5194 File Offset: 0x000D3394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223475, RefRangeEnd = 223476, XrefRangeStart = 223471, XrefRangeEnd = 223475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Link()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000D51D0 File Offset: 0x000D33D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223516, RefRangeEnd = 223517, XrefRangeStart = 223476, XrefRangeEnd = 223516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, Object> Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x000D5210 File Offset: 0x000D3410
		public unsafe string Url
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_Url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x000D5248 File Offset: 0x000D3448
		public unsafe string Domain
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_Domain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600331B RID: 13083 RVA: 0x000D5280 File Offset: 0x000D3480
		public unsafe Link.AndroidParameters AndroidParams
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_AndroidParams_Public_get_AndroidParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.AndroidParameters>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x000D52C0 File Offset: 0x000D34C0
		public unsafe Link.IosParameters IosParams
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_IosParams_Public_get_IosParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600331D RID: 13085 RVA: 0x000D5300 File Offset: 0x000D3500
		public unsafe Link.GoogleAnalyticsParameters GoogleAnalyticsParams
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_GoogleAnalyticsParams_Public_get_GoogleAnalyticsParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x000D5340 File Offset: 0x000D3540
		public unsafe Link.ItunesConnectAnalyticsParameters ItunesAnalyticsParams
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_ItunesAnalyticsParams_Public_get_ItunesConnectAnalyticsParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x000D5380 File Offset: 0x000D3580
		public unsafe Link.SocialMetaTagParameters SocialMetaTagParams
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.NativeMethodInfoPtr_get_SocialMetaTagParams_Public_get_SocialMetaTagParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters>(intPtr3) : null;
			}
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00013D8B File Offset: 0x00011F8B
		public Link(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x000D53C0 File Offset: 0x000D35C0
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x00013D94 File Offset: 0x00011F94
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x000D53E8 File Offset: 0x000D35E8
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x00013DB3 File Offset: 0x00011FB3
		public unsafe string domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x000D5410 File Offset: 0x000D3610
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x00013DD2 File Offset: 0x00011FD2
		public unsafe Link.AndroidParameters androidParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_androidParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.AndroidParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_androidParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x000D5440 File Offset: 0x000D3640
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x00013DF1 File Offset: 0x00011FF1
		public unsafe Link.IosParameters iosParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_iosParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.IosParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_iosParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000D5470 File Offset: 0x000D3670
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x00013E10 File Offset: 0x00012010
		public unsafe Link.GoogleAnalyticsParameters googleAnalyticsParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_googleAnalyticsParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_googleAnalyticsParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000D54A0 File Offset: 0x000D36A0
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x00013E2F File Offset: 0x0001202F
		public unsafe Link.ItunesConnectAnalyticsParameters itunesAnalyticsParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_itunesAnalyticsParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_itunesAnalyticsParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x000D54D0 File Offset: 0x000D36D0
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x00013E4E File Offset: 0x0001204E
		public unsafe Link.SocialMetaTagParameters socialMetaTagParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_socialMetaTagParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.NativeFieldInfoPtr_socialMetaTagParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeFieldInfoPtr_domain;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeFieldInfoPtr_androidParams;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeFieldInfoPtr_iosParams;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeFieldInfoPtr_googleAnalyticsParams;

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeFieldInfoPtr_itunesAnalyticsParams;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeFieldInfoPtr_socialMetaTagParams;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Public_get_String_0;

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_get_String_0;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeMethodInfoPtr_get_AndroidParams_Public_get_AndroidParameters_0;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeMethodInfoPtr_get_IosParams_Public_get_IosParameters_0;

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeMethodInfoPtr_get_GoogleAnalyticsParams_Public_get_GoogleAnalyticsParameters_0;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeMethodInfoPtr_get_ItunesAnalyticsParams_Public_get_ItunesConnectAnalyticsParameters_0;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeMethodInfoPtr_get_SocialMetaTagParams_Public_get_SocialMetaTagParameters_0;

		// Token: 0x020003F7 RID: 1015
		public class SocialMetaTagParameters : Object
		{
			// Token: 0x06003A0F RID: 14863 RVA: 0x000EAD24 File Offset: 0x000E8F24
			// Note: this type is marked as 'beforefieldinit'.
			static SocialMetaTagParameters()
			{
				Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link>.NativeClassPtr, "SocialMetaTagParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr);
				Link.SocialMetaTagParameters.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, "title");
				Link.SocialMetaTagParameters.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, "description");
				Link.SocialMetaTagParameters.NativeFieldInfoPtr_imageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, "imageUrl");
				Link.SocialMetaTagParameters.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, 100670610);
				Link.SocialMetaTagParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, 100670611);
				Link.SocialMetaTagParameters.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, 100670612);
				Link.SocialMetaTagParameters.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, 100670613);
				Link.SocialMetaTagParameters.NativeMethodInfoPtr_get_ImageUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, 100670614);
			}

			// Token: 0x06003A10 RID: 14864 RVA: 0x000EADF0 File Offset: 0x000E8FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223261, XrefRangeEnd = 223266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SocialMetaTagParameters()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A11 RID: 14865 RVA: 0x000EAE2C File Offset: 0x000E902C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223285, RefRangeEnd = 223286, XrefRangeStart = 223266, XrefRangeEnd = 223285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> Serialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x06003A12 RID: 14866 RVA: 0x000EAE6C File Offset: 0x000E906C
			public unsafe string Title
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x06003A13 RID: 14867 RVA: 0x000EAEA4 File Offset: 0x000E90A4
			public unsafe string Description
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x06003A14 RID: 14868 RVA: 0x000EAEDC File Offset: 0x000E90DC
			public unsafe string ImageUrl
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.NativeMethodInfoPtr_get_ImageUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003A15 RID: 14869 RVA: 0x000166EF File Offset: 0x000148EF
			public SocialMetaTagParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x06003A16 RID: 14870 RVA: 0x000EAF14 File Offset: 0x000E9114
			// (set) Token: 0x06003A17 RID: 14871 RVA: 0x000166F8 File Offset: 0x000148F8
			public unsafe string title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.NativeFieldInfoPtr_title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x06003A18 RID: 14872 RVA: 0x000EAF3C File Offset: 0x000E913C
			// (set) Token: 0x06003A19 RID: 14873 RVA: 0x00016717 File Offset: 0x00014917
			public unsafe string description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.NativeFieldInfoPtr_description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x06003A1A RID: 14874 RVA: 0x000EAF64 File Offset: 0x000E9164
			// (set) Token: 0x06003A1B RID: 14875 RVA: 0x00016736 File Offset: 0x00014936
			public unsafe string imageUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.NativeFieldInfoPtr_imageUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.NativeFieldInfoPtr_imageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040033F0 RID: 13296
			private static readonly IntPtr NativeFieldInfoPtr_title;

			// Token: 0x040033F1 RID: 13297
			private static readonly IntPtr NativeFieldInfoPtr_description;

			// Token: 0x040033F2 RID: 13298
			private static readonly IntPtr NativeFieldInfoPtr_imageUrl;

			// Token: 0x040033F3 RID: 13299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040033F4 RID: 13300
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0;

			// Token: 0x040033F5 RID: 13301
			private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

			// Token: 0x040033F6 RID: 13302
			private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

			// Token: 0x040033F7 RID: 13303
			private static readonly IntPtr NativeMethodInfoPtr_get_ImageUrl_Public_get_String_0;

			// Token: 0x02000403 RID: 1027
			public class Builder : Object
			{
				// Token: 0x06003A82 RID: 14978 RVA: 0x000EC264 File Offset: 0x000EA464
				// Note: this type is marked as 'beforefieldinit'.
				static Builder()
				{
					Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link.SocialMetaTagParameters>.NativeClassPtr, "Builder");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr);
					Link.SocialMetaTagParameters.Builder.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr, "param");
					Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr, 100670653);
					Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_SetTitle_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr, 100670654);
					Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_SetDescription_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr, 100670655);
					Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_SetImageUrl_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr, 100670656);
					Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_Build_Public_SocialMetaTagParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr, 100670657);
				}

				// Token: 0x06003A83 RID: 14979 RVA: 0x000EC308 File Offset: 0x000EA508
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223252, RefRangeEnd = 223253, XrefRangeStart = 223243, XrefRangeEnd = 223252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Builder()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.SocialMetaTagParameters.Builder>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003A84 RID: 14980 RVA: 0x000EC344 File Offset: 0x000EA544
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223253, RefRangeEnd = 223257, XrefRangeStart = 223253, XrefRangeEnd = 223253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.SocialMetaTagParameters.Builder SetTitle(string title)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_SetTitle_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A85 RID: 14981 RVA: 0x000EC394 File Offset: 0x000EA594
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223257, RefRangeEnd = 223261, XrefRangeStart = 223257, XrefRangeEnd = 223257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.SocialMetaTagParameters.Builder SetDescription(string description)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_SetDescription_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A86 RID: 14982 RVA: 0x000EC3E4 File Offset: 0x000EA5E4
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.SocialMetaTagParameters.Builder SetImageUrl(string url)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_SetImageUrl_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A87 RID: 14983 RVA: 0x000EC434 File Offset: 0x000EA634
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.SocialMetaTagParameters Build()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.SocialMetaTagParameters.Builder.NativeMethodInfoPtr_Build_Public_SocialMetaTagParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters>(intPtr3) : null;
				}

				// Token: 0x06003A88 RID: 14984 RVA: 0x00016A90 File Offset: 0x00014C90
				public Builder(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000DEB RID: 3563
				// (get) Token: 0x06003A89 RID: 14985 RVA: 0x000EC474 File Offset: 0x000EA674
				// (set) Token: 0x06003A8A RID: 14986 RVA: 0x00016A99 File Offset: 0x00014C99
				public unsafe Link.SocialMetaTagParameters param
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.Builder.NativeFieldInfoPtr_param);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.SocialMetaTagParameters>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.SocialMetaTagParameters.Builder.NativeFieldInfoPtr_param), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04003453 RID: 13395
				private static readonly IntPtr NativeFieldInfoPtr_param;

				// Token: 0x04003454 RID: 13396
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04003455 RID: 13397
				private static readonly IntPtr NativeMethodInfoPtr_SetTitle_Public_Builder_String_0;

				// Token: 0x04003456 RID: 13398
				private static readonly IntPtr NativeMethodInfoPtr_SetDescription_Public_Builder_String_0;

				// Token: 0x04003457 RID: 13399
				private static readonly IntPtr NativeMethodInfoPtr_SetImageUrl_Public_Builder_String_0;

				// Token: 0x04003458 RID: 13400
				private static readonly IntPtr NativeMethodInfoPtr_Build_Public_SocialMetaTagParameters_0;
			}
		}

		// Token: 0x020003F8 RID: 1016
		public class ItunesConnectAnalyticsParameters : Object
		{
			// Token: 0x06003A1C RID: 14876 RVA: 0x000EAF8C File Offset: 0x000E918C
			// Note: this type is marked as 'beforefieldinit'.
			static ItunesConnectAnalyticsParameters()
			{
				Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link>.NativeClassPtr, "ItunesConnectAnalyticsParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr);
				Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_providerToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, "providerToken");
				Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_affiliateToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, "affiliateToken");
				Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_campaignToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, "campaignToken");
				Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, 100670615);
				Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, 100670616);
				Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_get_CampaignToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, 100670617);
				Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_get_AffiliateToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, 100670618);
				Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_get_ProviderToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, 100670619);
			}

			// Token: 0x06003A1D RID: 14877 RVA: 0x000EB058 File Offset: 0x000E9258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223296, XrefRangeEnd = 223301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItunesConnectAnalyticsParameters()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A1E RID: 14878 RVA: 0x000EB094 File Offset: 0x000E9294
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223320, RefRangeEnd = 223321, XrefRangeStart = 223301, XrefRangeEnd = 223320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> Serialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x06003A1F RID: 14879 RVA: 0x000EB0D4 File Offset: 0x000E92D4
			public unsafe string CampaignToken
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_get_CampaignToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x06003A20 RID: 14880 RVA: 0x000EB10C File Offset: 0x000E930C
			public unsafe string AffiliateToken
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_get_AffiliateToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x06003A21 RID: 14881 RVA: 0x000EB144 File Offset: 0x000E9344
			public unsafe string ProviderToken
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.NativeMethodInfoPtr_get_ProviderToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003A22 RID: 14882 RVA: 0x00016755 File Offset: 0x00014955
			public ItunesConnectAnalyticsParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x06003A23 RID: 14883 RVA: 0x000EB17C File Offset: 0x000E937C
			// (set) Token: 0x06003A24 RID: 14884 RVA: 0x0001675E File Offset: 0x0001495E
			public unsafe string providerToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_providerToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_providerToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x06003A25 RID: 14885 RVA: 0x000EB1A4 File Offset: 0x000E93A4
			// (set) Token: 0x06003A26 RID: 14886 RVA: 0x0001677D File Offset: 0x0001497D
			public unsafe string affiliateToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_affiliateToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_affiliateToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x06003A27 RID: 14887 RVA: 0x000EB1CC File Offset: 0x000E93CC
			// (set) Token: 0x06003A28 RID: 14888 RVA: 0x0001679C File Offset: 0x0001499C
			public unsafe string campaignToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_campaignToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.NativeFieldInfoPtr_campaignToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040033F8 RID: 13304
			private static readonly IntPtr NativeFieldInfoPtr_providerToken;

			// Token: 0x040033F9 RID: 13305
			private static readonly IntPtr NativeFieldInfoPtr_affiliateToken;

			// Token: 0x040033FA RID: 13306
			private static readonly IntPtr NativeFieldInfoPtr_campaignToken;

			// Token: 0x040033FB RID: 13307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040033FC RID: 13308
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0;

			// Token: 0x040033FD RID: 13309
			private static readonly IntPtr NativeMethodInfoPtr_get_CampaignToken_Public_get_String_0;

			// Token: 0x040033FE RID: 13310
			private static readonly IntPtr NativeMethodInfoPtr_get_AffiliateToken_Public_get_String_0;

			// Token: 0x040033FF RID: 13311
			private static readonly IntPtr NativeMethodInfoPtr_get_ProviderToken_Public_get_String_0;

			// Token: 0x02000404 RID: 1028
			public class Builder : Object
			{
				// Token: 0x06003A8B RID: 14987 RVA: 0x000EC4A4 File Offset: 0x000EA6A4
				// Note: this type is marked as 'beforefieldinit'.
				static Builder()
				{
					Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters>.NativeClassPtr, "Builder");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr);
					Link.ItunesConnectAnalyticsParameters.Builder.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr, "param");
					Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr, 100670658);
					Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_SetProviderToken_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr, 100670659);
					Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_SetAffiliateToken_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr, 100670660);
					Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_SetCampaignToken_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr, 100670661);
					Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_Build_Public_ItunesConnectAnalyticsParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr, 100670662);
				}

				// Token: 0x06003A8C RID: 14988 RVA: 0x000EC548 File Offset: 0x000EA748
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223295, RefRangeEnd = 223296, XrefRangeStart = 223286, XrefRangeEnd = 223295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Builder()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.ItunesConnectAnalyticsParameters.Builder>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003A8D RID: 14989 RVA: 0x000EC584 File Offset: 0x000EA784
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223253, RefRangeEnd = 223257, XrefRangeStart = 223253, XrefRangeEnd = 223257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.ItunesConnectAnalyticsParameters.Builder SetProviderToken(string token)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_SetProviderToken_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A8E RID: 14990 RVA: 0x000EC5D4 File Offset: 0x000EA7D4
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223257, RefRangeEnd = 223261, XrefRangeStart = 223257, XrefRangeEnd = 223261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.ItunesConnectAnalyticsParameters.Builder SetAffiliateToken(string token)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_SetAffiliateToken_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A8F RID: 14991 RVA: 0x000EC624 File Offset: 0x000EA824
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.ItunesConnectAnalyticsParameters.Builder SetCampaignToken(string token)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_SetCampaignToken_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A90 RID: 14992 RVA: 0x000EC674 File Offset: 0x000EA874
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.ItunesConnectAnalyticsParameters Build()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.ItunesConnectAnalyticsParameters.Builder.NativeMethodInfoPtr_Build_Public_ItunesConnectAnalyticsParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters>(intPtr3) : null;
				}

				// Token: 0x06003A91 RID: 14993 RVA: 0x00016AB8 File Offset: 0x00014CB8
				public Builder(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000DEC RID: 3564
				// (get) Token: 0x06003A92 RID: 14994 RVA: 0x000EC6B4 File Offset: 0x000EA8B4
				// (set) Token: 0x06003A93 RID: 14995 RVA: 0x00016AC1 File Offset: 0x00014CC1
				public unsafe Link.ItunesConnectAnalyticsParameters param
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.Builder.NativeFieldInfoPtr_param);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.ItunesConnectAnalyticsParameters>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.ItunesConnectAnalyticsParameters.Builder.NativeFieldInfoPtr_param), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04003459 RID: 13401
				private static readonly IntPtr NativeFieldInfoPtr_param;

				// Token: 0x0400345A RID: 13402
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400345B RID: 13403
				private static readonly IntPtr NativeMethodInfoPtr_SetProviderToken_Public_Builder_String_0;

				// Token: 0x0400345C RID: 13404
				private static readonly IntPtr NativeMethodInfoPtr_SetAffiliateToken_Public_Builder_String_0;

				// Token: 0x0400345D RID: 13405
				private static readonly IntPtr NativeMethodInfoPtr_SetCampaignToken_Public_Builder_String_0;

				// Token: 0x0400345E RID: 13406
				private static readonly IntPtr NativeMethodInfoPtr_Build_Public_ItunesConnectAnalyticsParameters_0;
			}
		}

		// Token: 0x020003F9 RID: 1017
		public class GoogleAnalyticsParameters : Object
		{
			// Token: 0x06003A29 RID: 14889 RVA: 0x000EB1F4 File Offset: 0x000E93F4
			// Note: this type is marked as 'beforefieldinit'.
			static GoogleAnalyticsParameters()
			{
				Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link>.NativeClassPtr, "GoogleAnalyticsParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr);
				Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, "source");
				Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_medium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, "medium");
				Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_campaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, "campaign");
				Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_term = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, "term");
				Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, "content");
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670620);
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670621);
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Content_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670622);
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Term_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670623);
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Campaign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670624);
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Medium_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670625);
				Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Source_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, 100670626);
			}

			// Token: 0x06003A2A RID: 14890 RVA: 0x000EB310 File Offset: 0x000E9510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223333, XrefRangeEnd = 223340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GoogleAnalyticsParameters()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A2B RID: 14891 RVA: 0x000EB34C File Offset: 0x000E954C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223367, RefRangeEnd = 223368, XrefRangeStart = 223340, XrefRangeEnd = 223367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> Serialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x06003A2C RID: 14892 RVA: 0x000EB38C File Offset: 0x000E958C
			public unsafe string Content
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Content_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DCD RID: 3533
			// (get) Token: 0x06003A2D RID: 14893 RVA: 0x000EB3C4 File Offset: 0x000E95C4
			public unsafe string Term
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Term_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DCE RID: 3534
			// (get) Token: 0x06003A2E RID: 14894 RVA: 0x000EB3FC File Offset: 0x000E95FC
			public unsafe string Campaign
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Campaign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DCF RID: 3535
			// (get) Token: 0x06003A2F RID: 14895 RVA: 0x000EB434 File Offset: 0x000E9634
			public unsafe string Medium
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Medium_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DD0 RID: 3536
			// (get) Token: 0x06003A30 RID: 14896 RVA: 0x000EB46C File Offset: 0x000E966C
			public unsafe string Source
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.NativeMethodInfoPtr_get_Source_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003A31 RID: 14897 RVA: 0x000167BB File Offset: 0x000149BB
			public GoogleAnalyticsParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x06003A32 RID: 14898 RVA: 0x000EB4A4 File Offset: 0x000E96A4
			// (set) Token: 0x06003A33 RID: 14899 RVA: 0x000167C4 File Offset: 0x000149C4
			public unsafe string source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_source);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x06003A34 RID: 14900 RVA: 0x000EB4CC File Offset: 0x000E96CC
			// (set) Token: 0x06003A35 RID: 14901 RVA: 0x000167E3 File Offset: 0x000149E3
			public unsafe string medium
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_medium);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_medium), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x06003A36 RID: 14902 RVA: 0x000EB4F4 File Offset: 0x000E96F4
			// (set) Token: 0x06003A37 RID: 14903 RVA: 0x00016802 File Offset: 0x00014A02
			public unsafe string campaign
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_campaign);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_campaign), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x06003A38 RID: 14904 RVA: 0x000EB51C File Offset: 0x000E971C
			// (set) Token: 0x06003A39 RID: 14905 RVA: 0x00016821 File Offset: 0x00014A21
			public unsafe string term
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_term);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_term), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x06003A3A RID: 14906 RVA: 0x000EB544 File Offset: 0x000E9744
			// (set) Token: 0x06003A3B RID: 14907 RVA: 0x00016840 File Offset: 0x00014A40
			public unsafe string content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_content);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.NativeFieldInfoPtr_content), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003400 RID: 13312
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04003401 RID: 13313
			private static readonly IntPtr NativeFieldInfoPtr_medium;

			// Token: 0x04003402 RID: 13314
			private static readonly IntPtr NativeFieldInfoPtr_campaign;

			// Token: 0x04003403 RID: 13315
			private static readonly IntPtr NativeFieldInfoPtr_term;

			// Token: 0x04003404 RID: 13316
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x04003405 RID: 13317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04003406 RID: 13318
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0;

			// Token: 0x04003407 RID: 13319
			private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_String_0;

			// Token: 0x04003408 RID: 13320
			private static readonly IntPtr NativeMethodInfoPtr_get_Term_Public_get_String_0;

			// Token: 0x04003409 RID: 13321
			private static readonly IntPtr NativeMethodInfoPtr_get_Campaign_Public_get_String_0;

			// Token: 0x0400340A RID: 13322
			private static readonly IntPtr NativeMethodInfoPtr_get_Medium_Public_get_String_0;

			// Token: 0x0400340B RID: 13323
			private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_String_0;

			// Token: 0x02000405 RID: 1029
			public class Builder : Object
			{
				// Token: 0x06003A94 RID: 14996 RVA: 0x000EC6E4 File Offset: 0x000EA8E4
				// Note: this type is marked as 'beforefieldinit'.
				static Builder()
				{
					Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters>.NativeClassPtr, "Builder");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr);
					Link.GoogleAnalyticsParameters.Builder.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, "param");
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670663);
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetSource_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670664);
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetMedium_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670665);
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetCampaign_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670666);
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetTerm_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670667);
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetContent_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670668);
					Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_Build_Public_GoogleAnalyticsParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr, 100670669);
				}

				// Token: 0x06003A95 RID: 14997 RVA: 0x000EC7B0 File Offset: 0x000EA9B0
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223332, RefRangeEnd = 223333, XrefRangeStart = 223321, XrefRangeEnd = 223332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Builder()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.GoogleAnalyticsParameters.Builder>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003A96 RID: 14998 RVA: 0x000EC7EC File Offset: 0x000EA9EC
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223253, RefRangeEnd = 223257, XrefRangeStart = 223253, XrefRangeEnd = 223257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.GoogleAnalyticsParameters.Builder SetSource(string source)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetSource_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A97 RID: 14999 RVA: 0x000EC83C File Offset: 0x000EAA3C
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223257, RefRangeEnd = 223261, XrefRangeStart = 223257, XrefRangeEnd = 223261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.GoogleAnalyticsParameters.Builder SetMedium(string medium)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(medium);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetMedium_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A98 RID: 15000 RVA: 0x000EC88C File Offset: 0x000EAA8C
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.GoogleAnalyticsParameters.Builder SetCampaign(string campaign)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(campaign);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetCampaign_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A99 RID: 15001 RVA: 0x000EC8DC File Offset: 0x000EAADC
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 222592, RefRangeEnd = 222594, XrefRangeStart = 222592, XrefRangeEnd = 222594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.GoogleAnalyticsParameters.Builder SetTerm(string term)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetTerm_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A9A RID: 15002 RVA: 0x000EC92C File Offset: 0x000EAB2C
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 222117, RefRangeEnd = 222121, XrefRangeStart = 222117, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.GoogleAnalyticsParameters.Builder SetContent(string content)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_SetContent_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003A9B RID: 15003 RVA: 0x000EC97C File Offset: 0x000EAB7C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.GoogleAnalyticsParameters Build()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.GoogleAnalyticsParameters.Builder.NativeMethodInfoPtr_Build_Public_GoogleAnalyticsParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters>(intPtr3) : null;
				}

				// Token: 0x06003A9C RID: 15004 RVA: 0x00016AE0 File Offset: 0x00014CE0
				public Builder(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000DED RID: 3565
				// (get) Token: 0x06003A9D RID: 15005 RVA: 0x000EC9BC File Offset: 0x000EABBC
				// (set) Token: 0x06003A9E RID: 15006 RVA: 0x00016AE9 File Offset: 0x00014CE9
				public unsafe Link.GoogleAnalyticsParameters param
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.Builder.NativeFieldInfoPtr_param);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.GoogleAnalyticsParameters>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.GoogleAnalyticsParameters.Builder.NativeFieldInfoPtr_param), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400345F RID: 13407
				private static readonly IntPtr NativeFieldInfoPtr_param;

				// Token: 0x04003460 RID: 13408
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04003461 RID: 13409
				private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Builder_String_0;

				// Token: 0x04003462 RID: 13410
				private static readonly IntPtr NativeMethodInfoPtr_SetMedium_Public_Builder_String_0;

				// Token: 0x04003463 RID: 13411
				private static readonly IntPtr NativeMethodInfoPtr_SetCampaign_Public_Builder_String_0;

				// Token: 0x04003464 RID: 13412
				private static readonly IntPtr NativeMethodInfoPtr_SetTerm_Public_Builder_String_0;

				// Token: 0x04003465 RID: 13413
				private static readonly IntPtr NativeMethodInfoPtr_SetContent_Public_Builder_String_0;

				// Token: 0x04003466 RID: 13414
				private static readonly IntPtr NativeMethodInfoPtr_Build_Public_GoogleAnalyticsParameters_0;
			}
		}

		// Token: 0x020003FA RID: 1018
		public class IosParameters : Object
		{
			// Token: 0x06003A3C RID: 14908 RVA: 0x000EB56C File Offset: 0x000E976C
			// Note: this type is marked as 'beforefieldinit'.
			static IosParameters()
			{
				Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link>.NativeClassPtr, "IosParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr);
				Link.IosParameters.NativeFieldInfoPtr_appBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "appBundle");
				Link.IosParameters.NativeFieldInfoPtr_appStoreId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "appStoreId");
				Link.IosParameters.NativeFieldInfoPtr_minimumVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "minimumVersion");
				Link.IosParameters.NativeFieldInfoPtr_ipadBundleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "ipadBundleId");
				Link.IosParameters.NativeFieldInfoPtr_ipadFallbackUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "ipadFallbackUrl");
				Link.IosParameters.NativeFieldInfoPtr_fallbackUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "fallbackUrl");
				Link.IosParameters.NativeFieldInfoPtr_customScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "customScheme");
				Link.IosParameters.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670627);
				Link.IosParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670628);
				Link.IosParameters.NativeMethodInfoPtr_get_AppStoreId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670629);
				Link.IosParameters.NativeMethodInfoPtr_get_AppBundle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670630);
				Link.IosParameters.NativeMethodInfoPtr_get_MinimumVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670631);
				Link.IosParameters.NativeMethodInfoPtr_get_IpadBundleId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670632);
				Link.IosParameters.NativeMethodInfoPtr_get_IpadFallbackUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670633);
				Link.IosParameters.NativeMethodInfoPtr_get_FallbackUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670634);
				Link.IosParameters.NativeMethodInfoPtr_get_CustomScheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, 100670635);
			}

			// Token: 0x06003A3D RID: 14909 RVA: 0x000EB6D8 File Offset: 0x000E98D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223383, XrefRangeEnd = 223392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IosParameters()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A3E RID: 14910 RVA: 0x000EB714 File Offset: 0x000E9914
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223427, RefRangeEnd = 223428, XrefRangeStart = 223392, XrefRangeEnd = 223427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> Serialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x17000DD8 RID: 3544
			// (get) Token: 0x06003A3F RID: 14911 RVA: 0x000EB754 File Offset: 0x000E9954
			public unsafe string AppStoreId
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_AppStoreId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DD9 RID: 3545
			// (get) Token: 0x06003A40 RID: 14912 RVA: 0x000EB78C File Offset: 0x000E998C
			public unsafe string AppBundle
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_AppBundle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DDA RID: 3546
			// (get) Token: 0x06003A41 RID: 14913 RVA: 0x000EB7C4 File Offset: 0x000E99C4
			public unsafe string MinimumVersion
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_MinimumVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DDB RID: 3547
			// (get) Token: 0x06003A42 RID: 14914 RVA: 0x000EB7FC File Offset: 0x000E99FC
			public unsafe string IpadBundleId
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_IpadBundleId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DDC RID: 3548
			// (get) Token: 0x06003A43 RID: 14915 RVA: 0x000EB834 File Offset: 0x000E9A34
			public unsafe string IpadFallbackUrl
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_IpadFallbackUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DDD RID: 3549
			// (get) Token: 0x06003A44 RID: 14916 RVA: 0x000EB86C File Offset: 0x000E9A6C
			public unsafe string FallbackUrl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_FallbackUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DDE RID: 3550
			// (get) Token: 0x06003A45 RID: 14917 RVA: 0x000EB8A4 File Offset: 0x000E9AA4
			public unsafe string CustomScheme
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.NativeMethodInfoPtr_get_CustomScheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003A46 RID: 14918 RVA: 0x0001685F File Offset: 0x00014A5F
			public IosParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD1 RID: 3537
			// (get) Token: 0x06003A47 RID: 14919 RVA: 0x000EB8DC File Offset: 0x000E9ADC
			// (set) Token: 0x06003A48 RID: 14920 RVA: 0x00016868 File Offset: 0x00014A68
			public unsafe string appBundle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_appBundle);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_appBundle), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DD2 RID: 3538
			// (get) Token: 0x06003A49 RID: 14921 RVA: 0x000EB904 File Offset: 0x000E9B04
			// (set) Token: 0x06003A4A RID: 14922 RVA: 0x00016887 File Offset: 0x00014A87
			public unsafe string appStoreId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_appStoreId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_appStoreId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DD3 RID: 3539
			// (get) Token: 0x06003A4B RID: 14923 RVA: 0x000EB92C File Offset: 0x000E9B2C
			// (set) Token: 0x06003A4C RID: 14924 RVA: 0x000168A6 File Offset: 0x00014AA6
			public unsafe string minimumVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_minimumVersion);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_minimumVersion), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DD4 RID: 3540
			// (get) Token: 0x06003A4D RID: 14925 RVA: 0x000EB954 File Offset: 0x000E9B54
			// (set) Token: 0x06003A4E RID: 14926 RVA: 0x000168C5 File Offset: 0x00014AC5
			public unsafe string ipadBundleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_ipadBundleId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_ipadBundleId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DD5 RID: 3541
			// (get) Token: 0x06003A4F RID: 14927 RVA: 0x000EB97C File Offset: 0x000E9B7C
			// (set) Token: 0x06003A50 RID: 14928 RVA: 0x000168E4 File Offset: 0x00014AE4
			public unsafe string ipadFallbackUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_ipadFallbackUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_ipadFallbackUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DD6 RID: 3542
			// (get) Token: 0x06003A51 RID: 14929 RVA: 0x000EB9A4 File Offset: 0x000E9BA4
			// (set) Token: 0x06003A52 RID: 14930 RVA: 0x00016903 File Offset: 0x00014B03
			public unsafe string fallbackUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_fallbackUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_fallbackUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DD7 RID: 3543
			// (get) Token: 0x06003A53 RID: 14931 RVA: 0x000EB9CC File Offset: 0x000E9BCC
			// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00016922 File Offset: 0x00014B22
			public unsafe string customScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_customScheme);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.NativeFieldInfoPtr_customScheme), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400340C RID: 13324
			private static readonly IntPtr NativeFieldInfoPtr_appBundle;

			// Token: 0x0400340D RID: 13325
			private static readonly IntPtr NativeFieldInfoPtr_appStoreId;

			// Token: 0x0400340E RID: 13326
			private static readonly IntPtr NativeFieldInfoPtr_minimumVersion;

			// Token: 0x0400340F RID: 13327
			private static readonly IntPtr NativeFieldInfoPtr_ipadBundleId;

			// Token: 0x04003410 RID: 13328
			private static readonly IntPtr NativeFieldInfoPtr_ipadFallbackUrl;

			// Token: 0x04003411 RID: 13329
			private static readonly IntPtr NativeFieldInfoPtr_fallbackUrl;

			// Token: 0x04003412 RID: 13330
			private static readonly IntPtr NativeFieldInfoPtr_customScheme;

			// Token: 0x04003413 RID: 13331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04003414 RID: 13332
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0;

			// Token: 0x04003415 RID: 13333
			private static readonly IntPtr NativeMethodInfoPtr_get_AppStoreId_Public_get_String_0;

			// Token: 0x04003416 RID: 13334
			private static readonly IntPtr NativeMethodInfoPtr_get_AppBundle_Public_get_String_0;

			// Token: 0x04003417 RID: 13335
			private static readonly IntPtr NativeMethodInfoPtr_get_MinimumVersion_Public_get_String_0;

			// Token: 0x04003418 RID: 13336
			private static readonly IntPtr NativeMethodInfoPtr_get_IpadBundleId_Public_get_String_0;

			// Token: 0x04003419 RID: 13337
			private static readonly IntPtr NativeMethodInfoPtr_get_IpadFallbackUrl_Public_get_String_0;

			// Token: 0x0400341A RID: 13338
			private static readonly IntPtr NativeMethodInfoPtr_get_FallbackUrl_Public_get_String_0;

			// Token: 0x0400341B RID: 13339
			private static readonly IntPtr NativeMethodInfoPtr_get_CustomScheme_Public_get_String_0;

			// Token: 0x02000406 RID: 1030
			public class Builder : Object
			{
				// Token: 0x06003A9F RID: 15007 RVA: 0x000EC9EC File Offset: 0x000EABEC
				// Note: this type is marked as 'beforefieldinit'.
				static Builder()
				{
					Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link.IosParameters>.NativeClassPtr, "Builder");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr);
					Link.IosParameters.Builder.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, "param");
					Link.IosParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670670);
					Link.IosParameters.Builder.NativeMethodInfoPtr_SetFallbackUrl_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670671);
					Link.IosParameters.Builder.NativeMethodInfoPtr_SetCustomScheme_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670672);
					Link.IosParameters.Builder.NativeMethodInfoPtr_SetIpadFallbackUrl_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670673);
					Link.IosParameters.Builder.NativeMethodInfoPtr_SetIpadBundleId_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670674);
					Link.IosParameters.Builder.NativeMethodInfoPtr_SetAppStoreId_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670675);
					Link.IosParameters.Builder.NativeMethodInfoPtr_SetMinimumVersion_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670676);
					Link.IosParameters.Builder.NativeMethodInfoPtr_Build_Public_IosParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr, 100670677);
				}

				// Token: 0x06003AA0 RID: 15008 RVA: 0x000ECACC File Offset: 0x000EACCC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223381, RefRangeEnd = 223382, XrefRangeStart = 223368, XrefRangeEnd = 223381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Builder(string appBundle)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.IosParameters.Builder>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(appBundle);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003AA1 RID: 15009 RVA: 0x000ECB18 File Offset: 0x000EAD18
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 222121, RefRangeEnd = 222123, XrefRangeStart = 222121, XrefRangeEnd = 222123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters.Builder SetFallbackUrl(string url)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_SetFallbackUrl_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AA2 RID: 15010 RVA: 0x000ECB68 File Offset: 0x000EAD68
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223382, RefRangeEnd = 223383, XrefRangeStart = 223382, XrefRangeEnd = 223382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters.Builder SetCustomScheme(string scheme)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(scheme);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_SetCustomScheme_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AA3 RID: 15011 RVA: 0x000ECBB8 File Offset: 0x000EADB8
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 222117, RefRangeEnd = 222121, XrefRangeStart = 222117, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters.Builder SetIpadFallbackUrl(string ipadFallbackUrl)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(ipadFallbackUrl);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_SetIpadFallbackUrl_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AA4 RID: 15012 RVA: 0x000ECC08 File Offset: 0x000EAE08
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 222592, RefRangeEnd = 222594, XrefRangeStart = 222592, XrefRangeEnd = 222594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters.Builder SetIpadBundleId(string ipadBundleId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(ipadBundleId);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_SetIpadBundleId_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AA5 RID: 15013 RVA: 0x000ECC58 File Offset: 0x000EAE58
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223257, RefRangeEnd = 223261, XrefRangeStart = 223257, XrefRangeEnd = 223261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters.Builder SetAppStoreId(string appStoreId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(appStoreId);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_SetAppStoreId_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AA6 RID: 15014 RVA: 0x000ECCA8 File Offset: 0x000EAEA8
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters.Builder SetMinimumVersion(string minVersion)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(minVersion);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_SetMinimumVersion_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AA7 RID: 15015 RVA: 0x000ECCF8 File Offset: 0x000EAEF8
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.IosParameters Build()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.IosParameters.Builder.NativeMethodInfoPtr_Build_Public_IosParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.IosParameters>(intPtr3) : null;
				}

				// Token: 0x06003AA8 RID: 15016 RVA: 0x00016B08 File Offset: 0x00014D08
				public Builder(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000DEE RID: 3566
				// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x000ECD38 File Offset: 0x000EAF38
				// (set) Token: 0x06003AAA RID: 15018 RVA: 0x00016B11 File Offset: 0x00014D11
				public unsafe Link.IosParameters param
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.Builder.NativeFieldInfoPtr_param);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.IosParameters>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.IosParameters.Builder.NativeFieldInfoPtr_param), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04003467 RID: 13415
				private static readonly IntPtr NativeFieldInfoPtr_param;

				// Token: 0x04003468 RID: 13416
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

				// Token: 0x04003469 RID: 13417
				private static readonly IntPtr NativeMethodInfoPtr_SetFallbackUrl_Public_Builder_String_0;

				// Token: 0x0400346A RID: 13418
				private static readonly IntPtr NativeMethodInfoPtr_SetCustomScheme_Public_Builder_String_0;

				// Token: 0x0400346B RID: 13419
				private static readonly IntPtr NativeMethodInfoPtr_SetIpadFallbackUrl_Public_Builder_String_0;

				// Token: 0x0400346C RID: 13420
				private static readonly IntPtr NativeMethodInfoPtr_SetIpadBundleId_Public_Builder_String_0;

				// Token: 0x0400346D RID: 13421
				private static readonly IntPtr NativeMethodInfoPtr_SetAppStoreId_Public_Builder_String_0;

				// Token: 0x0400346E RID: 13422
				private static readonly IntPtr NativeMethodInfoPtr_SetMinimumVersion_Public_Builder_String_0;

				// Token: 0x0400346F RID: 13423
				private static readonly IntPtr NativeMethodInfoPtr_Build_Public_IosParameters_0;
			}
		}

		// Token: 0x020003FB RID: 1019
		public class AndroidParameters : Object
		{
			// Token: 0x06003A55 RID: 14933 RVA: 0x000EB9F4 File Offset: 0x000E9BF4
			// Note: this type is marked as 'beforefieldinit'.
			static AndroidParameters()
			{
				Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link>.NativeClassPtr, "AndroidParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr);
				Link.AndroidParameters.NativeFieldInfoPtr_appBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, "appBundle");
				Link.AndroidParameters.NativeFieldInfoPtr_fallbackUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, "fallbackUrl");
				Link.AndroidParameters.NativeFieldInfoPtr_minimumVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, "minimumVersion");
				Link.AndroidParameters.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, 100670636);
				Link.AndroidParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, 100670637);
				Link.AndroidParameters.NativeMethodInfoPtr_get_FallbackUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, 100670638);
				Link.AndroidParameters.NativeMethodInfoPtr_get_MinimumVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, 100670639);
				Link.AndroidParameters.NativeMethodInfoPtr_get_AppBundle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, 100670640);
			}

			// Token: 0x06003A56 RID: 14934 RVA: 0x000EBAC0 File Offset: 0x000E9CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223438, XrefRangeEnd = 223442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndroidParameters()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A57 RID: 14935 RVA: 0x000EBAFC File Offset: 0x000E9CFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223464, RefRangeEnd = 223465, XrefRangeStart = 223442, XrefRangeEnd = 223464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> Serialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x06003A58 RID: 14936 RVA: 0x000EBB3C File Offset: 0x000E9D3C
			public unsafe string FallbackUrl
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.NativeMethodInfoPtr_get_FallbackUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x06003A59 RID: 14937 RVA: 0x000EBB74 File Offset: 0x000E9D74
			public unsafe int MinimumVersion
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.NativeMethodInfoPtr_get_MinimumVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000DE4 RID: 3556
			// (get) Token: 0x06003A5A RID: 14938 RVA: 0x000EBBB0 File Offset: 0x000E9DB0
			public unsafe string AppBundle
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.NativeMethodInfoPtr_get_AppBundle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003A5B RID: 14939 RVA: 0x00016941 File Offset: 0x00014B41
			public AndroidParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DDF RID: 3551
			// (get) Token: 0x06003A5C RID: 14940 RVA: 0x000EBBE8 File Offset: 0x000E9DE8
			// (set) Token: 0x06003A5D RID: 14941 RVA: 0x0001694A File Offset: 0x00014B4A
			public unsafe string appBundle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.NativeFieldInfoPtr_appBundle);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.NativeFieldInfoPtr_appBundle), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x06003A5E RID: 14942 RVA: 0x000EBC10 File Offset: 0x000E9E10
			// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00016969 File Offset: 0x00014B69
			public unsafe string fallbackUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.NativeFieldInfoPtr_fallbackUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.NativeFieldInfoPtr_fallbackUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x06003A60 RID: 14944 RVA: 0x000EBC38 File Offset: 0x000E9E38
			// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00016988 File Offset: 0x00014B88
			public unsafe int minimumVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.NativeFieldInfoPtr_minimumVersion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.NativeFieldInfoPtr_minimumVersion)) = value;
				}
			}

			// Token: 0x0400341C RID: 13340
			private static readonly IntPtr NativeFieldInfoPtr_appBundle;

			// Token: 0x0400341D RID: 13341
			private static readonly IntPtr NativeFieldInfoPtr_fallbackUrl;

			// Token: 0x0400341E RID: 13342
			private static readonly IntPtr NativeFieldInfoPtr_minimumVersion;

			// Token: 0x0400341F RID: 13343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04003420 RID: 13344
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Dictionary_2_String_Object_0;

			// Token: 0x04003421 RID: 13345
			private static readonly IntPtr NativeMethodInfoPtr_get_FallbackUrl_Public_get_String_0;

			// Token: 0x04003422 RID: 13346
			private static readonly IntPtr NativeMethodInfoPtr_get_MinimumVersion_Public_get_Int32_0;

			// Token: 0x04003423 RID: 13347
			private static readonly IntPtr NativeMethodInfoPtr_get_AppBundle_Public_get_String_0;

			// Token: 0x02000407 RID: 1031
			public class Builder : Object
			{
				// Token: 0x06003AAB RID: 15019 RVA: 0x000ECD68 File Offset: 0x000EAF68
				// Note: this type is marked as 'beforefieldinit'.
				static Builder()
				{
					Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link.AndroidParameters>.NativeClassPtr, "Builder");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr);
					Link.AndroidParameters.Builder.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr, "param");
					Link.AndroidParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr, 100670678);
					Link.AndroidParameters.Builder.NativeMethodInfoPtr_SetFallbackUrl_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr, 100670679);
					Link.AndroidParameters.Builder.NativeMethodInfoPtr_SetMinimumVersion_Public_Builder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr, 100670680);
					Link.AndroidParameters.Builder.NativeMethodInfoPtr_Build_Public_AndroidParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr, 100670681);
				}

				// Token: 0x06003AAC RID: 15020 RVA: 0x000ECDF8 File Offset: 0x000EAFF8
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223436, RefRangeEnd = 223437, XrefRangeStart = 223428, XrefRangeEnd = 223436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Builder(string appBundle)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.AndroidParameters.Builder>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(appBundle);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.Builder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003AAD RID: 15021 RVA: 0x000ECE44 File Offset: 0x000EB044
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 223257, RefRangeEnd = 223261, XrefRangeStart = 223257, XrefRangeEnd = 223261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.AndroidParameters.Builder SetFallbackUrl(string url)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.Builder.NativeMethodInfoPtr_SetFallbackUrl_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.AndroidParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AAE RID: 15022 RVA: 0x000ECE94 File Offset: 0x000EB094
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 223437, RefRangeEnd = 223438, XrefRangeStart = 223437, XrefRangeEnd = 223437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.AndroidParameters.Builder SetMinimumVersion(int minVersion)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref minVersion;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.Builder.NativeMethodInfoPtr_SetMinimumVersion_Public_Builder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.AndroidParameters.Builder>(intPtr3) : null;
					}
				}

				// Token: 0x06003AAF RID: 15023 RVA: 0x000ECEE0 File Offset: 0x000EB0E0
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Link.AndroidParameters Build()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.AndroidParameters.Builder.NativeMethodInfoPtr_Build_Public_AndroidParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.AndroidParameters>(intPtr3) : null;
				}

				// Token: 0x06003AB0 RID: 15024 RVA: 0x00016B30 File Offset: 0x00014D30
				public Builder(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000DEF RID: 3567
				// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x000ECF20 File Offset: 0x000EB120
				// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x00016B39 File Offset: 0x00014D39
				public unsafe Link.AndroidParameters param
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.Builder.NativeFieldInfoPtr_param);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link.AndroidParameters>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.AndroidParameters.Builder.NativeFieldInfoPtr_param), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04003470 RID: 13424
				private static readonly IntPtr NativeFieldInfoPtr_param;

				// Token: 0x04003471 RID: 13425
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

				// Token: 0x04003472 RID: 13426
				private static readonly IntPtr NativeMethodInfoPtr_SetFallbackUrl_Public_Builder_String_0;

				// Token: 0x04003473 RID: 13427
				private static readonly IntPtr NativeMethodInfoPtr_SetMinimumVersion_Public_Builder_Int32_0;

				// Token: 0x04003474 RID: 13428
				private static readonly IntPtr NativeMethodInfoPtr_Build_Public_AndroidParameters_0;
			}
		}

		// Token: 0x020003FC RID: 1020
		public class Builder : Object
		{
			// Token: 0x06003A62 RID: 14946 RVA: 0x000EBC60 File Offset: 0x000E9E60
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<Link.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Link>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr);
				Link.Builder.NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, "link");
				Link.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670641);
				Link.Builder.NativeMethodInfoPtr_SetLink_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670642);
				Link.Builder.NativeMethodInfoPtr_SetDynamicLinkDomain_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670643);
				Link.Builder.NativeMethodInfoPtr_SetAndroidParameters_Public_Builder_AndroidParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670644);
				Link.Builder.NativeMethodInfoPtr_SetIosParameters_Public_Builder_IosParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670645);
				Link.Builder.NativeMethodInfoPtr_SetGoogleAnalyticsParameters_Public_Builder_GoogleAnalyticsParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670646);
				Link.Builder.NativeMethodInfoPtr_SetItunesConnectAnalyticsParameters_Public_Builder_ItunesConnectAnalyticsParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670647);
				Link.Builder.NativeMethodInfoPtr_SetSocialMetaTagParameters_Public_Builder_SocialMetaTagParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670648);
				Link.Builder.NativeMethodInfoPtr_Build_Public_Link_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr, 100670649);
			}

			// Token: 0x06003A63 RID: 14947 RVA: 0x000EBD54 File Offset: 0x000E9F54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223470, RefRangeEnd = 223471, XrefRangeStart = 223465, XrefRangeEnd = 223470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Link.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A64 RID: 14948 RVA: 0x000EBD90 File Offset: 0x000E9F90
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 223253, RefRangeEnd = 223257, XrefRangeStart = 223253, XrefRangeEnd = 223257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetLink(string url)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetLink_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A65 RID: 14949 RVA: 0x000EBDE0 File Offset: 0x000E9FE0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 223257, RefRangeEnd = 223261, XrefRangeStart = 223257, XrefRangeEnd = 223261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetDynamicLinkDomain(string domain)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetDynamicLinkDomain_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A66 RID: 14950 RVA: 0x000EBE30 File Offset: 0x000EA030
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetAndroidParameters(Link.AndroidParameters param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetAndroidParameters_Public_Builder_AndroidParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A67 RID: 14951 RVA: 0x000EBE80 File Offset: 0x000EA080
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222592, RefRangeEnd = 222594, XrefRangeStart = 222592, XrefRangeEnd = 222594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetIosParameters(Link.IosParameters param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetIosParameters_Public_Builder_IosParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A68 RID: 14952 RVA: 0x000EBED0 File Offset: 0x000EA0D0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 222117, RefRangeEnd = 222121, XrefRangeStart = 222117, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetGoogleAnalyticsParameters(Link.GoogleAnalyticsParameters param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetGoogleAnalyticsParameters_Public_Builder_GoogleAnalyticsParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A69 RID: 14953 RVA: 0x000EBF20 File Offset: 0x000EA120
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222121, RefRangeEnd = 222123, XrefRangeStart = 222121, XrefRangeEnd = 222123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetItunesConnectAnalyticsParameters(Link.ItunesConnectAnalyticsParameters param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetItunesConnectAnalyticsParameters_Public_Builder_ItunesConnectAnalyticsParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A6A RID: 14954 RVA: 0x000EBF70 File Offset: 0x000EA170
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223382, RefRangeEnd = 223383, XrefRangeStart = 223382, XrefRangeEnd = 223383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link.Builder SetSocialMetaTagParameters(Link.SocialMetaTagParameters param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_SetSocialMetaTagParameters_Public_Builder_SocialMetaTagParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x06003A6B RID: 14955 RVA: 0x000EBFC0 File Offset: 0x000EA1C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Link Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Link.Builder.NativeMethodInfoPtr_Build_Public_Link_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Link>(intPtr3) : null;
			}

			// Token: 0x06003A6C RID: 14956 RVA: 0x000169A3 File Offset: 0x00014BA3
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x06003A6D RID: 14957 RVA: 0x000EC000 File Offset: 0x000EA200
			// (set) Token: 0x06003A6E RID: 14958 RVA: 0x000169AC File Offset: 0x00014BAC
			public unsafe Link link
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.Builder.NativeFieldInfoPtr_link);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Link>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Link.Builder.NativeFieldInfoPtr_link), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003424 RID: 13348
			private static readonly IntPtr NativeFieldInfoPtr_link;

			// Token: 0x04003425 RID: 13349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003426 RID: 13350
			private static readonly IntPtr NativeMethodInfoPtr_SetLink_Public_Builder_String_0;

			// Token: 0x04003427 RID: 13351
			private static readonly IntPtr NativeMethodInfoPtr_SetDynamicLinkDomain_Public_Builder_String_0;

			// Token: 0x04003428 RID: 13352
			private static readonly IntPtr NativeMethodInfoPtr_SetAndroidParameters_Public_Builder_AndroidParameters_0;

			// Token: 0x04003429 RID: 13353
			private static readonly IntPtr NativeMethodInfoPtr_SetIosParameters_Public_Builder_IosParameters_0;

			// Token: 0x0400342A RID: 13354
			private static readonly IntPtr NativeMethodInfoPtr_SetGoogleAnalyticsParameters_Public_Builder_GoogleAnalyticsParameters_0;

			// Token: 0x0400342B RID: 13355
			private static readonly IntPtr NativeMethodInfoPtr_SetItunesConnectAnalyticsParameters_Public_Builder_ItunesConnectAnalyticsParameters_0;

			// Token: 0x0400342C RID: 13356
			private static readonly IntPtr NativeMethodInfoPtr_SetSocialMetaTagParameters_Public_Builder_SocialMetaTagParameters_0;

			// Token: 0x0400342D RID: 13357
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Link_0;
		}
	}
}
