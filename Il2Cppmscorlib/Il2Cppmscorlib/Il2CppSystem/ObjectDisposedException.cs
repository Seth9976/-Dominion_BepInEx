using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D4 RID: 212
	[Serializable]
	public class ObjectDisposedException : InvalidOperationException
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x000629FC File Offset: 0x00060BFC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectDisposedException()
		{
			Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ObjectDisposedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr);
			ObjectDisposedException.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, "objectName");
			ObjectDisposedException.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665691);
			ObjectDisposedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665692);
			ObjectDisposedException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665693);
			ObjectDisposedException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665694);
			ObjectDisposedException.NativeMethodInfoPtr_get_ObjectName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665695);
			ObjectDisposedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665696);
			ObjectDisposedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr, 100665697);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00062ACC File Offset: 0x00060CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290195, XrefRangeEnd = 290200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectDisposedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDisposedException.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00062B08 File Offset: 0x00060D08
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 290205, RefRangeEnd = 290228, XrefRangeStart = 290200, XrefRangeEnd = 290205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectDisposedException(string objectName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDisposedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00062B54 File Offset: 0x00060D54
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 290230, RefRangeEnd = 290243, XrefRangeStart = 290228, XrefRangeEnd = 290230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectDisposedException(string objectName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDisposedException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00062BB4 File Offset: 0x00060DB4
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290243, XrefRangeEnd = 290260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectDisposedException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00062BF8 File Offset: 0x00060DF8
		public unsafe string ObjectName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290264, RefRangeEnd = 290266, XrefRangeStart = 290260, XrefRangeEnd = 290264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDisposedException.NativeMethodInfoPtr_get_ObjectName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00062C30 File Offset: 0x00060E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290266, XrefRangeEnd = 290270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectDisposedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDisposedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDisposedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00062C94 File Offset: 0x00060E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290270, XrefRangeEnd = 290281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectDisposedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000059F9 File Offset: 0x00003BF9
		public ObjectDisposedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00062CF8 File Offset: 0x00060EF8
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00005A02 File Offset: 0x00003C02
		public unsafe string objectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDisposedException.NativeFieldInfoPtr_objectName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDisposedException.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_objectName;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectName_Public_get_String_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
