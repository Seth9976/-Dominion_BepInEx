using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E7 RID: 231
	[Serializable]
	public sealed class EmptyWebProxy : Object
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x0004272C File Offset: 0x0004092C
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyWebProxy()
		{
			Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EmptyWebProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr);
			EmptyWebProxy.NativeFieldInfoPtr_m_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr, "m_credentials");
			EmptyWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr, 100665176);
			EmptyWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr, 100665177);
			EmptyWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr, 100665178);
			EmptyWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr, 100665179);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000427C0 File Offset: 0x000409C0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmptyWebProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyWebProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000427FC File Offset: 0x000409FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri GetProxy(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0004284C File Offset: 0x00040A4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassed(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0004289C File Offset: 0x00040A9C
		public unsafe ICredentials Credentials
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000072EB File Offset: 0x000054EB
		public EmptyWebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x000428DC File Offset: 0x00040ADC
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x000072F4 File Offset: 0x000054F4
		public unsafe ICredentials m_credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyWebProxy.NativeFieldInfoPtr_m_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmptyWebProxy.NativeFieldInfoPtr_m_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr_m_credentials;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;
	}
}
