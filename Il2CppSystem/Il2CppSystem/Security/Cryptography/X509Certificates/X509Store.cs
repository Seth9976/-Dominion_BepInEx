using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009E RID: 158
	public sealed class X509Store : Object
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x00032A1C File Offset: 0x00030C1C
		// Note: this type is marked as 'beforefieldinit'.
		static X509Store()
		{
			Il2CppClassPointerStore<X509Store>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Store");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Store>.NativeClassPtr);
			X509Store.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "list");
			X509Store.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "store");
			X509Store.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100664505);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00032A88 File Offset: 0x00030C88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 43052, RefRangeEnd = 43056, XrefRangeStart = 43051, XrefRangeEnd = 43052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00005CE3 File Offset: 0x00003EE3
		public X509Store(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00032ABC File Offset: 0x00030CBC
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00005CEC File Offset: 0x00003EEC
		public unsafe X509Certificate2Collection list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00032AEC File Offset: 0x00030CEC
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005D0B File Offset: 0x00003F0B
		public unsafe X509Store store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
	}
}
