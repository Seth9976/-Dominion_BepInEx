using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net
{
	// Token: 0x02000016 RID: 22
	public class CFProxy : Object
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00013CF0 File Offset: 0x00011EF0
		// Note: this type is marked as 'beforefieldinit'.
		static CFProxy()
		{
			Il2CppClassPointerStore<CFProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFProxy");
			CFProxy.NativeFieldInfoPtr_kCFProxyAutoConfigurationJavaScriptKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyAutoConfigurationJavaScriptKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyAutoConfigurationURLKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyAutoConfigurationURLKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyHostNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyHostNameKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyPasswordKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyPasswordKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyPortNumberKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyPortNumberKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyUsernameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyUsernameKey");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeAutoConfigurationURL");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationJavaScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeAutoConfigurationJavaScript");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeFTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeFTP");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeHTTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeHTTP");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeHTTPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeHTTPS");
			CFProxy.NativeFieldInfoPtr_kCFProxyTypeSOCKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "kCFProxyTypeSOCKS");
			CFProxy.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, "settings");
			CFProxy.NativeMethodInfoPtr__ctor_Internal_Void_CFDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663481);
			CFProxy.NativeMethodInfoPtr_CFProxyTypeToEnum_Private_Static_CFProxyType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663482);
			CFProxy.NativeMethodInfoPtr_get_AutoConfigurationJavaScript_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663483);
			CFProxy.NativeMethodInfoPtr_get_AutoConfigurationUrl_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663484);
			CFProxy.NativeMethodInfoPtr_get_HostName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663485);
			CFProxy.NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663486);
			CFProxy.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663487);
			CFProxy.NativeMethodInfoPtr_get_ProxyType_Public_get_CFProxyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663488);
			CFProxy.NativeMethodInfoPtr_get_Username_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxy>.NativeClassPtr, 100663489);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00013EE4 File Offset: 0x000120E4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFProxy(CFDictionary settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr__ctor_Internal_Void_CFDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00013F30 File Offset: 0x00012130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32555, RefRangeEnd = 32556, XrefRangeStart = 32530, XrefRangeEnd = 32555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFProxyType CFProxyTypeToEnum(IntPtr type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_CFProxyTypeToEnum_Private_Static_CFProxyType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00013F70 File Offset: 0x00012170
		public unsafe IntPtr AutoConfigurationJavaScript
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32566, RefRangeEnd = 32567, XrefRangeStart = 32556, XrefRangeEnd = 32566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_AutoConfigurationJavaScript_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00013FAC File Offset: 0x000121AC
		public unsafe IntPtr AutoConfigurationUrl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32577, RefRangeEnd = 32578, XrefRangeStart = 32567, XrefRangeEnd = 32577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_AutoConfigurationUrl_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00013FE8 File Offset: 0x000121E8
		public unsafe string HostName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32589, RefRangeEnd = 32590, XrefRangeStart = 32578, XrefRangeEnd = 32589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_HostName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00014020 File Offset: 0x00012220
		public unsafe string Password
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32601, RefRangeEnd = 32602, XrefRangeStart = 32590, XrefRangeEnd = 32601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00014058 File Offset: 0x00012258
		public unsafe int Port
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32617, RefRangeEnd = 32618, XrefRangeStart = 32602, XrefRangeEnd = 32617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00014094 File Offset: 0x00012294
		public unsafe CFProxyType ProxyType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 32629, RefRangeEnd = 32632, XrefRangeStart = 32618, XrefRangeEnd = 32629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_ProxyType_Public_get_CFProxyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000140D0 File Offset: 0x000122D0
		public unsafe string Username
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32643, RefRangeEnd = 32644, XrefRangeStart = 32632, XrefRangeEnd = 32643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxy.NativeMethodInfoPtr_get_Username_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002444 File Offset: 0x00000644
		public CFProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00014108 File Offset: 0x00012308
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe static IntPtr kCFProxyAutoConfigurationJavaScriptKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyAutoConfigurationJavaScriptKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyAutoConfigurationJavaScriptKey, (void*)(&value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00014124 File Offset: 0x00012324
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe static IntPtr kCFProxyAutoConfigurationURLKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyAutoConfigurationURLKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyAutoConfigurationURLKey, (void*)(&value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00014140 File Offset: 0x00012340
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002469 File Offset: 0x00000669
		public unsafe static IntPtr kCFProxyHostNameKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyHostNameKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyHostNameKey, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0001415C File Offset: 0x0001235C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002477 File Offset: 0x00000677
		public unsafe static IntPtr kCFProxyPasswordKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyPasswordKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyPasswordKey, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00014178 File Offset: 0x00012378
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002485 File Offset: 0x00000685
		public unsafe static IntPtr kCFProxyPortNumberKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyPortNumberKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyPortNumberKey, (void*)(&value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00014194 File Offset: 0x00012394
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002493 File Offset: 0x00000693
		public unsafe static IntPtr kCFProxyTypeKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeKey, (void*)(&value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000141B0 File Offset: 0x000123B0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000024A1 File Offset: 0x000006A1
		public unsafe static IntPtr kCFProxyUsernameKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyUsernameKey, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyUsernameKey, (void*)(&value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000141CC File Offset: 0x000123CC
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000024AF File Offset: 0x000006AF
		public unsafe static IntPtr kCFProxyTypeAutoConfigurationURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationURL, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationURL, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000141E8 File Offset: 0x000123E8
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000024BD File Offset: 0x000006BD
		public unsafe static IntPtr kCFProxyTypeAutoConfigurationJavaScript
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationJavaScript, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationJavaScript, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00014204 File Offset: 0x00012404
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000024CB File Offset: 0x000006CB
		public unsafe static IntPtr kCFProxyTypeFTP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeFTP, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeFTP, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00014220 File Offset: 0x00012420
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000024D9 File Offset: 0x000006D9
		public unsafe static IntPtr kCFProxyTypeHTTP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeHTTP, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeHTTP, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0001423C File Offset: 0x0001243C
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000024E7 File Offset: 0x000006E7
		public unsafe static IntPtr kCFProxyTypeHTTPS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeHTTPS, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeHTTPS, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00014258 File Offset: 0x00012458
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000024F5 File Offset: 0x000006F5
		public unsafe static IntPtr kCFProxyTypeSOCKS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeSOCKS, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxy.NativeFieldInfoPtr_kCFProxyTypeSOCKS, (void*)(&value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00014274 File Offset: 0x00012474
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002503 File Offset: 0x00000703
		public unsafe CFDictionary settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFProxy.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CFDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFProxy.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyAutoConfigurationJavaScriptKey;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyAutoConfigurationURLKey;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyHostNameKey;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyPasswordKey;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyPortNumberKey;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeKey;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyUsernameKey;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationURL;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeAutoConfigurationJavaScript;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeFTP;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeHTTP;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeHTTPS;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_kCFProxyTypeSOCKS;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CFDictionary_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_CFProxyTypeToEnum_Private_Static_CFProxyType_IntPtr_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoConfigurationJavaScript_Public_get_IntPtr_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoConfigurationUrl_Public_get_IntPtr_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_HostName_Public_get_String_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyType_Public_get_CFProxyType_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_Username_Public_get_String_0;
	}
}
