using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace UTNotifications
{
	// Token: 0x020000EB RID: 235
	public class WaitForInitialized : MonoBehaviour
	{
		// Token: 0x06001C8B RID: 7307 RVA: 0x0006F680 File Offset: 0x0006D880
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForInitialized()
		{
			Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "WaitForInitialized");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr);
			WaitForInitialized.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr, 100665536);
			WaitForInitialized.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr, 100665537);
			WaitForInitialized.NativeMethodInfoPtr_OnInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr, 100665538);
			WaitForInitialized.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr, 100665539);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0006F700 File Offset: 0x0006D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253711, XrefRangeEnd = 253726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForInitialized.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0006F734 File Offset: 0x0006D934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253726, XrefRangeEnd = 253743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForInitialized.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0006F768 File Offset: 0x0006D968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253743, XrefRangeEnd = 253756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForInitialized.NativeMethodInfoPtr_OnInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0006F79C File Offset: 0x0006D99C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForInitialized()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForInitialized>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForInitialized.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00012523 File Offset: 0x00010723
		public WaitForInitialized(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Private_Void_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
