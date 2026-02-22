using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000005 RID: 5
	public class UnityWebRequestAsyncOperation : AsyncOperation
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003A64 File Offset: 0x00001C64
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestAsyncOperation()
		{
			Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequestAsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr);
			UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, "<webRequest>k__BackingField");
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663325);
			UnityWebRequestAsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr, 100663326);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000022A5 File Offset: 0x000004A5
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00003AD0 File Offset: 0x00001CD0
		public unsafe UnityWebRequest webRequest
		{
			get
			{
				return this._webRequest_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003B14 File Offset: 0x00001D14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequestAsyncOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequestAsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000227D File Offset: 0x0000047D
		public UnityWebRequestAsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003B50 File Offset: 0x00001D50
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002286 File Offset: 0x00000486
		public unsafe UnityWebRequest _webRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityWebRequestAsyncOperation.NativeFieldInfoPtr__webRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__webRequest_k__BackingField;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_set_webRequest_Internal_set_Void_UnityWebRequest_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
