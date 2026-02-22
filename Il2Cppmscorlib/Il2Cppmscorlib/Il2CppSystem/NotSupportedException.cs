using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D1 RID: 209
	[Serializable]
	public class NotSupportedException : SystemException
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x00061514 File Offset: 0x0005F714
		// Note: this type is marked as 'beforefieldinit'.
		static NotSupportedException()
		{
			Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NotSupportedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr);
			NotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr, 100665642);
			NotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr, 100665643);
			NotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr, 100665644);
			NotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr, 100665645);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00061594 File Offset: 0x0005F794
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 288611, RefRangeEnd = 288808, XrefRangeStart = 288606, XrefRangeEnd = 288611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotSupportedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000615D0 File Offset: 0x0005F7D0
		[CallerCount(917)]
		[CachedScanResults(RefRangeStart = 288810, RefRangeEnd = 289727, XrefRangeStart = 288808, XrefRangeEnd = 288810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotSupportedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0006161C File Offset: 0x0005F81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289727, XrefRangeEnd = 289729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotSupportedException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0006167C File Offset: 0x0005F87C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotSupportedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000059DE File Offset: 0x00003BDE
		public NotSupportedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
