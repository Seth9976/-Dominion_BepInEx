using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000D RID: 13
	public class GoogleLastKnownProductService : Object
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000069F4 File Offset: 0x00004BF4
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleLastKnownProductService()
		{
			Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleLastKnownProductService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr);
			GoogleLastKnownProductService.NativeFieldInfoPtr_m_LastKnownProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, "m_LastKnownProductId");
			GoogleLastKnownProductService.NativeFieldInfoPtr_m_LastKnownProrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, "m_LastKnownProrationMode");
			GoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProductId_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, 100663340);
			GoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProductId_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, 100663341);
			GoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProrationMode_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, 100663342);
			GoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProrationMode_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, 100663343);
			GoogleLastKnownProductService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLastKnownProductId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProductId_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006AE8 File Offset: 0x00004CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLastKnownProductId(string lastKnownProductId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lastKnownProductId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProductId_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006B2C File Offset: 0x00004D2C
		[CallerCount(0)]
		public unsafe virtual int GetLastKnownProrationMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProrationMode_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006B68 File Offset: 0x00004D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLastKnownProrationMode(int lastKnownProrationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastKnownProrationMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProrationMode_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006BA8 File Offset: 0x00004DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150416, XrefRangeEnd = 150421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleLastKnownProductService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleLastKnownProductService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleLastKnownProductService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021B4 File Offset: 0x000003B4
		public GoogleLastKnownProductService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00006BE4 File Offset: 0x00004DE4
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000021BD File Offset: 0x000003BD
		public unsafe string m_LastKnownProductId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLastKnownProductService.NativeFieldInfoPtr_m_LastKnownProductId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLastKnownProductService.NativeFieldInfoPtr_m_LastKnownProductId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006C0C File Offset: 0x00004E0C
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000021DC File Offset: 0x000003DC
		public unsafe int m_LastKnownProrationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLastKnownProductService.NativeFieldInfoPtr_m_LastKnownProrationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleLastKnownProductService.NativeFieldInfoPtr_m_LastKnownProrationMode)) = value;
			}
		}

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_LastKnownProductId;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_LastKnownProrationMode;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_GetLastKnownProductId_Public_Virtual_Final_New_String_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_SetLastKnownProductId_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_GetLastKnownProrationMode_Public_Virtual_Final_New_Int32_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_SetLastKnownProrationMode_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
