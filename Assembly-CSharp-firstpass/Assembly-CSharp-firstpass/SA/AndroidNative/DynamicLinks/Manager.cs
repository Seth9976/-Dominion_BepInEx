using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

namespace SA.AndroidNative.DynamicLinks
{
	// Token: 0x02000350 RID: 848
	public class Manager : Singleton<Manager>
	{
		// Token: 0x06003336 RID: 13110 RVA: 0x000D55F8 File Offset: 0x000D37F8
		// Note: this type is marked as 'beforefieldinit'.
		static Manager()
		{
			Il2CppClassPointerStore<Manager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.DynamicLinks", "Manager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Manager>.NativeClassPtr);
			Manager.NativeFieldInfoPtr_OnShortLinkReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnShortLinkReceived");
			Manager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100669858);
			Manager.NativeMethodInfoPtr_GetPendingDynamicLink_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100669859);
			Manager.NativeMethodInfoPtr_RequestShortDynamicLink_Public_Void_Link_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100669860);
			Manager.NativeMethodInfoPtr_ShortLinkReceived_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100669861);
			Manager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100669862);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000D56A0 File Offset: 0x000D38A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223521, XrefRangeEnd = 223526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000D56D4 File Offset: 0x000D38D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223526, XrefRangeEnd = 223528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPendingDynamicLink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_GetPendingDynamicLink_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000D570C File Offset: 0x000D390C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223532, RefRangeEnd = 223533, XrefRangeStart = 223528, XrefRangeEnd = 223532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestShortDynamicLink(Link link)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(link);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_RequestShortDynamicLink_Public_Void_Link_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000D5750 File Offset: 0x000D3950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223533, XrefRangeEnd = 223568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShortLinkReceived(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_ShortLinkReceived_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000D5794 File Offset: 0x000D3994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223568, XrefRangeEnd = 223590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Manager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00013EB4 File Offset: 0x000120B4
		public Manager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x000D57D0 File Offset: 0x000D39D0
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x00013EBD File Offset: 0x000120BD
		public unsafe Action<ShortLinkResult> OnShortLinkReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnShortLinkReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ShortLinkResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnShortLinkReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeFieldInfoPtr_OnShortLinkReceived;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeMethodInfoPtr_GetPendingDynamicLink_Public_String_0;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeMethodInfoPtr_RequestShortDynamicLink_Public_Void_Link_0;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeMethodInfoPtr_ShortLinkReceived_Public_Void_String_0;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003FD RID: 1021
		[ObfuscatedName("SA.AndroidNative.DynamicLinks.Manager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003A6F RID: 14959 RVA: 0x000EC030 File Offset: 0x000EA230
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Manager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Manager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Manager.__c>.NativeClassPtr);
				Manager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager.__c>.NativeClassPtr, "<>9");
				Manager.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager.__c>.NativeClassPtr, "<>9__5_0");
				Manager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.__c>.NativeClassPtr, 100670651);
				Manager.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_ShortLinkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.__c>.NativeClassPtr, 100670652);
			}

			// Token: 0x06003A70 RID: 14960 RVA: 0x000EC0AC File Offset: 0x000EA2AC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A71 RID: 14961 RVA: 0x000EC0E8 File Offset: 0x000EA2E8
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(ShortLinkResult <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_ShortLinkResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003A72 RID: 14962 RVA: 0x000169CB File Offset: 0x00014BCB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE6 RID: 3558
			// (get) Token: 0x06003A73 RID: 14963 RVA: 0x000EC12C File Offset: 0x000EA32C
			// (set) Token: 0x06003A74 RID: 14964 RVA: 0x000169D4 File Offset: 0x00014BD4
			public unsafe static Manager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Manager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Manager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE7 RID: 3559
			// (get) Token: 0x06003A75 RID: 14965 RVA: 0x000EC154 File Offset: 0x000EA354
			// (set) Token: 0x06003A76 RID: 14966 RVA: 0x000169E6 File Offset: 0x00014BE6
			public unsafe static Action<ShortLinkResult> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Manager.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ShortLinkResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Manager.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400342E RID: 13358
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400342F RID: 13359
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003430 RID: 13360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003431 RID: 13361
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_ShortLinkResult_0;
		}
	}
}
