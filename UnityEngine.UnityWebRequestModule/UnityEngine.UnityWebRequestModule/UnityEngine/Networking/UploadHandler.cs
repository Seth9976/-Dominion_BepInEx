using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x0200000A RID: 10
	public class UploadHandler : Object
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000067BC File Offset: 0x000049BC
		// Note: this type is marked as 'beforefieldinit'.
		static UploadHandler()
		{
			Il2CppClassPointerStore<UploadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UploadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr);
			UploadHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, "m_Ptr");
			UploadHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663409);
			UploadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663410);
			UploadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663411);
			UploadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663412);
			UploadHandler.NativeMethodInfoPtr_set_contentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663413);
			UploadHandler.NativeMethodInfoPtr_SetContentType_Internal_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663414);
			UploadHandler.NativeMethodInfoPtr_InternalSetContentType_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663415);
			UploadHandler.InternalGetContentTypeDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalGetContentTypeDelegate>("UnityEngine.Networking.UploadHandler::InternalGetContentType");
			UploadHandler.InternalGetProgressDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalGetProgressDelegate>("UnityEngine.Networking.UploadHandler::InternalGetProgress");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000068AC File Offset: 0x00004AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124841, XrefRangeEnd = 124843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000068E0 File Offset: 0x00004AE0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000691C File Offset: 0x00004B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006958 File Offset: 0x00004B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124843, XrefRangeEnd = 124847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00006AAC File Offset: 0x00004CAC
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00006994 File Offset: 0x00004B94
		public unsafe string contentType
		{
			get
			{
				return this.GetContentType();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124847, RefRangeEnd = 124848, XrefRangeStart = 124847, XrefRangeEnd = 124847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_set_contentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000069D8 File Offset: 0x00004BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124848, XrefRangeEnd = 124850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentType(string newContentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newContentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_SetContentType_Internal_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006A28 File Offset: 0x00004C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetContentType(string newContentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newContentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_InternalSetContentType_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000025BD File Offset: 0x000007BD
		public UploadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00006A6C File Offset: 0x00004C6C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000025C6 File Offset: 0x000007C6
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00006A94 File Offset: 0x00004C94
		public Il2CppStructArray<byte> data
		{
			get
			{
				return this.GetData();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00006AC4 File Offset: 0x00004CC4
		public float progress
		{
			get
			{
				return this.GetProgress();
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006ADC File Offset: 0x00004CDC
		public virtual Il2CppStructArray<byte> GetData()
		{
			return null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public virtual string GetContentType()
		{
			return this.InternalGetContentType();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006B08 File Offset: 0x00004D08
		public virtual float GetProgress()
		{
			return this.InternalGetProgress();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006B20 File Offset: 0x00004D20
		public string InternalGetContentType()
		{
			IntPtr intPtr = UploadHandler.InternalGetContentTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000025E1 File Offset: 0x000007E1
		public float InternalGetProgress()
		{
			return UploadHandler.InternalGetProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_set_contentType_Public_set_Void_String_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_SetContentType_Internal_Virtual_New_Void_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetContentType_Private_Void_String_0;

		// Token: 0x040000B7 RID: 183
		private static readonly UploadHandler.InternalGetContentTypeDelegate InternalGetContentTypeDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly UploadHandler.InternalGetProgressDelegate InternalGetProgressDelegateField;

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate IntPtr InternalGetContentTypeDelegate(IntPtr @this);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate float InternalGetProgressDelegate(IntPtr @this);
	}
}
