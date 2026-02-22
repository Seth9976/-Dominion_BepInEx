using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000003 RID: 3
	public class AmazonAppStoreStoreExtensions : Object
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000060E0 File Offset: 0x000042E0
		// Note: this type is marked as 'beforefieldinit'.
		static AmazonAppStoreStoreExtensions()
		{
			Il2CppClassPointerStore<AmazonAppStoreStoreExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "AmazonAppStoreStoreExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmazonAppStoreStoreExtensions>.NativeClassPtr);
			AmazonAppStoreStoreExtensions.NativeFieldInfoPtr_android = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmazonAppStoreStoreExtensions>.NativeClassPtr, "android");
			AmazonAppStoreStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmazonAppStoreStoreExtensions>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00006138 File Offset: 0x00004338
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmazonAppStoreStoreExtensions(AndroidJavaObject a)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmazonAppStoreStoreExtensions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmazonAppStoreStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002059 File Offset: 0x00000259
		public AmazonAppStoreStoreExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00006184 File Offset: 0x00004384
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe AndroidJavaObject android
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmazonAppStoreStoreExtensions.NativeFieldInfoPtr_android);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmazonAppStoreStoreExtensions.NativeFieldInfoPtr_android), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_android;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0;
	}
}
